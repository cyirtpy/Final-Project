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
    public partial class Form8 : Form
    {
        private readonly string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;";
        public Form8()
        {
            InitializeComponent();
            // 一開始鎖定按鈕
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            // 綁定欄位變動事件
            txtEditBookName.TextChanged += Fields_TextChanged;
            txtEditEnglishName.TextChanged += Fields_TextChanged;
            txtEditAuthor.TextChanged += Fields_TextChanged;
            txtEditPublisher.TextChanged += Fields_TextChanged;
            txtEditYear.TextChanged += Fields_TextChanged;
            txtEditMonth.TextChanged += Fields_TextChanged;
            txtEditDay.TextChanged += Fields_TextChanged;
            txtEditISBN.TextChanged += Fields_TextChanged;

            // 只允許輸入數字與控制鍵
            txtEditYear.KeyPress += NumericOnly_KeyPress;
            txtEditMonth.KeyPress += NumericOnly_KeyPress;
            txtEditDay.KeyPress += NumericOnly_KeyPress;
            txtEditISBN.KeyPress += NumericOnly_KeyPress;

            // 失去焦點時驗證範圍
            txtEditYear.Leave += DatePart_Leave;
            txtEditMonth.Leave += DatePart_Leave;
            txtEditDay.Leave += DatePart_Leave;
        }
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // char.IsControl 允許 Backspace、Delete、箭頭鍵等
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // 最小/最大定義
        private static readonly DateTime MinSqlDate = new DateTime(1753, 1, 1);
        private static readonly DateTime MaxSqlDate = new DateTime(9999, 12, 31);

        private void DatePart_Leave(object sender, EventArgs e)
        {
            int y, m, d;

            if (!int.TryParse(txtEditYear.Text, out y) ||
                !int.TryParse(txtEditMonth.Text, out m) ||
                !int.TryParse(txtEditDay.Text, out d))
                return;

            DateTime dt;

            // 嘗試建立日期，失敗則修成最小值
            try
            {
                dt = new DateTime(y, m, d);
            }
            catch
            {
                dt = MinSqlDate;
            }

            // 修正低於最小值
            if (dt < MinSqlDate) dt = MinSqlDate;
            // 修正超過最大值
            if (dt > MaxSqlDate) dt = MaxSqlDate;

            // 寫回修正後的年/月/日
            txtEditYear.Text = dt.Year.ToString();
            txtEditMonth.Text = dt.Month.ToString("00");
            txtEditDay.Text = dt.Day.ToString("00");
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            bool allFilled =
                !string.IsNullOrWhiteSpace(txtEditBookName.Text) &&
                !string.IsNullOrWhiteSpace(txtEditEnglishName.Text) &&
                !string.IsNullOrWhiteSpace(txtEditAuthor.Text) &&
                !string.IsNullOrWhiteSpace(txtEditPublisher.Text) &&
                !string.IsNullOrWhiteSpace(txtEditYear.Text) &&
                !string.IsNullOrWhiteSpace(txtEditMonth.Text) &&
                !string.IsNullOrWhiteSpace(txtEditDay.Text) &&
                !string.IsNullOrWhiteSpace(txtEditISBN.Text);

            if (!allFilled)
            {
                btnAdd.Enabled = btnDelete.Enabled = false;
                return;
            }

            // 檢查是否已存在一模一樣的書
            DateTime pubDate;
            DateTime.TryParse($"{txtEditYear.Text}-{txtEditMonth.Text}-{txtEditDay.Text}", out pubDate);

            bool exists;
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "SELECT COUNT(1) FROM Basic WHERE 書名=@n AND 英文書名=@e AND 作者=@a AND 出版社=@p AND 出版日期=@d AND ISBN=@i", conn))
            {
                cmd.Parameters.AddWithValue("@n", txtEditBookName.Text.Trim());
                cmd.Parameters.AddWithValue("@e", txtEditEnglishName.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtEditAuthor.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtEditPublisher.Text.Trim());
                cmd.Parameters.AddWithValue("@d", pubDate);
                cmd.Parameters.AddWithValue("@i", txtEditISBN.Text.Trim());
                conn.Open();
                exists = ((int)cmd.ExecuteScalar() > 0);
            }

            btnAdd.Enabled = allFilled && !exists;
            btnDelete.Enabled = allFilled && exists;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要新增資料嗎?", "", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            DateTime pubDate = DateTime.Parse($"{txtEditYear.Text}-{txtEditMonth.Text}-{txtEditDay.Text}");
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "INSERT INTO Basic (書名, 英文書名, 作者, 出版社, 出版日期, ISBN) VALUES (@n,@e,@a,@p,@d,@i)", conn))
            {
                cmd.Parameters.AddWithValue("@n", txtEditBookName.Text.Trim());
                cmd.Parameters.AddWithValue("@e", txtEditEnglishName.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtEditAuthor.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtEditPublisher.Text.Trim());
                cmd.Parameters.AddWithValue("@d", pubDate);
                cmd.Parameters.AddWithValue("@i", txtEditISBN.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("已成功新增資料");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除資料嗎?", "", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "DELETE FROM Basic WHERE 書名=@n AND 英文書名=@e AND ISBN=@i", conn))
            {
                cmd.Parameters.AddWithValue("@n", txtEditBookName.Text.Trim());
                cmd.Parameters.AddWithValue("@e", txtEditEnglishName.Text.Trim());
                cmd.Parameters.AddWithValue("@i", txtEditISBN.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("已成功刪除資料");
        }
    }
}
