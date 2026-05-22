using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Add_Education : Form
    {
        public Add_Education()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Education form = new Education();
            form.Show(); this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add logic with backend
            Education form = new Education();
            form.Show(); this.Hide();
        }

        private void Add_Education_Load(object sender, EventArgs e)
        {

        }
    }
}
