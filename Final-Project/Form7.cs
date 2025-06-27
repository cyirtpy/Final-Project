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
    public partial class Form7 : Form
    {
        private readonly string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;";
        public Form7()
        {
            InitializeComponent();
            LoadBooksForManager();
        }
        private void LoadBooksForManager()
        {
            using (var conn = new SqlConnection(connString))
            using (var adapter = new SqlDataAdapter(
                "SELECT 書名, 英文書名, 作者, 出版社, 出版日期, ISBN FROM Basic", conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvManager.DataSource = dt;
            }
        }
        private void btnBooksEdit_Click(object sender, EventArgs e)
        {
            using (var frm8 = new Form8())
            {
                this.Hide();
                frm8.ShowDialog();
                this.Show();
                LoadBooksForManager();  // 更新
            }
        }

        private void btnUserState_Click(object sender, EventArgs e)
        {
            using (var f9 = new Form9())
            {
                f9.ShowDialog();
            }
        }
    }
}
