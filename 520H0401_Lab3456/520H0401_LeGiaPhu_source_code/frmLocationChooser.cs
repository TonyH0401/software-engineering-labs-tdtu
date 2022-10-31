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
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class frmLocationChooser : Form
    {
        public static string frmUserSelectedChoice = "";
        public static ArrayList frmInvoiceCreated = new ArrayList();
        private int ticketCounter = 0;
        public frmLocationChooser()
        {
            InitializeComponent();
        }

        private void frmLocationChooser_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            txtbxLocationID.Enabled = false;
            txtbxLocationName.Enabled = false;
            txtbxLocationPrice.Enabled = false;
            txtbxTicketAmount.Enabled = false;
            txtbxLocationAva.Enabled = false;
            dateTimePickerEndTime.Enabled = false;
            dateTimePickerStartTime.Enabled = false;

            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "select * from Location";
                SqlCommand cmd = new SqlCommand(sSQL, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewLocation.DataSource = dt;
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
        }

        private void dataGridViewLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ActiveControl = txtbxTicketAmount;
            btnAdd.Enabled = true;
            txtbxTicketAmount.Enabled = true;

            int index = dataGridViewLocation.SelectedCells[0].RowIndex;
            if(index < 0 || index >= dataGridViewLocation.Rows.Count)
            {
                return; 
            }

            DataGridViewRow row = dataGridViewLocation.Rows[index];
            String locationID = row.Cells[0].Value.ToString().Trim();
            String locationName = row.Cells[1].Value.ToString().Trim();
            String locationPrice = row.Cells[2].Value.ToString().Trim();
            String startDate = row.Cells[3].Value.ToString().Trim();
            String endDate = row.Cells[4].Value.ToString().Trim();
            int availability = int.Parse(row.Cells[5].Value.ToString().Trim());

            txtbxLocationID.Text = locationID;
            txtbxLocationName.Text = locationName;
            txtbxLocationPrice.Text = locationPrice;
            txtbxLocationAva.Text = availability.ToString();
            dateTimePickerStartTime.Text = startDate;
            dateTimePickerEndTime.Text = endDate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!txtbxTicketAmount.Text.ToString().Trim().Equals(""))
            {
                if (int.Parse(txtbxLocationAva.Text.ToString().Trim()) < int.Parse(txtbxTicketAmount.Text.ToString().Trim()))
                {
                    MessageBox.Show("No more space", "Warning Box");
                    return;
                }
                String userSelectedLocation = txtbxLocationID.Text.ToString().Trim() + ";" + txtbxLocationName.Text.ToString().Trim() + ";" + txtbxLocationPrice.Text.ToString().Trim() + ";" + dateTimePickerStartTime.Text.ToString().Trim() + ";" + dateTimePickerEndTime.Text.ToString().Trim() + ";" + txtbxLocationAva.Text.ToString().Trim() + ";" + txtbxTicketAmount.Text.ToString().Trim();

                frmUserSelectedChoice = userSelectedLocation;
                frmCheckout f = new frmCheckout();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter amount", "Warning Box");
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if(frmInvoiceCreated.Count == 0)
            {
                MessageBox.Show("Cart Empty", "Notification");
            }
            else
            {
                String displayIndex = "";
                foreach (String i in frmInvoiceCreated) {
                    displayIndex = displayIndex + i + "\n";
                }
                MessageBox.Show(displayIndex, "Notification");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "select * from Invoice";
                SqlCommand cmd = new SqlCommand(sSQL, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.ticketCounter = dt.Rows.Count + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            String invoiceID = DateTime.Now.ToString().Split(' ')[0].Replace("/", "").Trim() + this.ticketCounter.ToString().Trim();

            frmCreateInvoice.frmInvoiceID = invoiceID;
            frmCreateInvoice.frmInvoiceCreated = frmInvoiceCreated;

            frmCreateInvoice f = new frmCreateInvoice();
            f.ShowDialog();
        }
    }
}
