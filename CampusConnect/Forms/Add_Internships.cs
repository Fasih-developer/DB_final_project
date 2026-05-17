using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Add_Internships : Form
    {
        public Add_Internships()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Internship form = new Internship();
            form.Show(); this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add logic with backend
            Internship form = new Internship();
            form.Show(); this.Hide();
        }
    }
}
