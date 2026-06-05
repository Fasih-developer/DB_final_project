namespace CampusConnect.Forms
{
    partial class Messages
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelNav = new System.Windows.Forms.Panel();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.btnNavConnections = new System.Windows.Forms.Button();
            this.btnNavUniversities = new System.Windows.Forms.Button();
            this.btnNavPosts = new System.Windows.Forms.Button();
            this.btnNavMessages = new System.Windows.Forms.Button();
            this.btnNavEvents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowConversations = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConversationsHeader = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.flowChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChatHeader = new System.Windows.Forms.Panel();
            this.panelSendBar = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnNewChat = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblChatWith = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelNav.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelChatHeader.SuspendLayout();
            this.panelSendBar.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
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
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(220, 656);
            this.panelNav.TabIndex = 0;
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.lblNavTitle.Location = new System.Drawing.Point(16, 20);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(190, 30);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "CampusConnect";
            // 
            // btnNavProfile
            // 
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.btnNavProfile.FlatAppearance.BorderSize = 0;
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavProfile.ForeColor = System.Drawing.Color.White;
            this.btnNavProfile.Location = new System.Drawing.Point(16, 70);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(188, 40);
            this.btnNavProfile.TabIndex = 1;
            this.btnNavProfile.Text = "Profile";
            this.btnNavProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfile.UseVisualStyleBackColor = false;
            this.btnNavProfile.Click += new System.EventHandler(this.btnNavProfile_Click);
            // 
            // btnNavSearch
            // 
            this.btnNavSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.btnNavSearch.FlatAppearance.BorderSize = 0;
            this.btnNavSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSearch.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavSearch.ForeColor = System.Drawing.Color.White;
            this.btnNavSearch.Location = new System.Drawing.Point(16, 118);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(188, 40);
            this.btnNavSearch.TabIndex = 2;
            this.btnNavSearch.Text = "Search";
            this.btnNavSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSearch.UseVisualStyleBackColor = false;
            this.btnNavSearch.Click += new System.EventHandler(this.btnNavSearch_Click);
            // 
            // btnNavConnections
            // 
            this.btnNavConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.btnNavConnections.FlatAppearance.BorderSize = 0;
            this.btnNavConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavConnections.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavConnections.ForeColor = System.Drawing.Color.White;
            this.btnNavConnections.Location = new System.Drawing.Point(16, 166);
            this.btnNavConnections.Name = "btnNavConnections";
            this.btnNavConnections.Size = new System.Drawing.Size(188, 40);
            this.btnNavConnections.TabIndex = 3;
            this.btnNavConnections.Text = "Connections";
            this.btnNavConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavConnections.UseVisualStyleBackColor = false;
            this.btnNavConnections.Click += new System.EventHandler(this.btnNavConnections_Click);
            // 
            // btnNavUniversities
            // 
            this.btnNavUniversities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.btnNavUniversities.FlatAppearance.BorderSize = 0;
            this.btnNavUniversities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUniversities.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavUniversities.ForeColor = System.Drawing.Color.White;
            this.btnNavUniversities.Location = new System.Drawing.Point(16, 214);
            this.btnNavUniversities.Name = "btnNavUniversities";
            this.btnNavUniversities.Size = new System.Drawing.Size(188, 40);
            this.btnNavUniversities.TabIndex = 4;
            this.btnNavUniversities.Text = "Universities";
            this.btnNavUniversities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUniversities.UseVisualStyleBackColor = false;
            this.btnNavUniversities.Click += new System.EventHandler(this.btnNavUniversities_Click);
            // 
            // btnNavPosts
            // 
            this.btnNavPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.btnNavPosts.FlatAppearance.BorderSize = 0;
            this.btnNavPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPosts.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavPosts.ForeColor = System.Drawing.Color.White;
            this.btnNavPosts.Location = new System.Drawing.Point(16, 262);
            this.btnNavPosts.Name = "btnNavPosts";
            this.btnNavPosts.Size = new System.Drawing.Size(188, 40);
            this.btnNavPosts.TabIndex = 5;
            this.btnNavPosts.Text = "Posts";
            this.btnNavPosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPosts.UseVisualStyleBackColor = false;
            this.btnNavPosts.Click += new System.EventHandler(this.btnNavPosts_Click);
            // 
            // btnNavMessages
            // 
            this.btnNavMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnNavMessages.FlatAppearance.BorderSize = 0;
            this.btnNavMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMessages.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMessages.ForeColor = System.Drawing.Color.White;
            this.btnNavMessages.Location = new System.Drawing.Point(16, 310);
            this.btnNavMessages.Name = "btnNavMessages";
            this.btnNavMessages.Size = new System.Drawing.Size(188, 40);
            this.btnNavMessages.TabIndex = 6;
            this.btnNavMessages.Text = "Messages";
            this.btnNavMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMessages.UseVisualStyleBackColor = false;
            this.btnNavMessages.Click += new System.EventHandler(this.btnNavMessages_Click);
            // 
            // btnNavEvents
            // 
            this.btnNavEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.btnNavEvents.FlatAppearance.BorderSize = 0;
            this.btnNavEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEvents.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavEvents.ForeColor = System.Drawing.Color.White;
            this.btnNavEvents.Location = new System.Drawing.Point(16, 358);
            this.btnNavEvents.Name = "btnNavEvents";
            this.btnNavEvents.Size = new System.Drawing.Size(188, 40);
            this.btnNavEvents.TabIndex = 7;
            this.btnNavEvents.Text = "Events";
            this.btnNavEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEvents.UseVisualStyleBackColor = false;
            this.btnNavEvents.Click += new System.EventHandler(this.btnNavEvents_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(16, 600);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 38);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panelContent.Controls.Add(this.splitMain);
            this.panelContent.Controls.Add(this.panelTopBar);
            this.panelContent.Controls.Add(this.lblPageTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(16, 0, 16, 12);
            this.panelContent.Size = new System.Drawing.Size(1079, 656);
            this.panelContent.TabIndex = 1;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(16, 112);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelRight);
            this.splitMain.Size = new System.Drawing.Size(1047, 532);
            this.splitMain.SplitterDistance = 420;
            this.splitMain.SplitterWidth = 2;
            this.splitMain.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelLeft.Controls.Add(this.flowConversations);
            this.panelLeft.Controls.Add(this.lblConversationsHeader);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(420, 532);
            this.panelLeft.TabIndex = 0;
            // 
            // flowConversations
            // 
            this.flowConversations.AutoScroll = true;
            this.flowConversations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.flowConversations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowConversations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowConversations.Location = new System.Drawing.Point(0, 36);
            this.flowConversations.Name = "flowConversations";
            this.flowConversations.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.flowConversations.Size = new System.Drawing.Size(420, 496);
            this.flowConversations.TabIndex = 1;
            this.flowConversations.WrapContents = false;
            this.flowConversations.Paint += new System.Windows.Forms.PaintEventHandler(this.flowConversations_Paint);
            // 
            // lblConversationsHeader
            // 
            this.lblConversationsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblConversationsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConversationsHeader.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblConversationsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.lblConversationsHeader.Location = new System.Drawing.Point(0, 0);
            this.lblConversationsHeader.Name = "lblConversationsHeader";
            this.lblConversationsHeader.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblConversationsHeader.Size = new System.Drawing.Size(420, 36);
            this.lblConversationsHeader.TabIndex = 0;
            this.lblConversationsHeader.Text = "Conversations";
            this.lblConversationsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panelRight.Controls.Add(this.flowChat);
            this.panelRight.Controls.Add(this.panelChatHeader);
            this.panelRight.Controls.Add(this.panelSendBar);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(625, 532);
            this.panelRight.TabIndex = 0;
            // 
            // flowChat
            // 
            this.flowChat.AutoScroll = true;
            this.flowChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.flowChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowChat.Location = new System.Drawing.Point(0, 44);
            this.flowChat.Name = "flowChat";
            this.flowChat.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.flowChat.Size = new System.Drawing.Size(625, 420);
            this.flowChat.TabIndex = 1;
            this.flowChat.WrapContents = false;
            // 
            // panelChatHeader
            // 
            this.panelChatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelChatHeader.Controls.Add(this.lblChatWith);
            this.panelChatHeader.Controls.Add(this.txtSearch);
            this.panelChatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatHeader.Location = new System.Drawing.Point(0, 0);
            this.panelChatHeader.Name = "panelChatHeader";
            this.panelChatHeader.Size = new System.Drawing.Size(625, 44);
            this.panelChatHeader.TabIndex = 0;
            // 
            // panelSendBar
            // 
            this.panelSendBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelSendBar.Controls.Add(this.btnSend);
            this.panelSendBar.Controls.Add(this.txtMessage);
            this.panelSendBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSendBar.Location = new System.Drawing.Point(0, 464);
            this.panelSendBar.Name = "panelSendBar";
            this.panelSendBar.Padding = new System.Windows.Forms.Padding(10);
            this.panelSendBar.Size = new System.Drawing.Size(625, 68);
            this.panelSendBar.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(521, 10);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 46);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(10, 10);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(501, 46);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnNewChat
            // 
            this.btnNewChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnNewChat.FlatAppearance.BorderSize = 0;
            this.btnNewChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewChat.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewChat.ForeColor = System.Drawing.Color.White;
            this.btnNewChat.Location = new System.Drawing.Point(897, 0);
            this.btnNewChat.Name = "btnNewChat";
            this.btnNewChat.Size = new System.Drawing.Size(150, 36);
            this.btnNewChat.TabIndex = 1;
            this.btnNewChat.Text = "+ New Chat";
            this.btnNewChat.UseVisualStyleBackColor = false;
            this.btnNewChat.Click += new System.EventHandler(this.btnNewChat_Click);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(16, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 14, 0, 8);
            this.lblPageTitle.Size = new System.Drawing.Size(1047, 60);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Messages";
            // 
            // lblChatWith
            // 
            this.lblChatWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChatWith.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblChatWith.ForeColor = System.Drawing.Color.White;
            this.lblChatWith.Location = new System.Drawing.Point(0, 0);
            this.lblChatWith.Name = "lblChatWith";
            this.lblChatWith.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblChatWith.Size = new System.Drawing.Size(625, 44);
            this.lblChatWith.TabIndex = 0;
            this.lblChatWith.Text = "Select a conversation to begin";
            this.lblChatWith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panelTopBar.Controls.Add(this.btnNewChat);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(16, 60);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panelTopBar.Size = new System.Drawing.Size(1047, 52);
            this.panelTopBar.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(289, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(49, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1299, 656);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNav);
            this.Name = "Messages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages — CampusConnect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Messages_Load);
            this.panelNav.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelChatHeader.ResumeLayout(false);
            this.panelChatHeader.PerformLayout();
            this.panelSendBar.ResumeLayout(false);
            this.panelSendBar.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ─────────────────────────────────────────
        private System.Windows.Forms.Panel           panelNav;
        private System.Windows.Forms.Label           lblNavTitle;
        private System.Windows.Forms.Button          btnNavProfile;
        private System.Windows.Forms.Button          btnNavSearch;
        private System.Windows.Forms.Button          btnNavConnections;
        private System.Windows.Forms.Button          btnNavUniversities;
        private System.Windows.Forms.Button          btnNavPosts;
        private System.Windows.Forms.Button          btnNavMessages;
        private System.Windows.Forms.Button          btnNavEvents;
        private System.Windows.Forms.Button          btnLogout;
        private System.Windows.Forms.Panel           panelContent;
        private System.Windows.Forms.Label           lblPageTitle;
        private System.Windows.Forms.Button          btnNewChat;
        private System.Windows.Forms.SplitContainer  splitMain;
        private System.Windows.Forms.Panel           panelLeft;
        private System.Windows.Forms.Label           lblConversationsHeader;
        private System.Windows.Forms.FlowLayoutPanel flowConversations;
        private System.Windows.Forms.Panel           panelRight;
        private System.Windows.Forms.Panel           panelChatHeader;
        private System.Windows.Forms.FlowLayoutPanel flowChat;
        private System.Windows.Forms.Panel           panelSendBar;
        private System.Windows.Forms.TextBox         txtMessage;
        private System.Windows.Forms.Button          btnSend;
        private System.Windows.Forms.Label lblChatWith;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelTopBar;
    }
}
