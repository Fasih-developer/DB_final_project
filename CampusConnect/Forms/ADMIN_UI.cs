using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class ADMIN_UI : Form
    {
        public ADMIN_UI()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            Admin_RemoveUser form = new Admin_RemoveUser();
            form.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Admin_Reports form = new Admin_Reports();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            admin_signin form = new admin_signin();
            form.Show();
            this.Hide();
        }

        private void ADMIN_UI_Load(object sender, EventArgs e)
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
