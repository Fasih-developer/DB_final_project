using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Other_Person : Form
    {
        public Other_Person()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Other_Person_Load(object sender, EventArgs e)
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