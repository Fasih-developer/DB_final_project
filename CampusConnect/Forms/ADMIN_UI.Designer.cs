namespace CampusConnect.Forms
{
    partial class ADMIN_UI
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblSideTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelRemoveUser = new System.Windows.Forms.Panel();
            this.lblRemoveTitle = new System.Windows.Forms.Label();
            this.lblRemoveDesc = new System.Windows.Forms.Label();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.panelReports = new System.Windows.Forms.Panel();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.lblReportsDesc = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelRemoveUser.SuspendLayout();
            this.panelReports.SuspendLayout();
            this.SuspendLayout();
            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelSidebar.Controls.Add(this.lblSideTitle);
            this.panelSidebar.Controls.Add(this.btnExit);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(280, 656);
            this.panelSidebar.TabIndex = 0;
            // lblSideTitle
            this.lblSideTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblSideTitle.ForeColor = System.Drawing.Color.White;
            this.lblSideTitle.Location = new System.Drawing.Point(20, 260);
            this.lblSideTitle.Name = "lblSideTitle";
            this.lblSideTitle.Size = new System.Drawing.Size(240, 80);
            this.lblSideTitle.TabIndex = 0;
            this.lblSideTitle.Text = "Admin\r\nDashboard";
            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(20, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // lblPageTitle
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(320, 50);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Admin Panel";
            // panelRemoveUser
            this.panelRemoveUser.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelRemoveUser.Controls.Add(this.lblRemoveTitle);
            this.panelRemoveUser.Controls.Add(this.lblRemoveDesc);
            this.panelRemoveUser.Controls.Add(this.btnRemoveUser);
            this.panelRemoveUser.Location = new System.Drawing.Point(320, 130);
            this.panelRemoveUser.Name = "panelRemoveUser";
            this.panelRemoveUser.Size = new System.Drawing.Size(380, 280);
            this.panelRemoveUser.TabIndex = 2;
            // lblRemoveTitle
            this.lblRemoveTitle.AutoSize = true;
            this.lblRemoveTitle.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.lblRemoveTitle.ForeColor = System.Drawing.Color.White;
            this.lblRemoveTitle.Location = new System.Drawing.Point(24, 30);
            this.lblRemoveTitle.Name = "lblRemoveTitle";
            this.lblRemoveTitle.TabIndex = 0;
            this.lblRemoveTitle.Text = "Remove a User";
            // lblRemoveDesc
            this.lblRemoveDesc.Font = new System.Drawing.Font("Montserrat", 9.5F);
            this.lblRemoveDesc.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblRemoveDesc.Location = new System.Drawing.Point(24, 72);
            this.lblRemoveDesc.Name = "lblRemoveDesc";
            this.lblRemoveDesc.Size = new System.Drawing.Size(320, 80);
            this.lblRemoveDesc.TabIndex = 1;
            this.lblRemoveDesc.Text = "Search for a user and remove them from the platform.";
            // btnRemoveUser
            this.btnRemoveUser.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnRemoveUser.FlatAppearance.BorderSize = 0;
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.Location = new System.Drawing.Point(24, 210);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(140, 42);
            this.btnRemoveUser.TabIndex = 2;
            this.btnRemoveUser.Text = "Manage";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // panelReports
            this.panelReports.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelReports.Controls.Add(this.lblReportsTitle);
            this.panelReports.Controls.Add(this.lblReportsDesc);
            this.panelReports.Controls.Add(this.btnReports);
            this.panelReports.Location = new System.Drawing.Point(730, 130);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(380, 280);
            this.panelReports.TabIndex = 3;
            // lblReportsTitle
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.lblReportsTitle.ForeColor = System.Drawing.Color.White;
            this.lblReportsTitle.Location = new System.Drawing.Point(24, 30);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.TabIndex = 0;
            this.lblReportsTitle.Text = "See the Reports";
            // lblReportsDesc
            this.lblReportsDesc.Font = new System.Drawing.Font("Montserrat", 9.5F);
            this.lblReportsDesc.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblReportsDesc.Location = new System.Drawing.Point(24, 72);
            this.lblReportsDesc.Name = "lblReportsDesc";
            this.lblReportsDesc.Size = new System.Drawing.Size(320, 80);
            this.lblReportsDesc.TabIndex = 1;
            this.lblReportsDesc.Text = "View platform activity reports and analytics.";
            // btnReports
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(24, 210);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(140, 42);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "View";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // ADMIN_UI
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.panelRemoveUser);
            this.Controls.Add(this.panelReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ADMIN_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panelSidebar.ResumeLayout(false);
            this.panelRemoveUser.ResumeLayout(false);
            this.panelRemoveUser.PerformLayout();
            this.panelReports.ResumeLayout(false);
            this.panelReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSideTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelRemoveUser;
        private System.Windows.Forms.Label lblRemoveTitle;
        private System.Windows.Forms.Label lblRemoveDesc;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Label lblReportsDesc;
        private System.Windows.Forms.Button btnReports;
    }
}
