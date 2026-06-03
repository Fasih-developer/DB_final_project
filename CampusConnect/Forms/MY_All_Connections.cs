using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class MY_All_Connections : Form
    {
        public MY_All_Connections() {
            ApplyTheme(); InitializeComponent(); }
        private void MY_All_Connections_Load(object sender, EventArgs e) { LoadConnections(); }

        private void LoadConnections()
        {
            try
            {
                flowConns.Controls.Clear();

                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string myProfileQ = "SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID";
                MySqlCommand myCmd = new MySqlCommand(myProfileQ, con);
                myCmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                int myProfileID = Convert.ToInt32(myCmd.ExecuteScalar());

                // StatusID 4 = Accepted — get the OTHER person in the connection
                string query = @"SELECT up.FirstName, up.LastName, ua.Username,
                                        u.CampusName, d.DepartmentName,
                                        c.RequestedAt
                                 FROM connections c
                                 INNER JOIN user_profiles up ON
                                     (CASE WHEN c.RequesterID = @myProfileID THEN c.ReceiverID ELSE c.RequesterID END) = up.ProfileID
                                 INNER JOIN user_accounts ua ON up.AccountID = ua.AccountID
                                 LEFT JOIN campus_enrollments ce ON up.ProfileID = ce.ProfileID
                                 LEFT JOIN universities u ON ce.UniversityID = u.UniversityID
                                 LEFT JOIN departments d ON ce.DepartmentID = d.DepartmentID
                                 WHERE (c.RequesterID = @myProfileID OR c.ReceiverID = @myProfileID)
                                   AND c.StatusID = 4
                                 ORDER BY c.RequestedAt DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@myProfileID", myProfileID);
                MySqlDataReader reader = cmd.ExecuteReader();

                bool has = false;
                while (reader.Read())
                {
                    has = true;
                    Panel card = BuildConnectionCard(
                        reader["FirstName"] + " " + reader["LastName"],
                        "@" + reader["Username"],
                        reader["CampusName"].ToString(),
                        reader["DepartmentName"].ToString()
                    );
                    flowConns.Controls.Add(card);
                }
                reader.Close();
                con.Close();

                if (!has)
                {
                    Label lbl = new Label();
                    lbl.Text = "You have no connections yet.";
                    lbl.Font = new Font("Montserrat", 11F);
                    lbl.ForeColor = Color.FromArgb(120, 120, 120);
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(16);
                    flowConns.Controls.Add(lbl);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private Panel BuildConnectionCard(string name, string uname, string uni, string dept)
        {
            Panel card = new Panel();
            card.BackColor = Color.FromArgb(68, 72, 71);
            card.Width = flowConns.Width - 24;
            card.Height = 80;
            card.Margin = new Padding(0, 0, 0, 10);

            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Montserrat Medium", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(18, 12);
            lblName.AutoSize = true;
            card.Controls.Add(lblName);

            Label lblUser = new Label();
            lblUser.Text = uname;
            lblUser.Font = new Font("Montserrat", 9F);
            lblUser.ForeColor = Color.FromArgb(52, 193, 164);
            lblUser.AutoSize = true;
            lblUser.Location = new Point(lblName.Right + 10, 16);
            card.Controls.Add(lblUser);

            Label lblInfo = new Label();
            lblInfo.Text = (uni != "" ? uni : "—") + "  ·  " + (dept != "" ? dept : "—");
            lblInfo.Font = new Font("Montserrat", 9F);
            lblInfo.ForeColor = Color.FromArgb(160, 160, 160);
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(18, 46);
            card.Controls.Add(lblInfo);

            return card;
        }

        private void btnExit_Click(object sender, EventArgs e) { new Connections().Show(); this.Hide(); }
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flowConns != null && IsHandleCreated)
                LoadConnections();
        }

    }
}