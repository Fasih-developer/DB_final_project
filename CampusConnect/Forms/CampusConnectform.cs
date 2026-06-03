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
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (panelCreate == null || !IsHandleCreated) return;

            int navWidth = panelSidebar.Width;
            int contentWidth = this.ClientSize.Width - navWidth;
            int totalPanels = panelCreate.Width + panelSignIn.Width + 40;
            int startX = navWidth + (contentWidth - totalPanels) / 2;
            if (startX < navWidth + 20) startX = navWidth + 20;

            panelCreate.Left = startX;
            panelSignIn.Left = startX + panelCreate.Width + 40;

            int midY = (this.ClientSize.Height - panelCreate.Height) / 2;
            if (midY < 160) midY = 160;
            panelCreate.Top = midY;
            panelSignIn.Top = midY;

            lblPageTitle.Left = startX;
            lblSubtitle.Left = startX;
        }

    }
}