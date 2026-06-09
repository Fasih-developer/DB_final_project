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
            ApplyTheme();
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
                    cmbUni.Items.Add(new { Text = reader["CampusName"].ToString(), Value = reader["UniversityID"].ToString() });
                reader.Close();
                con.Close();
                cmbUni.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Error loading universities: " + ex.Message); }
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
                    cmbDept.Items.Add(new { Text = reader["DepartmentName"].ToString(), Value = reader["DepartmentID"].ToString() });
                reader.Close();
                con.Close();
                cmbDept.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Error loading departments: " + ex.Message); }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string fullName  = txtFullName.Text.Trim();
            string email     = txtEmail.Text.Trim();
            string username  = txtUsername.Text.Trim();
            string password  = txtPassword.Text.Trim();
            string ageText   = txtAge.Text.Trim();

            if (fullName == "" || email == "" || username == "" || password == "" || ageText == "")
            { MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cmbUni.SelectedIndex == -1)
            { MessageBox.Show("Please select a University.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cmbDept.SelectedIndex == -1)
            { MessageBox.Show("Please select a Department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cmbGender.SelectedIndex == -1)
            { MessageBox.Show("Please select a Gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!Regex.IsMatch(fullName, @"^[a-zA-Z ]+$"))
            { MessageBox.Show("Full Name can only contain letters and spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!Regex.IsMatch(email, @"^[^@]+@[^@]+\.com$"))
            { MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (password.Length <= 6)
            { MessageBox.Show("Password must be greater than 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int age;
            if (!int.TryParse(ageText, out age) || age < 10 || age > 100)
            { MessageBox.Show("Please enter a valid age (10-100).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int universityID = Convert.ToInt32(((dynamic)cmbUni.SelectedItem).Value);
            int departmentID = Convert.ToInt32(((dynamic)cmbDept.SelectedItem).Value);
            // GenderID from lookups: Male=1, Female=2
            int genderID     = Convert.ToInt32(((dynamic)cmbGender.SelectedItem).Value);

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM user_accounts WHERE Username = @username";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@username", username);
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                { con.Close(); MessageBox.Show("Username already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                string[] nameParts = fullName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts.Length > 1 ? string.Join(" ", nameParts, 1, nameParts.Length - 1) : "";

                string accountQuery = "INSERT INTO user_accounts (Username, Password, IsActive, CreatedAt) VALUES (@username, @password, 1, NOW())";
                MySqlCommand accountCmd = new MySqlCommand(accountQuery, con);
                accountCmd.Parameters.AddWithValue("@username", username);
                accountCmd.Parameters.AddWithValue("@password", password);
                accountCmd.ExecuteNonQuery();
                long accountID = accountCmd.LastInsertedId;

                // Include Gender and Age in profile insert
                string profileQuery = "INSERT INTO user_profiles (AccountID, FirstName, LastName, Gender, Age) VALUES (@accountID, @firstName, @lastName, @gender, @age)";
                MySqlCommand profileCmd = new MySqlCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("@accountID", accountID);
                profileCmd.Parameters.AddWithValue("@firstName", firstName);
                profileCmd.Parameters.AddWithValue("@lastName", lastName);
                profileCmd.Parameters.AddWithValue("@gender", genderID);
                profileCmd.Parameters.AddWithValue("@age", age);
                profileCmd.ExecuteNonQuery();
                long profileID = profileCmd.LastInsertedId;

                string enrollQuery = "INSERT INTO campus_enrollments (ProfileID, UniversityID, DepartmentID, IsCurrent) VALUES (@profileID, @universityID, @departmentID, 1)";
                MySqlCommand enrollCmd = new MySqlCommand(enrollQuery, con);
                enrollCmd.Parameters.AddWithValue("@profileID", profileID);
                enrollCmd.Parameters.AddWithValue("@universityID", universityID);
                enrollCmd.Parameters.AddWithValue("@departmentID", departmentID);
                enrollCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Login().Show(); this.Hide();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExit_Click(object sender, EventArgs e) { new CampusConnectform().Show(); this.Hide(); }
        private void label2_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panelCard_Paint(object sender, PaintEventArgs e) { }
        private void SignUp_Load(object sender, EventArgs e) { }
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (panelCard != null && IsHandleCreated)
            {
                int navWidth = panelSidebar.Width;
                int contentWidth = this.ClientSize.Width - navWidth;
                panelCard.Left = navWidth + (contentWidth - panelCard.Width) / 2;
                int top = (this.ClientSize.Height - panelCard.Height) / 2;
                panelCard.Top = top > 20 ? top : 20;
            }
        }

    }
}