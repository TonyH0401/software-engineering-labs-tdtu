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
    public partial class frmDataGrid : Form
    {
        private List<Person> Profession { get; set; }
        public frmDataGrid()
        {
            Profession = GetProfession();
            InitializeComponent();
        }
        private List<Person> GetProfession()
        {
            var list = new List<Person>();
            list.Add(new Person()
            {
                PersonID = 1,
                Name = "Hoang Anh",
                Address = "HCM City",
                Job = "IT Developer"
            });
            list.Add(new Person()

            {
                PersonID = 2,
                Name = "Trung Pham",
                Address = "NewYork City",
                Job = "IT Lecturer"
            });
            list.Add(new Person()
            {
                PersonID = 3,
                Name = "Anh Thu",
                Address = "Ostrava City",
                Job = "IT Student"
            });
            list.Add(new Person()
            {
                PersonID = 4,
                Name = "Que Chau",
                Address = "Kiev City",
                Job = "IT Defender"
            });
            return list;
        }
        private void frmDataGrid_Load(object sender, EventArgs e)
        {
            var profession = this.Profession;
            dataGridViewProfession.DataSource = profession;
        }
        private void dataGridViewProfession_CellContentClick(object sender,
        DataGridViewCellEventArgs e)
        {
            try
            {
                var selectRow = dataGridViewProfession.SelectedRows[0].DataBoundItem as
                Person;
                txtPersonID.Text = selectRow.PersonID.ToString();
                txtFullName.Text = selectRow.Name.ToString();
                txtAddress.Text = selectRow.Address.ToString();
                txtJob.Text = selectRow.Job.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message + "-" + ex.Source);
            }
        }
    }
}
