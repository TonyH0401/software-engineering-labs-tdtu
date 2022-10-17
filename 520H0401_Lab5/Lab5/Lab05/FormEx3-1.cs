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
    public partial class FormEx3_1 : Form
    {
        int db_data_rows_count = -1;
        public FormEx3_1()
        {
            InitializeComponent();
        }

        private void FormEx3_1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
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
                if(dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                } 
                else
                {
                    MessageBox.Show("No Data", "Warning");
                }
                //Count how many rows are in database before everything else
                db_data_rows_count = dt.Rows.Count;
                adapter.Dispose();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int row_index = db_data_rows_count; row_index < dataGridView1.Rows.Count; row_index++)
                {
                    if (dataGridView1.Rows[row_index].Cells[0].Value == null)
                    {
                        break;
                    }
                    String FName = dataGridView1.Rows[row_index].Cells[0].Value.ToString().Trim();
                    String Mint = (dataGridView1.Rows[row_index].Cells[1].Value.ToString().Trim().Equals("")) ? "NULL" : dataGridView1.Rows[row_index].Cells[1].Value.ToString().Trim();
                    String LName = dataGridView1.Rows[row_index].Cells[2].Value.ToString().Trim();
                    String SSN = dataGridView1.Rows[row_index].Cells[3].Value.ToString().Trim();
                    String BDate = (dataGridView1.Rows[row_index].Cells[4].Value.ToString().Trim().Equals("")) ? "NULL" : dataGridView1.Rows[row_index].Cells[4].Value.ToString().Trim();
                    String Address = (dataGridView1.Rows[row_index].Cells[5].Value.ToString().Trim().Equals("")) ? "NULL" : dataGridView1.Rows[row_index].Cells[5].Value.ToString().Trim();
                    String Sex = dataGridView1.Rows[row_index].Cells[6].Value.ToString().Trim();
                    int Salary = int.Parse(dataGridView1.Rows[row_index].Cells[7].Value.ToString().Trim());
                    String SuperSSN = dataGridView1.Rows[row_index].Cells[8].Value.ToString().Trim();
                    int DNo = int.Parse(dataGridView1.Rows[row_index].Cells[9].Value.ToString().Trim());

                    SqlConnection conn = new SqlConnection(Program.strConn);
                    conn.Open();

                    String sSQL = "INSERT INTO Employee VALUES (@FName, @Mint, @LName, @SSN, @BDate, @Address, @Sex, @Salary, @SuperSSN, @DNo)";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.Parameters.AddWithValue("@Fname", FName);
                    cmd.Parameters.AddWithValue("@Mint", Mint);
                    cmd.Parameters.AddWithValue("@LName", LName);
                    cmd.Parameters.AddWithValue("@SSN", SSN);
                    cmd.Parameters.AddWithValue("@BDate", BDate);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Sex", Sex);
                    cmd.Parameters.AddWithValue("@Salary", Salary);
                    cmd.Parameters.AddWithValue("@SuperSSN", SuperSSN);
                    cmd.Parameters.AddWithValue("@DNo", DNo);

                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                //Database có primary key và foreign key, khi có lỗi xày ra sẽ báo lỗi và không cho add vào trong database
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }
    }
}
