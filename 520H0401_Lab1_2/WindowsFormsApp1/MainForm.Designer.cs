﻿namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataToolStripMenuItem,
            this.manageDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDataToolStripMenuItem
            // 
            this.menuDataToolStripMenuItem.Name = "menuDataToolStripMenuItem";
            this.menuDataToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.menuDataToolStripMenuItem.Text = "Files";
            // 
            // manageDataToolStripMenuItem
            // 
            this.manageDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataGridToolStripMenuItem});
            this.manageDataToolStripMenuItem.Name = "manageDataToolStripMenuItem";
            this.manageDataToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.manageDataToolStripMenuItem.Text = "Manage &Data";
            // 
            // dataGridToolStripMenuItem
            // 
            this.dataGridToolStripMenuItem.Name = "dataGridToolStripMenuItem";
            this.dataGridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataGridToolStripMenuItem.Text = "Data &Grid";
            this.dataGridToolStripMenuItem.Click += new System.EventHandler(this.dataGridToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGridToolStripMenuItem;
    }
}