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
        private readonly string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;";
        public Form9()
        {
            InitializeComponent();
            timerUserState.Interval = 1000; // 每秒更新一次
            timerUserState.Tick += (s, e) => LoadUserState();
            timerUserState.Start();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadUserState();
        }

        private void LoadUserState()
        {
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "SELECT 書名, 英文書名, 借閱人, 剩餘借閱時間 FROM BorrowBook WHERE 剩餘借閱時間 > GETDATE()", conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);

                // 加入剩餘時間欄（格式化）
                dt.Columns.Add("剩餘時間顯示", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    DateTime end = Convert.ToDateTime(row["剩餘借閱時間"]);
                    TimeSpan rem = end - DateTime.Now;

                    if (rem.TotalSeconds <= 0)
                        row["剩餘時間顯示"] = "已逾期";
                    else if (rem.TotalSeconds > 3600)
                        row["剩餘時間顯示"] = $"{(int)rem.TotalDays} 天";
                    else
                        row["剩餘時間顯示"] = rem.ToString(@"hh\:mm\:ss");
                }

                // 僅顯示指定欄位
                dgvUserState.DataSource = dt.DefaultView.ToTable(false, "書名", "英文書名", "借閱人", "剩餘時間顯示");
            }
        }
    }
}
