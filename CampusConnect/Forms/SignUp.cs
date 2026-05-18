using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (fullName == "" || email == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                // Split full name into first and last
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

                // Get the new AccountID
                long accountID = accountCmd.LastInsertedId;

                // Insert into user_profiles
                string profileQuery = "INSERT INTO user_profiles (AccountID, FirstName, LastName) VALUES (@accountID, @firstName, @lastName)";
                MySqlCommand profileCmd = new MySqlCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("@accountID", accountID);
                profileCmd.Parameters.AddWithValue("@firstName", firstName);
                profileCmd.Parameters.AddWithValue("@lastName", lastName);
                profileCmd.ExecuteNonQuery();

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
    }
}
