using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            LoadUniversities();
            LoadDepartments();
        }

        private void LoadUniversities()
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "SELECT UniversityID, CampusName FROM universities";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbUni.Items.Clear();
                cmbUni.DisplayMember = "Text";
                cmbUni.ValueMember = "Value";

                while (reader.Read())
                {
                    cmbUni.Items.Add(new { Text = reader["CampusName"].ToString(), Value = reader["UniversityID"].ToString() });
                }

                reader.Close();
                con.Close();

                cmbUni.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading universities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDepartments()
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "SELECT DepartmentID, DepartmentName FROM departments";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbDept.Items.Clear();
                cmbDept.DisplayMember = "Text";
                cmbDept.ValueMember = "Value";

                while (reader.Read())
                {
                    cmbDept.Items.Add(new { Text = reader["DepartmentName"].ToString(), Value = reader["DepartmentID"].ToString() });
                }

                reader.Close();
                con.Close();

                cmbDept.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Empty fields check
            if (fullName == "" || email == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Combo boxes check
            if (cmbUni.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a University.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDept.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Full name: only letters and spaces allowed
            if (!Regex.IsMatch(fullName, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Full Name can only contain letters and spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            if (!Regex.IsMatch(email, @"^[^@]+@[^@]+\.com$"))
            {
                MessageBox.Show("Please enter a valid email address.\nExample: example@domain.com", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password length greater than 6
            if (password.Length <= 6)
            {
                MessageBox.Show("Password must be greater than 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected University and Department IDs
            int universityID = Convert.ToInt32(((dynamic)cmbUni.SelectedItem).Value);
            int departmentID = Convert.ToInt32(((dynamic)cmbDept.SelectedItem).Value);

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM user_accounts WHERE Username = @username";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@username", username);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    con.Close();
                    MessageBox.Show("Username already exists. Please choose another.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Split full name
                string firstName = "";
                string lastName = "";
                string[] nameParts = fullName.Split(' ');
                firstName = nameParts[0];
                if (nameParts.Length > 1)
                    lastName = string.Join(" ", nameParts, 1, nameParts.Length - 1);

                // Insert into user_accounts
                string accountQuery = "INSERT INTO user_accounts (Username, Password, IsActive, CreatedAt) VALUES (@username, @password, 1, NOW())";
                MySqlCommand accountCmd = new MySqlCommand(accountQuery, con);
                accountCmd.Parameters.AddWithValue("@username", username);
                accountCmd.Parameters.AddWithValue("@password", password);
                accountCmd.ExecuteNonQuery();

                long accountID = accountCmd.LastInsertedId;

                // Insert into user_profiles
                string profileQuery = "INSERT INTO user_profiles (AccountID, FirstName, LastName) VALUES (@accountID, @firstName, @lastName)";
                MySqlCommand profileCmd = new MySqlCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("@accountID", accountID);
                profileCmd.Parameters.AddWithValue("@firstName", firstName);
                profileCmd.Parameters.AddWithValue("@lastName", lastName);
                profileCmd.ExecuteNonQuery();

                long profileID = profileCmd.LastInsertedId;

                // Insert into campus_enrollment
                string enrollQuery = "INSERT INTO campus_enrollments (ProfileID, UniversityID, DepartmentID, IsCurrent) VALUES (@profileID, @universityID, @departmentID, 1)";
                MySqlCommand enrollCmd = new MySqlCommand(enrollQuery, con);
                enrollCmd.Parameters.AddWithValue("@profileID", profileID);
                enrollCmd.Parameters.AddWithValue("@universityID", universityID);
                enrollCmd.Parameters.AddWithValue("@departmentID", departmentID);
                enrollCmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login form = new Login();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CampusConnectform form = new CampusConnectform();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
