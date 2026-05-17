namespace CampusConnect.Forms
{
    partial class admin_signin
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
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblCardSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);
            this.panelSidebar.Controls.Add(this.btnExit);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(280, 656);
            this.panelSidebar.TabIndex = 0;
            // lblSidebarTitle
            this.lblSidebarTitle.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(20, 260);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(240, 80);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Admin\r\nPortal";
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
            // panelCard
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelCard.Controls.Add(this.lblCardTitle);
            this.panelCard.Controls.Add(this.lblCardSubtitle);
            this.panelCard.Controls.Add(this.lblUsername);
            this.panelCard.Controls.Add(this.txtUsername);
            this.panelCard.Controls.Add(this.lblPassword);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.btnSignIn);
            this.panelCard.Location = new System.Drawing.Point(380, 140);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(440, 380);
            this.panelCard.TabIndex = 1;
            // lblCardTitle
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.Location = new System.Drawing.Point(30, 30);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Sign In";
            // lblCardSubtitle
            this.lblCardSubtitle.AutoSize = true;
            this.lblCardSubtitle.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblCardSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblCardSubtitle.Location = new System.Drawing.Point(30, 68);
            this.lblCardSubtitle.Name = "lblCardSubtitle";
            this.lblCardSubtitle.TabIndex = 1;
            this.lblCardSubtitle.Text = "Admin access only";
            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(30, 110);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // txtUsername
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(30, 140);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(370, 34);
            this.txtUsername.TabIndex = 3;
            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(30, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // txtPassword
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(30, 230);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(370, 34);
            this.txtPassword.TabIndex = 5;
            // btnSignIn
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(30, 300);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(160, 46);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // admin_signin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "admin_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Sign In";
            this.panelSidebar.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblCardSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
    }
}
