
namespace Lab02
{
    partial class DataGridForm
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.btnSaveToSQL = new System.Windows.Forms.Button();
            this.txtbxTest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(458, 150);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.SelectionChanged += new System.EventHandler(this.dataGridViewUser_SelectionChanged);
            // 
            // btnSaveToSQL
            // 
            this.btnSaveToSQL.Location = new System.Drawing.Point(12, 182);
            this.btnSaveToSQL.Name = "btnSaveToSQL";
            this.btnSaveToSQL.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToSQL.TabIndex = 1;
            this.btnSaveToSQL.Text = "Save";
            this.btnSaveToSQL.UseVisualStyleBackColor = true;
            this.btnSaveToSQL.Click += new System.EventHandler(this.btnSaveToSQL_Click);
            // 
            // txtbxTest
            // 
            this.txtbxTest.Location = new System.Drawing.Point(132, 185);
            this.txtbxTest.Name = "txtbxTest";
            this.txtbxTest.Size = new System.Drawing.Size(100, 20);
            this.txtbxTest.TabIndex = 2;
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 254);
            this.Controls.Add(this.txtbxTest);
            this.Controls.Add(this.btnSaveToSQL);
            this.Controls.Add(this.dataGridViewUser);
            this.Name = "DataGridForm";
            this.Text = "DataGridForm";
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button btnSaveToSQL;
        private System.Windows.Forms.TextBox txtbxTest;
    }
}