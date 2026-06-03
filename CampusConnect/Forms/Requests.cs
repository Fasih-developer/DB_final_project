using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Requests : Form
    {
        public Requests() {
            ApplyTheme(); InitializeComponent(); }
        private void Requests_Load(object sender, EventArgs e) { LoadRequests(); }

        private void LoadRequests()
        {
            try
            {
                flowRequests.Controls.Clear();

                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Get current user's ProfileID
                string myProfileQ = "SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID";
                MySqlCommand myCmd = new MySqlCommand(myProfileQ, con);
                myCmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                int myProfileID = Convert.ToInt32(myCmd.ExecuteScalar());

                // StatusID 3 = Pending (Active repurposed)
                string query = @"SELECT c.ConnectionID,
                                        up.FirstName, up.LastName, ua.Username,
                                        u.CampusName, d.DepartmentName,
                                        c.RequestedAt
                                 FROM connections c
                                 INNER JOIN user_profiles up ON c.RequesterID = up.ProfileID
                                 INNER JOIN user_accounts ua ON up.AccountID = ua.AccountID
                                 LEFT JOIN campus_enrollments ce ON up.ProfileID = ce.ProfileID
                                 LEFT JOIN universities u ON ce.UniversityID = u.UniversityID
                                 LEFT JOIN departments d ON ce.DepartmentID = d.DepartmentID
                                 WHERE c.ReceiverID = @myProfileID AND c.StatusID = 3
                                 ORDER BY c.RequestedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@myProfileID", myProfileID);
                MySqlDataReader reader = cmd.ExecuteReader();

                bool has = false;
                var rows = new System.Collections.Generic.List<(int connID, string name, string uname, string uni, string dept, string date)>();
                while (reader.Read())
                {
                    has = true;
                    rows.Add((
                        Convert.ToInt32(reader["ConnectionID"]),
                        reader["FirstName"] + " " + reader["LastName"],
                        "@" + reader["Username"],
                        reader["CampusName"].ToString(),
                        reader["DepartmentName"].ToString(),
                        Convert.ToDateTime(reader["RequestedAt"]).ToString("dd MMM yyyy")
                    ));
                }
                reader.Close();
                con.Close();

                foreach (var r in rows)
                    flowRequests.Controls.Add(BuildRequestRow(r.connID, r.name, r.uname, r.uni, r.dept, r.date));

                if (!has)
                {
                    Label lbl = new Label();
                    lbl.Text = "No pending connection requests.";
                    lbl.Font = new Font("Montserrat", 11F);
                    lbl.ForeColor = Color.FromArgb(120, 120, 120);
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(16);
                    flowRequests.Controls.Add(lbl);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private Panel BuildRequestRow(int connID, string name, string uname, string uni, string dept, string date)
        {
            Panel row = new Panel();
            row.BackColor = Color.FromArgb(68, 72, 71);
            row.Width = flowRequests.Width - 24;
            row.Height = 90;
            row.Margin = new Padding(0, 0, 0, 10);

            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Montserrat Medium", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(18, 12);
            lblName.AutoSize = true;
            row.Controls.Add(lblName);

            Label lblUser = new Label();
            lblUser.Text = uname;
            lblUser.Font = new Font("Montserrat", 9F);
            lblUser.ForeColor = Color.FromArgb(52, 193, 164);
            lblUser.AutoSize = true;
            lblUser.Location = new Point(lblName.Right + 10, 16);
            row.Controls.Add(lblUser);

            Label lblInfo = new Label();
            lblInfo.Text = (uni != "" ? uni : "—") + "  ·  " + (dept != "" ? dept : "—") + "  ·  Sent: " + date;
            lblInfo.Font = new Font("Montserrat", 9F);
            lblInfo.ForeColor = Color.FromArgb(160, 160, 160);
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(18, 46);
            row.Controls.Add(lblInfo);

            Button btnAccept = new Button();
            btnAccept.BackColor = Color.FromArgb(52, 193, 164);
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnAccept.ForeColor = Color.White;
            btnAccept.Text = "Accept";
            btnAccept.Size = new Size(110, 34);
            btnAccept.Location = new Point(row.Width - 250, 28);
            row.Controls.Add(btnAccept);

            Button btnReject = new Button();
            btnReject.BackColor = Color.Red;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Text = "Reject";
            btnReject.Size = new Size(110, 34);
            btnReject.Location = new Point(row.Width - 130, 28);
            row.Controls.Add(btnReject);

            int capConnID = connID;
            btnAccept.Click += (s, e) => RespondToRequest(capConnID, true, row);
            btnReject.Click += (s, e) => RespondToRequest(capConnID, false, row);

            return row;
        }

        private void RespondToRequest(int connID, bool accept, Panel row)
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                if (accept)
                {
                    // StatusID 4 = Inactive (repurposed as Accepted)
                    string updateQ = "UPDATE connections SET StatusID = 4 WHERE ConnectionID = @connID";
                    MySqlCommand cmd = new MySqlCommand(updateQ, con);
                    cmd.Parameters.AddWithValue("@connID", connID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string deleteQ = "DELETE FROM connections WHERE ConnectionID = @connID";
                    MySqlCommand cmd = new MySqlCommand(deleteQ, con);
                    cmd.Parameters.AddWithValue("@connID", connID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Request rejected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();

                // Remove the row from UI
                flowRequests.Controls.Remove(row);
                row.Dispose();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnExit_Click(object sender, EventArgs e) { new Connections().Show(); this.Hide(); }
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flowRequests != null && IsHandleCreated)
                LoadRequests();
        }

    }
}