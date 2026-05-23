using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Add_Skills : Form
    {
        public Add_Skills()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string skillName = txtSkillName.Text.Trim();

            if (skillName == "")
            {
                MessageBox.Show("Please enter a skill name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Check if skill already exists
                string checkQuery = "SELECT SkillID FROM skills WHERE SkillName = @skillName";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@skillName", skillName);
                object result = checkCmd.ExecuteScalar();

                long skillID;

                if (result != null)
                {
                    // Skill already exists, use existing ID
                    skillID = Convert.ToInt64(result);
                }
                else
                {
                    // Insert new skill
                    string insertSkill = "INSERT INTO skills (SkillName) VALUES (@skillName)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSkill, con);
                    insertCmd.Parameters.AddWithValue("@skillName", skillName);
                    insertCmd.ExecuteNonQuery();
                    skillID = insertCmd.LastInsertedId;
                }

                // Get ProfileID from AccountID
                string profileQuery = "SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID";
                MySqlCommand profileCmd = new MySqlCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                long profileID = Convert.ToInt64(profileCmd.ExecuteScalar());

                // Check if already added
                string dupCheck = "SELECT COUNT(*) FROM profile_skills WHERE ProfileID = @profileID AND SkillID = @skillID";
                MySqlCommand dupCmd = new MySqlCommand(dupCheck, con);
                dupCmd.Parameters.AddWithValue("@profileID", profileID);
                dupCmd.Parameters.AddWithValue("@skillID", skillID);
                int count = Convert.ToInt32(dupCmd.ExecuteScalar());

                if (count > 0)
                {
                    con.Close();
                    MessageBox.Show("This skill is already added.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert into profile_skills
                string linkQuery = "INSERT INTO profile_skills (ProfileID, SkillID) VALUES (@profileID, @skillID)";
                MySqlCommand linkCmd = new MySqlCommand(linkQuery, con);
                linkCmd.Parameters.AddWithValue("@profileID", profileID);
                linkCmd.Parameters.AddWithValue("@skillID", skillID);
                linkCmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Skill added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Skills form = new Skills();
                form.Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Skills form = new Skills();
            form.Show(); this.Hide();
        }

        private void Add_Skills_Load(object sender, EventArgs e) { }
    }
}