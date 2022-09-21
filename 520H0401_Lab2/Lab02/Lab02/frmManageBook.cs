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
    public partial class frmManageBook : Form
    {
        public frmManageBook()
        {
            InitializeComponent();
        }

        private void frmManageBook_Load(object sender, EventArgs e)
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
        }

        private void dataGridViewBook_SelectionChanged(object sender, EventArgs e)
        {
            string BookID = "";
            string BookName = "";
            string ISBN = "";
            string Author = "";
            foreach (DataGridViewRow row in dataGridViewBook.SelectedRows)
            {
                BookID = row.Cells[0].Value.ToString();
                BookName = row.Cells[1].Value.ToString();
                ISBN = row.Cells[2].Value.ToString();
                Author = row.Cells[3].Value.ToString();
            }
            txtbxBookID.Text = BookID;
            txtbxBookName.Text = BookName;
            txtbxISBN.Text = ISBN;
            txtbxAuthor.Text = Author;
        }
    }
}
