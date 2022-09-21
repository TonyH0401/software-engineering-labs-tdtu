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
    public partial class frmForm : Form
    {
        public static DataTable myData;
        public frmForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to Exit");
            Application.Exit();
        }

        private void frmForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxUser;
        }

        // connect to the data and check if the user and password is correct
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT UserID, Password FROM tblUsers WHERE " +
            "UserID='" + txtbxUser.Text + "' and Password='" + txtbxPassoword.Text + "'";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check userID or Password!");
            }
            myData = dt;
        }

        private void frmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

    }
}
