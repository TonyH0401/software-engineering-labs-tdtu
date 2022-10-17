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
    public partial class frmDeptEmp : Form
    {
        public frmDeptEmp()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                //Get row index of a selected cell
                //seletectedCell[0] là khóa luôn cái column, chỉ để tự do cái row, giá trị trả về là column và row
                int index = dataGridViewDepartment.SelectedCells[0].RowIndex;
                if (index < 0 || index >= dataGridViewDepartment.RowCount)
                {
                    MessageBox.Show("Please select a department first", "Warning");
                    return;
                }
                //MessageBox.Show("Test: " + index);

                DataGridViewRow row = dataGridViewDepartment.Rows[index];
                //Get DNumber from the dataGrid
                int iDNo = int.Parse(row.Cells[1].Value.ToString());

                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "SELECT * FROM Employee WHERE DNo=@CB";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@CB", iDNo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt); 
                if(dt.Rows.Count > 0)
                {
                    dataGridViewEmployee.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data", "Warning");
                }
                adapter.Dispose();
                dataGridViewEmployee.Refresh();
            }
            catch(Exception ex)
            {

            }
        
        
        }
        private void frmDeptEmp_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "SELECT * FROM Department";
            SqlCommand cmd = new SqlCommand(sSQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                dataGridViewDepartment.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data", "Warning");
            }
            adapter.Dispose();
            LoadData();
        }

        private void dataGridViewDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
            dataGridViewDepartment.Refresh();
            dataGridViewEmployee.Refresh();
        }
    }
}
