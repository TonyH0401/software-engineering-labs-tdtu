using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to Exit");
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool themeChk = false;
            if(rdbtnLightTheme.Checked || rdbtnLightTheme.Checked)
            {
                themeChk = true;
            }
            if(themeChk == false)
            {
                MessageBox.Show("Please check one of the option");
            } else
            {
                MessageBox.Show("Correct");
                Application.Exit();
            }

        }
    }
}
