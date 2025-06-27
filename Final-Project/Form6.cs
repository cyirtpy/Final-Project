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
    public partial class Form6 : Form
    {
        string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;";
        public Form6()
        {
            InitializeComponent();
            // 密碼使用星號顯示
            txtManagerPassword.UseSystemPasswordChar = true;
        }

        void btnManagerLogIn_Click(object sender, EventArgs e)
        {
            string mgr = txtManagerAccount.Text.Trim();
            string pwd = txtManagerPassword.Text;
            if (string.IsNullOrEmpty(mgr) || string.IsNullOrEmpty(pwd))
            {
                lblManagerError.Text = "帳號名稱或密碼輸入錯誤!";
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "SELECT Password FROM managerBasic WHERE ManagerName=@m", conn))
            {
                cmd.Parameters.AddWithValue("@m", mgr);
                conn.Open();
                var result = cmd.ExecuteScalar() as string;
                if (result == null || result != pwd)
                {
                    lblManagerError.Text = "帳號名稱或密碼輸入錯誤!";
                    return;
                }
            }

            // 登入成功 → 跳到 Form7
            using (var frm7 = new Form7())
            {
                this.Hide();
                frm7.ShowDialog();
                this.Show();
            }
        }
    }
}
