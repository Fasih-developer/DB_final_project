using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class New_Post : Form
    {
        public New_Post()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string content = txtContent.Text.Trim();
            if (content == "")
            {
                MessageBox.Show("Please write something before posting.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Get ProfileID from Session AccountID
                string profileQuery = "SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID";
                MySqlCommand profileCmd = new MySqlCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                long profileID = Convert.ToInt64(profileCmd.ExecuteScalar());

                string insertQuery = "INSERT INTO posts (ProfileID, Description, PostedAt) VALUES (@profileID, @description, NOW())";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@profileID", profileID);
                insertCmd.Parameters.AddWithValue("@description", content);
                insertCmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Post created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new My_Posts().Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) { new My_Posts().Show(); this.Hide(); }
        private void New_Post_Load(object sender, EventArgs e) { }
        private void ApplyTheme() { ThemeManager.Apply(this); }
    }
}
