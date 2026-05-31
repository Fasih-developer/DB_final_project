namespace CampusConnect.Forms
{
    partial class CampusConnectform
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
            this.btnThemeToggle = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.lblCreateTitle = new System.Windows.Forms.Label();
            this.lblCreateDesc = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.lblSignInTitle = new System.Windows.Forms.Label();
            this.lblSignInDesc = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.panelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelSidebar.Controls.Add(this.lblSideTitle);
            this.panelSidebar.Controls.Add(this.btnExit);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(373, 807);
            this.panelSidebar.TabIndex = 0;
            // 
            // lblSideTitle
            // 
            this.lblSideTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblSideTitle.ForeColor = System.Drawing.Color.White;
            this.lblSideTitle.Location = new System.Drawing.Point(27, 295);
            this.lblSideTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSideTitle.Name = "lblSideTitle";
            this.lblSideTitle.Size = new System.Drawing.Size(320, 123);
            this.lblSideTitle.TabIndex = 0;
            this.lblSideTitle.Text = "Campus\r\nConnect";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(27, 738);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(427, 74);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(240, 68);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Welcome";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblSubtitle.Location = new System.Drawing.Point(429, 138);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(327, 29);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "How would you like to continue?";
            // 
            // panelCreate
            // 
            this.panelCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelCreate.Controls.Add(this.lblCreateTitle);
            this.panelCreate.Controls.Add(this.lblCreateDesc);
            this.panelCreate.Controls.Add(this.btnCreateAccount);
            this.panelCreate.Location = new System.Drawing.Point(427, 197);
            this.panelCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(507, 345);
            this.panelCreate.TabIndex = 3;
            // 
            // lblCreateTitle
            // 
            this.lblCreateTitle.AutoSize = true;
            this.lblCreateTitle.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold);
            this.lblCreateTitle.ForeColor = System.Drawing.Color.White;
            this.lblCreateTitle.Location = new System.Drawing.Point(32, 37);
            this.lblCreateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.Size = new System.Drawing.Size(232, 42);
            this.lblCreateTitle.TabIndex = 0;
            this.lblCreateTitle.Text = "Create Account";
            // 
            // lblCreateDesc
            // 
            this.lblCreateDesc.Font = new System.Drawing.Font("Montserrat", 9.5F);
            this.lblCreateDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblCreateDesc.Location = new System.Drawing.Point(32, 89);
            this.lblCreateDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateDesc.Name = "lblCreateDesc";
            this.lblCreateDesc.Size = new System.Drawing.Size(427, 98);
            this.lblCreateDesc.TabIndex = 1;
            this.lblCreateDesc.Text = "New here? Create your account and join the community.";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(32, 258);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(213, 52);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Get Started";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelSignIn.Controls.Add(this.lblSignInTitle);
            this.panelSignIn.Controls.Add(this.lblSignInDesc);
            this.panelSignIn.Controls.Add(this.btnSignIn);
            this.panelSignIn.Location = new System.Drawing.Point(973, 197);
            this.panelSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(507, 345);
            this.panelSignIn.TabIndex = 4;
            // 
            // lblSignInTitle
            // 
            this.lblSignInTitle.AutoSize = true;
            this.lblSignInTitle.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold);
            this.lblSignInTitle.ForeColor = System.Drawing.Color.White;
            this.lblSignInTitle.Location = new System.Drawing.Point(32, 37);
            this.lblSignInTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignInTitle.Name = "lblSignInTitle";
            this.lblSignInTitle.Size = new System.Drawing.Size(113, 42);
            this.lblSignInTitle.TabIndex = 0;
            this.lblSignInTitle.Text = "Sign In";
            // 
            // lblSignInDesc
            // 
            this.lblSignInDesc.Font = new System.Drawing.Font("Montserrat", 9.5F);
            this.lblSignInDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblSignInDesc.Location = new System.Drawing.Point(32, 89);
            this.lblSignInDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignInDesc.Name = "lblSignInDesc";
            this.lblSignInDesc.Size = new System.Drawing.Size(427, 98);
            this.lblSignInDesc.TabIndex = 1;
            this.lblSignInDesc.Text = "Already have an account? Sign in and continue.";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(32, 258);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(213, 52);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // CampusConnectform
            // 
            this.btnThemeToggle.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.btnThemeToggle.FlatAppearance.BorderSize = 0;
            this.btnThemeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeToggle.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemeToggle.ForeColor = System.Drawing.Color.White;
            this.btnThemeToggle.Location = new System.Drawing.Point(1440, 14);
            this.btnThemeToggle.Name = "btnThemeToggle";
            this.btnThemeToggle.Size = new System.Drawing.Size(110, 34);
            this.btnThemeToggle.TabIndex = 199;
            this.btnThemeToggle.Text = "\u2600 Light";
            this.btnThemeToggle.UseVisualStyleBackColor = false;
            this.btnThemeToggle.Click += new System.EventHandler(this.btnThemeToggle_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.panelCreate);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.btnThemeToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CampusConnectform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campus Connect";
            this.Load += new System.EventHandler(this.CampusConnectform_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSideTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.Label lblCreateDesc;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Label lblSignInTitle;
        private System.Windows.Forms.Label lblSignInDesc;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnThemeToggle;
    }
}
