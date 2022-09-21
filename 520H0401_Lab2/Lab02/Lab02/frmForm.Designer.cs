
namespace Lab02
{
    partial class frmForm
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
            this.lblUSer = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxUser = new System.Windows.Forms.TextBox();
            this.txtbxPassoword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUSer
            // 
            this.lblUSer.AutoSize = true;
            this.lblUSer.Location = new System.Drawing.Point(99, 67);
            this.lblUSer.Name = "lblUSer";
            this.lblUSer.Size = new System.Drawing.Size(29, 13);
            this.lblUSer.TabIndex = 0;
            this.lblUSer.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(99, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtbxUser
            // 
            this.txtbxUser.Location = new System.Drawing.Point(217, 67);
            this.txtbxUser.Name = "txtbxUser";
            this.txtbxUser.Size = new System.Drawing.Size(183, 20);
            this.txtbxUser.TabIndex = 2;
            // 
            // txtbxPassoword
            // 
            this.txtbxPassoword.Location = new System.Drawing.Point(217, 109);
            this.txtbxPassoword.Name = "txtbxPassoword";
            this.txtbxPassoword.Size = new System.Drawing.Size(183, 20);
            this.txtbxPassoword.TabIndex = 3;
            this.txtbxPassoword.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(325, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(217, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtbxPassoword);
            this.Controls.Add(this.txtbxUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUSer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForm";
            this.Text = "frmForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmForm_FormClosing);
            this.Load += new System.EventHandler(this.frmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUSer;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxUser;
        private System.Windows.Forms.TextBox txtbxPassoword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}