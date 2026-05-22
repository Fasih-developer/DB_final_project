using System;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Connections : Form
    {
        public Connections()
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

        private void btnNavConnections_Click(object sender, System.EventArgs e) { }

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

        private void btnNavMessages_Click(object sender, System.EventArgs e)
        {
            Messages form = new Messages();
            form.Show(); this.Hide();
        }

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

        private void Connections_Load(object sender, EventArgs e)
        {

        }
    }
}