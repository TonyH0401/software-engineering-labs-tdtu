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
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=school;Integrated Security=True";
                conn.Open();
                String sSQL = "SELECT * FROM student";

                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewStudent.DataSource = dt;    
                    // this.Close();
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.ActiveControl = txtbxName;
        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            //string maso = "";
            string hovaten = "";
            string ngaySinh = "";
            string gioitinh = "";
            string email = "";
            foreach (DataGridViewRow row in dataGridViewStudent.SelectedRows)
            {
                // maso = row.Cells[0].Value.ToString();
                hovaten = row.Cells[1].Value.ToString();
                ngaySinh = row.Cells[2].Value.ToString();
                gioitinh = row.Cells[3].Value.ToString();
                email = row.Cells[4].Value.ToString();
            }
            txtbxName.Text = hovaten;
            dateTimePickerStudent.Text = ngaySinh;
            if (gioitinh.Equals("True") == true)
            {
                rdbtnMale.Checked = true;
                rdbtnFemale.Checked = false;
            }
            else
            {
                rdbtnMale.Checked = false;
                rdbtnFemale.Checked = true;
            }
            txtbxEmail.Text = email;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            //btnUpdate.Enabled = false;
            //Update.Enabled = false;

            txtbxName.Clear();
            txtbxEmail.Clear();

            rdbtnFemale.Checked = false;
            rdbtnMale.Checked = false;

            dateTimePickerStudent.Value = DateTime.Today;
            this.ActiveControl = txtbxName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int gioiTinhBitValue = (rdbtnMale.Checked == true) ? 1 : 0;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=school;Integrated Security=True";
                conn.Open();

                String sSQL = "INSERT INTO student (hoTen, ngaySinh, gioitinh, email) VALUES ('" + txtbxName.Text + "', '" + dateTimePickerStudent.Text + "', '" + gioiTinhBitValue + "', '" + txtbxEmail.Text + "')";
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
                refreshDataBase();
                //this.Close();
            }
        }

        private void refreshDataBase()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=school;Integrated Security=True";

                conn.Open();
                String sSQL = "SELECT * FROM student";

                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewStudent.DataSource = dt;
                    // this.Close();
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occur: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewStudent.SelectedRows[0];
            //MessageBox.Show(row.Cells[0].Value.ToString());
            int gioiTinhBitValue = (rdbtnMale.Checked == true) ? 1 : 0;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=school;Integrated Security=True";
                conn.Open();

                String sSQL = "UPDATE student SET hoTen = @hoTen, ngaySinh = @ngaySinh, gioiTinh=@gioiTinh, email=@email WHERE maso=@maso";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@hoten", txtbxName.Text);
                cmd.Parameters.AddWithValue("@ngaySinh", dateTimePickerStudent.Text);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinhBitValue);
                cmd.Parameters.AddWithValue("@email", txtbxEmail.Text);
                cmd.Parameters.AddWithValue("@maso", int.Parse(row.Cells[0].Value.ToString()));
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
                refreshDataBase();
                //this.Close();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewStudent.SelectedRows[0];
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=school;Integrated Security=True";
                conn.Open();

                String sSQL = "DELETE FROM student WHERE maso = @maso";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@maso", int.Parse(row.Cells[0].Value.ToString()));
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show("Deleted");
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
                refreshDataBase();
                //this.Close();
            }
        }

        private void txtbxName_Leave(object sender, EventArgs e)
        {
            //if (txtbxName.Text == "")
            //{
            //    MessageBox.Show("Can not leave Name empty", "Warning Box");
            //    this.ActiveControl = txtbxName;
            //}
        }

        private void txtbxEmail_Leave(object sender, EventArgs e)
        {
            //if(txtbxEmail.Text == "" || txtbxEmail.Text.Contains("@") == false)
            //{
            //    MessageBox.Show("Can not leave Email empty or missing and @", "Warning Box");
            //    this.ActiveControl=txtbxEmail;
            //}
        }

    }
}
