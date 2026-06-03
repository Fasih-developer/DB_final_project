using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    // Check credentials regardless of IsActive status
                    string query = "SELECT AccountID, IsActive FROM user_accounts WHERE Username = @username AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int accountID = Convert.ToInt32(reader["AccountID"]);
                        bool isActive = Convert.ToBoolean(reader["IsActive"]);
                        reader.Close();

                        if (!isActive)
                        {
                            // Account inactive — ask to reactivate
                            var result = MessageBox.Show(
                                "Your account is currently inactive.\nWould you like to reactivate it?",
                                "Account Inactive",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.No)
                                return; // stay on login form

                            // Reactivate
                            string reactivateQ = "UPDATE user_accounts SET IsActive = 1 WHERE AccountID = @accountID";
                            MySqlCommand reactivateCmd = new MySqlCommand(reactivateQ, con);
                            reactivateCmd.Parameters.AddWithValue("@accountID", accountID);
                            reactivateCmd.ExecuteNonQuery();
                        }

                        con.Close();
                        Session.AccountID = accountID;
                        new Profile().Show();
                        this.Hide();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new CampusConnectform().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e) { }

        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (panelCard != null && IsHandleCreated)
            {
                int navWidth = panelSidebar.Width;
                int contentWidth = this.ClientSize.Width - navWidth;
                panelCard.Left = navWidth + (contentWidth - panelCard.Width) / 2;
                panelCard.Top = (this.ClientSize.Height - panelCard.Height) / 2;
            }
        }

    }
}