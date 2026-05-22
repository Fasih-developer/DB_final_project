using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Add_Skills : Form
    {
        public Add_Skills()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Skills form = new Skills();
            form.Show(); this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add logic with backend
            Skills form = new Skills();
            form.Show(); this.Hide();
        }

        private void Add_Skills_Load(object sender, EventArgs e)
        {

        }
    }
}
