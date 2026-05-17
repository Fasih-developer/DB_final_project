using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Internship : Form
    {
        public Internship()
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
            Add_Internships form = new Add_Internships();
            form.Show(); this.Hide();
        }
    }
}
