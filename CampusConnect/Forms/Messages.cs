using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
  
    public partial class Messages : Form
    {
        // ── Dependencies ─────────────────────────────────────────────
        private readonly MessageService _service = new MessageService();

        private int    _myProfileID  = -1;
        private int    _activePID    = -1;
        private string _activeName   = "";

        public Messages()
        {
            InitializeComponent();
        }


        private void Messages_Load(object sender, EventArgs e)
        {
            try
            {
                _myProfileID = _service.GetMyProfileID(Session.AccountID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Session Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HighlightNavButton(btnNavMessages);
            LoadConversationList();
        }


        private void HighlightNavButton(Button active)
        {
            Button[] all = {
                btnNavProfile, btnNavSearch, btnNavConnections,
                btnNavUniversities, btnNavPosts, btnNavMessages, btnNavEvents
            };
            foreach (var b in all)
                b.BackColor = ThemeManager.NavBtn;
            active.BackColor = ThemeManager.NavActive;
        }


        private void LoadConversationList()
        {
            string searchText = txtSearch.Text;
            RenderConversations(
                string.IsNullOrWhiteSpace(searchText)
                    ? _service.GetConversations(_myProfileID)
                    : _service.SearchConversations(_myProfileID, searchText)
            );
        }

        private void RenderConversations(List<ConversationModel> convs)
        {
            flowConversations.Controls.Clear();

            if (convs.Count == 0)
            {
                var hint = new Label
                {
                    Text      = string.IsNullOrWhiteSpace(txtSearch.Text)
                                ? "No conversations yet.\nClick \"+ New Chat\" to start one."
                                : "No conversations match your search.",
                    Font      = new Font("Montserrat", 9.5F),
                    ForeColor = ThemeManager.SubText,
                    AutoSize  = false,
                    Size      = new Size(flowConversations.Width - 12, 60),
                    Padding   = new Padding(8, 10, 0, 0)
                };
                flowConversations.Controls.Add(hint);
                return;
            }

            foreach (var c in convs)
                flowConversations.Controls.Add(BuildConvCard(c));
        }

        private Panel BuildConvCard(ConversationModel conv)
        {
            bool isActive = conv.OtherProfileID == _activePID;

            var card = new Panel
            {
                Size      = new Size(flowConversations.Width - 8, 72),
                BackColor = isActive ? ThemeManager.Accent : ThemeManager.Panel,
                Margin    = new Padding(0, 0, 0, 2),
                Cursor    = Cursors.Hand,
                Tag       = conv
            };

            var lblName = new Label
            {
                Text      = conv.OtherName,
                Font      = new Font("Montserrat Medium", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Location  = new Point(10, 8),
                AutoSize  = false,
                Size      = new Size(card.Width - 80, 20)
            };

            string preview = conv.LastMessagePreview.Length > 50
                ? conv.LastMessagePreview.Substring(0, 47) + "..."
                : conv.LastMessagePreview;

            var lblPreview = new Label
            {
                Text      = preview,
                Font      = new Font("Montserrat", 8.5F),
                ForeColor = isActive ? Color.White : ThemeManager.SubText,
                Location  = new Point(10, 32),
                AutoSize  = false,
                Size      = new Size(card.Width - 20, 20)
            };

            var lblTime = new Label
            {
                Text      = conv.LastMessageTimeDisplay,
                Font      = new Font("Montserrat", 7.5F),
                ForeColor = isActive ? Color.White : ThemeManager.Muted,
                Location  = new Point(card.Width - 72, 8),
                AutoSize  = false,
                Size      = new Size(66, 18),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblPreview);
            card.Controls.Add(lblTime);

            EventHandler onClick = (s, ev) => OpenChat(conv.OtherProfileID, conv.OtherName);
            card.Click       += onClick;
            lblName.Click    += onClick;
            lblPreview.Click += onClick;
            lblTime.Click    += onClick;

            return card;
        }


        private void btnNewChat_Click(object sender, EventArgs e)
        {
            if (_myProfileID < 0) return;

            using (var dlg = new NewChatDialog(_service, _myProfileID))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    OpenChat(dlg.SelectedProfileID, dlg.SelectedName);
            }
        }

        private void OpenChat(int otherPID, string otherName)
        {
            _activePID  = otherPID;
            _activeName = otherName;

            lblChatWith.Text = otherName;
            flowChat.Controls.Clear();

            if (_myProfileID < 0) return;

            try
            {
                var messages = _service.GetMessages(_myProfileID, otherPID);
                foreach (var msg in messages)
                    flowChat.Controls.Add(BuildBubble(msg));
            }
            catch (Exception ex)
            {
                ShowError("Error loading messages: " + ex.Message);
                return;
            }

            ScrollChatToBottom();
            LoadConversationList();
        }

        private Panel BuildBubble(MessageModel msg)
        {
            bool isMine = msg.IsMine(_myProfileID);
            int  chatW  = Math.Max(flowChat.ClientSize.Width - flowChat.Padding.Horizontal, 200);
            int  maxBubW = (int)(chatW * 0.65);

            var bubble = new Panel
            {
                BackColor = isMine ? ThemeManager.Accent : ThemeManager.Panel,
                Padding   = new Padding(10, 6, 10, 6),
                Tag       = msg
            };

            var lblText = new Label
            {
                Text        = msg.Content,
                Font        = new Font("Montserrat", 10F),
                ForeColor   = Color.White,
                MaximumSize = new Size(maxBubW - 20, 0),
                AutoSize    = true,
                Location    = new Point(10, 6)
            };
            bubble.Controls.Add(lblText);

            var lblTime = new Label
            {
                Text      = msg.SentAt.ToString("dd MMM  HH:mm"),
                Font      = new Font("Montserrat", 7.5F),
                ForeColor = Color.FromArgb(210, 210, 210),
                AutoSize  = true,
                Location  = new Point(10, lblText.Bottom + 3)
            };
            bubble.Controls.Add(lblTime);

            int bW = Math.Max(lblText.PreferredWidth + 20, lblTime.PreferredWidth + 20);
            bW = Math.Min(bW, maxBubW);
            int bH = lblTime.Bottom + 8;
            bubble.Size = new Size(bW, bH);

            // Delete button — own messages only
            if (isMine)
            {
                var lblDel = new Label
                {
                    Text      = "✕",
                    Font      = new Font("Montserrat", 7F),
                    ForeColor = Color.FromArgb(200, 200, 200),
                    AutoSize  = true,
                    Location  = new Point(bW - 18, 4),
                    Cursor    = Cursors.Hand,
                    Tag       = msg
                };
                lblDel.Click      += LblDel_Click;
                lblDel.MouseEnter += (s, ev) => lblDel.ForeColor = Color.White;
                lblDel.MouseLeave += (s, ev) => lblDel.ForeColor = Color.FromArgb(200, 200, 200);
                bubble.Controls.Add(lblDel);
                bubble.Controls.SetChildIndex(lblDel, 0);
            }

            // Full-width wrapper to push bubble left or right
            var wrapper = new Panel
            {
                BackColor = Color.Transparent,
                Margin    = new Padding(0, 2, 0, 2),
                Size      = new Size(chatW, bH + 4)
            };

            bubble.Location = isMine
                ? new Point(chatW - bW - 4, 2)
                : new Point(4, 2);

            wrapper.Controls.Add(bubble);
            return wrapper;
        }

        private void LblDel_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            var msg = (MessageModel)lbl.Tag;

            if (MessageBox.Show(
                    "Delete this message?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                _service.DeleteMessage(msg.MessageID, _myProfileID);
                OpenChat(_activePID, _activeName);
            }
            catch (UnauthorizedAccessException ex)
            {
                ShowError(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError("Error deleting message: " + ex.Message);
            }
        }

        private void ScrollChatToBottom()
        {
            if (flowChat.Controls.Count > 0)
                flowChat.ScrollControlIntoView(
                    flowChat.Controls[flowChat.Controls.Count - 1]);
        }


        private void SendMessage()
        {
            string text = txtMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(text)) return;

            if (_activePID < 0)
            {
                MessageBox.Show(
                    "Please select a conversation or start a new chat first.",
                    "No Conversation Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _service.SendMessage(_myProfileID, _activePID, text);
                txtMessage.Clear();
                OpenChat(_activePID, _activeName);
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError("Error sending message: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e) => SendMessage();

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }


        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnNavProfile_Click(object sender, EventArgs e)      { new Profile().Show();       Hide(); }
        private void btnNavSearch_Click(object sender, EventArgs e)       { new Search_Person().Show(); Hide(); }
        private void btnNavConnections_Click(object sender, EventArgs e)  { new Connections().Show();   Hide(); }
        private void btnNavUniversities_Click(object sender, EventArgs e) { new University().Show();    Hide(); }
        private void btnNavPosts_Click(object sender, EventArgs e)        { new Posts().Show();         Hide(); }
        private void btnNavMessages_Click(object sender, EventArgs e)     { /* already here */ }
        private void btnNavEvents_Click(object sender, EventArgs e)       { new Events().Show();        Hide(); }
        private void btnLogout_Click(object sender, EventArgs e)          { new Form1().Show();         Hide(); }

        private void flowConversations_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
