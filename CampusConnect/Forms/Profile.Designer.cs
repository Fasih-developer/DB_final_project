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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsavebio = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.panelSkills.SuspendLayout();
            this.panelCertificates.SuspendLayout();
            this.panelEducation.SuspendLayout();
            this.panelInternships.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelNav.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnNavProfile.FlatAppearance.BorderSize = 0;
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavProfile.ForeColor = System.Drawing.Color.White;
            this.btnNavProfile.Location = new System.Drawing.Point(21, 86);
            this.btnNavProfile.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNavSearch.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNavConnections.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNavUniversities.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNavPosts.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNavMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.btnNavMessages.FlatAppearance.BorderSize = 0;
            this.btnNavMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMessages.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMessages.ForeColor = System.Drawing.Color.White;
            this.btnNavMessages.Location = new System.Drawing.Point(21, 382);
            this.btnNavMessages.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNavEvents.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 47);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(320, 37);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(217, 57);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "My Profile";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblUsername.Location = new System.Drawing.Point(323, 86);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(133, 31);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "@username";
            // 
            // panelSkills
            // 
            this.panelSkills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelSkills.Controls.Add(this.lblSkillsTitle);
            this.panelSkills.Controls.Add(this.btnCheckSkills);
            this.panelSkills.Location = new System.Drawing.Point(330, 402);
            this.panelSkills.Margin = new System.Windows.Forms.Padding(4);
            this.panelSkills.Name = "panelSkills";
            this.panelSkills.Size = new System.Drawing.Size(293, 197);
            this.panelSkills.TabIndex = 3;
            // 
            // lblSkillsTitle
            // 
            this.lblSkillsTitle.AutoSize = true;
            this.lblSkillsTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblSkillsTitle.ForeColor = System.Drawing.Color.White;
            this.lblSkillsTitle.Location = new System.Drawing.Point(21, 22);
            this.lblSkillsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkillsTitle.Name = "lblSkillsTitle";
            this.lblSkillsTitle.Size = new System.Drawing.Size(75, 34);
            this.lblSkillsTitle.TabIndex = 0;
            this.lblSkillsTitle.Text = "Skills";
            // 
            // btnCheckSkills
            // 
            this.btnCheckSkills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnCheckSkills.FlatAppearance.BorderSize = 0;
            this.btnCheckSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckSkills.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckSkills.ForeColor = System.Drawing.Color.White;
            this.btnCheckSkills.Location = new System.Drawing.Point(21, 135);
            this.btnCheckSkills.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckSkills.Name = "btnCheckSkills";
            this.btnCheckSkills.Size = new System.Drawing.Size(147, 42);
            this.btnCheckSkills.TabIndex = 1;
            this.btnCheckSkills.Text = "Check All";
            this.btnCheckSkills.UseVisualStyleBackColor = false;
            this.btnCheckSkills.Click += new System.EventHandler(this.btnCheckSkills_Click);
            // 
            // panelCertificates
            // 
            this.panelCertificates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelCertificates.Controls.Add(this.lblCertTitle);
            this.panelCertificates.Controls.Add(this.btnCheckCertificates);
            this.panelCertificates.Location = new System.Drawing.Point(650, 402);
            this.panelCertificates.Margin = new System.Windows.Forms.Padding(4);
            this.panelCertificates.Name = "panelCertificates";
            this.panelCertificates.Size = new System.Drawing.Size(293, 197);
            this.panelCertificates.TabIndex = 4;
            // 
            // lblCertTitle
            // 
            this.lblCertTitle.AutoSize = true;
            this.lblCertTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblCertTitle.ForeColor = System.Drawing.Color.White;
            this.lblCertTitle.Location = new System.Drawing.Point(21, 22);
            this.lblCertTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCertTitle.Name = "lblCertTitle";
            this.lblCertTitle.Size = new System.Drawing.Size(143, 34);
            this.lblCertTitle.TabIndex = 0;
            this.lblCertTitle.Text = "Certificates";
            // 
            // btnCheckCertificates
            // 
            this.btnCheckCertificates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnCheckCertificates.FlatAppearance.BorderSize = 0;
            this.btnCheckCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCertificates.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckCertificates.ForeColor = System.Drawing.Color.White;
            this.btnCheckCertificates.Location = new System.Drawing.Point(21, 135);
            this.btnCheckCertificates.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckCertificates.Name = "btnCheckCertificates";
            this.btnCheckCertificates.Size = new System.Drawing.Size(147, 42);
            this.btnCheckCertificates.TabIndex = 1;
            this.btnCheckCertificates.Text = "Check All";
            this.btnCheckCertificates.UseVisualStyleBackColor = false;
            this.btnCheckCertificates.Click += new System.EventHandler(this.btnCheckCertificates_Click);
            // 
            // panelEducation
            // 
            this.panelEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelEducation.Controls.Add(this.lblEduTitle);
            this.panelEducation.Controls.Add(this.btnCheckEducation);
            this.panelEducation.Location = new System.Drawing.Point(970, 402);
            this.panelEducation.Margin = new System.Windows.Forms.Padding(4);
            this.panelEducation.Name = "panelEducation";
            this.panelEducation.Size = new System.Drawing.Size(293, 197);
            this.panelEducation.TabIndex = 5;
            // 
            // lblEduTitle
            // 
            this.lblEduTitle.AutoSize = true;
            this.lblEduTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblEduTitle.ForeColor = System.Drawing.Color.White;
            this.lblEduTitle.Location = new System.Drawing.Point(21, 22);
            this.lblEduTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEduTitle.Name = "lblEduTitle";
            this.lblEduTitle.Size = new System.Drawing.Size(131, 34);
            this.lblEduTitle.TabIndex = 0;
            this.lblEduTitle.Text = "Education";
            // 
            // btnCheckEducation
            // 
            this.btnCheckEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnCheckEducation.FlatAppearance.BorderSize = 0;
            this.btnCheckEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckEducation.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckEducation.ForeColor = System.Drawing.Color.White;
            this.btnCheckEducation.Location = new System.Drawing.Point(21, 135);
            this.btnCheckEducation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckEducation.Name = "btnCheckEducation";
            this.btnCheckEducation.Size = new System.Drawing.Size(147, 42);
            this.btnCheckEducation.TabIndex = 1;
            this.btnCheckEducation.Text = "Check All";
            this.btnCheckEducation.UseVisualStyleBackColor = false;
            this.btnCheckEducation.Click += new System.EventHandler(this.btnCheckEducation_Click);
            // 
            // panelInternships
            // 
            this.panelInternships.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelInternships.Controls.Add(this.lblIntTitle);
            this.panelInternships.Controls.Add(this.btnCheckInternships);
            this.panelInternships.Location = new System.Drawing.Point(1290, 402);
            this.panelInternships.Margin = new System.Windows.Forms.Padding(4);
            this.panelInternships.Name = "panelInternships";
            this.panelInternships.Size = new System.Drawing.Size(267, 197);
            this.panelInternships.TabIndex = 6;
            // 
            // lblIntTitle
            // 
            this.lblIntTitle.AutoSize = true;
            this.lblIntTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblIntTitle.ForeColor = System.Drawing.Color.White;
            this.lblIntTitle.Location = new System.Drawing.Point(21, 22);
            this.lblIntTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntTitle.Name = "lblIntTitle";
            this.lblIntTitle.Size = new System.Drawing.Size(132, 34);
            this.lblIntTitle.TabIndex = 0;
            this.lblIntTitle.Text = "Internship";
            // 
            // btnCheckInternships
            // 
            this.btnCheckInternships.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnCheckInternships.FlatAppearance.BorderSize = 0;
            this.btnCheckInternships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInternships.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckInternships.ForeColor = System.Drawing.Color.White;
            this.btnCheckInternships.Location = new System.Drawing.Point(21, 135);
            this.btnCheckInternships.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckInternships.Name = "btnCheckInternships";
            this.btnCheckInternships.Size = new System.Drawing.Size(147, 42);
            this.btnCheckInternships.TabIndex = 1;
            this.btnCheckInternships.Text = "Check All";
            this.btnCheckInternships.UseVisualStyleBackColor = false;
            this.btnCheckInternships.Click += new System.EventHandler(this.btnCheckInternships_Click);
            // 
            // btnMyPosts
            // 
            this.btnMyPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnMyPosts.FlatAppearance.BorderSize = 0;
            this.btnMyPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPosts.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnMyPosts.ForeColor = System.Drawing.Color.White;
            this.btnMyPosts.Location = new System.Drawing.Point(320, 726);
            this.btnMyPosts.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyPosts.Name = "btnMyPosts";
            this.btnMyPosts.Size = new System.Drawing.Size(187, 52);
            this.btnMyPosts.TabIndex = 7;
            this.btnMyPosts.Text = "My Posts";
            this.btnMyPosts.UseVisualStyleBackColor = false;
            this.btnMyPosts.Click += new System.EventHandler(this.btnMyPosts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.txtUni);
            this.panel1.Controls.Add(this.txtDept);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtCreatedAt);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(330, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 226);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUni
            // 
            this.txtUni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtUni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUni.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUni.ForeColor = System.Drawing.Color.White;
            this.txtUni.Location = new System.Drawing.Point(661, 134);
            this.txtUni.Multiline = true;
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(237, 22);
            this.txtUni.TabIndex = 12;
            // 
            // txtDept
            // 
            this.txtDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDept.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDept.ForeColor = System.Drawing.Color.White;
            this.txtDept.Location = new System.Drawing.Point(661, 192);
            this.txtDept.Multiline = true;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(237, 22);
            this.txtDept.TabIndex = 11;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGender.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.White;
            this.txtGender.Location = new System.Drawing.Point(661, 76);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(237, 22);
            this.txtGender.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.White;
            this.txtAge.Location = new System.Drawing.Point(182, 133);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(237, 22);
            this.txtAge.TabIndex = 9;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedAt.ForeColor = System.Drawing.Color.White;
            this.txtCreatedAt.Location = new System.Drawing.Point(182, 189);
            this.txtCreatedAt.Multiline = true;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(237, 22);
            this.txtCreatedAt.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(182, 75);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 22);
            this.txtName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(438, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "University Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(438, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(438, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dept Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created At";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.btnsavebio);
            this.panel2.Controls.Add(this.txtBio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(1290, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 226);
            this.panel2.TabIndex = 9;
            // 
            // txtBio
            // 
            this.txtBio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtBio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBio.ForeColor = System.Drawing.Color.White;
            this.txtBio.Location = new System.Drawing.Point(21, 59);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(213, 97);
            this.txtBio.TabIndex = 11;
            this.txtBio.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter Bio";
            // 
            // btnsavebio
            // 
            this.btnsavebio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnsavebio.FlatAppearance.BorderSize = 0;
            this.btnsavebio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavebio.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnsavebio.ForeColor = System.Drawing.Color.White;
            this.btnsavebio.Location = new System.Drawing.Point(21, 173);
            this.btnsavebio.Margin = new System.Windows.Forms.Padding(4);
            this.btnsavebio.Name = "btnsavebio";
            this.btnsavebio.Size = new System.Drawing.Size(147, 42);
            this.btnsavebio.TabIndex = 12;
            this.btnsavebio.Text = "Check All";
            this.btnsavebio.UseVisualStyleBackColor = false;
            this.btnsavebio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panelSkills);
            this.Controls.Add(this.panelCertificates);
            this.Controls.Add(this.panelEducation);
            this.Controls.Add(this.panelInternships);
            this.Controls.Add(this.btnMyPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panelNav.ResumeLayout(false);
            this.panelSkills.ResumeLayout(false);
            this.panelSkills.PerformLayout();
            this.panelCertificates.ResumeLayout(false);
            this.panelCertificates.PerformLayout();
            this.panelEducation.ResumeLayout(false);
            this.panelEducation.PerformLayout();
            this.panelInternships.ResumeLayout(false);
            this.panelInternships.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsavebio;
    }
}
