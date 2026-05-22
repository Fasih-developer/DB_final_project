using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Add_Certifications : Form
    {
        public Add_Certifications()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Certificates form = new Certificates();
            form.Show(); this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add logic with backend
            Certificates form = new Certificates();
            form.Show(); this.Hide();
        }

        private void Add_Certifications_Load(object sender, EventArgs e)
        {

        }
    }
}
