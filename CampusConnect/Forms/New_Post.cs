using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class New_Post : Form
    {
        public New_Post()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            My_Posts form = new My_Posts();
            form.Show(); this.Hide();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            // Post logic added with backend
            My_Posts form = new My_Posts();
            form.Show(); this.Hide();
        }
    }
}
