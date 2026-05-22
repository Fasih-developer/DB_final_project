using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Skills : Form
    {
        public Skills()
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
            Add_Skills form = new Add_Skills();
            form.Show(); this.Hide();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
