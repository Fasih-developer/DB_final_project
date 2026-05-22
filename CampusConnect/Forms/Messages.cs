using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void btnNavProfile_Click(object sender, System.EventArgs e)
        {
            Profile form = new Profile();
            form.Show(); this.Hide();
        }

        private void btnNavSearch_Click(object sender, System.EventArgs e)
        {
            Search_Person form = new Search_Person();
            form.Show(); this.Hide();
        }

        private void btnNavConnections_Click(object sender, System.EventArgs e)
        {
            Connections form = new Connections();
            form.Show(); this.Hide();
        }

        private void btnNavUniversities_Click(object sender, System.EventArgs e)
        {
            University form = new University();
            form.Show(); this.Hide();
        }

        private void btnNavPosts_Click(object sender, System.EventArgs e)
        {
            Posts form = new Posts();
            form.Show(); this.Hide();
        }

        private void btnNavMessages_Click(object sender, System.EventArgs e) { }

        private void btnNavEvents_Click(object sender, System.EventArgs e)
        {
            Events form = new Events();
            form.Show(); this.Hide();
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(); this.Hide();
        }
        private void btnSearchMsg_Click(object sender, System.EventArgs e) { }
        private void btnStartMessaging_Click(object sender, System.EventArgs e) { }

        private void Messages_Load(object sender, EventArgs e)
        {

        }
    }
}