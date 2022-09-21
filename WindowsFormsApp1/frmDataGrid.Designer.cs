namespace WindowsFormsApp1
{
    partial class frmDataGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataGrid));
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.lblPersonalID = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.dataGridViewProfession = new System.Windows.Forms.DataGridView();
            this.lblCopyrightName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfession)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(146, 58);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(193, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(77, 61);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(49, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Fullname";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(146, 32);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(193, 20);
            this.txtPersonID.TabIndex = 5;
            // 
            // lblPersonalID
            // 
            this.lblPersonalID.AutoSize = true;
            this.lblPersonalID.Location = new System.Drawing.Point(77, 35);
            this.lblPersonalID.Name = "lblPersonalID";
            this.lblPersonalID.Size = new System.Drawing.Size(59, 13);
            this.lblPersonalID.TabIndex = 4;
            this.lblPersonalID.Text = "PersonalID";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(440, 54);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(193, 20);
            this.txtJob.TabIndex = 11;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(371, 57);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(24, 13);
            this.lblJob.TabIndex = 10;
            this.lblJob.Text = "Job";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(440, 28);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(371, 31);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 13);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Address";
            // 
            // dataGridViewProfession
            // 
            this.dataGridViewProfession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfession.Location = new System.Drawing.Point(121, 98);
            this.dataGridViewProfession.Name = "dataGridViewProfession";
            this.dataGridViewProfession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProfession.Size = new System.Drawing.Size(512, 193);
            this.dataGridViewProfession.TabIndex = 12;
            this.dataGridViewProfession.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProfession_CellContentClick);
            this.dataGridViewProfession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProfession_CellContentClick);
            // 
            // lblCopyrightName
            // 
            this.lblCopyrightName.AutoSize = true;
            this.lblCopyrightName.Location = new System.Drawing.Point(574, 318);
            this.lblCopyrightName.Name = "lblCopyrightName";
            this.lblCopyrightName.Size = new System.Drawing.Size(101, 13);
            this.lblCopyrightName.TabIndex = 13;
            this.lblCopyrightName.Text = "Copyrighted by LGP";
            // 
            // frmDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.lblCopyrightName);
            this.Controls.Add(this.dataGridViewProfession);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.lblPersonalID);
            this.Name = "frmDataGrid";
            this.Text = "frmDataGrid";
            this.Load += new System.EventHandler(this.frmDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lblPersonalID;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.DataGridView dataGridViewProfession;
        private System.Windows.Forms.Label lblCopyrightName;
    }
}