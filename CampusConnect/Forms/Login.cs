using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CampusConnectform form = new CampusConnectform();
            form.Show();
            this.Hide();
        }
    }
}
