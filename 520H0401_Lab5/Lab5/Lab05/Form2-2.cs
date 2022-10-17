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
    public partial class Form2_2 : Form
    {
        public Form2_2()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                //Get row index of a selected cell
                //seletectedCell[0] là khóa luôn cái column, chỉ để tự do cái row, giá trị trả về là column và row
                int index = dataGridView1.SelectedCells[0].RowIndex;
                if (index < 0 || index >= dataGridView1.RowCount)
                {
                    MessageBox.Show("Please select a department first", "Warning");
                    return;
                }
                //MessageBox.Show("Test: " + index);

                DataGridViewRow row = dataGridView1.Rows[index];
                //Get SSN from the dataGrid
                int iDNo = int.Parse(row.Cells[3].Value.ToString());

                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "SELECT * FROM Dependent WHERE ESSN=@CB";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@CB", iDNo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data", "Warning");
                }
                adapter.Dispose();
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        private void Form2_2_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data", "Warning");
            }
            adapter.Dispose();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }
    }
}
