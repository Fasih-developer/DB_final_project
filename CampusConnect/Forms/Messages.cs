using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Messages : Form
    {
        private int _myProfileID   = -1;
        private int _activeChatPID = -1;
        private string _activeChatName = "";

        // ── Constructor ──────────────────────────────────────────────
        public Messages()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme() { ThemeManager.Apply(this); }

        // ── Load ─────────────────────────────────────────────────────
        private void Messages_Load(object sender, EventArgs e)
        {
            _myProfileID = GetMyProfileID();
            LoadConversations();
        }

        private int GetMyProfileID()
        {
            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    var cmd = new MySqlCommand(
                        "SELECT ProfileID FROM user_profiles WHERE AccountID = @aid", con);
                    cmd.Parameters.AddWithValue("@aid", Session.AccountID);
                    var r = cmd.ExecuteScalar();
                    return r != null ? Convert.ToInt32(r) : -1;
                }
            }
            catch { return -1; }
        }

        // ── Conversation list ────────────────────────────────────────
        private void LoadConversations()
        {
            flowConversations.Controls.Clear();
            lblConvHeader.Text = "Conversations";

            if (_myProfileID < 0) return;

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string sql = @"
                        SELECT
                            other.ProfileID,
                            CONCAT(up.FirstName,' ',up.LastName) AS FullName,
                            (SELECT m2.Content FROM messages m2
                             WHERE (m2.SenderID=@me AND m2.ReceiverID=other.ProfileID)
                                OR (m2.SenderID=other.ProfileID AND m2.ReceiverID=@me)
                             ORDER BY m2.SentAt DESC LIMIT 1) AS LastMsg,
                            (SELECT m3.SentAt FROM messages m3
                             WHERE (m3.SenderID=@me AND m3.ReceiverID=other.ProfileID)
                                OR (m3.SenderID=other.ProfileID AND m3.ReceiverID=@me)
                             ORDER BY m3.SentAt DESC LIMIT 1) AS LastAt
                        FROM (
                            SELECT SenderID AS ProfileID FROM messages WHERE ReceiverID=@me
                            UNION
                            SELECT ReceiverID AS ProfileID FROM messages WHERE SenderID=@me
                        ) AS other
                        INNER JOIN user_profiles up ON up.ProfileID=other.ProfileID
                        ORDER BY LastAt DESC";

                    var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@me", _myProfileID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pid    = Convert.ToInt32(reader["ProfileID"]);
                            string nm  = reader["FullName"].ToString();
                            string lm  = reader["LastMsg"] != DBNull.Value ? reader["LastMsg"].ToString() : "";
                            AddConvCard(pid, nm, lm);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading conversations: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (flowConversations.Controls.Count == 0)
            {
                var lbl = new Label();
                lbl.Text = "No conversations yet.\nSearch for someone to start chatting.";
                lbl.Font = new Font("Montserrat", 9.5F);
                lbl.ForeColor = Color.FromArgb(120, 120, 120);
                lbl.AutoSize = false;
                lbl.Size = new Size(305, 60);
                lbl.Padding = new Padding(8, 10, 0, 0);
                flowConversations.Controls.Add(lbl);
            }
        }

        private void AddConvCard(int profileID, string name, string lastMsg)
        {
            var panel = new Panel();
            panel.BackColor = profileID == _activeChatPID
                ? Color.FromArgb(52, 193, 164)
                : Color.FromArgb(68, 72, 71);
            panel.Size    = new Size(308, 62);
            panel.Margin  = new Padding(0, 0, 0, 3);
            panel.Cursor  = Cursors.Hand;
            panel.Tag     = profileID;

            var lblName = new Label();
            lblName.Text     = name;
            lblName.Font     = new Font("Montserrat Medium", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(10, 8);
            lblName.AutoSize = false;
            lblName.Size     = new Size(288, 22);
            panel.Controls.Add(lblName);

            var lblLast = new Label();
            string preview = lastMsg.Length > 50 ? lastMsg.Substring(0, 47) + "..." : lastMsg;
            lblLast.Text      = preview;
            lblLast.Font      = new Font("Montserrat", 8.5F);
            lblLast.ForeColor = Color.FromArgb(200, 200, 200);
            lblLast.Location  = new Point(10, 32);
            lblLast.AutoSize  = false;
            lblLast.Size      = new Size(288, 22);
            panel.Controls.Add(lblLast);

            EventHandler clickHandler = (s, ev) => LoadChat(profileID, name);
            panel.Click   += clickHandler;
            lblName.Click += clickHandler;
            lblLast.Click += clickHandler;

            flowConversations.Controls.Add(panel);
        }

        // ── Chat view ────────────────────────────────────────────────
        private void LoadChat(int otherPID, string otherName)
        {
            _activeChatPID  = otherPID;
            _activeChatName = otherName;
            lblChatHeader.Text = "  " + otherName;
            flowChat.Controls.Clear();

            if (_myProfileID < 0) return;

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string sql = @"
                        SELECT SenderID, Content, SentAt
                        FROM messages
                        WHERE (SenderID=@me AND ReceiverID=@other)
                           OR (SenderID=@other AND ReceiverID=@me)
                        ORDER BY SentAt ASC";

                    var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@me", _myProfileID);
                    cmd.Parameters.AddWithValue("@other", otherPID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool isMine = Convert.ToInt32(reader["SenderID"]) == _myProfileID;
                            string content = reader["Content"].ToString();
                            string ts      = Convert.ToDateTime(reader["SentAt"]).ToString("dd MMM  HH:mm");
                            flowChat.Controls.Add(BuildBubble(content, ts, isMine));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chat: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Scroll to bottom
            if (flowChat.Controls.Count > 0)
                flowChat.ScrollControlIntoView(flowChat.Controls[flowChat.Controls.Count - 1]);

            // Highlight the active conversation card
            LoadConversations();
        }

        private Panel BuildBubble(string content, string ts, bool isMine)
        {
            int chatW = flowChat.Width - flowChat.Padding.Horizontal - 4;
            int maxBubbleW = (int)(chatW * 0.65);

            var bubble = new Panel();
            bubble.BackColor = isMine
                ? Color.FromArgb(52, 193, 164)
                : Color.FromArgb(68, 72, 71);
            bubble.Padding = new Padding(10, 6, 10, 6);

            var lblText = new Label();
            lblText.Text = content;
            lblText.Font = new Font("Montserrat", 10F);
            lblText.ForeColor = Color.White;
            lblText.MaximumSize = new Size(maxBubbleW - 20, 0);
            lblText.AutoSize = true;
            lblText.Location = new Point(10, 6);
            bubble.Controls.Add(lblText);

            var lblTime = new Label();
            lblTime.Text = ts;
            lblTime.Font = new Font("Montserrat", 7.5F);
            lblTime.ForeColor = Color.FromArgb(210, 210, 210);
            lblTime.AutoSize = true;
            lblTime.Location = new Point(10, lblText.Bottom + 3);
            bubble.Controls.Add(lblTime);

            int bW = Math.Max(lblText.Width + 20, lblTime.Width + 20);
            int bH = lblTime.Bottom + 8;
            bubble.Size = new Size(bW, bH);

            // Wrapper to align bubble left or right
            var wrapper = new Panel();
            wrapper.BackColor = Color.Transparent;
            wrapper.Size = new Size(chatW, bH + 6);
            wrapper.Margin = new Padding(0, 2, 0, 2);

            bubble.Location = isMine
                ? new Point(chatW - bW - 2, 3)
                : new Point(2, 3);

            wrapper.Controls.Add(bubble);
            return wrapper;
        }

        // ── Send ─────────────────────────────────────────────────────
        private void SendMessage()
        {
            string msg = txtNewMessage.Text.Trim();
            if (msg.Length == 0) return;

            if (_activeChatPID < 0)
            {
                MessageBox.Show("Select a conversation first.", "No chat open",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string sql = "INSERT INTO messages (SenderID, ReceiverID, Content) VALUES (@s, @r, @c)";
                    var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@s", _myProfileID);
                    cmd.Parameters.AddWithValue("@r", _activeChatPID);
                    cmd.Parameters.AddWithValue("@c", msg);
                    cmd.ExecuteNonQuery();
                }
                txtNewMessage.Text = "";
                LoadChat(_activeChatPID, _activeChatName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e) { SendMessage(); }

        private void txtNewMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }

        // ── Search ───────────────────────────────────────────────────
        private void SearchUsers(string query)
        {
            flowConversations.Controls.Clear();
            lblConvHeader.Text = "Search Results";

            if (query.Trim().Length == 0)
            {
                LoadConversations();
                return;
            }

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string sql = @"
                        SELECT up.ProfileID, CONCAT(up.FirstName,' ',up.LastName) AS FullName
                        FROM user_profiles up
                        INNER JOIN user_accounts ua ON ua.AccountID = up.AccountID
                        WHERE (up.FirstName LIKE @q OR up.LastName LIKE @q
                               OR CONCAT(up.FirstName,' ',up.LastName) LIKE @q
                               OR ua.Username LIKE @q)
                          AND up.ProfileID <> @me
                        LIMIT 40";

                    var cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@q", "%" + query.Trim() + "%");
                    cmd.Parameters.AddWithValue("@me", _myProfileID);

                    bool found = false;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            found = true;
                            int pid   = Convert.ToInt32(reader["ProfileID"]);
                            string nm = reader["FullName"].ToString();
                            AddConvCard(pid, nm, "Tap to start a conversation");
                        }
                    }

                    if (!found)
                    {
                        var lbl = new Label();
                        lbl.Text      = "No users found.";
                        lbl.Font      = new Font("Montserrat", 9.5F);
                        lbl.ForeColor = Color.FromArgb(120, 120, 120);
                        lbl.AutoSize  = true;
                        lbl.Padding   = new Padding(10, 10, 0, 0);
                        flowConversations.Controls.Add(lbl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMsg_Click(object sender, EventArgs e)
        {
            string q = txtMsgSearch.Text.Trim();
            if (q.Length == 0)
                LoadConversations();
            else
                SearchUsers(q);
        }

        private void txtMsgSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearchMsg_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtMsgSearch.Text = "";
                LoadConversations();
            }
        }

        // ── Nav ──────────────────────────────────────────────────────
        private void btnNavProfile_Click(object sender, EventArgs e)      { new Profile().Show(); this.Hide(); }
        private void btnNavSearch_Click(object sender, EventArgs e)       { new Search_Person().Show(); this.Hide(); }
        private void btnNavConnections_Click(object sender, EventArgs e)  { new Connections().Show(); this.Hide(); }
        private void btnNavUniversities_Click(object sender, EventArgs e) { new University().Show(); this.Hide(); }
        private void btnNavPosts_Click(object sender, EventArgs e)        { new Posts().Show(); this.Hide(); }
        private void btnNavMessages_Click(object sender, EventArgs e)     { }
        private void btnNavEvents_Click(object sender, EventArgs e)       { new Events().Show(); this.Hide(); }
        private void btnLogout_Click(object sender, EventArgs e)          { new Form1().Show(); this.Hide(); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (tableMain == null || !IsHandleCreated) return;
            int navW = panelNav.Width;
            tableMain.Left   = navW + 20;
            tableMain.Top    = 75;
            tableMain.Width  = this.ClientSize.Width - navW - 20;
            tableMain.Height = this.ClientSize.Height - 75 - 10;
        }

    }
}