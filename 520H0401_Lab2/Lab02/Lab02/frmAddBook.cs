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
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02;Integrated Security=True";
                conn.Open();

                String sSQL = "INSERT INTO tblBooks (BookID, BookTitle, ISBN, Author) VALUES ('" + txtbxBookID.Text + "', '" + txtbxBookName.Text + "', '" + txtbxISBN.Text + "', '" + txtbxAuthor.Text + "')";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show("Saved");
                else
                    MessageBox.Show("Error");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occur: " + ex.Message + " - " + ex.Source);
            }
            finally
            {
                this.Close();
            }
        }

        private void txtbxBookID_Leave(object sender, EventArgs e)
        {
            if(txtbxBookID.Text == "")
            {
                MessageBox.Show("Can not leave Empty", "Warning Box");
                this.ActiveControl = txtbxBookID;
            }
        }
    }
}
