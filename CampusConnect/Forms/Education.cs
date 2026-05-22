using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Education : Form
    {
        public Education()
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
            Add_Education form = new Add_Education();
            form.Show(); this.Hide();
        }

        private void Education_Load(object sender, EventArgs e)
        {

        }
    }
}
