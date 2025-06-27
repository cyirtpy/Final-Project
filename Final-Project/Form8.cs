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
            // 初始：清空模式選擇
            rbAdd.Checked = true;  // 預設新增
            ApplyMode();           // 根據模式開/關欄位
            SetupNumericFields();
            btnEditBook.Enabled = false;

            // 綁定模式選擇變更事件
            rbAdd.CheckedChanged += ModeChanged;
            rbDelete.CheckedChanged += ModeChanged;

            // 綁定所有欄位變更事件
            txtEditBookName.TextChanged += FieldsOrModeChanged;
            txtEditEnglishName.TextChanged += FieldsOrModeChanged;
            txtEditAuthor.TextChanged += FieldsOrModeChanged;
            txtEditPublisher.TextChanged += FieldsOrModeChanged;
            txtEditYear.TextChanged += FieldsOrModeChanged;
            txtEditMonth.TextChanged += FieldsOrModeChanged;
            txtEditDay.TextChanged += FieldsOrModeChanged;
            txtEditISBN.TextChanged += FieldsOrModeChanged;
        }

        // 模式切換時開關欄位並檢查按鈕
        private void ModeChanged(object sender, EventArgs e)
        {
            ApplyMode();
            UpdateEditButtonState();
        }

        // 欄位或模式改變時檢查按鈕
        private void FieldsOrModeChanged(object sender, EventArgs e)
        {
            UpdateEditButtonState();
        }

        private void ApplyMode()
        {
            bool isAdd = rbAdd.Checked;
            // 新增時：所有欄位可用
            txtEditAuthor.Enabled =
            txtEditPublisher.Enabled =
            txtEditYear.Enabled =
            txtEditMonth.Enabled =
            txtEditDay.Enabled =
            txtEditISBN.Enabled = isAdd;

            // 刪除時：只有書名、英文書名可用
            if (!isAdd)
            {
                // 確保其他欄位是空的
                txtEditAuthor.Text =
                txtEditPublisher.Text =
                txtEditYear.Text =
                txtEditMonth.Text =
                txtEditDay.Text =
                txtEditISBN.Text = "";
            }
        }

        private void UpdateEditButtonState()
        {
            bool enable = false;
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                if (rbAdd.Checked)
                {
                    // 新增模式：所有都必填
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
                        enable = false;
                    }
                    else
                    {
                        // 確認資料庫中尚不存在同樣一筆
                        DateTime pubDate = DateTime.Parse($"{txtEditYear.Text}-{txtEditMonth.Text}-{txtEditDay.Text}");
                        cmd.CommandText = @"
SELECT COUNT(1) FROM Basic
WHERE 書名=@n AND 英文書名=@e AND 作者=@a
  AND 出版社=@p AND 出版日期=@d AND ISBN=@i";
                        cmd.Parameters.AddWithValue("@n", txtEditBookName.Text.Trim());
                        cmd.Parameters.AddWithValue("@e", txtEditEnglishName.Text.Trim());
                        cmd.Parameters.AddWithValue("@a", txtEditAuthor.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", txtEditPublisher.Text.Trim());
                        cmd.Parameters.AddWithValue("@d", pubDate);
                        cmd.Parameters.AddWithValue("@i", txtEditISBN.Text.Trim());

                        conn.Open();
                        int exists = (int)cmd.ExecuteScalar();
                        enable = (exists == 0);
                    }
                }
                else // rbDelete.Checked
                {
                    // 刪除模式：書名+英文書名都要填
                    bool haveKey =
                        !string.IsNullOrWhiteSpace(txtEditBookName.Text) &&
                        !string.IsNullOrWhiteSpace(txtEditEnglishName.Text);

                    if (!haveKey)
                    {
                        enable = false;
                    }
                    else
                    {
                        cmd.CommandText = @"
SELECT COUNT(1) FROM Basic
WHERE 書名=@n AND 英文書名=@e";
                        cmd.Parameters.AddWithValue("@n", txtEditBookName.Text.Trim());
                        cmd.Parameters.AddWithValue("@e", txtEditEnglishName.Text.Trim());

                        conn.Open();
                        int exists = (int)cmd.ExecuteScalar();
                        enable = (exists == 1);
                    }
                }
            }
            btnEditBook.Enabled = enable;
        }

        // 限制只能輸入數字
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // 限制輸入長度、綁定數字檢查與日期修正事件
        private void SetupNumericFields()
        {
            txtEditYear.MaxLength = 4;
            txtEditMonth.MaxLength = 2;
            txtEditDay.MaxLength = 2;
            txtEditISBN.MaxLength = 12;

            txtEditYear.KeyPress += NumericOnly_KeyPress;
            txtEditMonth.KeyPress += NumericOnly_KeyPress;
            txtEditDay.KeyPress += NumericOnly_KeyPress;
            txtEditISBN.KeyPress += NumericOnly_KeyPress;

            txtEditYear.Leave += DatePart_Leave;
            txtEditMonth.Leave += DatePart_Leave;
            txtEditDay.Leave += DatePart_Leave;
        }

        private static readonly DateTime MinSqlDate = new DateTime(1753, 1, 1);
        private static readonly DateTime MaxSqlDate = new DateTime(9999, 12, 31);

        private void DatePart_Leave(object sender, EventArgs e)
        {
            int y, m, d;

            if (!int.TryParse(txtEditYear.Text, out y)) return;
            if (!int.TryParse(txtEditMonth.Text, out m)) return;
            if (!int.TryParse(txtEditDay.Text, out d)) return;

            DateTime result;

            try
            {
                result = new DateTime(y, m, d);
            }
            catch
            {
                // 日期不合法（如 2023/2/30），預設設為最小合法值
                result = MinSqlDate;
            }

            // 修正邊界
            if (result < MinSqlDate) result = MinSqlDate;
            if (result > MaxSqlDate) result = MaxSqlDate;

            // 回填欄位
            txtEditYear.Text = result.Year.ToString();
            txtEditMonth.Text = result.Month.ToString("00");
            txtEditDay.Text = result.Day.ToString("00");
        }

        private void btnEditBook_Click(object sender, EventArgs e)
            {
                if (rbAdd.Checked)
                {
                    // 新增動作
                    if (MessageBox.Show("確定要新增資料嗎?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

                    DateTime pubDate = DateTime.Parse($"{txtEditYear.Text}-{txtEditMonth.Text}-{txtEditDay.Text}");
                    using (var conn = new SqlConnection(connString))
                    using (var cmd = new SqlCommand(@"
INSERT INTO Basic
(書名, 英文書名, 作者, 出版社, 出版日期, ISBN)
VALUES(@n,@e,@a,@p,@d,@i)", conn))
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
                else
                {
                    // 刪除動作
                    if (MessageBox.Show("確定要刪除資料嗎?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

                    using (var conn = new SqlConnection(connString))
                    using (var cmd = new SqlCommand(@"
DELETE FROM Basic WHERE 書名=@n AND 英文書名=@e", conn))
                    {
                        cmd.Parameters.AddWithValue("@n", txtEditBookName.Text.Trim());
                        cmd.Parameters.AddWithValue("@e", txtEditEnglishName.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("已成功刪除資料");
                }

                // 完成後重新檢查一下按鈕狀態
                UpdateEditButtonState();
            }
        }
    }