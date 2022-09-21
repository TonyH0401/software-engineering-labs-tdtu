using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class MainForm : Form
    {
        int childCount = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmForm f = new frmForm();
            f.ShowDialog();
        }

        private void dataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            DataGridForm datag = new DataGridForm();
            datag.MdiParent = this;
            datag.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click OK to Exit");
            //Application.Exit();
            this.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridForm datag = new DataGridForm();
            datag.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TestNewFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating MDI child form and initialize its fields
            ChildForm childForm = new ChildForm();
            childForm.Text = "MDIChild " + childCount.ToString();
            childForm.MdiParent = this;
            //child Form will now hold a reference value to the tab control
            childForm.TabCtrl = tabControlDataGridView;
            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControlDataGridView;
            tp.Text = childForm.Text;
            tp.Show();
            //child Form will now hold a reference value to a tabpage
            childForm.TabPag = tp;
            //Activate the MDI child form
            childForm.Show();
            childCount++;
            //Activate the newly created Tabpage
            tabControlDataGridView.SelectedTab = tp;
        }

        private void tabControlDataGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ChildForm childForm in this.MdiChildren)
            {
                if (childForm.TabPag.Equals(tabControlDataGridView.SelectedTab))
                {
                    //Active the child form
                    childForm.Select();
                }
            }
        }
    }
}
