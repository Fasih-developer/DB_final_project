using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Login form = new Login();
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
