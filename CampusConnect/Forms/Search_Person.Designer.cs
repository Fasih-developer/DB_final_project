namespace CampusConnect.Forms
{
    partial class Search_Person
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing){ if(disposing&&components!=null)components.Dispose(); base.Dispose(disposing); }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelNav=new System.Windows.Forms.Panel(); this.lblNavTitle=new System.Windows.Forms.Label();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.btnNavConnections = new System.Windows.Forms.Button();
            this.btnNavUniversities = new System.Windows.Forms.Button();
            this.btnNavPosts = new System.Windows.Forms.Button();
            this.btnNavMessages = new System.Windows.Forms.Button();
            this.btnNavEvents = new System.Windows.Forms.Button();
            this.btnLogout=new System.Windows.Forms.Button(); this.lblPageTitle=new System.Windows.Forms.Label();
            this.txtSearch  = new System.Windows.Forms.TextBox();
            this.btnSearch  = new System.Windows.Forms.Button();
            this.flowResults = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemeToggle = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout(); this.SuspendLayout();
            this.panelNav.BackColor=System.Drawing.Color.FromArgb(68, 72, 71); this.panelNav.Controls.Add(this.lblNavTitle);
            this.panelNav.Controls.Add(this.btnNavProfile);
            this.panelNav.Controls.Add(this.btnNavSearch);
            this.panelNav.Controls.Add(this.btnNavConnections);
            this.panelNav.Controls.Add(this.btnNavUniversities);
            this.panelNav.Controls.Add(this.btnNavPosts);
            this.panelNav.Controls.Add(this.btnNavMessages);
            this.panelNav.Controls.Add(this.btnNavEvents);
            this.panelNav.Controls.Add(this.btnLogout);
            this.panelNav.Dock=System.Windows.Forms.DockStyle.Left; this.panelNav.Name="panelNav"; this.panelNav.Size=new System.Drawing.Size(293,807); this.panelNav.TabIndex=0;
            this.lblNavTitle.Font=new System.Drawing.Font("Montserrat",13F,System.Drawing.FontStyle.Bold); this.lblNavTitle.ForeColor=System.Drawing.Color.FromArgb(52, 193, 164); this.lblNavTitle.Location=new System.Drawing.Point(21,25); this.lblNavTitle.Name="lblNavTitle"; this.lblNavTitle.Size=new System.Drawing.Size(253,37); this.lblNavTitle.TabIndex=0; this.lblNavTitle.Text="CampusConnect";

            this.btnNavProfile.BackColor=System.Drawing.Color.FromArgb(68, 72, 71); this.btnNavProfile.FlatAppearance.BorderSize=0; this.btnNavProfile.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnNavProfile.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnNavProfile.ForeColor=System.Drawing.Color.White; this.btnNavProfile.Location=new System.Drawing.Point(21,86); this.btnNavProfile.Name="btnNavProfile"; this.btnNavProfile.Size=new System.Drawing.Size(251,49); this.btnNavProfile.TabIndex=1; this.btnNavProfile.Text="Profile"; this.btnNavProfile.TextAlign=System.Drawing.ContentAlignment.MiddleLeft; this.btnNavProfile.UseVisualStyleBackColor=false; this.btnNavProfile.Click+=new System.EventHandler(this.btnNavProfile_Click);
            this.btnNavSearch.BackColor=System.Drawing.Color.FromArgb(52, 193, 164); this.btnNavSearch.FlatAppearance.BorderSize=0; this.btnNavSearch.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnNavSearch.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnNavSearch.ForeColor=System.Drawing.Color.White; this.btnNavSearch.Location=new System.Drawing.Point(21,145); this.btnNavSearch.Name="btnNavSearch"; this.btnNavSearch.Size=new System.Drawing.Size(251,49); this.btnNavSearch.TabIndex=2; this.btnNavSearch.Text="Search"; this.btnNavSearch.TextAlign=System.Drawing.ContentAlignment.MiddleLeft; this.btnNavSearch.UseVisualStyleBackColor=false; this.btnNavSearch.Click+=new System.EventHandler(this.btnNavSearch_Click);
            this.btnNavConnections.BackColor=System.Drawing.Color.FromArgb(68, 72, 71); this.btnNavConnections.FlatAppearance.BorderSize=0; this.btnNavConnections.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnNavConnections.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnNavConnections.ForeColor=System.Drawing.Color.White; this.btnNavConnections.Location=new System.Drawing.Point(21,204); this.btnNavConnections.Name="btnNavConnections"; this.btnNavConnections.Size=new System.Drawing.Size(251,49); this.btnNavConnections.TabIndex=3; this.btnNavConnections.Text="Connections"; this.btnNavConnections.TextAlign=System.Drawing.ContentAlignment.MiddleLeft; this.btnNavConnections.UseVisualStyleBackColor=false; this.btnNavConnections.Click+=new System.EventHandler(this.btnNavConnections_Click);
            this.btnNavUniversities.BackColor=System.Drawing.Color.FromArgb(68, 72, 71); this.btnNavUniversities.FlatAppearance.BorderSize=0; this.btnNavUniversities.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnNavUniversities.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnNavUniversities.ForeColor=System.Drawing.Color.White; this.btnNavUniversities.Location=new System.Drawing.Point(21,263); this.btnNavUniversities.Name="btnNavUniversities"; this.btnNavUniversities.Size=new System.Drawing.Size(251,49); this.btnNavUniversities.TabIndex=4; this.btnNavUniversities.Text="Universities"; this.btnNavUniversities.TextAlign=System.Drawing.ContentAlignment.MiddleLeft; this.btnNavUniversities.UseVisualStyleBackColor=false; this.btnNavUniversities.Click+=new System.EventHandler(this.btnNavUniversities_Click);
            this.btnNavPosts.BackColor=System.Drawing.Color.FromArgb(68, 72, 71); this.btnNavPosts.FlatAppearance.BorderSize=0; this.btnNavPosts.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnNavPosts.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnNavPosts.ForeColor=System.Drawing.Color.White; this.btnNavPosts.Location=new System.Drawing.Point(21,322); this.btnNavPosts.Name="btnNavPosts"; this.btnNavPosts.Size=new System.Drawing.Size(251,49); this.btnNavPosts.TabIndex=5; this.btnNavPosts.Text="Posts"; this.btnNavPosts.TextAlign=System.Drawing.ContentAlignment.MiddleLeft; this.btnNavPosts.UseVisualStyleBackColor=false; this.btnNavPosts.Click+=new System.EventHandler(this.btnNavPosts_Click);
            this.btnNavMessages.BackColor=System.Drawing.Color.FromArgb(68, 72, 71); this.btnNavMessages.FlatAppearance.BorderSize=0; this.btnNavMessages.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnNavMessages.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnNavMessages.ForeColor=System.Drawing.Color.White; this.btnNavMessages.Location=new System.Drawing.Point(21,381); this.btnNavMessages.Name="btnNavMessages"; this.btnNavMessages.Size=new System.Drawing.Size(251,49); this.btnNavMessages.TabIndex=6; this.btnNavMessages.Text="Messages"; this.btnNavMessages.TextAlign=System.Drawing.ContentAlignment.MiddleLeft; this.btnNavMessages.UseVisualStyleBackColor=false; this.btnNavMessages.Click+=new System.EventHandler(this.btnNavMessages_Click);
            this.btnNavEvents.BackColor=System.Drawing.Color.FromArgb(68, 72, 71); this.btnNavEvents.FlatAppearance.BorderSize=0; this.btnNavEvents.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnNavEvents.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnNavEvents.ForeColor=System.Drawing.Color.White; this.btnNavEvents.Location=new System.Drawing.Point(21,440); this.btnNavEvents.Name="btnNavEvents"; this.btnNavEvents.Size=new System.Drawing.Size(251,49); this.btnNavEvents.TabIndex=7; this.btnNavEvents.Text="Events"; this.btnNavEvents.TextAlign=System.Drawing.ContentAlignment.MiddleLeft; this.btnNavEvents.UseVisualStyleBackColor=false; this.btnNavEvents.Click+=new System.EventHandler(this.btnNavEvents_Click);
            this.btnLogout.BackColor=System.Drawing.Color.Red; this.btnLogout.FlatAppearance.BorderSize=0; this.btnLogout.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnLogout.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnLogout.ForeColor=System.Drawing.Color.White; this.btnLogout.Location=new System.Drawing.Point(21,738); this.btnLogout.Name="btnLogout"; this.btnLogout.Size=new System.Drawing.Size(147,47); this.btnLogout.TabIndex=9; this.btnLogout.Text="Logout"; this.btnLogout.UseVisualStyleBackColor=false; this.btnLogout.Click+=new System.EventHandler(this.btnLogout_Click);
            this.lblPageTitle.AutoSize=true; this.lblPageTitle.Font=new System.Drawing.Font("Montserrat",20F,System.Drawing.FontStyle.Bold); this.lblPageTitle.ForeColor=System.Drawing.Color.White; this.lblPageTitle.Location=new System.Drawing.Point(313,26); this.lblPageTitle.Name="lblPageTitle"; this.lblPageTitle.TabIndex=10; this.lblPageTitle.Text="Search";
            this.txtSearch.BackColor=System.Drawing.Color.FromArgb(44, 49, 49); this.txtSearch.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle; this.txtSearch.Font=new System.Drawing.Font("Montserrat",11F); this.txtSearch.ForeColor=System.Drawing.Color.White; this.txtSearch.Location=new System.Drawing.Point(313,80); this.txtSearch.Name="txtSearch"; this.txtSearch.Size=new System.Drawing.Size(960,34); this.txtSearch.TabIndex=11;
            this.btnSearch.BackColor=System.Drawing.Color.FromArgb(52, 193, 164); this.btnSearch.FlatAppearance.BorderSize=0; this.btnSearch.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnSearch.Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold); this.btnSearch.ForeColor=System.Drawing.Color.White; this.btnSearch.Location=new System.Drawing.Point(1283,80); this.btnSearch.Name="btnSearch"; this.btnSearch.Size=new System.Drawing.Size(140,34); this.btnSearch.TabIndex=12; this.btnSearch.Text="Search"; this.btnSearch.UseVisualStyleBackColor=false; this.btnSearch.Click+=new System.EventHandler(this.btnSearch_Click);
            this.flowResults.AutoScroll=true; this.flowResults.BackColor=System.Drawing.Color.FromArgb(44, 49, 49); this.flowResults.FlowDirection=System.Windows.Forms.FlowDirection.TopDown; this.flowResults.WrapContents=false; this.flowResults.Location=new System.Drawing.Point(313,130); this.flowResults.Name="flowResults"; this.flowResults.Size=new System.Drawing.Size(1247,650); this.flowResults.TabIndex=13;
            this.btnThemeToggle.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.btnThemeToggle.FlatAppearance.BorderSize = 0;
            this.btnThemeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeToggle.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemeToggle.ForeColor = System.Drawing.Color.White;
            this.btnThemeToggle.Name = "btnThemeToggle";
            this.btnThemeToggle.Size = new System.Drawing.Size(110, 34);
            this.btnThemeToggle.TabIndex = 99;
            this.btnThemeToggle.Text = "\u2600 Light";
            this.btnThemeToggle.UseVisualStyleBackColor = false;
            this.btnThemeToggle.Click += new System.EventHandler(this.btnThemeToggle_Click);
            this.AutoScaleDimensions=new System.Drawing.SizeF(8F,16F); this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font; this.BackColor=System.Drawing.Color.FromArgb(44, 49, 49); this.ClientSize=new System.Drawing.Size(1573,807); this.Controls.Add(this.panelNav); this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnThemeToggle);
            this.Controls.Add(this.txtSearch); this.Controls.Add(this.btnSearch); this.Controls.Add(this.flowResults);
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle; this.MaximizeBox=false; this.Name="Search_Person"; this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen; this.Text="Search";
            
            this.panelNav.ResumeLayout(false); this.ResumeLayout(false); this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label lblNavTitle,lblPageTitle;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Button btnNavConnections;
        private System.Windows.Forms.Button btnNavUniversities;
        private System.Windows.Forms.Button btnNavPosts;
        private System.Windows.Forms.Button btnNavMessages;
        private System.Windows.Forms.Button btnNavEvents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowResults;
        private System.Windows.Forms.Button btnThemeToggle;
    }
}
