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
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (panelAdmin == null || !IsHandleCreated) return;

            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int totalW = panelAdmin.Width + panelUser.Width + 40;
            int startX = (w - totalW) / 2;
            if (startX < 40) startX = 40;

            panelAdmin.Left = startX;
            panelUser.Left  = startX + panelAdmin.Width + 40;

            int midY = (h - panelAdmin.Height) / 2;
            if (midY < 160) midY = 160;
            panelAdmin.Top = midY;
            panelUser.Top  = midY;

            lblTitle.Left = (w - lblTitle.Width) / 2;
            lblSubtitle.Left = (w - lblSubtitle.Width) / 2;
        }

    }
}