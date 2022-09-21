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

namespace Lab02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to Exit", "Warning Box");
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmForm frm = new frmForm();
            frm.ShowDialog();

            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02;Integrated Security=True";
                conn.Open();
                String sSQL = "SELECT * FROM tblBooks";

                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewBook.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            frmManageBook frmManageBook = new frmManageBook();  
            frmManageBook.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook frmAddBook = new frmAddBook();
            frmAddBook.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM tblBooks";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewBook.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data");
            }
            conn.Close();
        }
    }
}
