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
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (panelRequests == null || !IsHandleCreated) return;

            int navWidth = panelNav.Width;
            int contentWidth = this.ClientSize.Width - navWidth;
            int totalW = panelRequests.Width + panelMyConn.Width + 40;
            int startX = navWidth + (contentWidth - totalW) / 2;
            if (startX < navWidth + 20) startX = navWidth + 20;

            panelRequests.Left = startX;
            panelMyConn.Left   = startX + panelRequests.Width + 40;

            int midY = (this.ClientSize.Height - panelRequests.Height) / 2;
            if (midY < 120) midY = 120;
            panelRequests.Top = midY;
            panelMyConn.Top   = midY;
        }

    }
}