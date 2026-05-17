using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Admin_RemoveUser : Form
    {
        public Admin_RemoveUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ADMIN_UI form = new ADMIN_UI();
            form.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search logic will be added with backend
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove logic will be added with backend
        }
    }
}
