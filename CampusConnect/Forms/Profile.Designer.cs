namespace CampusConnect.Forms
{
    partial class Profile
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelSkills = new System.Windows.Forms.Panel();
            this.lblSkillsTitle = new System.Windows.Forms.Label();
            this.btnCheckSkills = new System.Windows.Forms.Button();
            this.panelCertificates = new System.Windows.Forms.Panel();
            this.lblCertTitle = new System.Windows.Forms.Label();
            this.btnCheckCertificates = new System.Windows.Forms.Button();
            this.panelEducation = new System.Windows.Forms.Panel();
            this.lblEduTitle = new System.Windows.Forms.Label();
            this.btnCheckEducation = new System.Windows.Forms.Button();
            this.panelInternships = new System.Windows.Forms.Panel();
            this.lblIntTitle = new System.Windows.Forms.Label();
            this.btnCheckInternships = new System.Windows.Forms.Button();
            this.btnMyPosts = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.panelSkills.SuspendLayout();
            this.panelCertificates.SuspendLayout();
            this.panelEducation.SuspendLayout();
            this.panelInternships.SuspendLayout();
            this.SuspendLayout();
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
            // lblNavTitle
            this.lblNavTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.lblNavTitle.Location = new System.Drawing.Point(16, 20);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(190, 30);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "CampusConnect";
            // btnNavProfile
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
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
            // btnNavSearch
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
            // btnNavConnections
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
            // btnNavUniversities
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
            // btnNavPosts
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
            // btnNavMessages
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
            // btnNavEvents
            this.btnNavEvents.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
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
            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(16, 600);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 38);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // lblPageTitle
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(240, 30);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "My Profile";
            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblUsername.Location = new System.Drawing.Point(242, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "@username";
            // panelSkills
            this.panelSkills.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelSkills.Controls.Add(this.lblSkillsTitle);
            this.panelSkills.Controls.Add(this.btnCheckSkills);
            this.panelSkills.Location = new System.Drawing.Point(240, 120);
            this.panelSkills.Name = "panelSkills";
            this.panelSkills.Size = new System.Drawing.Size(220, 160);
            this.panelSkills.TabIndex = 3;
            // lblSkillsTitle
            this.lblSkillsTitle.AutoSize = true;
            this.lblSkillsTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblSkillsTitle.ForeColor = System.Drawing.Color.White;
            this.lblSkillsTitle.Location = new System.Drawing.Point(16, 18);
            this.lblSkillsTitle.Name = "lblSkillsTitle";
            this.lblSkillsTitle.TabIndex = 0;
            this.lblSkillsTitle.Text = "Skills";
            // btnCheckSkills
            this.btnCheckSkills.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnCheckSkills.FlatAppearance.BorderSize = 0;
            this.btnCheckSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckSkills.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckSkills.ForeColor = System.Drawing.Color.White;
            this.btnCheckSkills.Location = new System.Drawing.Point(16, 110);
            this.btnCheckSkills.Name = "btnCheckSkills";
            this.btnCheckSkills.Size = new System.Drawing.Size(110, 34);
            this.btnCheckSkills.TabIndex = 1;
            this.btnCheckSkills.Text = "Check All";
            this.btnCheckSkills.UseVisualStyleBackColor = false;
            this.btnCheckSkills.Click += new System.EventHandler(this.btnCheckSkills_Click);
            // panelCertificates
            this.panelCertificates.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelCertificates.Controls.Add(this.lblCertTitle);
            this.panelCertificates.Controls.Add(this.btnCheckCertificates);
            this.panelCertificates.Location = new System.Drawing.Point(480, 120);
            this.panelCertificates.Name = "panelCertificates";
            this.panelCertificates.Size = new System.Drawing.Size(220, 160);
            this.panelCertificates.TabIndex = 4;
            // lblCertTitle
            this.lblCertTitle.AutoSize = true;
            this.lblCertTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblCertTitle.ForeColor = System.Drawing.Color.White;
            this.lblCertTitle.Location = new System.Drawing.Point(16, 18);
            this.lblCertTitle.Name = "lblCertTitle";
            this.lblCertTitle.TabIndex = 0;
            this.lblCertTitle.Text = "Certificates";
            // btnCheckCertificates
            this.btnCheckCertificates.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnCheckCertificates.FlatAppearance.BorderSize = 0;
            this.btnCheckCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCertificates.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckCertificates.ForeColor = System.Drawing.Color.White;
            this.btnCheckCertificates.Location = new System.Drawing.Point(16, 110);
            this.btnCheckCertificates.Name = "btnCheckCertificates";
            this.btnCheckCertificates.Size = new System.Drawing.Size(110, 34);
            this.btnCheckCertificates.TabIndex = 1;
            this.btnCheckCertificates.Text = "Check All";
            this.btnCheckCertificates.UseVisualStyleBackColor = false;
            this.btnCheckCertificates.Click += new System.EventHandler(this.btnCheckCertificates_Click);
            // panelEducation
            this.panelEducation.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelEducation.Controls.Add(this.lblEduTitle);
            this.panelEducation.Controls.Add(this.btnCheckEducation);
            this.panelEducation.Location = new System.Drawing.Point(720, 120);
            this.panelEducation.Name = "panelEducation";
            this.panelEducation.Size = new System.Drawing.Size(220, 160);
            this.panelEducation.TabIndex = 5;
            // lblEduTitle
            this.lblEduTitle.AutoSize = true;
            this.lblEduTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblEduTitle.ForeColor = System.Drawing.Color.White;
            this.lblEduTitle.Location = new System.Drawing.Point(16, 18);
            this.lblEduTitle.Name = "lblEduTitle";
            this.lblEduTitle.TabIndex = 0;
            this.lblEduTitle.Text = "Education";
            // btnCheckEducation
            this.btnCheckEducation.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnCheckEducation.FlatAppearance.BorderSize = 0;
            this.btnCheckEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckEducation.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckEducation.ForeColor = System.Drawing.Color.White;
            this.btnCheckEducation.Location = new System.Drawing.Point(16, 110);
            this.btnCheckEducation.Name = "btnCheckEducation";
            this.btnCheckEducation.Size = new System.Drawing.Size(110, 34);
            this.btnCheckEducation.TabIndex = 1;
            this.btnCheckEducation.Text = "Check All";
            this.btnCheckEducation.UseVisualStyleBackColor = false;
            this.btnCheckEducation.Click += new System.EventHandler(this.btnCheckEducation_Click);
            // panelInternships
            this.panelInternships.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelInternships.Controls.Add(this.lblIntTitle);
            this.panelInternships.Controls.Add(this.btnCheckInternships);
            this.panelInternships.Location = new System.Drawing.Point(960, 120);
            this.panelInternships.Name = "panelInternships";
            this.panelInternships.Size = new System.Drawing.Size(200, 160);
            this.panelInternships.TabIndex = 6;
            // lblIntTitle
            this.lblIntTitle.AutoSize = true;
            this.lblIntTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblIntTitle.ForeColor = System.Drawing.Color.White;
            this.lblIntTitle.Location = new System.Drawing.Point(16, 18);
            this.lblIntTitle.Name = "lblIntTitle";
            this.lblIntTitle.TabIndex = 0;
            this.lblIntTitle.Text = "Internship";
            // btnCheckInternships
            this.btnCheckInternships.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnCheckInternships.FlatAppearance.BorderSize = 0;
            this.btnCheckInternships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInternships.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckInternships.ForeColor = System.Drawing.Color.White;
            this.btnCheckInternships.Location = new System.Drawing.Point(16, 110);
            this.btnCheckInternships.Name = "btnCheckInternships";
            this.btnCheckInternships.Size = new System.Drawing.Size(110, 34);
            this.btnCheckInternships.TabIndex = 1;
            this.btnCheckInternships.Text = "Check All";
            this.btnCheckInternships.UseVisualStyleBackColor = false;
            this.btnCheckInternships.Click += new System.EventHandler(this.btnCheckInternships_Click);
            // btnMyPosts
            this.btnMyPosts.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnMyPosts.FlatAppearance.BorderSize = 0;
            this.btnMyPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPosts.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnMyPosts.ForeColor = System.Drawing.Color.White;
            this.btnMyPosts.Location = new System.Drawing.Point(240, 590);
            this.btnMyPosts.Name = "btnMyPosts";
            this.btnMyPosts.Size = new System.Drawing.Size(140, 42);
            this.btnMyPosts.TabIndex = 7;
            this.btnMyPosts.Text = "My Posts";
            this.btnMyPosts.UseVisualStyleBackColor = false;
            this.btnMyPosts.Click += new System.EventHandler(this.btnMyPosts_Click);
            // Profile
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panelSkills);
            this.Controls.Add(this.panelCertificates);
            this.Controls.Add(this.panelEducation);
            this.Controls.Add(this.panelInternships);
            this.Controls.Add(this.btnMyPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.panelNav.ResumeLayout(false);
            this.panelSkills.ResumeLayout(false);
            this.panelSkills.PerformLayout();
            this.panelCertificates.ResumeLayout(false);
            this.panelCertificates.PerformLayout();
            this.panelEducation.ResumeLayout(false);
            this.panelEducation.PerformLayout();
            this.panelInternships.ResumeLayout(false);
            this.panelInternships.PerformLayout();
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
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelSkills;
        private System.Windows.Forms.Label lblSkillsTitle;
        private System.Windows.Forms.Button btnCheckSkills;
        private System.Windows.Forms.Panel panelCertificates;
        private System.Windows.Forms.Label lblCertTitle;
        private System.Windows.Forms.Button btnCheckCertificates;
        private System.Windows.Forms.Panel panelEducation;
        private System.Windows.Forms.Label lblEduTitle;
        private System.Windows.Forms.Button btnCheckEducation;
        private System.Windows.Forms.Panel panelInternships;
        private System.Windows.Forms.Label lblIntTitle;
        private System.Windows.Forms.Button btnCheckInternships;
        private System.Windows.Forms.Button btnMyPosts;
    }
}
