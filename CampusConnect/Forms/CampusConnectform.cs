using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class CampusConnectform : Form
    {
        public CampusConnectform()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void CampusConnectform_Load(object sender, EventArgs e)
        {

        }
        private void ApplyTheme()
        {
            ThemeManager.Apply(this);
            if (btnThemeToggle != null)
                btnThemeToggle.Text = ThemeManager.ToggleButtonLabel;
        }

        private void btnThemeToggle_Click(object sender, EventArgs e)
        {
            ThemeManager.Toggle();
            ApplyTheme();
        }

    }
}
