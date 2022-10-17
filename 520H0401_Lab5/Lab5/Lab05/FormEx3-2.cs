using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Lab05
{
    public partial class FormEx3_2 : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder oleDbCommandBuilder = null;
        DataTable dt = new DataTable();

        String strConn = ConfigurationManager.ConnectionStrings["MyConnOleDb"].ConnectionString;
        public FormEx3_2()
        {
            InitializeComponent();
        }

        private void FormEx3_2_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            dataGridView1.DataSource = null;
            dt.Clear();
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();

            String sSQL = "SELECT * FROM Employee";
            cmd = conn.CreateCommand();
            cmd.CommandText = sSQL;
            try
            {
                da = new OleDbDataAdapter(sSQL, conn);
                oleDbCommandBuilder = new OleDbCommandBuilder(da);
                da.Fill(dt);
                bindingSource = new BindingSource { DataSource = dt };
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //important step
            dataGridView1.EndEdit();
            try
            {
                //Update data back to database
                da.Update(dt);
                MessageBox.Show("Updated");
                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
