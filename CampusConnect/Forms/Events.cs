using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Events : Form
    {
        public Events() {
            ApplyTheme(); InitializeComponent(); }
        private void Events_Load(object sender, EventArgs e) { LoadEvents(); }

        private void LoadEvents()
        {
            try
            {
                flowEvents.Controls.Clear();
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Load all events with their university name
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
                    // Load attendees for this event (UPDATED: Removed AttendeeRole)
                    string attQuery = @"SELECT up.FirstName, up.LastName
                                        FROM event_attendees ea
                                        INNER JOIN user_profiles up ON ea.ProfileID = up.ProfileID
                                        WHERE ea.EventID = @eventID";
                    MySqlCommand attCmd = new MySqlCommand(attQuery, con);
                    attCmd.Parameters.AddWithValue("@eventID", ev.id);
                    MySqlDataReader attReader = attCmd.ExecuteReader();

                    var attendees = new System.Collections.Generic.List<string>();

                    // UPDATED: Simply concatenate First Name and Last Name
                    while (attReader.Read())
                    {
                        attendees.Add(attReader["FirstName"].ToString() + " " + attReader["LastName"].ToString());
                    }
                    attReader.Close();

                    Panel card = BuildEventCard(ev.title, ev.desc, ev.date, ev.uni, attendees);
                    flowEvents.Controls.Add(card);
                }
                con.Close();

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Panel BuildEventCard(string title, string desc, DateTime date, string uni, System.Collections.Generic.List<string> attendees)
        {
            Panel card = new Panel();
            card.BackColor = Color.FromArgb(68, 72, 71);
            card.Width = flowEvents.Width - 24;
            card.Margin = new Padding(0, 0, 0, 16);

            // Title
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Montserrat", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 16);
            lblTitle.AutoSize = true;
            card.Controls.Add(lblTitle);

            // University + date row
            Label lblMeta = new Label();
            lblMeta.Text = uni + "  ·  " + date.ToString("dd MMM yyyy, HH:mm");
            lblMeta.Font = new Font("Montserrat", 9F);
            lblMeta.ForeColor = Color.FromArgb(52, 193, 164);
            lblMeta.AutoSize = true;
            lblMeta.Location = new Point(18, lblTitle.Bottom + 6);
            card.Controls.Add(lblMeta);

            // Description
            int nextY = lblMeta.Bottom + 10;
            if (desc != null && desc.Trim() != "")
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

            // Attendees section
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

        private void btnNavProfile_Click(object sender, System.EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnNavSearch_Click(object sender, System.EventArgs e) { new Search_Person().Show(); this.Hide(); }
        private void btnNavConnections_Click(object sender, System.EventArgs e) { new Connections().Show(); this.Hide(); }
        private void btnNavUniversities_Click(object sender, System.EventArgs e) { new University().Show(); this.Hide(); }
        private void btnNavPosts_Click(object sender, System.EventArgs e) { new Posts().Show(); this.Hide(); }
        private void btnNavMessages_Click(object sender, System.EventArgs e) { new Messages().Show(); this.Hide(); }
        private void btnNavEvents_Click(object sender, System.EventArgs e) { }
        private void btnLogout_Click(object sender, System.EventArgs e) { new Form1().Show(); this.Hide(); }
        private void ApplyTheme() { ThemeManager.Apply(this); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flowEvents != null && IsHandleCreated)
                LoadEvents();
        }

        private void flowEvents_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}