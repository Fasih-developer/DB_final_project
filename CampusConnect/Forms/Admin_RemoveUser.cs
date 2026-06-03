using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Admin_RemoveUser : Form
    {
        public Admin_RemoveUser()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void Admin_RemoveUser_Load(object sender, EventArgs e) { }

        private void ApplyTheme() { ThemeManager.Apply(this); }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim();
            if (term == "")
            {
                MessageBox.Show("Please enter a name to search.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SearchUsers(term);
        }

        private void SearchUsers(string term)
        {
            try
            {
                flowResults.Controls.Clear();

                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = @"SELECT up.ProfileID, up.FirstName, up.LastName,
                                        ua.AccountID, ua.Username,
                                        u.CampusName, d.DepartmentName
                                 FROM user_profiles up
                                 INNER JOIN user_accounts ua ON up.AccountID = ua.AccountID
                                 LEFT JOIN campus_enrollments ce ON up.ProfileID = ce.ProfileID AND ce.IsCurrent = 1
                                 LEFT JOIN universities u ON ce.UniversityID = u.UniversityID
                                 LEFT JOIN departments d ON ce.DepartmentID = d.DepartmentID
                                 WHERE (up.FirstName LIKE @term OR up.LastName LIKE @term
                                        OR CONCAT(up.FirstName,' ',up.LastName) LIKE @term)
                                 LIMIT 50";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@term", "%" + term + "%");

                var rows = new System.Collections.Generic.List<(int accountID, int profileID, string name, string username, string uni, string dept)>();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows.Add((
                            Convert.ToInt32(reader["AccountID"]),
                            Convert.ToInt32(reader["ProfileID"]),
                            reader["FirstName"] + " " + reader["LastName"],
                            reader["Username"].ToString(),
                            reader["CampusName"].ToString(),
                            reader["DepartmentName"].ToString()
                        ));
                    }
                }
                con.Close();

                if (rows.Count == 0)
                {
                    Label lbl = new Label();
                    lbl.Text = "No users found matching \"" + term + "\".";
                    lbl.Font = new Font("Montserrat", 11F);
                    lbl.ForeColor = ThemeManager.Muted;
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(16);
                    flowResults.Controls.Add(lbl);
                    return;
                }

                foreach (var r in rows)
                    flowResults.Controls.Add(BuildUserRow(r.accountID, r.profileID, r.name, r.username, r.uni, r.dept));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel BuildUserRow(int accountID, int profileID, string name, string username, string uni, string dept)
        {
            Panel row = new Panel();
            row.BackColor = ThemeManager.Panel;
            row.Width = flowResults.Width - 24;
            row.Height = 80;
            row.Margin = new Padding(0, 0, 0, 10);

            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Montserrat Medium", 11F, FontStyle.Bold);
            lblName.ForeColor = ThemeManager.Text;
            lblName.Location = new Point(18, 10);
            lblName.AutoSize = true;
            row.Controls.Add(lblName);

            Label lblUser = new Label();
            lblUser.Text = "@" + username;
            lblUser.Font = new Font("Montserrat", 9F);
            lblUser.ForeColor = ThemeManager.Accent;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(lblName.Right + 10, 14);
            row.Controls.Add(lblUser);

            Label lblInfo = new Label();
            lblInfo.Text = (uni != "" ? uni : "—") + "  ·  " + (dept != "" ? dept : "—");
            lblInfo.Font = new Font("Montserrat", 9F);
            lblInfo.ForeColor = ThemeManager.SubText;
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(18, 46);
            row.Controls.Add(lblInfo);

            Button btnRemove = new Button();
            btnRemove.BackColor = Color.Red;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Text = "Remove";
            btnRemove.Size = new Size(130, 36);
            btnRemove.Location = new Point(row.Width - 150, 22);
            row.Controls.Add(btnRemove);

            int capAccountID = accountID;
            Panel capRow = row;
            btnRemove.Click += (s, e) => RemoveUser(capAccountID, name, capRow);

            return row;
        }

        private void RemoveUser(int accountID, string name, Panel row)
        {
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to remove \"{name}\"?\nThis will permanently delete their account and all associated data.",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Get ProfileID first
                string pidQ = "SELECT ProfileID FROM user_profiles WHERE AccountID = @aid";
                MySqlCommand pidCmd = new MySqlCommand(pidQ, con);
                pidCmd.Parameters.AddWithValue("@aid", accountID);
                object pidObj = pidCmd.ExecuteScalar();

                if (pidObj != null)
                {
                    int profileID = Convert.ToInt32(pidObj);

                    // Delete in dependency order
                    string[] cleanupQueries = {
                        "DELETE FROM profile_skills WHERE ProfileID = @pid",
                        "DELETE FROM certifications WHERE ProfileID = @pid",
                        "DELETE FROM educations WHERE ProfileID = @pid",
                        "DELETE FROM internships WHERE ProfileID = @pid",
                        "DELETE FROM posts WHERE ProfileID = @pid",
                        "DELETE FROM connections WHERE RequesterID = @pid OR ReceiverID = @pid",
                        "DELETE FROM event_attendees WHERE ProfileID = @pid",
                        "DELETE FROM campus_enrollments WHERE ProfileID = @pid",
                        "DELETE FROM user_profiles WHERE ProfileID = @pid"
                    };

                    foreach (string q in cleanupQueries)
                    {
                        MySqlCommand c = new MySqlCommand(q, con);
                        c.Parameters.AddWithValue("@pid", profileID);
                        c.ExecuteNonQuery();
                    }
                }

                // Finally delete the account
                string accQ = "DELETE FROM user_accounts WHERE AccountID = @aid";
                MySqlCommand accCmd = new MySqlCommand(accQ, con);
                accCmd.Parameters.AddWithValue("@aid", accountID);
                accCmd.ExecuteNonQuery();

                con.Close();

                flowResults.Controls.Remove(row);
                row.Dispose();
                MessageBox.Show($"\"{name}\" has been removed successfully.", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new ADMIN_UI().Show();
            this.Hide();
        }
    }
}
