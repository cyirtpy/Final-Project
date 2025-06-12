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
    public partial class Form5 : Form
    {
        private readonly string connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;";
        private readonly string currentUser;
        public Form5(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadBorrowList();
            lvwBorrowList.Columns.Add("書名", 250);
            lvwBorrowList.Columns.Add("英文書名", 300);
        }

        private void LoadBorrowList()
        {
            lvwBorrowList.Items.Clear();

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "SELECT 書名, 英文書名 FROM BorrowBook WHERE 借閱人=@u", conn))
            {
                cmd.Parameters.AddWithValue("@u", currentUser);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lvwBorrowList.Items.Add(new ListViewItem(new[] { reader.GetString(0), reader.GetString(1) }));
                }
            }
        }

        private void lvwBorrowList_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBorrowList.SelectedItems.Count == 0) return;
            var itm = lvwBorrowList.SelectedItems[0];
            if (itm.Index < 0) return;

            string bookName = itm.SubItems[0].Text;
            string engName = itm.SubItems[1].Text;
            var dr = MessageBox.Show("確定要還書嗎?", "還書確認", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(
                    "DELETE FROM BorrowBook WHERE 書名=@n AND 英文書名=@e AND 借閱人=@u", conn))
                {
                    cmd.Parameters.AddWithValue("@n", bookName);
                    cmd.Parameters.AddWithValue("@e", engName);
                    cmd.Parameters.AddWithValue("@u", currentUser);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("已成功還書!");
                LoadBorrowList();
            }
        }
    }
}
