namespace WindowsFormsApp1
{
    partial class frmCreateInvoice
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.txtbxTotalBill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 11);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(417, 238);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(509, 98);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 35);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Location = new System.Drawing.Point(526, 24);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(47, 13);
            this.lblTotalBill.TabIndex = 2;
            this.lblTotalBill.Text = "Total Bill";
            // 
            // txtbxTotalBill
            // 
            this.txtbxTotalBill.Location = new System.Drawing.Point(496, 40);
            this.txtbxTotalBill.Name = "txtbxTotalBill";
            this.txtbxTotalBill.Size = new System.Drawing.Size(117, 20);
            this.txtbxTotalBill.TabIndex = 3;
            // 
            // frmCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.txtbxTotalBill);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmCreateInvoice";
            this.Text = "frmCreateInvoice";
            this.Load += new System.EventHandler(this.frmCreateInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.TextBox txtbxTotalBill;
    }
}