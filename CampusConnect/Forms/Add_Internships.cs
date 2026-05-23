using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Add_Internships : Form
    {
        public Add_Internships()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string company = txtCompany.Text.Trim();
            string jobRole = txtJobRole.Text.Trim();
            string description = txtDescription.Text.Trim();
            string startDate = txtStartYear.Text.Trim();
            string endDate = txtEndDate.Text.Trim();

            if (company == "" || jobRole == "" || startDate == "" || endDate == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime parsedStart, parsedEnd;
            if (!DateTime.TryParse(startDate, out parsedStart) || !DateTime.TryParse(endDate, out parsedEnd))
            {
                MessageBox.Show("Please enter date in correct format.\nExample: 2024-01-15", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (parsedEnd <= parsedStart)
            {
                MessageBox.Show("End date cannot be before start date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Get ProfileID
                string profileQuery = "SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID";
                MySqlCommand profileCmd = new MySqlCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                long profileID = Convert.ToInt64(profileCmd.ExecuteScalar());

                string query = @"INSERT INTO internships (ProfileID, CompanyName, JobRole, Description, StartDate, EndDate) 
                                 VALUES (@profileID, @company, @jobRole, @description, @startDate, @endDate)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@profileID", profileID);
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@jobRole", jobRole);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@startDate", parsedStart.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@endDate", parsedEnd.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Internship added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Internship form = new Internship();
                form.Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Internship form = new Internship();
            form.Show(); this.Hide();
        }

        private void Add_Internships_Load(object sender, EventArgs e) { }
    }
}