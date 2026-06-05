using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Events : Form
    {
        private int _myProfileID = -1;

        public Events()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            _myProfileID = GetMyProfileID();
            LoadEvents();
        }

        private int GetMyProfileID()
        {
            try
            {
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT ProfileID FROM user_profiles WHERE AccountID = @aid", con);
                    cmd.Parameters.AddWithValue("@aid", Session.AccountID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch { return -1; }
        }

        private void LoadEvents()
        {
            try
            {
                flowEvents.Controls.Clear();

                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string evtQuery = @"SELECT e.EventID, e.EventTitle, e.Description, e.EventDate,
                                               u.CampusName
                                        FROM events e
                                        INNER JOIN universities u ON e.UniversityID = u.UniversityID
                                        ORDER BY e.EventDate DESC";

                    MySqlCommand evtCmd = new MySqlCommand(evtQuery, con);
                    MySqlDataReader evtReader = evtCmd.ExecuteReader();

                    var events = new System.Collections.Generic.List<(int id, string title, string desc, DateTime date, string uni)>();
                    while (evtReader.Read())
                        events.Add((
                            Convert.ToInt32(evtReader["EventID"]),
                            evtReader["EventTitle"].ToString(),
                            evtReader["Description"].ToString(),
                            Convert.ToDateTime(evtReader["EventDate"]),
                            evtReader["CampusName"].ToString()
                        ));
                    evtReader.Close();

                    foreach (var ev in events)
                    {
                        // Load attendees for this event
                        string attQuery = @"SELECT up.FirstName, up.LastName
                                            FROM event_attendees ea
                                            INNER JOIN user_profiles up ON ea.ProfileID = up.ProfileID
                                            WHERE ea.EventID = @eventID";
                        MySqlCommand attCmd = new MySqlCommand(attQuery, con);
                        attCmd.Parameters.AddWithValue("@eventID", ev.id);
                        MySqlDataReader attReader = attCmd.ExecuteReader();

                        var attendees = new System.Collections.Generic.List<string>();
                        while (attReader.Read())
                            attendees.Add(attReader["FirstName"] + " " + attReader["LastName"]);
                        attReader.Close();

                        // Check if current user has already attended
                        bool alreadyAttended = false;
                        if (_myProfileID > 0)
                        {
                            string checkQuery = "SELECT COUNT(*) FROM event_attendees WHERE EventID = @eid AND ProfileID = @pid";
                            MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@eid", ev.id);
                            checkCmd.Parameters.AddWithValue("@pid", _myProfileID);
                            alreadyAttended = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                        }

                        Panel card = BuildEventCard(ev.id, ev.title, ev.desc, ev.date, ev.uni, attendees, alreadyAttended);
                        flowEvents.Controls.Add(card);
                    }

                    if (events.Count == 0)
                    {
                        Label lbl = new Label();
                        lbl.Text = "No events available at the moment.";
                        lbl.Font = new Font("Montserrat", 11F);
                        lbl.ForeColor = Color.FromArgb(120, 120, 120);
                        lbl.AutoSize = true;
                        lbl.Margin = new Padding(20);
                        flowEvents.Controls.Add(lbl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel BuildEventCard(int eventID, string title, string desc, DateTime date, string uni,
                                     System.Collections.Generic.List<string> attendees, bool alreadyAttended)
        {
            Panel card = new Panel();
            card.BackColor = Color.FromArgb(68, 72, 71);
            card.Width = flowEvents.Width - 24;
            card.Margin = new Padding(0, 0, 0, 16);

            // "Mark as Attended" button — top-right corner
            Button btnAttend = new Button();
            btnAttend.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            btnAttend.FlatStyle = FlatStyle.Flat;
            btnAttend.FlatAppearance.BorderSize = 0;
            btnAttend.Size = new Size(148, 32);
            btnAttend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAttend.Cursor = Cursors.Hand;

            if (alreadyAttended)
            {
                btnAttend.Text = "Attended ✓";
                btnAttend.BackColor = Color.FromArgb(80, 80, 80);
                btnAttend.ForeColor = Color.FromArgb(160, 160, 160);
                btnAttend.Enabled = false;
            }
            else
            {
                btnAttend.Text = "Mark as Attended";
                btnAttend.BackColor = Color.FromArgb(52, 193, 164);
                btnAttend.ForeColor = Color.White;

                int capturedEventID = eventID;
                btnAttend.Click += (s, e) => MarkAsAttended(capturedEventID, btnAttend);
            }

            card.Controls.Add(btnAttend);

            // Title — leaves room for button on the right
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Montserrat", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 16);
            lblTitle.AutoSize = true;
            lblTitle.MaximumSize = new Size(card.Width - 190, 0);
            card.Controls.Add(lblTitle);

            // University + date row
            Label lblMeta = new Label();
            lblMeta.Text = uni + "  ·  " + date.ToString("dd MMM yyyy, HH:mm");
            lblMeta.Font = new Font("Montserrat", 9F);
            lblMeta.ForeColor = Color.FromArgb(52, 193, 164);
            lblMeta.AutoSize = true;
            lblMeta.Location = new Point(18, lblTitle.Bottom + 6);
            card.Controls.Add(lblMeta);

            // Position the attend button vertically centered with title row
            btnAttend.Location = new Point(card.Width - btnAttend.Width - 18, 16 + (lblTitle.Height / 2) - (btnAttend.Height / 2));

            // Description
            int nextY = lblMeta.Bottom + 10;
            if (!string.IsNullOrWhiteSpace(desc))
            {
                Label lblDesc = new Label();
                lblDesc.Text = desc;
                lblDesc.Font = new Font("Montserrat", 10F);
                lblDesc.ForeColor = Color.FromArgb(210, 210, 210);
                lblDesc.MaximumSize = new Size(card.Width - 40, 0);
                lblDesc.AutoSize = true;
                lblDesc.Location = new Point(18, nextY);
                card.Controls.Add(lblDesc);
                nextY = lblDesc.Bottom + 12;
            }

            // Attendees heading
            Label lblAttHead = new Label();
            lblAttHead.Text = "Attendees:";
            lblAttHead.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            lblAttHead.ForeColor = Color.FromArgb(180, 180, 180);
            lblAttHead.AutoSize = true;
            lblAttHead.Location = new Point(18, nextY);
            card.Controls.Add(lblAttHead);
            nextY = lblAttHead.Bottom + 6;

            if (attendees.Count == 0)
            {
                Label lblNoAtt = new Label();
                lblNoAtt.Text = "No one has attended this event through this application.";
                lblNoAtt.Font = new Font("Montserrat", 9F);
                lblNoAtt.ForeColor = Color.FromArgb(120, 120, 120);
                lblNoAtt.AutoSize = true;
                lblNoAtt.Location = new Point(18, nextY);
                card.Controls.Add(lblNoAtt);
                nextY = lblNoAtt.Bottom;
            }
            else
            {
                foreach (string att in attendees)
                {
                    Label lblAtt = new Label();
                    lblAtt.Text = "• " + att;
                    lblAtt.Font = new Font("Montserrat", 9.5F);
                    lblAtt.ForeColor = Color.White;
                    lblAtt.AutoSize = true;
                    lblAtt.Location = new Point(26, nextY);
                    card.Controls.Add(lblAtt);
                    nextY = lblAtt.Bottom + 2;
                }
            }

            card.Height = nextY + 18;
            return card;
        }

        private void MarkAsAttended(int eventID, Button btn)
        {
            if (_myProfileID < 0)
            {
                MessageBox.Show("Could not identify your profile. Please log in again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    // Guard against duplicates (race condition or direct click spam)
                    string checkSql = "SELECT COUNT(*) FROM event_attendees WHERE EventID = @eid AND ProfileID = @pid";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@eid", eventID);
                    checkCmd.Parameters.AddWithValue("@pid", _myProfileID);
                    int existing = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existing > 0)
                    {
                        // Already exists — just update the button state silently
                        SetButtonAttended(btn);
                        return;
                    }

                    string insertSql = "INSERT INTO event_attendees (EventID, ProfileID) VALUES (@eid, @pid)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, con);
                    insertCmd.Parameters.AddWithValue("@eid", eventID);
                    insertCmd.Parameters.AddWithValue("@pid", _myProfileID);
                    insertCmd.ExecuteNonQuery();
                }

                SetButtonAttended(btn);

                // Reload so the attendee name appears in the list immediately
                LoadEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking attendance: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetButtonAttended(Button btn)
        {
            btn.Text = "Attended ✓";
            btn.BackColor = Color.FromArgb(80, 80, 80);
            btn.ForeColor = Color.FromArgb(160, 160, 160);
            btn.Enabled = false;
        }

        // ── Nav ──────────────────────────────────────────────────────
        private void btnNavProfile_Click(object sender, EventArgs e)      { new Profile().Show(); this.Hide(); }
        private void btnNavSearch_Click(object sender, EventArgs e)       { new Search_Person().Show(); this.Hide(); }
        private void btnNavConnections_Click(object sender, EventArgs e)  { new Connections().Show(); this.Hide(); }
        private void btnNavUniversities_Click(object sender, EventArgs e) { new University().Show(); this.Hide(); }
        private void btnNavPosts_Click(object sender, EventArgs e)        { new Posts().Show(); this.Hide(); }
        private void btnNavMessages_Click(object sender, EventArgs e)     { new Messages().Show(); this.Hide(); }
        private void btnNavEvents_Click(object sender, EventArgs e)       { }
        private void btnLogout_Click(object sender, EventArgs e)          { new Form1().Show(); this.Hide(); }

        private void ApplyTheme() { ThemeManager.Apply(this); }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flowEvents != null && IsHandleCreated)
                LoadEvents();
        }

        private void flowEvents_Paint(object sender, PaintEventArgs e) { }
    }
}
