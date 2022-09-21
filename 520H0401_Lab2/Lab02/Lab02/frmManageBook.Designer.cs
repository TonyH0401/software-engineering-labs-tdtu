namespace Lab02
{
    partial class frmManageBook
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
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.txtbxBookID = new System.Windows.Forms.TextBox();
            this.txtbxISBN = new System.Windows.Forms.TextBox();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.txtbxBookName = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(12, 199);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBook.Size = new System.Drawing.Size(660, 150);
            this.dataGridViewBook.TabIndex = 0;
            this.dataGridViewBook.SelectionChanged += new System.EventHandler(this.dataGridViewBook_SelectionChanged);
            // 
            // txtbxBookID
            // 
            this.txtbxBookID.Location = new System.Drawing.Point(269, 25);
            this.txtbxBookID.Name = "txtbxBookID";
            this.txtbxBookID.Size = new System.Drawing.Size(190, 20);
            this.txtbxBookID.TabIndex = 1;
            // 
            // txtbxISBN
            // 
            this.txtbxISBN.Location = new System.Drawing.Point(269, 99);
            this.txtbxISBN.Name = "txtbxISBN";
            this.txtbxISBN.Size = new System.Drawing.Size(190, 20);
            this.txtbxISBN.TabIndex = 2;
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(269, 133);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(190, 20);
            this.txtbxAuthor.TabIndex = 3;
            // 
            // txtbxBookName
            // 
            this.txtbxBookName.Location = new System.Drawing.Point(269, 60);
            this.txtbxBookName.Name = "txtbxBookName";
            this.txtbxBookName.Size = new System.Drawing.Size(190, 20);
            this.txtbxBookName.TabIndex = 4;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(178, 25);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(43, 13);
            this.lblBookID.TabIndex = 6;
            this.lblBookID.Text = "BookID";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(178, 63);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(63, 13);
            this.lblBookName.TabIndex = 7;
            this.lblBookName.Text = "Book Name";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(178, 102);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 8;
            this.lblISBN.Text = "ISBN";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(178, 140);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Author";
            // 
            // frmManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtbxBookName);
            this.Controls.Add(this.txtbxAuthor);
            this.Controls.Add(this.txtbxISBN);
            this.Controls.Add(this.txtbxBookID);
            this.Controls.Add(this.dataGridViewBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageBook";
            this.Text = "frmManageBook";
            this.Load += new System.EventHandler(this.frmManageBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.TextBox txtbxBookID;
        private System.Windows.Forms.TextBox txtbxISBN;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.TextBox txtbxBookName;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthor;
    }
}