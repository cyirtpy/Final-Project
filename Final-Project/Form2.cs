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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        string connString =
            @"Data Source=(localDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|\Database.mdf;";
        public string Username { get; set; }
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = btnLogInAccount;
            txtPassword.UseSystemPasswordChar = true;
        }


        void btnLogInAccount_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pwd = txtPassword.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            {
                lblError.Text = "帳號名稱或密碼輸入錯誤!";
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "SELECT Password FROM memberBasic WHERE Username=@u", conn))
            {
                cmd.Parameters.AddWithValue("@u", user);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result == null || !pwd.Equals(result.ToString()))
                {
                    lblError.Text = "帳號名稱或密碼輸入錯誤!";
                    return;
                }
            }

            // 登入成功，回傳 Username，並關閉 Dialog
            Username = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        void btnRegister_Click(object sender, EventArgs e)
        {
            // 開啟註冊畫面
            using (var regForm = new Form3())
            {
                regForm.ShowDialog();
            }
        }
    }
}
