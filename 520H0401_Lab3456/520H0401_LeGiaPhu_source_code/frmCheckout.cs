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
    public partial class frmCheckout : Form
    {
        private String locationID = "";
        private String userID = "";
        private String ticketAmount = "";
        private String totalPrice = "";

        public frmCheckout()
        {
            InitializeComponent();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxUserID;

            String[] locationInfo = frmLocationChooser.frmUserSelectedChoice.Split(';');
            String locationID = locationInfo[0].Trim();
            String locationName = locationInfo[1].Trim();
            String locationPrice = locationInfo[2].Trim();
            String startTime = locationInfo[3].Trim();
            String endTime = locationInfo[4].Trim();
            String locationAvailability = (int.Parse(locationInfo[5]) - int.Parse(locationInfo[6])).ToString().Trim();
            String userAmount = locationInfo[6].Trim();

            this.locationID = locationID;
            this.ticketAmount = userAmount;

            txtbxLocationID.Text = locationID;
            txtbxLocationName.Text = locationName;
            txtbxLocationPrice.Text = locationPrice;
            txtbxTicketAmount.Text = userAmount;
            txtbxLocationAva.Text = locationAvailability;
            dateTimePickerStartTime.Text = startTime;
            dateTimePickerEndTime.Text = endTime;
            txtbxTotalPrice.Text = (int.Parse(locationPrice) * int.Parse(userAmount)).ToString().Trim();

            this.totalPrice = (int.Parse(locationPrice) * int.Parse(userAmount)).ToString().Trim();

            txtbxLocationID.Enabled = false;
            txtbxLocationName.Enabled = false;
            txtbxLocationPrice.Enabled = false;
            txtbxTicketAmount.Enabled = false;
            txtbxLocationAva.Enabled = false;
            dateTimePickerStartTime.Enabled = false;
            dateTimePickerEndTime.Enabled = false;
            txtbxTotalPrice.Enabled = false;

            txtbxUsername.Enabled = false;
            txtbxCurrentBalance.Enabled = false;
            btnBuy.Enabled = false;
        }

        private void btnUserValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "select * from UserCreditCard where userID = @userid and userPassword = @password";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@userid", txtbxUserID.Text);
                cmd.Parameters.AddWithValue("@password", txtbxPassword.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Validation Success", "Success");
                    String userId = (String) dt.Rows[0][0];
                    String username = (String) dt.Rows[0][1];
                    int int_balance = (int) dt.Rows[0][3];
                    String balance = int_balance.ToString().Trim();

                    this.userID = userId;

                    txtbxUserID.Text = userId;
                    txtbxUsername.Text = username;
                    txtbxCurrentBalance.Text = balance;

                    txtbxPassword.Enabled = false;
                    txtbxUserID.Enabled = false;
                    btnUserValidate.Enabled = false; ;
                    btnBuy.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong username or password! Try again!", "Warning No User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtbxCurrentBalance.Text.ToString().Trim()) < int.Parse(this.totalPrice.ToString().Trim()))
            {
                MessageBox.Show("Not enough credit", "Warning");
                return;
            }
            //create invoiceID
            //this.ticketCounter += 1;
            //String invoiceID = DateTime.Now.ToString().Split(' ')[0].Replace("/","").Trim() + this.ticketCounter.ToString().Trim();
            
            //save locationID, userID, ticketamount, totalPrice
            String createInvoice = this.locationID.ToString().Trim() + ";" + this.userID.ToString().Trim() + ";" + this.ticketAmount.ToString().Trim() + ";" + this.totalPrice.ToString().Trim();

            frmLocationChooser.frmInvoiceCreated.Add(createInvoice.ToString().Trim());
            btnBuy.Enabled = false;
            this.Close();
        }
    }
}
