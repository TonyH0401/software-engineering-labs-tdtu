﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataGrid f = new frmDataGrid();
            f.TopLevel = false;
            this.Controls.Add(f);
            f.Show();
        }
    }
}