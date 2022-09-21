using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class DataGridForm : Form
    {
        // get rows that are initially in SQL
        int preDataRows = -1;

        public DataGridForm()
        {
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM tblUsers";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewUser.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data");
            }

            preDataRows = dt.Rows.Count;
        }

        private void btnSaveToSQL_Click(object sender, EventArgs e)
        {
            try
            {
                //String returnData = "";
                for (int rows = preDataRows; rows < dataGridViewUser.Rows.Count; rows++)
                {
                    if (dataGridViewUser.Rows[rows].Cells[0].Value == null)
                        break;
                    String UserID = dataGridViewUser.Rows[rows].Cells[0].Value.ToString().Trim();
                    String Name = dataGridViewUser.Rows[rows].Cells[1].Value.ToString().Trim();
                    String Password = dataGridViewUser.Rows[rows].Cells[2].Value.ToString().Trim();
                    String temp = dataGridViewUser.Rows[rows].Cells[3].Value.ToString();
                    int isActive = (dataGridViewUser.Rows[rows].Cells[3].Value.ToString() == "") ? 0 : 1;
                    //returnData = UserID + ";" + Name + ";" + Password + ";" + isActive;

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02;Integrated Security=True";
                    conn.Open();

                    String sSQL = "INSERT INTO tblUsers (UserID, Name, Password, isActive) VALUES ('"+UserID+"', '"+Name+"', '"+Password+"', '"+isActive+"')";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        MessageBox.Show("Saved");
                    else
                        MessageBox.Show("Error");
                    conn.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Some error occur: " + ex.Message + " - " +ex.Source);
            }
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUser_SelectionChanged(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridViewUser.SelectedRows)
            {
                value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
            }
            txtbxTest.Text = value1;
        }
    }
}
