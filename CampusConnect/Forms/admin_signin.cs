using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class admin_signin : Form
    {
        public admin_signin()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme() { ThemeManager.Apply(this); }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hardcoded admin credentials
            if (username == "admin" && password == "admin")
            {
                new ADMIN_UI().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Access denied.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void admin_signin_Load(object sender, EventArgs e) { }
    }
}
