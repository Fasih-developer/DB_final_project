using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class My_Posts : Form
    {
        public My_Posts()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void My_Posts_Load(object sender, EventArgs e)
        {
            LoadMyPosts();
        }

        private void LoadMyPosts()
        {
            try
            {
                flowPosts.Controls.Clear();

                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = @"SELECT p.PostID, p.Description, p.PostedAt
                                 FROM posts p
                                 INNER JOIN user_profiles up ON p.ProfileID = up.ProfileID
                                 WHERE up.AccountID = @accountID
                                 ORDER BY p.PostedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                MySqlDataReader reader = cmd.ExecuteReader();

                bool hasPosts = false;
                while (reader.Read())
                {
                    hasPosts = true;
                    int postID = Convert.ToInt32(reader["PostID"]);
                    Panel postCard = CreatePostCard(
                        postID,
                        reader["Description"].ToString(),
                        Convert.ToDateTime(reader["PostedAt"]).ToString("dd MMM yyyy  HH:mm")
                    );
                    flowPosts.Controls.Add(postCard);
                }
                reader.Close();
                con.Close();

                if (!hasPosts)
                {
                    Label lbl = new Label();
                    lbl.Text = "You have not posted anything yet.";
                    lbl.Font = new Font("Montserrat", 11F);
                    lbl.ForeColor = Color.FromArgb(120, 120, 120);
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(20);
                    flowPosts.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreatePostCard(int postID, string description, string postedAt)
        {
            Panel card = new Panel();
            card.BackColor = Color.FromArgb(68, 72, 71);
            card.Width = flowPosts.Width - 30;
            card.Padding = new Padding(18, 14, 18, 14);
            card.Margin = new Padding(0, 0, 0, 14);

            Label lblDesc = new Label();
            lblDesc.Text = description;
            lblDesc.Font = new Font("Montserrat", 11F);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(18, 16);
            lblDesc.MaximumSize = new Size(card.Width - 130, 0);
            lblDesc.AutoSize = true;
            card.Controls.Add(lblDesc);

            Label lblDate = new Label();
            lblDate.Text = postedAt;
            lblDate.Font = new Font("Montserrat", 8.5F);
            lblDate.ForeColor = Color.FromArgb(52, 193, 164);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(18, lblDesc.Bottom + 10);
            card.Controls.Add(lblDate);

            // Delete button
            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Size = new Size(90, 34);
            btnDelete.Location = new Point(card.Width - 108, 16);
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            int capturedPostID = postID;
            btnDelete.Click += (sender, e) =>
            {
                var result = MessageBox.Show("Delete this post?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeletePost(capturedPostID);
                }
            };
            card.Controls.Add(btnDelete);

            card.Height = Math.Max(lblDate.Bottom + 18, btnDelete.Bottom + 14);
            return card;
        }

        private void DeletePost(int postID)
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();
                string q = "DELETE FROM posts WHERE PostID = @postID";
                MySqlCommand cmd = new MySqlCommand(q, con);
                cmd.Parameters.AddWithValue("@postID", postID);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadMyPosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting post: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flowPosts != null && flowPosts.Controls.Count > 0)
                LoadMyPosts();
        }

        private void btnNewPost_Click(object sender, EventArgs e) { new New_Post().Show(); this.Hide(); }
        private void btnExit_Click(object sender, EventArgs e) { new Profile().Show(); this.Hide(); }
        private void ApplyTheme() { ThemeManager.Apply(this); }
    }
}
