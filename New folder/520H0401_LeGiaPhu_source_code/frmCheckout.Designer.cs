namespace WindowsFormsApp1
{
    partial class frmCheckout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTicketAmount = new System.Windows.Forms.Label();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtbxLocationAva = new System.Windows.Forms.TextBox();
            this.txtbxTicketAmount = new System.Windows.Forms.TextBox();
            this.txtbxLocationPrice = new System.Windows.Forms.TextBox();
            this.txtbxLocationName = new System.Windows.Forms.TextBox();
            this.txtbxLocationID = new System.Windows.Forms.TextBox();
            this.lblLocationAva = new System.Windows.Forms.Label();
            this.lblLocationEndTime = new System.Windows.Forms.Label();
            this.lblLocationStart = new System.Windows.Forms.Label();
            this.lblLocationPrice = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserBalance = new System.Windows.Forms.Label();
            this.txtbxUserID = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxCurrentBalance = new System.Windows.Forms.TextBox();
            this.btnUserValidate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbxTotalPrice = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTicketAmount
            // 
            this.lblTicketAmount.AutoSize = true;
            this.lblTicketAmount.Location = new System.Drawing.Point(25, 276);
            this.lblTicketAmount.Name = "lblTicketAmount";
            this.lblTicketAmount.Size = new System.Drawing.Size(76, 13);
            this.lblTicketAmount.TabIndex = 32;
            this.lblTicketAmount.Text = "Ticket Amount";
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(131, 196);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerEndTime.TabIndex = 31;
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(131, 155);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerStartTime.TabIndex = 30;
            // 
            // txtbxLocationAva
            // 
            this.txtbxLocationAva.Location = new System.Drawing.Point(131, 232);
            this.txtbxLocationAva.Name = "txtbxLocationAva";
            this.txtbxLocationAva.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationAva.TabIndex = 29;
            // 
            // txtbxTicketAmount
            // 
            this.txtbxTicketAmount.Location = new System.Drawing.Point(131, 276);
            this.txtbxTicketAmount.Name = "txtbxTicketAmount";
            this.txtbxTicketAmount.Size = new System.Drawing.Size(183, 20);
            this.txtbxTicketAmount.TabIndex = 28;
            // 
            // txtbxLocationPrice
            // 
            this.txtbxLocationPrice.Location = new System.Drawing.Point(131, 115);
            this.txtbxLocationPrice.Name = "txtbxLocationPrice";
            this.txtbxLocationPrice.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationPrice.TabIndex = 27;
            // 
            // txtbxLocationName
            // 
            this.txtbxLocationName.Location = new System.Drawing.Point(132, 77);
            this.txtbxLocationName.Name = "txtbxLocationName";
            this.txtbxLocationName.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationName.TabIndex = 26;
            // 
            // txtbxLocationID
            // 
            this.txtbxLocationID.Location = new System.Drawing.Point(131, 35);
            this.txtbxLocationID.Name = "txtbxLocationID";
            this.txtbxLocationID.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationID.TabIndex = 25;
            // 
            // lblLocationAva
            // 
            this.lblLocationAva.AutoSize = true;
            this.lblLocationAva.Location = new System.Drawing.Point(25, 232);
            this.lblLocationAva.Name = "lblLocationAva";
            this.lblLocationAva.Size = new System.Drawing.Size(56, 13);
            this.lblLocationAva.TabIndex = 24;
            this.lblLocationAva.Text = "Availability";
            // 
            // lblLocationEndTime
            // 
            this.lblLocationEndTime.AutoSize = true;
            this.lblLocationEndTime.Location = new System.Drawing.Point(25, 196);
            this.lblLocationEndTime.Name = "lblLocationEndTime";
            this.lblLocationEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblLocationEndTime.TabIndex = 23;
            this.lblLocationEndTime.Text = "End Time";
            // 
            // lblLocationStart
            // 
            this.lblLocationStart.AutoSize = true;
            this.lblLocationStart.Location = new System.Drawing.Point(25, 155);
            this.lblLocationStart.Name = "lblLocationStart";
            this.lblLocationStart.Size = new System.Drawing.Size(55, 13);
            this.lblLocationStart.TabIndex = 22;
            this.lblLocationStart.Text = "Start Time";
            // 
            // lblLocationPrice
            // 
            this.lblLocationPrice.AutoSize = true;
            this.lblLocationPrice.Location = new System.Drawing.Point(25, 115);
            this.lblLocationPrice.Name = "lblLocationPrice";
            this.lblLocationPrice.Size = new System.Drawing.Size(75, 13);
            this.lblLocationPrice.TabIndex = 21;
            this.lblLocationPrice.Text = "Location Price";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(25, 77);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(79, 13);
            this.lblLocationName.TabIndex = 20;
            this.lblLocationName.Text = "Location Name";
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Location = new System.Drawing.Point(25, 35);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(62, 13);
            this.lblLocationID.TabIndex = 19;
            this.lblLocationID.Text = "Location ID";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(442, 35);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(40, 13);
            this.lblUserID.TabIndex = 33;
            this.lblUserID.Text = "UserID";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(442, 77);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(53, 13);
            this.lblUserPassword.TabIndex = 34;
            this.lblUserPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(442, 115);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 35;
            this.lblUsername.Text = "Username";
            // 
            // lblUserBalance
            // 
            this.lblUserBalance.AutoSize = true;
            this.lblUserBalance.Location = new System.Drawing.Point(442, 201);
            this.lblUserBalance.Name = "lblUserBalance";
            this.lblUserBalance.Size = new System.Drawing.Size(80, 13);
            this.lblUserBalance.TabIndex = 36;
            this.lblUserBalance.Text = "CurrentBalance";
            // 
            // txtbxUserID
            // 
            this.txtbxUserID.Location = new System.Drawing.Point(551, 32);
            this.txtbxUserID.Name = "txtbxUserID";
            this.txtbxUserID.Size = new System.Drawing.Size(183, 20);
            this.txtbxUserID.TabIndex = 37;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(551, 77);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(183, 20);
            this.txtbxPassword.TabIndex = 38;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(551, 115);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(183, 20);
            this.txtbxUsername.TabIndex = 39;
            // 
            // txtbxCurrentBalance
            // 
            this.txtbxCurrentBalance.Location = new System.Drawing.Point(551, 204);
            this.txtbxCurrentBalance.Name = "txtbxCurrentBalance";
            this.txtbxCurrentBalance.Size = new System.Drawing.Size(183, 20);
            this.txtbxCurrentBalance.TabIndex = 40;
            // 
            // btnUserValidate
            // 
            this.btnUserValidate.Location = new System.Drawing.Point(609, 151);
            this.btnUserValidate.Name = "btnUserValidate";
            this.btnUserValidate.Size = new System.Drawing.Size(74, 32);
            this.btnUserValidate.TabIndex = 41;
            this.btnUserValidate.Text = "&Validate";
            this.btnUserValidate.UseVisualStyleBackColor = true;
            this.btnUserValidate.Click += new System.EventHandler(this.btnUserValidate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(444, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 13);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Total Price";
            // 
            // txtbxTotalPrice
            // 
            this.txtbxTotalPrice.Location = new System.Drawing.Point(551, 241);
            this.txtbxTotalPrice.Name = "txtbxTotalPrice";
            this.txtbxTotalPrice.Size = new System.Drawing.Size(183, 20);
            this.txtbxTotalPrice.TabIndex = 43;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(609, 284);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(73, 32);
            this.btnBuy.TabIndex = 44;
            this.btnBuy.Text = "&Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtbxTotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnUserValidate);
            this.Controls.Add(this.txtbxCurrentBalance);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUserID);
            this.Controls.Add(this.lblUserBalance);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblTicketAmount);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.txtbxLocationAva);
            this.Controls.Add(this.txtbxTicketAmount);
            this.Controls.Add(this.txtbxLocationPrice);
            this.Controls.Add(this.txtbxLocationName);
            this.Controls.Add(this.txtbxLocationID);
            this.Controls.Add(this.lblLocationAva);
            this.Controls.Add(this.lblLocationEndTime);
            this.Controls.Add(this.lblLocationStart);
            this.Controls.Add(this.lblLocationPrice);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblLocationID);
            this.MaximizeBox = false;
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.TextBox txtbxLocationAva;
        private System.Windows.Forms.TextBox txtbxTicketAmount;
        private System.Windows.Forms.TextBox txtbxLocationPrice;
        private System.Windows.Forms.TextBox txtbxLocationName;
        private System.Windows.Forms.TextBox txtbxLocationID;
        private System.Windows.Forms.Label lblLocationAva;
        private System.Windows.Forms.Label lblLocationEndTime;
        private System.Windows.Forms.Label lblLocationStart;
        private System.Windows.Forms.Label lblLocationPrice;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserBalance;
        private System.Windows.Forms.TextBox txtbxUserID;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxCurrentBalance;
        private System.Windows.Forms.Button btnUserValidate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtbxTotalPrice;
        private System.Windows.Forms.Button btnBuy;
    }
}