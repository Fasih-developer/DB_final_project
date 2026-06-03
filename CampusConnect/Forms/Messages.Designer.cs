namespace CampusConnect.Forms
{
    partial class Messages
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelNav           = new System.Windows.Forms.Panel();
            this.lblNavTitle        = new System.Windows.Forms.Label();
            this.btnNavProfile      = new System.Windows.Forms.Button();
            this.btnNavSearch       = new System.Windows.Forms.Button();
            this.btnNavConnections  = new System.Windows.Forms.Button();
            this.btnNavUniversities = new System.Windows.Forms.Button();
            this.btnNavPosts        = new System.Windows.Forms.Button();
            this.btnNavMessages     = new System.Windows.Forms.Button();
            this.btnNavEvents       = new System.Windows.Forms.Button();
            this.btnLogout          = new System.Windows.Forms.Button();
            this.lblPageTitle       = new System.Windows.Forms.Label();
            this.tableMain          = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft          = new System.Windows.Forms.Panel();
            this.lblConvHeader      = new System.Windows.Forms.Label();
            this.panelSearchBar     = new System.Windows.Forms.Panel();
            this.txtMsgSearch       = new System.Windows.Forms.TextBox();
            this.btnSearchMsg       = new System.Windows.Forms.Button();
            this.flowConversations  = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRight         = new System.Windows.Forms.Panel();
            this.lblChatHeader      = new System.Windows.Forms.Label();
            this.flowChat           = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSendArea      = new System.Windows.Forms.Panel();
            this.txtNewMessage      = new System.Windows.Forms.TextBox();
            this.btnSend            = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelSearchBar.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelSendArea.SuspendLayout();
            this.SuspendLayout();

            // ── panelNav ───────────────────────────────────────────────
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelNav.Controls.Add(this.lblNavTitle);
            this.panelNav.Controls.Add(this.btnNavProfile);
            this.panelNav.Controls.Add(this.btnNavSearch);
            this.panelNav.Controls.Add(this.btnNavConnections);
            this.panelNav.Controls.Add(this.btnNavUniversities);
            this.panelNav.Controls.Add(this.btnNavPosts);
            this.panelNav.Controls.Add(this.btnNavMessages);
            this.panelNav.Controls.Add(this.btnNavEvents);
            this.panelNav.Controls.Add(this.btnLogout);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(293, 807);
            this.panelNav.TabIndex = 0;

            this.lblNavTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.lblNavTitle.Location = new System.Drawing.Point(21, 25);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(253, 37);
            this.lblNavTitle.Text = "CampusConnect";

            int[] navY = { 86, 145, 204, 263, 322, 381, 440 };
            string[] navTxt = { "Profile", "Search", "Connections", "Universities", "Posts", "Messages", "Events" };
            System.Windows.Forms.Button[] navBtns = {
                this.btnNavProfile, this.btnNavSearch, this.btnNavConnections,
                this.btnNavUniversities, this.btnNavPosts, this.btnNavMessages, this.btnNavEvents
            };
            System.EventHandler[] navHandlers = {
                new System.EventHandler(btnNavProfile_Click),
                new System.EventHandler(btnNavSearch_Click),
                new System.EventHandler(btnNavConnections_Click),
                new System.EventHandler(btnNavUniversities_Click),
                new System.EventHandler(btnNavPosts_Click),
                new System.EventHandler(btnNavMessages_Click),
                new System.EventHandler(btnNavEvents_Click)
            };
            for (int i = 0; i < 7; i++)
            {
                navBtns[i].BackColor = i == 5
                    ? System.Drawing.Color.FromArgb(52, 193, 164)
                    : System.Drawing.Color.FromArgb(68, 72, 71);
                navBtns[i].FlatAppearance.BorderSize = 0;
                navBtns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                navBtns[i].Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
                navBtns[i].ForeColor = System.Drawing.Color.White;
                navBtns[i].Location = new System.Drawing.Point(21, navY[i]);
                navBtns[i].Name = "btnNav" + navTxt[i];
                navBtns[i].Size = new System.Drawing.Size(251, 49);
                navBtns[i].Text = navTxt[i];
                navBtns[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                navBtns[i].UseVisualStyleBackColor = false;
                navBtns[i].TabIndex = i + 1;
                navBtns[i].Click += navHandlers[i];
            }

            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(21, 738);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 47);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ── lblPageTitle ───────────────────────────────────────────
            this.lblPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(313, 18);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Text = "Messages";

            // ── tableMain (fills content area) ─────────────────────────
            // 2 columns: left ~320px fixed, right fills rest
            this.tableMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.panelLeft, 0, 0);
            this.tableMain.Controls.Add(this.panelRight, 1, 0);
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Location = new System.Drawing.Point(313, 75);
            this.tableMain.Name = "tableMain";
            this.tableMain.Size = new System.Drawing.Size(1247, 720);
            this.tableMain.TabIndex = 10;

            // ── panelLeft ──────────────────────────────────────────────
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(56, 60, 60);
            this.panelLeft.Controls.Add(this.lblConvHeader);
            this.panelLeft.Controls.Add(this.panelSearchBar);
            this.panelLeft.Controls.Add(this.flowConversations);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Name = "panelLeft";

            this.lblConvHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConvHeader.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.lblConvHeader.ForeColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.lblConvHeader.Height = 42;
            this.lblConvHeader.Name = "lblConvHeader";
            this.lblConvHeader.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblConvHeader.Text = "Conversations";
            this.lblConvHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Search bar inside left panel
            this.panelSearchBar.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.panelSearchBar.Controls.Add(this.txtMsgSearch);
            this.panelSearchBar.Controls.Add(this.btnSearchMsg);
            this.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBar.Height = 52;
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);

            this.txtMsgSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsgSearch.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.txtMsgSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsgSearch.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtMsgSearch.ForeColor = System.Drawing.Color.White;
            this.txtMsgSearch.Location = new System.Drawing.Point(8, 10);
            this.txtMsgSearch.Name = "txtMsgSearch";
            this.txtMsgSearch.Size = new System.Drawing.Size(220, 28);
            this.txtMsgSearch.TabIndex = 0;
            this.txtMsgSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsgSearch_KeyDown);

            this.btnSearchMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSearchMsg.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnSearchMsg.FlatAppearance.BorderSize = 0;
            this.btnSearchMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMsg.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchMsg.ForeColor = System.Drawing.Color.White;
            this.btnSearchMsg.Location = new System.Drawing.Point(236, 8);
            this.btnSearchMsg.Name = "btnSearchMsg";
            this.btnSearchMsg.Size = new System.Drawing.Size(72, 30);
            this.btnSearchMsg.TabIndex = 1;
            this.btnSearchMsg.Text = "Search";
            this.btnSearchMsg.UseVisualStyleBackColor = false;
            this.btnSearchMsg.Click += new System.EventHandler(this.btnSearchMsg_Click);

            this.flowConversations.AutoScroll = true;
            this.flowConversations.BackColor = System.Drawing.Color.FromArgb(56, 60, 60);
            this.flowConversations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowConversations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowConversations.Name = "flowConversations";
            this.flowConversations.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.flowConversations.WrapContents = false;

            // ── panelRight ─────────────────────────────────────────────
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.panelRight.Controls.Add(this.lblChatHeader);
            this.panelRight.Controls.Add(this.flowChat);
            this.panelRight.Controls.Add(this.panelSendArea);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Name = "panelRight";

            this.lblChatHeader.BackColor = System.Drawing.Color.FromArgb(56, 60, 60);
            this.lblChatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChatHeader.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblChatHeader.ForeColor = System.Drawing.Color.White;
            this.lblChatHeader.Height = 44;
            this.lblChatHeader.Name = "lblChatHeader";
            this.lblChatHeader.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblChatHeader.Text = "Select a conversation";
            this.lblChatHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelSendArea.BackColor = System.Drawing.Color.FromArgb(56, 60, 60);
            this.panelSendArea.Controls.Add(this.txtNewMessage);
            this.panelSendArea.Controls.Add(this.btnSend);
            this.panelSendArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSendArea.Height = 60;
            this.panelSendArea.Name = "panelSendArea";
            this.panelSendArea.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

            this.txtNewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewMessage.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewMessage.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtNewMessage.ForeColor = System.Drawing.Color.White;
            this.txtNewMessage.Location = new System.Drawing.Point(10, 12);
            this.txtNewMessage.Multiline = true;
            this.txtNewMessage.Name = "txtNewMessage";
            this.txtNewMessage.Size = new System.Drawing.Size(800, 36);
            this.txtNewMessage.TabIndex = 0;
            this.txtNewMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewMessage_KeyDown);

            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(820, 10);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 38);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.flowChat.AutoScroll = true;
            this.flowChat.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.flowChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowChat.Name = "flowChat";
            this.flowChat.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.flowChat.WrapContents = false;

            // ── Form ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "Messages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Messages_Load);
            this.panelNav.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelSendArea.ResumeLayout(false);
            this.panelSendArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Button btnNavProfile, btnNavSearch, btnNavConnections;
        private System.Windows.Forms.Button btnNavUniversities, btnNavPosts, btnNavMessages, btnNavEvents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblConvHeader;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.TextBox txtMsgSearch;
        private System.Windows.Forms.Button btnSearchMsg;
        private System.Windows.Forms.FlowLayoutPanel flowConversations;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblChatHeader;
        private System.Windows.Forms.FlowLayoutPanel flowChat;
        private System.Windows.Forms.Panel panelSendArea;
        private System.Windows.Forms.TextBox txtNewMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
