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
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.btnNavConnections = new System.Windows.Forms.Button();
            this.btnNavUniversities = new System.Windows.Forms.Button();
            this.btnNavPosts = new System.Windows.Forms.Button();
            this.btnNavMessages = new System.Windows.Forms.Button();
            this.btnNavEvents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNav.SuspendLayout();
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
            this.panelNav.Size = new System.Drawing.Size(293, 807);
            this.panelNav.TabIndex = 0;
            // labels and nav buttons (same pattern as other nav forms)
            this.lblNavTitle.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.lblNavTitle.Location = new System.Drawing.Point(21, 25);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(253, 37);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "CampusConnect";
            // Nav buttons
            int[] navY = {86,145,204,263,322,381,440};
            string[] navTxt = {"Profile","Search","Connections","Universities","Posts","Messages","Events"};
            System.Windows.Forms.Button[] navBtns = {this.btnNavProfile,this.btnNavSearch,this.btnNavConnections,this.btnNavUniversities,this.btnNavPosts,this.btnNavMessages,this.btnNavEvents};
            System.EventHandler[] navHandlers = {new System.EventHandler(btnNavProfile_Click),new System.EventHandler(btnNavSearch_Click),new System.EventHandler(btnNavConnections_Click),new System.EventHandler(btnNavUniversities_Click),new System.EventHandler(btnNavPosts_Click),new System.EventHandler(btnNavMessages_Click),new System.EventHandler(btnNavEvents_Click)};
            for(int i=0;i<7;i++){
                navBtns[i].BackColor = i==3 ? System.Drawing.Color.FromArgb(52,193,164) : System.Drawing.Color.FromArgb(68,72,71);
                navBtns[i].FlatAppearance.BorderSize=0; navBtns[i].FlatStyle=System.Windows.Forms.FlatStyle.Flat;
                navBtns[i].Font=new System.Drawing.Font("Montserrat Medium",10F,System.Drawing.FontStyle.Bold);
                navBtns[i].ForeColor=System.Drawing.Color.White;
                navBtns[i].Location=new System.Drawing.Point(21,navY[i]);
                navBtns[i].Name="btn"+navTxt[i]; navBtns[i].Size=new System.Drawing.Size(251,49);
                navBtns[i].Text=navTxt[i]; navBtns[i].TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
                navBtns[i].UseVisualStyleBackColor=false;
                navBtns[i].TabIndex=i+1;
                navBtns[i].Click+=navHandlers[i];
            }
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 0; this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.btnLogout.Location = new System.Drawing.Point(21, 738);
            this.btnLogout.Name = "btnLogout"; this.btnLogout.Size = new System.Drawing.Size(147, 47);
            this.btnLogout.TabIndex = 9; this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // lblPageTitle
            this.lblPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(313, 26);
            this.lblPageTitle.Name = "lblPageTitle"; this.lblPageTitle.TabIndex = 10;
            this.lblPageTitle.Text = "Universities";
            // flowPanel - scrollable list of university cards
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.WrapContents = false;
            this.flowPanel.Location = new System.Drawing.Point(313, 80);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1247, 700);
            this.flowPanel.TabIndex = 11;
            // Form












            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.flowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        this.Name = "University"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Universities";
            this.Load += new System.EventHandler(this.University_Load);
            this.panelNav.ResumeLayout(false);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false); this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label lblNavTitle, lblPageTitle;
        private System.Windows.Forms.Button btnNavProfile, btnNavSearch, btnNavConnections, btnNavUniversities, btnNavPosts, btnNavMessages, btnNavEvents, btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}
