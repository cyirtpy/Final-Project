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
using System.Xml.Linq;

namespace Final_Project
{
    public partial class Form3 : Form
    {
        private readonly string connString =
               @"Data Source=(localDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|Database2.mdf;";
        public Form3()
        {
            InitializeComponent();
            btnRegisterAccount.Enabled = false;
            txtRegisterUsername.TextChanged += Fields_TextChanged;
            txtRegisterPassword.TextChanged += Fields_TextChanged;
            txtRegisterPasswordCheck.TextChanged += Fields_TextChanged;
            // 密碼欄顯示星號
            txtRegisterPassword.UseSystemPasswordChar = true;
            txtRegisterPasswordCheck.UseSystemPasswordChar = true;
        }
        private void Fields_TextChanged(object sender, EventArgs e)
        {
            btnRegisterAccount.Enabled =
                         !string.IsNullOrEmpty(txtRegisterUsername.Text.Trim()) &&
                         !string.IsNullOrEmpty(txtRegisterPassword.Text) &&
                         txtRegisterPassword.Text == txtRegisterPasswordCheck.Text;
        }



        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            string user = txtRegisterUsername.Text.Trim();
            string pwd = txtRegisterPassword.Text;

            using (var conn = new SqlConnection(connString))
            using (var cmdCheck = new SqlCommand(
                "SELECT COUNT(1) FROM memberBasic WHERE Username=@u", conn))
            {
                cmdCheck.Parameters.AddWithValue("@u", user);
                conn.Open();
                int cnt = (int)cmdCheck.ExecuteScalar();
                if (cnt > 0)
                {
                    MessageBox.Show("已有同名帳號!");
                    return;
                }
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "INSERT INTO memberBasic (Username, Password) VALUES (@u, @p)", conn))
            {
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pwd);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("註冊成功!");
            this.Close();
        }
    }
}