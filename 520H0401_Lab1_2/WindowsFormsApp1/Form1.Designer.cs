namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUserID = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rdbtnLightTheme = new System.Windows.Forms.RadioButton();
            this.rdbtnDarkTheme = new System.Windows.Forms.RadioButton();
            this.txtLabelCPY = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Location = new System.Drawing.Point(153, 117);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(40, 13);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.Text = "UserID";
            this.txtUserID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(222, 114);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(193, 20);
            this.textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(222, 140);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(193, 20);
            this.textPassword.TabIndex = 3;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(153, 143);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(53, 13);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 22);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(236, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(67, 22);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rdbtnLightTheme
            // 
            this.rdbtnLightTheme.AutoSize = true;
            this.rdbtnLightTheme.Location = new System.Drawing.Point(116, 211);
            this.rdbtnLightTheme.Name = "rdbtnLightTheme";
            this.rdbtnLightTheme.Size = new System.Drawing.Size(81, 17);
            this.rdbtnLightTheme.TabIndex = 6;
            this.rdbtnLightTheme.TabStop = true;
            this.rdbtnLightTheme.Text = "LightTheme";
            this.rdbtnLightTheme.UseVisualStyleBackColor = true;
            // 
            // rdbtnDarkTheme
            // 
            this.rdbtnDarkTheme.AutoSize = true;
            this.rdbtnDarkTheme.Location = new System.Drawing.Point(116, 234);
            this.rdbtnDarkTheme.Name = "rdbtnDarkTheme";
            this.rdbtnDarkTheme.Size = new System.Drawing.Size(84, 17);
            this.rdbtnDarkTheme.TabIndex = 7;
            this.rdbtnDarkTheme.TabStop = true;
            this.rdbtnDarkTheme.Text = "Dark Theme";
            this.rdbtnDarkTheme.UseVisualStyleBackColor = true;
            // 
            // txtLabelCPY
            // 
            this.txtLabelCPY.AutoSize = true;
            this.txtLabelCPY.Location = new System.Drawing.Point(517, 259);
            this.txtLabelCPY.Name = "txtLabelCPY";
            this.txtLabelCPY.Size = new System.Drawing.Size(113, 13);
            this.txtLabelCPY.TabIndex = 8;
            this.txtLabelCPY.Text = "@Copyrighted By LGP";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(135, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(341, 96);
            this.picBox.TabIndex = 9;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(657, 281);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtLabelCPY);
            this.Controls.Add(this.rdbtnDarkTheme);
            this.Controls.Add(this.rdbtnLightTheme);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.txtUserID);
            this.Name = "Form1";
            this.Text = "Form1 Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rdbtnLightTheme;
        private System.Windows.Forms.RadioButton rdbtnDarkTheme;
        private System.Windows.Forms.Label txtLabelCPY;
        private System.Windows.Forms.PictureBox picBox;
    }
}

