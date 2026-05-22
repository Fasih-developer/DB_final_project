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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelMsgTop = new System.Windows.Forms.Panel();
            this.txtMsgSearch = new System.Windows.Forms.TextBox();
            this.btnSearchMsg = new System.Windows.Forms.Button();
            this.btnStartMessaging = new System.Windows.Forms.Button();
            this.panelMsgArea = new System.Windows.Forms.Panel();
            this.lblMsgPlaceholder = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.panelMsgTop.SuspendLayout();
            this.panelMsgArea.SuspendLayout();
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
            this.panelNav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(293, 807);
            this.panelNav.TabIndex = 0;
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.lblNavTitle.Location = new System.Drawing.Point(21, 25);
            this.lblNavTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(253, 37);
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
            this.btnNavProfile.Location = new System.Drawing.Point(21, 86);
            this.btnNavProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(251, 49);
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
            this.btnNavSearch.Location = new System.Drawing.Point(21, 145);
            this.btnNavSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(251, 49);
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
            this.btnNavConnections.Location = new System.Drawing.Point(21, 204);
            this.btnNavConnections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavConnections.Name = "btnNavConnections";
            this.btnNavConnections.Size = new System.Drawing.Size(251, 49);
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
            this.btnNavUniversities.Location = new System.Drawing.Point(21, 263);
            this.btnNavUniversities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavUniversities.Name = "btnNavUniversities";
            this.btnNavUniversities.Size = new System.Drawing.Size(251, 49);
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
            this.btnNavPosts.Location = new System.Drawing.Point(21, 322);
            this.btnNavPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavPosts.Name = "btnNavPosts";
            this.btnNavPosts.Size = new System.Drawing.Size(251, 49);
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
            this.btnNavMessages.Location = new System.Drawing.Point(21, 382);
            this.btnNavMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavMessages.Name = "btnNavMessages";
            this.btnNavMessages.Size = new System.Drawing.Size(251, 49);
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
            this.btnNavEvents.Location = new System.Drawing.Point(21, 441);
            this.btnNavEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavEvents.Name = "btnNavEvents";
            this.btnNavEvents.Size = new System.Drawing.Size(251, 49);
            this.btnNavEvents.TabIndex = 7;
            this.btnNavEvents.Text = "Events";
            this.btnNavEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEvents.UseVisualStyleBackColor = false;
            this.btnNavEvents.Click += new System.EventHandler(this.btnNavEvents_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(21, 738);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 47);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(320, 37);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(192, 53);
            this.lblPageTitle.TabIndex = 9;
            this.lblPageTitle.Text = "Messages";
            // 
            // panelMsgTop
            // 
            this.panelMsgTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelMsgTop.Controls.Add(this.txtMsgSearch);
            this.panelMsgTop.Controls.Add(this.btnSearchMsg);
            this.panelMsgTop.Controls.Add(this.btnStartMessaging);
            this.panelMsgTop.Location = new System.Drawing.Point(320, 98);
            this.panelMsgTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMsgTop.Name = "panelMsgTop";
            this.panelMsgTop.Size = new System.Drawing.Size(1200, 86);
            this.panelMsgTop.TabIndex = 10;
            // 
            // txtMsgSearch
            // 
            this.txtMsgSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtMsgSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsgSearch.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtMsgSearch.ForeColor = System.Drawing.Color.White;
            this.txtMsgSearch.Location = new System.Drawing.Point(21, 22);
            this.txtMsgSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMsgSearch.Name = "txtMsgSearch";
            this.txtMsgSearch.Size = new System.Drawing.Size(693, 30);
            this.txtMsgSearch.TabIndex = 0;
            // 
            // btnSearchMsg
            // 
            this.btnSearchMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnSearchMsg.FlatAppearance.BorderSize = 0;
            this.btnSearchMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMsg.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchMsg.ForeColor = System.Drawing.Color.White;
            this.btnSearchMsg.Location = new System.Drawing.Point(733, 22);
            this.btnSearchMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchMsg.Name = "btnSearchMsg";
            this.btnSearchMsg.Size = new System.Drawing.Size(147, 39);
            this.btnSearchMsg.TabIndex = 1;
            this.btnSearchMsg.Text = "Search";
            this.btnSearchMsg.UseVisualStyleBackColor = false;
            this.btnSearchMsg.Click += new System.EventHandler(this.btnSearchMsg_Click);
            // 
            // btnStartMessaging
            // 
            this.btnStartMessaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnStartMessaging.FlatAppearance.BorderSize = 0;
            this.btnStartMessaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMessaging.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartMessaging.ForeColor = System.Drawing.Color.White;
            this.btnStartMessaging.Location = new System.Drawing.Point(901, 22);
            this.btnStartMessaging.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartMessaging.Name = "btnStartMessaging";
            this.btnStartMessaging.Size = new System.Drawing.Size(213, 39);
            this.btnStartMessaging.TabIndex = 2;
            this.btnStartMessaging.Text = "Start Messaging";
            this.btnStartMessaging.UseVisualStyleBackColor = false;
            this.btnStartMessaging.Click += new System.EventHandler(this.btnStartMessaging_Click);
            // 
            // panelMsgArea
            // 
            this.panelMsgArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelMsgArea.Controls.Add(this.lblMsgPlaceholder);
            this.panelMsgArea.Location = new System.Drawing.Point(320, 209);
            this.panelMsgArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMsgArea.Name = "panelMsgArea";
            this.panelMsgArea.Size = new System.Drawing.Size(1200, 542);
            this.panelMsgArea.TabIndex = 11;
            // 
            // lblMsgPlaceholder
            // 
            this.lblMsgPlaceholder.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblMsgPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblMsgPlaceholder.Location = new System.Drawing.Point(27, 25);
            this.lblMsgPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgPlaceholder.Name = "lblMsgPlaceholder";
            this.lblMsgPlaceholder.Size = new System.Drawing.Size(1147, 37);
            this.lblMsgPlaceholder.TabIndex = 0;
            this.lblMsgPlaceholder.Text = "Messages will appear here...";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.panelMsgTop);
            this.Controls.Add(this.panelMsgArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Messages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            this.panelNav.ResumeLayout(false);
            this.panelMsgTop.ResumeLayout(false);
            this.panelMsgTop.PerformLayout();
            this.panelMsgArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Button btnNavConnections;
        private System.Windows.Forms.Button btnNavUniversities;
        private System.Windows.Forms.Button btnNavPosts;
        private System.Windows.Forms.Button btnNavMessages;
        private System.Windows.Forms.Button btnNavEvents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelMsgTop;
        private System.Windows.Forms.TextBox txtMsgSearch;
        private System.Windows.Forms.Button btnSearchMsg;
        private System.Windows.Forms.Button btnStartMessaging;
        private System.Windows.Forms.Panel panelMsgArea;
        private System.Windows.Forms.Label lblMsgPlaceholder;
    }
}