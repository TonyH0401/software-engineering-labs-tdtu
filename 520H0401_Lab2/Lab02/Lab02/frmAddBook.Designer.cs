namespace Lab02
{
    partial class frmAddBook
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtbxBookName = new System.Windows.Forms.TextBox();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.txtbxISBN = new System.Windows.Forms.TextBox();
            this.txtbxBookID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(173, 150);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 17;
            this.lblAuthor.Text = "Author";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(173, 112);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 16;
            this.lblISBN.Text = "ISBN";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(173, 73);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(63, 13);
            this.lblBookName.TabIndex = 15;
            this.lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(173, 35);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(43, 13);
            this.lblBookID.TabIndex = 14;
            this.lblBookID.Text = "BookID";
            // 
            // txtbxBookName
            // 
            this.txtbxBookName.Location = new System.Drawing.Point(264, 70);
            this.txtbxBookName.Name = "txtbxBookName";
            this.txtbxBookName.Size = new System.Drawing.Size(190, 20);
            this.txtbxBookName.TabIndex = 13;
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(264, 143);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(190, 20);
            this.txtbxAuthor.TabIndex = 12;
            // 
            // txtbxISBN
            // 
            this.txtbxISBN.Location = new System.Drawing.Point(264, 109);
            this.txtbxISBN.Name = "txtbxISBN";
            this.txtbxISBN.Size = new System.Drawing.Size(190, 20);
            this.txtbxISBN.TabIndex = 11;
            // 
            // txtbxBookID
            // 
            this.txtbxBookID.Location = new System.Drawing.Point(264, 35);
            this.txtbxBookID.Name = "txtbxBookID";
            this.txtbxBookID.Size = new System.Drawing.Size(190, 20);
            this.txtbxBookID.TabIndex = 10;
            this.txtbxBookID.Leave += new System.EventHandler(this.txtbxBookID_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtbxBookName);
            this.Controls.Add(this.txtbxAuthor);
            this.Controls.Add(this.txtbxISBN);
            this.Controls.Add(this.txtbxBookID);
            this.Name = "frmAddBook";
            this.Text = "frmAddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtbxBookName;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.TextBox txtbxISBN;
        private System.Windows.Forms.TextBox txtbxBookID;
        private System.Windows.Forms.Button btnAdd;
    }
}