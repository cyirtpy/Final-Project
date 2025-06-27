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
        string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;";
        public string CurrentUser { get; private set; }

        // Konami Code 序列
        private Keys[] konami = new[]
        {
        Keys.Up, Keys.Up,
        Keys.Down, Keys.Down,
        Keys.Left, Keys.Right,
        Keys.Left, Keys.Right,
        Keys.B, Keys.A
    };
        private int konamiIndex = 0;
        public Form1()
        {
            InitializeComponent();
            // 綁定事件
            cbSearch.SelectedIndexChanged += (s, e) => UpdateSearchButtonState();
            txtSearch.TextChanged += (s, e) => UpdateSearchButtonState();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        // 檢查是否可以啟用 btnSearch
        void UpdateSearchButtonState()
        {
            // cbSearch 一定有一個選項 (DropDownList)，只要 txtSearch 有輸入，就啟用
            btnSearch.Enabled = cbSearch.SelectedIndex >= 0
                             && !string.IsNullOrWhiteSpace(txtSearch.Text);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnLogIn.Enabled = true;
            btnLogOut.Enabled = false;
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
            lvwBooks.Columns.Add("書名", 200);
            lvwBooks.Columns.Add("英文書名", 300);
        }
        string CurrentOrder = "ASC";
        void LoadBooks(string order)
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
            lvwBooks.BeginUpdate();
            lvwBooks.Items.Clear();

            // 資料行
            foreach (var (Title, Eng) in records)
                lvwBooks.Items.Add(new ListViewItem(new[] { Title, Eng }));
            lvwBooks.EndUpdate();
        }
        void AZToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AZToolStripMenuItem1.Checked = true;
            ZAToolStripMenuItem1.Checked = false;
            LoadBooks(order: "ASC");
        }

        void ZAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AZToolStripMenuItem1.Checked = false;
            ZAToolStripMenuItem1.Checked = true;
            LoadBooks(order: "DESC");
        }




        void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedItems.Count == 0) return;
            var item = lvwBooks.SelectedItems[0];
            if (item.Index < 0) return; // 標題
            using (var frm = new Form4(item.SubItems[0].Text, item.SubItems[1].Text, CurrentUser))
                frm.ShowDialog();
        }

        void btnBorrowList_Click(object sender, EventArgs e)
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
                            MessageBox.Show($"{title} 即將逾期，請盡快還書!");
                            Program.AlertedBooks.Add(title);
                        }
                    }
                }
            }
        }

        // 查詢邏輯
        void SearchBooks()
        {
            string category = cbSearch.SelectedItem.ToString();
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadBooks(CurrentOrder);
                return;
            }
            var records = new List<(string Title, string Eng)>();
            string sql;
            switch (category)
            {
                case "ISBN":
                    sql = "SELECT 書名, 英文書名 FROM Basic WHERE ISBN = @p";
                    break;
                case "作者":
                    sql = "SELECT 書名, 英文書名 FROM Basic WHERE 作者 LIKE @p ORDER BY 英文書名";
                    break;
                case "英文書名":
                    sql = "SELECT 書名, 英文書名 FROM Basic WHERE 英文書名 LIKE @p ORDER BY 英文書名";
                    break;
                default:
                    sql = "SELECT 書名, 英文書名 FROM Basic WHERE 書名 LIKE @p ORDER BY 英文書名";
                    break;
            }
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (category == "ISBN")
                    cmd.Parameters.AddWithValue("@p", keyword);
                else
                    cmd.Parameters.AddWithValue("@p", "%" + keyword + "%");
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        records.Add((reader.GetString(0), reader.GetString(1)));
                }
            }
            lvwBooks.BeginUpdate();
            lvwBooks.Items.Clear();
            foreach (var (Title, Eng) in records)
                lvwBooks.Items.Add(new ListViewItem(new[] { Title, Eng }));
            lvwBooks.EndUpdate();
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        // KeyDown 事件：檢測 Konami Code
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == konami[konamiIndex])
            {
                konamiIndex++;
                if (konamiIndex >= konami.Length)
                {
                    konamiIndex = 0;
                    // 顯示管理員登入介面
                    using (var mgr = new Form6())
                    {
                        mgr.ShowDialog();
                    }
                }
            }
            else
            {
                konamiIndex = 0;
            }
        }
        void btnLogIn_Click(object sender, EventArgs e)
        {
            // 以對話方塊方式開啟 Form2
            using (var loginForm = new Form2())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentUser = loginForm.Username;
                    lblWelcome.Text = $"歡迎 {CurrentUser} !";

                    btnLogIn.Enabled = false;
                    btnLogOut.Enabled = true;

                    // 鎖定 Konami Code 功能
                    this.KeyDown -= Form1_KeyDown;
                }
            }
        }

        void btnLogOut_Click(object sender, EventArgs e)
            {
            // 登出清除資訊
            CurrentUser = null;
            lblWelcome.Text = "";

            btnLogIn.Enabled = true;
            btnLogOut.Enabled = false;

            // 重新啟用 Konami Code
            this.KeyDown += Form1_KeyDown;
        }
    }
}