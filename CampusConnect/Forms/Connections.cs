using System;
using System.Drawing;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Connections : Form
    {
        public Connections() {
            ApplyTheme(); InitializeComponent(); }
        private void Connections_Load(object sender, EventArgs e) { }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            new Requests().Show(); this.Hide();
        }

        private void btnMyConnections_Click(object sender, EventArgs e)
        {
            new MY_All_Connections().Show(); this.Hide();
        }

        private void btnNavProfile_Click(object sender, System.EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnNavSearch_Click(object sender, System.EventArgs e) { new Search_Person().Show(); this.Hide(); }
        private void btnNavConnections_Click(object sender, System.EventArgs e) { }
        private void btnNavUniversities_Click(object sender, System.EventArgs e) { new University().Show(); this.Hide(); }
        private void btnNavPosts_Click(object sender, System.EventArgs e) { new Posts().Show(); this.Hide(); }
        private void btnNavMessages_Click(object sender, System.EventArgs e) { new Messages().Show(); this.Hide(); }
        private void btnNavEvents_Click(object sender, System.EventArgs e) { new Events().Show(); this.Hide(); }
        private void btnLogout_Click(object sender, System.EventArgs e) { new Form1().Show(); this.Hide(); }
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
