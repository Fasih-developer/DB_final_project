using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            HighlightNavButton(btnNavProfile);
        }

        private void HighlightNavButton(Button active)
        {
            Button[] allNav = { btnNavProfile, btnNavSearch, btnNavConnections, btnNavUniversities, btnNavPosts, btnNavMessages, btnNavEvents };
            foreach (var b in allNav)
                b.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            active.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
        }

        private void btnNavProfile_Click(object sender, EventArgs e) { }

        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            Search_Person form = new Search_Person();
            form.Show(); this.Hide();
        }

        private void btnNavConnections_Click(object sender, EventArgs e)
        {
            Connections form = new Connections();
            form.Show(); this.Hide();
        }

        private void btnNavUniversities_Click(object sender, EventArgs e)
        {
            University form = new University();
            form.Show(); this.Hide();
        }

        private void btnNavPosts_Click(object sender, EventArgs e)
        {
            Posts form = new Posts();
            form.Show(); this.Hide();
        }

        private void btnNavMessages_Click(object sender, EventArgs e)
        {
            Messages form = new Messages();
            form.Show(); this.Hide();
        }

        private void btnNavEvents_Click(object sender, EventArgs e)
        {
            Events form = new Events();
            form.Show(); this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(); this.Hide();
        }

        private void btnMyPosts_Click(object sender, EventArgs e)
        {
            My_Posts form = new My_Posts();
            form.Show(); this.Hide();
        }

        private void btnCheckSkills_Click(object sender, EventArgs e)
        {
            Skills form = new Skills();
            form.Show(); this.Hide();
        }

        private void btnCheckCertificates_Click(object sender, EventArgs e)
        {
            Certificates form = new Certificates();
            form.Show(); this.Hide();
        }

        private void btnCheckEducation_Click(object sender, EventArgs e)
        {
            Education form = new Education();
            form.Show(); this.Hide();
        }

        private void btnCheckInternships_Click(object sender, EventArgs e)
        {
            Internship form = new Internship();
            form.Show(); this.Hide();
        }
    }
}
