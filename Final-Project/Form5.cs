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
    public partial class Form5 : Form
    {
        private readonly string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;";
        private readonly string currentUser;
        private HashSet<string> alerted = new HashSet<string>(); // 已提醒一小時清單
        public Form5(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadBorrowList();
            lvwBorrowList.Columns.Add("書名", 250);
            lvwBorrowList.Columns.Add("英文書名", 300);
            lvwBorrowList.Columns.Add("剩餘借閱時間", 120);
            if (!string.IsNullOrEmpty(currentUser))
                ((Form1)Application.OpenForms["Form1"]).CheckHourAlerts();
            timerBorrow.Tick += (s, ev) => { LoadBorrowList(); };
            timerBorrow.Start();
        }

        private void LoadBorrowList()
        {
            var list = new List<(string Title, string Eng, DateTime End)>();
            int maxTitle = "書名".Length;
            int maxEng = "英文書名".Length;
            int maxTime = "剩餘時間".Length;
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT 書名, 英文書名, 剩餘借閱時間 FROM BorrowBook WHERE 借閱人=@u", conn))
                {
                    cmd.Parameters.AddWithValue("@u", currentUser);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var t = reader.GetString(0);
                            var eName = reader.GetString(1);
                            var end = reader.GetDateTime(2);
                            list.Add((t, eName, end));
                            maxTitle = Math.Max(maxTitle, t.Length);
                            maxEng = Math.Max(maxEng, eName.Length);
                            var rem = end - DateTime.Now;
                            string txt = rem.TotalSeconds <= 3600 ? rem.ToString(@"hh\:mm\:ss") : $"{(int)rem.TotalDays}天";
                            maxTime = Math.Max(maxTime, txt.Length);
                        }
                    }
                }
            }

            lvwBorrowList.BeginUpdate();
            lvwBorrowList.Items.Clear();
            // 資料行
            foreach (var (Title, Eng, End) in list)
            {
                var rem = End - DateTime.Now;
                bool isHourAlert = rem.TotalSeconds <= 3600 && rem.TotalSeconds > 0;
                bool isDayWarning = rem.TotalDays <= 1 && rem.TotalSeconds > 3600;
                string txt;
                if (rem.TotalSeconds <= 0) txt = "已逾期";
                else if (isHourAlert) txt = rem.ToString(@"hh\:mm\:ss");
                else txt = $"{(int)rem.TotalDays}天";

                var item = new ListViewItem(new[] { Title, Eng, txt });
                if (isDayWarning || isHourAlert) item.ForeColor = Color.Red;
                lvwBorrowList.Items.Add(item);

                if (isHourAlert && !alerted.Contains(Title))
                {
                    MessageBox.Show($"{Title} 借閱時間剩餘1小時，請盡快還書!");
                    alerted.Add(Title);
                }
            }
            lvwBorrowList.EndUpdate();
        }

        private void lvwBorrowList_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBorrowList.SelectedItems.Count == 0) return;
            var itm = lvwBorrowList.SelectedItems[0];
            if (itm.Index < 0) return;

            string bookName = itm.SubItems[0].Text;
            string engName = itm.SubItems[1].Text;
            var dr = MessageBox.Show("確定要還書嗎?", "還書確認", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(
                    "DELETE FROM BorrowBook WHERE 書名=@n AND 英文書名=@e AND 借閱人=@u", conn))
                {
                    cmd.Parameters.AddWithValue("@n", bookName);
                    cmd.Parameters.AddWithValue("@e", engName);
                    cmd.Parameters.AddWithValue("@u", currentUser);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("已成功還書!");
                LoadBorrowList();
            }
        }
    }
}
