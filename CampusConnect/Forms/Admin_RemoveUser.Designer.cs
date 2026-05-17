namespace CampusConnect.Forms
{
    partial class Admin_RemoveUser
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panelResults = new System.Windows.Forms.Panel();
            this.lblResultsPlaceholder = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelResults.SuspendLayout();
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
            this.lblSideTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblSideTitle.ForeColor = System.Drawing.Color.White;
            this.lblSideTitle.Location = new System.Drawing.Point(20, 260);
            this.lblSideTitle.Name = "lblSideTitle";
            this.lblSideTitle.Size = new System.Drawing.Size(240, 80);
            this.lblSideTitle.TabIndex = 0;
            this.lblSideTitle.Text = "Remove\r\nUser";
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
            this.lblPageTitle.Location = new System.Drawing.Point(320, 40);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Remove a User";
            // panelSearch
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelSearch.Controls.Add(this.lblSearchTitle);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.btnRemove);
            this.panelSearch.Location = new System.Drawing.Point(320, 100);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(820, 120);
            this.panelSearch.TabIndex = 2;
            // lblSearchTitle
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.ForeColor = System.Drawing.Color.White;
            this.lblSearchTitle.Location = new System.Drawing.Point(20, 16);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.TabIndex = 0;
            this.lblSearchTitle.Text = "Search User";
            // txtSearch
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(20, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(520, 34);
            this.txtSearch.TabIndex = 1;
            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(560, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // btnRemove
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(690, 50);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 34);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // panelResults
            this.panelResults.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelResults.Controls.Add(this.lblResultsPlaceholder);
            this.panelResults.Location = new System.Drawing.Point(320, 240);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(820, 360);
            this.panelResults.TabIndex = 3;
            // lblResultsPlaceholder
            this.lblResultsPlaceholder.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblResultsPlaceholder.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblResultsPlaceholder.Location = new System.Drawing.Point(20, 20);
            this.lblResultsPlaceholder.Name = "lblResultsPlaceholder";
            this.lblResultsPlaceholder.Size = new System.Drawing.Size(780, 30);
            this.lblResultsPlaceholder.TabIndex = 0;
            this.lblResultsPlaceholder.Text = "Search results will appear here...";
            // Admin_RemoveUser
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin_RemoveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove User";
            this.panelSidebar.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSideTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label lblResultsPlaceholder;
    }
}
