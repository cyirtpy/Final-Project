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
using System.Timers;


namespace Final_Project
{
    public partial class Form1 : Form
    {
        private readonly string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Database2;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;";
        public string CurrentUser { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogIn.Enabled = true;
            btnBorrowList.Enabled = true;
            LoadBooks(order: "ASC");
            // 設定每分鐘檢查與提醒
            timerBorrow.Interval = 60 * 1000;
            timerBorrow.Tick += (s, ev) =>
            {
                LoadBooks(CurrentOrder);
                CheckHourAlerts();
            };
            timerBorrow.Start();
            // 立即檢查一次
            CheckHourAlerts();
            lvwBooks.Columns.Add("書名", 250);  
            lvwBooks.Columns.Add("英文書名", 300);  
        }
        private string CurrentOrder = "ASC";
        private void LoadBooks(string order)
        {
            CurrentOrder = order;
            // 先取得所有資料到暫存
            var records = new List<(string Title, string Eng)>();
            int maxTitle = "書名".Length;
            int maxEng = "英文書名".Length;
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                $"SELECT 書名, 英文書名 FROM Basic ORDER BY 英文書名 {order}", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var title = reader.GetString(0);
                        var eng = reader.GetString(1);
                        records.Add((title, eng));
                        maxTitle = Math.Max(maxTitle, title.Length);
                        maxEng = Math.Max(maxEng, eng.Length);
                    }
                }
            }
            lvwBooks.Items.Clear();
            // 資料行
            foreach (var (Title, Eng) in records)
                lvwBooks.Items.Add(new ListViewItem(new[] { Title, Eng }));
        
    }
        private void AZToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AZToolStripMenuItem1.Checked = true;
            ZAToolStripMenuItem1.Checked = false;
            LoadBooks(order: "ASC");
        }

        private void ZAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AZToolStripMenuItem1.Checked = false;
            ZAToolStripMenuItem1.Checked = true;
            LoadBooks(order: "DESC");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // 以對話方塊方式開啟 Form2
            using (var loginForm = new Form2())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // 從 Form2 拿回正確的 Username
                    CurrentUser = loginForm.Username;
                    lblWelcome.Text = $"歡迎 {CurrentUser}!";

                }
            }
        }
    

        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedItems.Count == 0) return;
            var item = lvwBooks.SelectedItems[0];
            if (item.Index < 0) return; // 標題
            using (var frm = new Form4(item.SubItems[0].Text, item.SubItems[1].Text, CurrentUser))
                frm.ShowDialog();
        }

        private void btnBorrowList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentUser))
            {
                MessageBox.Show("請先登入帳號!");
                return;
            }
            using (var listForm = new Form5(CurrentUser))
            {
                listForm.ShowDialog();
            }
        }

        // 檢查剩餘1小時提醒
        public void CheckHourAlerts()
        {
            if (string.IsNullOrEmpty(CurrentUser)) return;
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "SELECT 書名, 剩餘借閱時間 FROM BorrowBook WHERE 借閱人=@u", conn))
            {
                cmd.Parameters.AddWithValue("@u", CurrentUser);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var title = reader.GetString(0);
                        var end = reader.GetDateTime(1);
                        var rem = end - DateTime.Now;
                        if (rem.TotalSeconds <= 3600 && rem.TotalSeconds > 0 && !Program.AlertedBooks.Contains(title))
                        {
                            MessageBox.Show($"{title} 借閱時間剩餘1小時，請盡快還書!");
                            Program.AlertedBooks.Add(title);
                        }
                    }
                }
            }
        }
    }
}
