namespace CampusConnect.Forms
{
    partial class University
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelNav = new System.Windows.Forms.Panel();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.btnNavUniversities = new System.Windows.Forms.Button();
            this.btnNavPosts = new System.Windows.Forms.Button();
            this.btnNavMessages = new System.Windows.Forms.Button();
            this.btnNavEvents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavConnections = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
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
            this.panelNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(220, 656);
            this.panelNav.TabIndex = 0;
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.lblNavTitle.Location = new System.Drawing.Point(16, 20);
            this.lblNavTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(190, 30);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "CampusConnect";
            // 
            // btnNavUniversities
            // 
            this.btnNavUniversities.Location = new System.Drawing.Point(0, 0);
            this.btnNavUniversities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNavUniversities.Name = "btnNavUniversities";
            this.btnNavUniversities.Size = new System.Drawing.Size(56, 19);
            this.btnNavUniversities.TabIndex = 4;
            // 
            // btnNavPosts
            // 
            this.btnNavPosts.Location = new System.Drawing.Point(0, 0);
            this.btnNavPosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNavPosts.Name = "btnNavPosts";
            this.btnNavPosts.Size = new System.Drawing.Size(56, 19);
            this.btnNavPosts.TabIndex = 5;
            // 
            // btnNavMessages
            // 
            this.btnNavMessages.Location = new System.Drawing.Point(0, 0);
            this.btnNavMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNavMessages.Name = "btnNavMessages";
            this.btnNavMessages.Size = new System.Drawing.Size(56, 19);
            this.btnNavMessages.TabIndex = 6;
            // 
            // btnNavEvents
            // 
            this.btnNavEvents.Location = new System.Drawing.Point(0, 0);
            this.btnNavEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNavEvents.Name = "btnNavEvents";
            this.btnNavEvents.Size = new System.Drawing.Size(56, 19);
            this.btnNavEvents.TabIndex = 7;
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
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 38);
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
            this.lblPageTitle.Location = new System.Drawing.Point(235, 21);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(184, 42);
            this.lblPageTitle.TabIndex = 10;
            this.lblPageTitle.Text = "Universities";
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(235, 65);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(935, 569);
            this.flowPanel.TabIndex = 11;
            this.flowPanel.WrapContents = false;
            // 
            // btnNavConnections
            // 
            this.btnNavConnections.Location = new System.Drawing.Point(0, 0);
            this.btnNavConnections.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavConnections.Name = "btnNavConnections";
            this.btnNavConnections.Size = new System.Drawing.Size(56, 19);
            this.btnNavConnections.TabIndex = 3;
            // 
            // btnNavSearch
            // 
            this.btnNavSearch.Location = new System.Drawing.Point(0, 0);
            this.btnNavSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(56, 19);
            this.btnNavSearch.TabIndex = 2;
            // 
            // btnNavProfile
            // 
            this.btnNavProfile.Location = new System.Drawing.Point(2, 2);
            this.btnNavProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(56, 19);
            this.btnNavProfile.TabIndex = 1;
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.flowPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "University";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universities";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.University_Load);
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label lblNavTitle, lblPageTitle;
        private System.Windows.Forms.Button btnNavUniversities, btnNavPosts, btnNavMessages, btnNavEvents, btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Button btnNavConnections;
    }
}