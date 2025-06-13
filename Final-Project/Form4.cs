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
    public partial class Form4 : Form
    {
        private readonly string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;";
        private readonly string bookName;
        private readonly string engName;
        private readonly string currentUser;
        public Form4(string bookName, string engName, string currentUser)
        {
            InitializeComponent();
            this.bookName = bookName;
            this.engName = engName;
            this.currentUser = currentUser;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // 查詢書籍其他欄位
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "SELECT 作者, 出版社, 出版日期, ISBN FROM Basic WHERE 書名=@n AND 英文書名=@e", conn))
            {
                cmd.Parameters.AddWithValue("@n", bookName);
                cmd.Parameters.AddWithValue("@e", engName);
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblBookName1.Text = bookName;
                    lblEnglishName1.Text = engName;
                    lblAuthor1.Text = reader.GetString(0);
                    lblPublisher1.Text = reader.GetString(1);
                    lblDate1.Text = reader.GetDateTime(2).ToShortDateString();
                    lblISBN1.Text = reader.GetString(3);
                }
            }
            if (!string.IsNullOrEmpty(currentUser))
                ((Form1)Application.OpenForms["Form1"]).CheckHourAlerts();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(currentUser))
                {
                    MessageBox.Show("請先登入帳號!");
                    return;
                }
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    // 檢查借閱狀態
                    using (var cmdCheck = new SqlCommand(
                        "SELECT 借閱人 FROM BorrowBook WHERE 書名=@n AND 英文書名=@e", conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@n", bookName);
                        cmdCheck.Parameters.AddWithValue("@e", engName);
                        var existing = cmdCheck.ExecuteScalar() as string;
                        if (existing != null)
                        {
                            if (existing == currentUser)
                                MessageBox.Show("你正在借閱該本書!");
                            else
                                MessageBox.Show("此書正在被借閱!");
                            return;
                        }
                    }
                    // 新增借閱記錄: 設定到期時間 = 現在 + 6 天
                    var endDate = DateTime.Now.AddDays(6);
                    using (var cmd = new SqlCommand(
                        "INSERT INTO BorrowBook (書名, 英文書名, 借閱人, 剩餘借閱時間) VALUES (@n, @e, @u, @end)", conn))
                    {
                        cmd.Parameters.AddWithValue("@n", bookName);
                        cmd.Parameters.AddWithValue("@e", engName);
                        cmd.Parameters.AddWithValue("@u", currentUser);
                        cmd.Parameters.AddWithValue("@end", endDate);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("已借書成功!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
