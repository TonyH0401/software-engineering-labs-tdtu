namespace WindowsFormsApp1
{
    partial class frmLocationChooser
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
            this.lblLocationID = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblLocationStart = new System.Windows.Forms.Label();
            this.lblLocationPrice = new System.Windows.Forms.Label();
            this.lblLocationEndTime = new System.Windows.Forms.Label();
            this.lblLocationAva = new System.Windows.Forms.Label();
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbxLocationID = new System.Windows.Forms.TextBox();
            this.txtbxLocationName = new System.Windows.Forms.TextBox();
            this.txtbxLocationPrice = new System.Windows.Forms.TextBox();
            this.txtbxTicketAmount = new System.Windows.Forms.TextBox();
            this.txtbxLocationAva = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblTicketAmount = new System.Windows.Forms.Label();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Location = new System.Drawing.Point(12, 32);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(62, 13);
            this.lblLocationID.TabIndex = 2;
            this.lblLocationID.Text = "Location ID";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(12, 74);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(79, 13);
            this.lblLocationName.TabIndex = 3;
            this.lblLocationName.Text = "Location Name";
            // 
            // lblLocationStart
            // 
            this.lblLocationStart.AutoSize = true;
            this.lblLocationStart.Location = new System.Drawing.Point(12, 152);
            this.lblLocationStart.Name = "lblLocationStart";
            this.lblLocationStart.Size = new System.Drawing.Size(55, 13);
            this.lblLocationStart.TabIndex = 5;
            this.lblLocationStart.Text = "Start Time";
            // 
            // lblLocationPrice
            // 
            this.lblLocationPrice.AutoSize = true;
            this.lblLocationPrice.Location = new System.Drawing.Point(12, 112);
            this.lblLocationPrice.Name = "lblLocationPrice";
            this.lblLocationPrice.Size = new System.Drawing.Size(75, 13);
            this.lblLocationPrice.TabIndex = 4;
            this.lblLocationPrice.Text = "Location Price";
            // 
            // lblLocationEndTime
            // 
            this.lblLocationEndTime.AutoSize = true;
            this.lblLocationEndTime.Location = new System.Drawing.Point(12, 193);
            this.lblLocationEndTime.Name = "lblLocationEndTime";
            this.lblLocationEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblLocationEndTime.TabIndex = 6;
            this.lblLocationEndTime.Text = "End Time";
            // 
            // lblLocationAva
            // 
            this.lblLocationAva.AutoSize = true;
            this.lblLocationAva.Location = new System.Drawing.Point(12, 229);
            this.lblLocationAva.Name = "lblLocationAva";
            this.lblLocationAva.Size = new System.Drawing.Size(56, 13);
            this.lblLocationAva.TabIndex = 7;
            this.lblLocationAva.Text = "Availability";
            // 
            // dataGridViewLocation
            // 
            this.dataGridViewLocation.AllowUserToAddRows = false;
            this.dataGridViewLocation.AllowUserToDeleteRows = false;
            this.dataGridViewLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocation.Location = new System.Drawing.Point(335, 32);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.ReadOnly = true;
            this.dataGridViewLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocation.Size = new System.Drawing.Size(453, 261);
            this.dataGridViewLocation.TabIndex = 8;
            this.dataGridViewLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocation_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add location";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbxLocationID
            // 
            this.txtbxLocationID.Location = new System.Drawing.Point(118, 32);
            this.txtbxLocationID.Name = "txtbxLocationID";
            this.txtbxLocationID.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationID.TabIndex = 10;
            // 
            // txtbxLocationName
            // 
            this.txtbxLocationName.Location = new System.Drawing.Point(119, 74);
            this.txtbxLocationName.Name = "txtbxLocationName";
            this.txtbxLocationName.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationName.TabIndex = 11;
            // 
            // txtbxLocationPrice
            // 
            this.txtbxLocationPrice.Location = new System.Drawing.Point(118, 112);
            this.txtbxLocationPrice.Name = "txtbxLocationPrice";
            this.txtbxLocationPrice.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationPrice.TabIndex = 12;
            // 
            // txtbxTicketAmount
            // 
            this.txtbxTicketAmount.Location = new System.Drawing.Point(118, 273);
            this.txtbxTicketAmount.Name = "txtbxTicketAmount";
            this.txtbxTicketAmount.Size = new System.Drawing.Size(183, 20);
            this.txtbxTicketAmount.TabIndex = 14;
            // 
            // txtbxLocationAva
            // 
            this.txtbxLocationAva.Location = new System.Drawing.Point(118, 229);
            this.txtbxLocationAva.Name = "txtbxLocationAva";
            this.txtbxLocationAva.Size = new System.Drawing.Size(183, 20);
            this.txtbxLocationAva.TabIndex = 15;
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(118, 152);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerStartTime.TabIndex = 16;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(118, 193);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerEndTime.TabIndex = 17;
            // 
            // lblTicketAmount
            // 
            this.lblTicketAmount.AutoSize = true;
            this.lblTicketAmount.Location = new System.Drawing.Point(12, 273);
            this.lblTicketAmount.Name = "lblTicketAmount";
            this.lblTicketAmount.Size = new System.Drawing.Size(76, 13);
            this.lblTicketAmount.TabIndex = 18;
            this.lblTicketAmount.Text = "Ticket Amount";
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(335, 322);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(90, 27);
            this.btnViewCart.TabIndex = 19;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(511, 322);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(90, 27);
            this.btnBuy.TabIndex = 20;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // frmLocationChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.lblTicketAmount);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.txtbxLocationAva);
            this.Controls.Add(this.txtbxTicketAmount);
            this.Controls.Add(this.txtbxLocationPrice);
            this.Controls.Add(this.txtbxLocationName);
            this.Controls.Add(this.txtbxLocationID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewLocation);
            this.Controls.Add(this.lblLocationAva);
            this.Controls.Add(this.lblLocationEndTime);
            this.Controls.Add(this.lblLocationStart);
            this.Controls.Add(this.lblLocationPrice);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblLocationID);
            this.MaximizeBox = false;
            this.Name = "frmLocationChooser";
            this.Text = "frmLocationChooser";
            this.Load += new System.EventHandler(this.frmLocationChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblLocationStart;
        private System.Windows.Forms.Label lblLocationPrice;
        private System.Windows.Forms.Label lblLocationEndTime;
        private System.Windows.Forms.Label lblLocationAva;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxLocationID;
        private System.Windows.Forms.TextBox txtbxLocationName;
        private System.Windows.Forms.TextBox txtbxLocationPrice;
        private System.Windows.Forms.TextBox txtbxTicketAmount;
        private System.Windows.Forms.TextBox txtbxLocationAva;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label lblTicketAmount;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnBuy;
    }
}