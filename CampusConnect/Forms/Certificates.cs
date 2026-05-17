using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Certificates : Form
    {
        public Certificates()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Show(); this.Hide();
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            Add_Certifications form = new Add_Certifications();
            form.Show(); this.Hide();
        }
    }
}
