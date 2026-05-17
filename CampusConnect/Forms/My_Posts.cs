using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class My_Posts : Form
    {
        public My_Posts()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Show(); this.Hide();
        }

        private void btnNewPost_Click(object sender, EventArgs e)
        {
            New_Post form = new New_Post();
            form.Show(); this.Hide();
        }
    }
}
