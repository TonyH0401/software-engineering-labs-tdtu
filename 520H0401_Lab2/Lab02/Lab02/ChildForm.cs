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
    public partial class ChildForm : Form
    {
        //private System.ComponentModel.Container components = null;
        private TabControl tabCtrl;
        private TabPage tabPag;
        public ChildForm()
        {
            InitializeComponent();
        }
        public TabPage TabPag
        {
            get
            {
                return tabPag;
            }
            set
            {
                tabPag = value;
            }
        }
        public TabControl TabCtrl
        {
            set
            {
                tabCtrl = value;
            }
        }
        private void ChildForm_Activated(object sender, EventArgs e)
        {
            //Activate the correspoding Tabpage
            tabCtrl.SelectedTab = tabPag;
            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }
        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();
            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

    }
}
