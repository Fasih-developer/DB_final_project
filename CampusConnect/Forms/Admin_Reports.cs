using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Admin_Reports : Form
    {
        public Admin_Reports()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ADMIN_UI form = new ADMIN_UI();
            form.Show();
            this.Hide();
        }

        private void Admin_Reports_Load(object sender, EventArgs e)
        {

        }
        private void ApplyTheme() { ThemeManager.Apply(this); }
    }
}
