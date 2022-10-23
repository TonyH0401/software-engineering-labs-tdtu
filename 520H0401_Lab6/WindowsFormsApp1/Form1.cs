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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxName;
            RefreshData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void RefreshData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                //solution 1
                //String sSQL = "SELECT * FROM student";
                //solution 2
                //String sSQL = "EXEC getAllStudent";

                String sSQL = "getAllStudent";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    dataGridViewStudent.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data", "Warning No Data");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            int index = dataGridViewStudent.SelectedCells[0].RowIndex;
            if(index < 0 || index >= dataGridViewStudent.RowCount)
            {
                return;
            }

            DataGridViewRow row = dataGridViewStudent.Rows[index];

            String name = row.Cells[1].Value.ToString().Trim();
            String email = row.Cells[4].Value.ToString().Trim();
            //MessageBox.Show(row.Cells[3].Value.ToString().Trim());
            String sex = row.Cells[3].Value.ToString().Trim();
            String date = row.Cells[2].Value.ToString().Trim();

            txtbxName.Text = name;
            txtbxEmail.Text = email;
            if (sex.Equals("True"))
            {
                rdbtnMale.Checked = true;
                rdbtnFemale.Checked = false;
            } 
            else
            {
                rdbtnMale.Checked = false;
                rdbtnFemale.Checked = true;
            }
            //cmd.Parameters.AddWithValue("@ngaySinh", dateTimePickerStudent.Text);
            dateTimePicker1.Text = date;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset all values
            txtbxEmail.Clear();
            txtbxName.Clear();
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            dateTimePicker1.Value = DateTime.Today;

            //reset all buttons
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            this.ActiveControl = txtbxName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int gioiTinhBitValue = (rdbtnMale.Checked == true) ? 1 : 0;
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "INSERT INTO student VALUES (@hoTen, @ngaySinh, @gioiTinh, @email)";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@hoTen", txtbxName.Text);
                cmd.Parameters.AddWithValue("@ngaySinh", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinhBitValue);
                cmd.Parameters.AddWithValue("@email", txtbxEmail.Text);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Data Added", "Success Box");
                }
                else
                {
                    MessageBox.Show("No Data", "Warning No Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            RefreshData();
        }
        // missing button update and button delete
    }
}
