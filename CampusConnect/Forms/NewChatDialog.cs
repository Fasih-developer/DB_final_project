using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    
    public partial class NewChatDialog : Form
    {
        public int    SelectedProfileID { get; private set; } = -1;
        public string SelectedName      { get; private set; } = "";

        // ── Private ──────────────────────────────────────────────────
        private readonly MessageService _service;
        private readonly int            _myProfileID;
        private List<UserModel>         _allUsers;

        public NewChatDialog(MessageService service, int myProfileID)
        {
            InitializeComponent();
            _service     = service;
            _myProfileID = myProfileID;
        }

        // ── Load ─────────────────────────────────────────────────────

        private void NewChatDialog_Load(object sender, EventArgs e)
        {
            LoadUsers("");
            txtSearchUsers.Focus();
        }

        // ── Data ─────────────────────────────────────────────────────

        private void LoadUsers(string query)
        {
            try
            {
                _allUsers = string.IsNullOrWhiteSpace(query)
                    ? _service.GetAllUsers(_myProfileID)
                    : _service.SearchAllUsers(_myProfileID, query);

                RenderUserList(_allUsers);
            }
            catch (Exception ex)
            {
                ShowError("Error loading users: " + ex.Message);
            }
        }

        private void RenderUserList(List<UserModel> users)
        {
            flowUsers.Controls.Clear();

            if (users.Count == 0)
            {
                var hint = new Label
                {
                    Text      = "No users found.",
                    Font      = new Font("Montserrat", 9.5F),
                    ForeColor = ThemeManager.SubText,
                    AutoSize  = false,
                    Size      = new Size(flowUsers.Width - 20, 36),
                    Padding   = new Padding(6, 8, 0, 0)
                };
                flowUsers.Controls.Add(hint);
                return;
            }

            foreach (var user in users)
                flowUsers.Controls.Add(BuildUserCard(user));
        }

        private Panel BuildUserCard(UserModel user)
        {
            var card = new Panel
            {
                Size      = new Size(flowUsers.Width - 8, 56),
                BackColor = ThemeManager.Panel,
                Margin    = new Padding(0, 0, 0, 2),
                Cursor    = Cursors.Hand,
                Tag       = user
            };

            var lblName = new Label
            {
                Text      = user.FullName,
                Font      = new Font("Montserrat Medium", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Location  = new Point(12, 8),
                AutoSize  = false,
                Size      = new Size(card.Width - 24, 20)
            };

            var lblUsername = new Label
            {
                Text      = "@" + user.Username,
                Font      = new Font("Montserrat", 8.5F),
                ForeColor = ThemeManager.SubText,
                Location  = new Point(12, 30),
                AutoSize  = false,
                Size      = new Size(card.Width - 24, 18)
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblUsername);

            EventHandler onClick = (s, e) => SelectUser(user);
            card.Click       += onClick;
            lblName.Click    += onClick;
            lblUsername.Click += onClick;

            // Hover highlight
            card.MouseEnter    += (s, e) => card.BackColor = ThemeManager.Card;
            card.MouseLeave    += (s, e) => card.BackColor = ThemeManager.Panel;
            lblName.MouseEnter += (s, e) => card.BackColor = ThemeManager.Card;
            lblName.MouseLeave += (s, e) => card.BackColor = ThemeManager.Panel;
            lblUsername.MouseEnter += (s, e) => card.BackColor = ThemeManager.Card;
            lblUsername.MouseLeave += (s, e) => card.BackColor = ThemeManager.Panel;

            return card;
        }

        private void SelectUser(UserModel user)
        {
            SelectedProfileID = user.ProfileID;
            SelectedName      = user.FullName;
            DialogResult      = DialogResult.OK;
            Close();
        }

        // ── Events ───────────────────────────────────────────────────

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(txtSearchUsers.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // ── Helpers ──────────────────────────────────────────────────

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
