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
    public partial class Form1 : Form
    {
        SqlConnection sqlDb = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cntStr = @"Data Source=(localDB)\MSSQLLocalDB;" +
                @"AttachDBFilename=|DataDirectory|Database2.mdf;";

            try
            {
                sqlDb = new SqlConnection(cntStr);
                sqlDb.Open();
                btnRead.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string sqlStr = "SELECT b.書名, 英文書名, 作者 FROM Basic b ";

            SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlDb);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            int rowIndex = 0;

            dgvBooks.Font = new Font("微軟正黑體", 10);

            for (int i = 0; i < sqlDr.FieldCount; i++)
                dgvBooks.Columns.Add("column" + (i + 1).ToString(), sqlDr.GetName(i));

            while (sqlDr.Read() != false)
            {
                dgvBooks.Rows.Add();

                for (int i = 0; i < sqlDr.FieldCount; i++)
                    dgvBooks.Rows[rowIndex].Cells[i].Value =
                        sqlDr.GetValue(i).ToString();
                rowIndex++;
            }

            sqlDr.Close();
            btnRead.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlDb != null)
                sqlDb.Close();  // 關閉資料庫連線
        }
    }
}
