using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class frmCreateInvoice : Form
    {
        public static String frmInvoiceID = "";
        //save locationID, userID, ticketamount, totalPrice
        public static ArrayList frmInvoiceCreated = new ArrayList();

        public frmCreateInvoice()
        {
            InitializeComponent();
        }

        private void frmCreateInvoice_Load(object sender, EventArgs e)
        {
            String displayText = "";
            int totalBill = 0;
            for(int i = 0; i < frmInvoiceCreated.Count; i++)
            {
                String[] invoiceInfo = frmInvoiceCreated[i].ToString().Trim().Split(';');
                String locationID = invoiceInfo[0];
                String userID = invoiceInfo[1];
                String ticketAmount = invoiceInfo[2];
                String totalPrice = invoiceInfo[3];

                displayText = displayText + "LocationID: "+ locationID + " - Ticket Amount: "+ ticketAmount + " - Total: " + totalPrice + "\r\n";
                totalBill = totalBill + int.Parse(totalPrice.ToString().Trim());
            }

            txtDisplay.Text = displayText;
            txtDisplay.Enabled = false;
            txtbxTotalBill.Text = totalBill.ToString().Trim();
            txtbxTotalBill.Enabled = false;
        }

        private void insertInvoice(String invoiceID, String userID, int totalPrice)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "insert into Invoice values (@invoiceID, @userID, @totalPrice)";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("totalPrice", totalPrice);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    
                }
                else
                {
                    MessageBox.Show("No Data", "Warning No Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 1");
            }
        }
        private void insertInvoiceDetail(String invoiceID, String locationID, int ticketAmount)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "insert into InvoiceDetail values (@invoiceID, @locationID, @ticketAmount)";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                cmd.Parameters.AddWithValue("@locationID", locationID);
                cmd.Parameters.AddWithValue("@ticketAmount", ticketAmount);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {

                }
                else
                {
                    MessageBox.Show("No Data", "Warning No Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 2");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String userID = "";
            int totalBill = 0;
            for (int i = 0; i < frmInvoiceCreated.Count; i++)
            {
                String[] invoiceInfo = frmInvoiceCreated[i].ToString().Trim().Split(';');
                userID = invoiceInfo[1];
                String totalPrice = invoiceInfo[3];
                totalBill = totalBill + int.Parse(totalPrice.ToString().Trim());
            }
            insertInvoice(frmInvoiceID, userID, totalBill);

            String locationID = "";
            int ticketAmount = -1;
            for (int i = 0; i < frmInvoiceCreated.Count; i++)
            {
                String[] invoiceInfo = frmInvoiceCreated[i].ToString().Trim().Split(';');
                locationID = invoiceInfo[0];
                ticketAmount = int.Parse(invoiceInfo[2]);
                
                insertInvoiceDetail(frmInvoiceID, locationID, ticketAmount);
                decreaseAvailability(locationID, ticketAmount);
            }

            decreaseUserBalanace(totalBill, userID);

            MessageBox.Show("Collect your ticket and receipt below!", "Success Purchase");
            Application.Exit();
        }

        private void decreaseUserBalanace(int totalBill, String userID)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "exec decreaseCash @userCash, @userID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@userCash", totalBill);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Transaction Success", "Success Notification");
                }
                else
                {
                    MessageBox.Show("No Data", "Warning No Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 2");
            }
        }

        private void decreaseAvailability(String locationID, int freeSpace)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "exec decreaseAvailability @locationID, @availability";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@locationID", locationID);
                cmd.Parameters.AddWithValue("@availability", freeSpace);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {

                }
                else
                {
                    MessageBox.Show("No Data", "Warning No Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 2");
            }
        }
    }
}
