using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Search_Person : Form
    {
        public Search_Person() { InitializeComponent(); ApplyTheme(); }

        private void ApplyTheme() { ThemeManager.Apply(this); }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim();
            if (term == "")
            {
                MessageBox.Show("Please enter a name to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadResults(term);
        }

        private void LoadResults(string term)
        {
            try
            {
                flowResults.Controls.Clear();

                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string myPQ = "SELECT ProfileID FROM user_profiles WHERE AccountID = @aid";
                MySqlCommand myCmd = new MySqlCommand(myPQ, con);
                myCmd.Parameters.AddWithValue("@aid", Session.AccountID);
                int myProfileID = Convert.ToInt32(myCmd.ExecuteScalar());

                string query = @"SELECT up.ProfileID, up.FirstName, up.LastName,
                                        ua.Username, up.Gender,
                                        u.CampusName, d.DepartmentName
                                 FROM user_profiles up
                                 INNER JOIN user_accounts ua ON up.AccountID = ua.AccountID
                                 LEFT JOIN campus_enrollments ce ON up.ProfileID = ce.ProfileID AND ce.IsCurrent = 1
                                 LEFT JOIN universities u ON ce.UniversityID = u.UniversityID
                                 LEFT JOIN departments d ON ce.DepartmentID = d.DepartmentID
                                 WHERE (up.FirstName LIKE @term OR up.LastName LIKE @term
                                        OR CONCAT(up.FirstName,' ',up.LastName) LIKE @term)
                                   AND up.AccountID != @aid
                                 LIMIT 50";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@term", "%" + term + "%");
                cmd.Parameters.AddWithValue("@aid", Session.AccountID);

                var results = new List<(int pid, string name, string uname, string gender, string uni, string dept)>();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string genderRaw = reader["Gender"].ToString();
                        string genderText = genderRaw == "1" ? "Male" : genderRaw == "2" ? "Female" : genderRaw;

                        results.Add((
                            Convert.ToInt32(reader["ProfileID"]),
                            reader["FirstName"] + " " + reader["LastName"],
                            "@" + reader["Username"],
                            genderText,
                            reader["CampusName"].ToString(),
                            reader["DepartmentName"].ToString()
                        ));
                    }
                }   

                bool found = results.Count > 0;
                foreach (var r in results)
                {
                    string checkQ = @"SELECT StatusID FROM connections
                                      WHERE (RequesterID=@mine AND ReceiverID=@them)
                                         OR (RequesterID=@them AND ReceiverID=@mine)
                                      LIMIT 1";
                    MySqlCommand chk = new MySqlCommand(checkQ, con);
                    chk.Parameters.AddWithValue("@mine", myProfileID);
                    chk.Parameters.AddWithValue("@them", r.pid);
                    object status = chk.ExecuteScalar();

                    Panel row = BuildRow(r.pid, myProfileID, r.name, r.uname, r.gender, r.uni, r.dept, status);
                    flowResults.Controls.Add(row);
                }

                con.Close();

                if (!found)
                {
                    Label lbl = new Label();
                    lbl.Text = "No users found matching \"" + term + "\".";
                    lbl.Font = new Font("Montserrat", 11F);
                    lbl.ForeColor = ThemeManager.Muted;
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(16);
                    flowResults.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel BuildRow(int pid, int myPID, string name, string uname,
                               string gender, string uni, string dept, object statusObj)
        {
            Panel row = new Panel();
            row.BackColor = ThemeManager.Panel;
            row.Width = flowResults.Width - 24;
            row.Height = 86;
            row.Margin = new Padding(0, 0, 0, 10);

            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Montserrat Medium", 11F, FontStyle.Bold);
            lblName.ForeColor = ThemeManager.Text;
            lblName.Location = new Point(18, 10);
            lblName.AutoSize = true;
            row.Controls.Add(lblName);

            Label lblUser = new Label();
            lblUser.Text = uname;
            lblUser.Font = new Font("Montserrat", 9F);
            lblUser.ForeColor = ThemeManager.Accent;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(lblName.Right + 10, 14);
            row.Controls.Add(lblUser);

            // Gender badge
            Label lblGender = new Label();
            lblGender.Text = gender;
            lblGender.Font = new Font("Montserrat", 8.5F);
            lblGender.ForeColor = ThemeManager.Text;
            lblGender.BackColor = ThemeManager.Card;
            lblGender.AutoSize = true;
            lblGender.Padding = new Padding(6, 2, 6, 2);
            lblGender.Location = new Point(lblUser.Right + 10, 12);
            row.Controls.Add(lblGender);

            Label lblInfo = new Label();
            lblInfo.Text = (uni != "" ? uni : "—") + "  ·  " + (dept != "" ? dept : "—");
            lblInfo.Font = new Font("Montserrat", 9F);
            lblInfo.ForeColor = ThemeManager.SubText;
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(18, 46);
            row.Controls.Add(lblInfo);

            Button btnConn = new Button();
            btnConn.FlatStyle = FlatStyle.Flat;
            btnConn.FlatAppearance.BorderSize = 0;
            btnConn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnConn.ForeColor = Color.White;
            btnConn.Size = new Size(180, 36);
            btnConn.Location = new Point(row.Width - 200, 24);
            row.Controls.Add(btnConn);

            if (statusObj == null)
            {
                btnConn.BackColor = ThemeManager.Accent;
                btnConn.Text = "Send Request";
                int capPid = pid; int capMyPid = myPID;
                btnConn.Click += (s, e) => SendRequest(capMyPid, capPid, btnConn);
            }
            else
            {
                int sid = Convert.ToInt32(statusObj);
                if (sid == 3) // pending
                {
                    btnConn.BackColor = Color.FromArgb(100, 100, 100);
                    btnConn.Text = "Request Sent";
                    btnConn.Enabled = false;
                }
                else // accepted
                {
                    btnConn.BackColor = ThemeManager.Accent;
                    btnConn.Text = "Connected";
                    btnConn.Enabled = false;
                }
            }

            return row;
        }

        private void SendRequest(int myPID, int targetPID, Button btn)
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string chkQ = @"SELECT COUNT(*) FROM connections
                                 WHERE (RequesterID=@mine AND ReceiverID=@them)
                                    OR (RequesterID=@them AND ReceiverID=@mine)";
                MySqlCommand chkCmd = new MySqlCommand(chkQ, con);
                chkCmd.Parameters.AddWithValue("@mine", myPID);
                chkCmd.Parameters.AddWithValue("@them", targetPID);
                if (Convert.ToInt32(chkCmd.ExecuteScalar()) > 0)
                {
                    con.Close();
                    MessageBox.Show("A connection already exists or is pending.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string insQ = "INSERT INTO connections (RequesterID, ReceiverID, StatusID, RequestedAt) VALUES (@mine, @them, 3, NOW())";
                MySqlCommand insCmd = new MySqlCommand(insQ, con);
                insCmd.Parameters.AddWithValue("@mine", myPID);
                insCmd.Parameters.AddWithValue("@them", targetPID);
                insCmd.ExecuteNonQuery();
                con.Close();

                btn.Text = "Request Sent";
                btn.BackColor = Color.FromArgb(100, 100, 100);
                btn.Enabled = false;
                MessageBox.Show("Connection request sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnNavProfile_Click(object sender, EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnNavSearch_Click(object sender, EventArgs e) { }
        private void btnNavConnections_Click(object sender, EventArgs e) { new Connections().Show(); this.Hide(); }
        private void btnNavUniversities_Click(object sender, EventArgs e) { new University().Show(); this.Hide(); }
        private void btnNavPosts_Click(object sender, EventArgs e) { new Posts().Show(); this.Hide(); }
        private void btnNavMessages_Click(object sender, EventArgs e) { new Messages().Show(); this.Hide(); }
        private void btnNavEvents_Click(object sender, EventArgs e) { new Events().Show(); this.Hide(); }
        private void btnLogout_Click(object sender, EventArgs e) { new Form1().Show(); this.Hide(); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flowResults != null && IsHandleCreated) ;
                //None();
        }

    }
}