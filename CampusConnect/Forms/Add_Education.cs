using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Add_Education : Form
    {
        public Add_Education()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string institution = txtInstitute.Text.Trim();
            string degree = txtDegree.Text.Trim();
            string startYear = txtStartYear.Text.Trim();
            string endYear = txtEndYear.Text.Trim();

            if (institution == "" || degree == "" || startYear == "" || endYear == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Year validation
            int sYear, eYear;
            if (!int.TryParse(startYear, out sYear) || !int.TryParse(endYear, out eYear))
            {
                MessageBox.Show("Please enter valid years.\nExample: 2020", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (eYear <= sYear)
            {
                MessageBox.Show("End year cannot be less than start year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                string query = @"INSERT INTO educations (ProfileID, InstitutionName, Degree, StartYear, EndYear) 
                                 VALUES (@profileID, @institution, @degree, @startYear, @endYear)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@profileID", profileID);
                cmd.Parameters.AddWithValue("@institution", institution);
                cmd.Parameters.AddWithValue("@degree", degree);
                cmd.Parameters.AddWithValue("@startYear", sYear);
                cmd.Parameters.AddWithValue("@endYear", eYear);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Education added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Education form = new Education();
                form.Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Education form = new Education();
            form.Show(); this.Hide();
        }

        private void Add_Education_Load(object sender, EventArgs e) { }
        private void ApplyTheme()
        {
            ThemeManager.Apply(this);
            if (btnThemeToggle != null)
                btnThemeToggle.Text = ThemeManager.ToggleButtonLabel;
        }

        private void btnThemeToggle_Click(object sender, EventArgs e)
        {
            ThemeManager.Toggle();
            ApplyTheme();
        }

    }
}