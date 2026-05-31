using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin_signin form = new admin_signin();
            form.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            CampusConnectform form = new CampusConnectform();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
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
