namespace CampusConnect.Forms
{
    partial class SignUp
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblCardSubtitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelCard.SuspendLayout();
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
            this.lblSideTitle.Location = new System.Drawing.Point(20, 240);
            this.lblSideTitle.Name = "lblSideTitle";
            this.lblSideTitle.Size = new System.Drawing.Size(240, 100);
            this.lblSideTitle.TabIndex = 0;
            this.lblSideTitle.Text = "Create\r\nAccount";
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
            this.panelCard.Controls.Add(this.lblFullName);
            this.panelCard.Controls.Add(this.txtFullName);
            this.panelCard.Controls.Add(this.lblEmail);
            this.panelCard.Controls.Add(this.txtEmail);
            this.panelCard.Controls.Add(this.lblUsername);
            this.panelCard.Controls.Add(this.txtUsername);
            this.panelCard.Controls.Add(this.lblPassword);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.btnSignUp);
            this.panelCard.Location = new System.Drawing.Point(340, 60);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(500, 530);
            this.panelCard.TabIndex = 1;
            // lblCardTitle
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.Location = new System.Drawing.Point(30, 28);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Sign Up";
            // lblCardSubtitle
            this.lblCardSubtitle.AutoSize = true;
            this.lblCardSubtitle.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblCardSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblCardSubtitle.Location = new System.Drawing.Point(30, 62);
            this.lblCardSubtitle.Name = "lblCardSubtitle";
            this.lblCardSubtitle.TabIndex = 1;
            this.lblCardSubtitle.Text = "Join Campus Connect today";
            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(30, 100);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // txtFullName
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(30, 126);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(430, 32);
            this.txtFullName.TabIndex = 3;
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // txtEmail
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(30, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(430, 32);
            this.txtEmail.TabIndex = 5;
            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(30, 256);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // txtUsername
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(30, 282);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(430, 32);
            this.txtUsername.TabIndex = 7;
            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(30, 334);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // txtPassword
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(30, 360);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(430, 32);
            this.txtPassword.TabIndex = 9;
            // btnSignUp
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(30, 430);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(160, 46);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // SignUp
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.panelSidebar.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSideTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblCardSubtitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignUp;
    }
}
