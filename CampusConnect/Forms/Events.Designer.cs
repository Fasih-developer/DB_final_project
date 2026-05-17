namespace CampusConnect.Forms
{
    partial class Events
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
            this.panelNav.SuspendLayout();
            // panelNav
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
            this.panelNav.Size = new System.Drawing.Size(220, 656);
            this.panelNav.TabIndex = 0;
            this.lblNavTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.lblNavTitle.Location = new System.Drawing.Point(16, 20);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(190, 30);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "CampusConnect";
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
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
            this.btnNavSearch.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
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
            this.btnNavConnections.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
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
            this.btnNavUniversities.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
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
            this.btnNavPosts.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
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
            this.btnNavMessages.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
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
            this.btnNavEvents.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
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
            this.lblPageTitle = new System.Windows.Forms.Label();

            // lblPageTitle
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(240, 30);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 9;
            this.lblPageTitle.Text = "Events";

            // Events
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.lblPageTitle);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.panelNav.ResumeLayout(false);

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

    }
}