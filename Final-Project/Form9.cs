using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form9 : Form
    {
        string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;";
        private int selectedRowIndex = -1;
        public Form9()
        {
            InitializeComponent();
            timerUserState.Interval = 1000; // 每秒更新一次
            timerUserState.Tick += (s, e) => LoadUserState();

            txtEditDay.TextChanged += EditField_TextChanged;
            txtEditHour.TextChanged += EditField_TextChanged;
            txtEditMinute.TextChanged += EditField_TextChanged;
            txtEditSecond.TextChanged += EditField_TextChanged;

        }

        void Form9_Load(object sender, EventArgs e)
        {
            LoadUserState(); 
            timerUserState.Start();
        }

        void LoadUserState()
        {
            if (checkbEditTime.Checked) return; // 編輯中暫停更新

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                 "SELECT 書名, 英文書名, 借閱人, 剩餘借閱時間 FROM BorrowBook", conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);

                // 加入剩餘時間欄（格式化）
                dt.Columns.Add("剩餘時間", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    DateTime end = Convert.ToDateTime(row["剩餘借閱時間"]);
                    TimeSpan rem = end - DateTime.Now;

                    if (rem.TotalSeconds <= 0)
                        row["剩餘時間"] = "已逾期";
                    else if (rem.TotalSeconds > 86400)
                        row["剩餘時間"] = $"{(int)rem.TotalDays} 天";
                    else
                        row["剩餘時間"] = rem.ToString(@"hh\:mm\:ss");
                }

                // 僅顯示指定欄位
                dgvUserState.DataSource = dt.DefaultView.ToTable(false, "書名", "英文書名", "借閱人", "剩餘時間");
                // 顯示資料後標記紅色
                foreach (DataGridViewRow row in dgvUserState.Rows)
                {
                    var text = row.Cells["剩餘時間"].Value?.ToString();
                    if (text == "已逾期")
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            selectedRowIndex = -1;
            btnEditData.Enabled = false;
        }
        void checkbEditTime_CheckedChanged(object sender, EventArgs e)
        {
            bool edit = checkbEditTime.Checked;
            if (edit) timerUserState.Stop();
            else timerUserState.Start();

            // 啟用 / 鎖定輸入欄位
            txtEditDay.Enabled = edit;
            txtEditHour.Enabled = edit;
            txtEditMinute.Enabled = edit;
            txtEditSecond.Enabled = edit;
            btnEditData.Enabled = false;

            // 清空欄位
            txtEditDay.Text = txtEditHour.Text = txtEditMinute.Text = txtEditSecond.Text = "";
        }
        void dgvUserState_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!checkbEditTime.Checked) return;
            if (e.RowIndex < 0) return;
            selectedRowIndex = e.RowIndex;

            string remText = dgvUserState.Rows[e.RowIndex].Cells["剩餘時間"].Value.ToString();
            // 根據格式填入
            if (remText.EndsWith("天"))
            {
                txtEditDay.Text = remText.TrimEnd('天');
                txtEditHour.Text = txtEditMinute.Text = txtEditSecond.Text = "";
            }
            else if (TimeSpan.TryParse(remText, out var ts))
            {
                txtEditDay.Text = "";
                txtEditHour.Text = ts.Hours.ToString();
                txtEditMinute.Text = ts.Minutes.ToString();
                txtEditSecond.Text = ts.Seconds.ToString();
            }
            UpdateEditButtonState();
        }

        // 任一編輯欄位變動後，決定按鈕狀態與欄位鎖定
        void EditField_TextChanged(object sender, EventArgs e)
        {
            // 如果日有值，鎖定時分秒；反之時分秒任一有值，鎖定日
            bool hasDay = !string.IsNullOrWhiteSpace(txtEditDay.Text);
            bool hasTime =
                !string.IsNullOrWhiteSpace(txtEditHour.Text) ||
                !string.IsNullOrWhiteSpace(txtEditMinute.Text) ||
                !string.IsNullOrWhiteSpace(txtEditSecond.Text);

            txtEditHour.Enabled = !hasDay;
            txtEditMinute.Enabled = !hasDay;
            txtEditSecond.Enabled = !hasDay;
            txtEditDay.Enabled = !hasTime;

            UpdateEditButtonState();
        }

        void UpdateEditButtonState()
        {
            // 需同時：已選列 + (日 或 (時分秒皆有))
            bool dayOK = !string.IsNullOrWhiteSpace(txtEditDay.Text);
            bool timeOK =
                !string.IsNullOrWhiteSpace(txtEditHour.Text) &&
                !string.IsNullOrWhiteSpace(txtEditMinute.Text) &&
                !string.IsNullOrWhiteSpace(txtEditSecond.Text);

            btnEditData.Enabled = checkbEditTime.Checked
                                 && selectedRowIndex >= 0
                                 && (dayOK || timeOK);
        }

        // 確定寫回資料庫
        void btnEditData_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0) return;
            // 取得主索引：書名、英文書名、借閱人
            var row = dgvUserState.Rows[selectedRowIndex];
            string name = row.Cells["書名"].Value.ToString();
            string eng = row.Cells["英文書名"].Value.ToString();
            string user = row.Cells["借閱人"].Value.ToString();

            // 計算新的 EndDate
            TimeSpan add;
            if (!string.IsNullOrWhiteSpace(txtEditDay.Text))
            {
                if (!int.TryParse(txtEditDay.Text, out var d)) d = 0;
                add = TimeSpan.FromDays(d);
            }
            else
            {
                int h = int.TryParse(txtEditHour.Text, out h) ? h : 0;
                int m = int.TryParse(txtEditMinute.Text, out m) ? m : 0;
                int s = int.TryParse(txtEditSecond.Text, out s) ? s : 0;
                add = new TimeSpan(h, m, s);
            }
            DateTime newEnd = DateTime.Now + add;

            // 更新資料庫
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "UPDATE BorrowBook SET 剩餘借閱時間=@end WHERE 書名=@n AND 英文書名=@e AND 借閱人=@u", conn))
            {
                cmd.Parameters.AddWithValue("@end", newEnd);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@e", eng);
                cmd.Parameters.AddWithValue("@u", user);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("剩餘借閱時間已更新");
            // 關閉編輯模式並重新整理
            checkbEditTime.Checked = false;
            LoadUserState();
        }

      
    }
}
