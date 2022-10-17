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
using System.Data.SqlClient;

namespace Lab05
{
    
    public partial class Form2_1 : Form
    {
        public Form2_1()
        {
            InitializeComponent();
        }

        private void Form2_1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "SELECT * FROM Employee";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    comboBoxEmployee.DataSource = dt;
                    comboBoxEmployee.DisplayMember = "FName";
                    comboBoxEmployee.ValueMember = "SSN";
                    LoadData();
                }
                else
                {
                    MessageBox.Show("No Data 1", "Warnning");
                }
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }
        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "SELECT * FROM Dependent WHERE ESSN=@CB";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@CB", comboBoxEmployee.SelectedValue.ToString());

                //String sSQL = "SELECT * FROM Employee where DNo=" + comboBoxDepartment.SelectedValue;
                //SqlCommand cmd = new SqlCommand(sSQL, conn);


                //SqlCommand cmd = new SqlCommand("SELECT * FROM Employee where DNo=" + comboBoxDepartment.SelectedValue, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    //MessageBox.Show("No Data", "Warning");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
