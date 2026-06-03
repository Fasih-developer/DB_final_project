using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Posts : Form
    {
        public Posts() {
            ApplyTheme(); InitializeComponent(); }
        private void Posts_Load(object sender, EventArgs e) { LoadPosts(); }

        private void LoadPosts()
        {
            try
            {
                flowPosts.Controls.Clear();
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = @"SELECT p.Description, p.PostedAt,
                                        up.FirstName, up.LastName,
                                        ua.Username
                                 FROM posts p
                                 INNER JOIN user_profiles up ON p.ProfileID = up.ProfileID
                                 INNER JOIN user_accounts ua ON up.AccountID = ua.AccountID
                                 ORDER BY p.PostedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                bool has = false;
                while (reader.Read())
                {
                    has = true;
                    string name   = reader["FirstName"] + " " + reader["LastName"];
                    string user   = "@" + reader["Username"];
                    string desc   = reader["Description"].ToString();
                    string date   = Convert.ToDateTime(reader["PostedAt"]).ToString("dd MMM yyyy  HH:mm");

                    Panel card = new Panel();
                    card.BackColor = Color.FromArgb(68, 72, 71);
                    card.Width = flowPosts.Width - 24;
                    card.Margin = new Padding(0, 0, 0, 14);
                    card.Padding = new Padding(18, 14, 18, 14);

                    Label lblName = new Label();
                    lblName.Text = name;
                    lblName.Font = new Font("Montserrat Medium", 11F, FontStyle.Bold);
                    lblName.ForeColor = Color.White;
                    lblName.Location = new Point(18, 14);
                    lblName.AutoSize = true;
                    card.Controls.Add(lblName);

                    Label lblUser = new Label();
                    lblUser.Text = user;
                    lblUser.Font = new Font("Montserrat", 9F);
                    lblUser.ForeColor = Color.FromArgb(52, 193, 164);
                    lblUser.AutoSize = true;
                    lblUser.Location = new Point(lblName.Right + 10, 18);
                    card.Controls.Add(lblUser);

                    Label lblDesc = new Label();
                    lblDesc.Text = desc;
                    lblDesc.Font = new Font("Montserrat", 10.5F);
                    lblDesc.ForeColor = Color.FromArgb(220, 220, 220);
                    lblDesc.MaximumSize = new Size(card.Width - 40, 0);
                    lblDesc.AutoSize = true;
                    lblDesc.Location = new Point(18, lblName.Bottom + 10);
                    card.Controls.Add(lblDesc);

                    Label lblDate = new Label();
                    lblDate.Text = date;
                    lblDate.Font = new Font("Montserrat", 8.5F);
                    lblDate.ForeColor = Color.FromArgb(130, 130, 130);
                    lblDate.AutoSize = true;
                    lblDate.Location = new Point(18, lblDesc.Bottom + 10);
                    card.Controls.Add(lblDate);

                    card.Height = lblDate.Bottom + 18;
                    flowPosts.Controls.Add(card);
                }
                reader.Close(); con.Close();

                if (!has)
                {
                    Label lbl = new Label();
                    lbl.Text = "No posts yet. Be the first to post!";
                    lbl.Font = new Font("Montserrat", 11F);
                    lbl.ForeColor = Color.FromArgb(120, 120, 120);
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(20);
                    flowPosts.Controls.Add(lbl);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnNavProfile_Click(object sender, System.EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnNavSearch_Click(object sender, System.EventArgs e) { new Search_Person().Show(); this.Hide(); }
        private void btnNavConnections_Click(object sender, System.EventArgs e) { new Connections().Show(); this.Hide(); }
        private void btnNavUniversities_Click(object sender, System.EventArgs e) { new University().Show(); this.Hide(); }
        private void btnNavPosts_Click(object sender, System.EventArgs e) { }
        private void btnNavMessages_Click(object sender, System.EventArgs e) { new Messages().Show(); this.Hide(); }
        private void btnNavEvents_Click(object sender, System.EventArgs e) { new Events().Show(); this.Hide(); }
        private void btnLogout_Click(object sender, System.EventArgs e) { new Form1().Show(); this.Hide(); }
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flowPosts != null && IsHandleCreated)
                LoadPosts();
        }

    }
}