using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Add_Certifications : Form
    {
        public Add_Certifications()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string certName = txtCertName.Text.Trim();
            string orgName = txtOrgName.Text.Trim();
            string dateEarned = txtDateEarned.Text.Trim();

            if (certName == "" || orgName == "" || dateEarned == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validation
            DateTime parsedDate;
            if (!DateTime.TryParse(dateEarned, out parsedDate))
            {
                MessageBox.Show("Please enter date in correct format.\nExample: 2024-01-15", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string profileQuery = "SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID";
                MySqlCommand profileCmd = new MySqlCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                long profileID = Convert.ToInt64(profileCmd.ExecuteScalar());

                
                string query = @"INSERT INTO certifications (ProfileID, CertificateName, IssuingOrganization, DateEarned) 
                                 VALUES (@profileID, @certName, @orgName, @dateEarned)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@profileID", profileID);
                cmd.Parameters.AddWithValue("@certName", certName);
                cmd.Parameters.AddWithValue("@orgName", orgName);
                cmd.Parameters.AddWithValue("@dateEarned", parsedDate.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Certificate added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Certificates form = new Certificates();
                form.Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Certificates form = new Certificates();
            form.Show(); this.Hide();
        }

        private void Add_Certifications_Load(object sender, EventArgs e) { }
        private void ApplyTheme() { ThemeManager.Apply(this); }
    }
}