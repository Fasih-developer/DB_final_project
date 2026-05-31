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
            this.btnThemeToggle = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelSidebar.Controls.Add(this.lblSideTitle);
            this.panelSidebar.Controls.Add(this.btnExit);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(373, 807);
            this.panelSidebar.TabIndex = 0;
            // lblSideTitle
            this.lblSideTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblSideTitle.ForeColor = System.Drawing.Color.White;
            this.lblSideTitle.Location = new System.Drawing.Point(27, 295);
            this.lblSideTitle.Name = "lblSideTitle";
            this.lblSideTitle.Size = new System.Drawing.Size(320, 123);
            this.lblSideTitle.TabIndex = 0;
            this.lblSideTitle.Text = "Create\r\nAccount";
            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(27, 738);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 47);
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
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.cmbUni);
            this.panelCard.Controls.Add(this.label2);
            this.panelCard.Controls.Add(this.cmbDept);
            this.panelCard.Controls.Add(this.lblGender);
            this.panelCard.Controls.Add(this.cmbGender);
            this.panelCard.Controls.Add(this.lblAge);
            this.panelCard.Controls.Add(this.txtAge);
            this.panelCard.Controls.Add(this.btnSignUp);
            this.panelCard.Location = new System.Drawing.Point(420, 30);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(740, 750);
            this.panelCard.TabIndex = 1;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCard_Paint);
            // lblCardTitle
            this.lblCardTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.Location = new System.Drawing.Point(40, 22);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(300, 44);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Sign Up";
            // lblCardSubtitle
            this.lblCardSubtitle.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblCardSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblCardSubtitle.Location = new System.Drawing.Point(40, 68);
            this.lblCardSubtitle.Name = "lblCardSubtitle";
            this.lblCardSubtitle.Size = new System.Drawing.Size(300, 24);
            this.lblCardSubtitle.TabIndex = 1;
            this.lblCardSubtitle.Text = "Join Campus Connect today";
            // Full Name
            this.lblFullName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(40, 102);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(200, 24);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(40, 128);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(650, 30);
            this.txtFullName.TabIndex = 3;
            // Email
            this.lblEmail.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(40, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(200, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(40, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(650, 30);
            this.txtEmail.TabIndex = 5;
            // Username
            this.lblUsername.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(40, 242);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 24);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(40, 268);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(650, 30);
            this.txtUsername.TabIndex = 7;
            // Password
            this.lblPassword.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(40, 312);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 24);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(40, 338);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(650, 30);
            this.txtPassword.TabIndex = 9;
            // University
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "University";
            this.cmbUni.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.cmbUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUni.Font = new System.Drawing.Font("Montserrat", 9F);
            this.cmbUni.ForeColor = System.Drawing.Color.White;
            this.cmbUni.FormattingEnabled = true;
            this.cmbUni.Location = new System.Drawing.Point(40, 408);
            this.cmbUni.Name = "cmbUni";
            this.cmbUni.Size = new System.Drawing.Size(310, 28);
            this.cmbUni.TabIndex = 11;
            this.cmbUni.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // Department
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(380, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Department";
            this.cmbDept.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.cmbDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDept.Font = new System.Drawing.Font("Montserrat", 9F);
            this.cmbDept.ForeColor = System.Drawing.Color.White;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(380, 408);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(310, 28);
            this.cmbDept.TabIndex = 13;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // Gender
            this.lblGender.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(40, 450);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(200, 24);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.Font = new System.Drawing.Font("Montserrat", 9F);
            this.cmbGender.ForeColor = System.Drawing.Color.White;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(40, 476);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(310, 28);
            this.cmbGender.TabIndex = 15;
            // Populate gender from lookups table (Male=1, Female=2)
            this.cmbGender.Items.Add(new { Text = "Male",   Value = "1" });
            this.cmbGender.Items.Add(new { Text = "Female", Value = "2" });
            this.cmbGender.DisplayMember = "Text";
            this.cmbGender.ValueMember   = "Value";
            // Age
            this.lblAge.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(380, 450);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(200, 24);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Age";
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtAge.ForeColor = System.Drawing.Color.White;
            this.txtAge.Location = new System.Drawing.Point(380, 476);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(310, 30);
            this.txtAge.TabIndex = 17;
            // Sign Up button
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(40, 530);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(180, 50);
            this.btnSignUp.TabIndex = 18;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // Form
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
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1200, 807);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.btnThemeToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
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
        private System.Windows.Forms.Label lblCardTitle, lblCardSubtitle;
        private System.Windows.Forms.Label lblFullName, lblEmail, lblUsername, lblPassword;
        private System.Windows.Forms.TextBox txtFullName, txtEmail, txtUsername, txtPassword;
        private System.Windows.Forms.Label label1, label2;
        private System.Windows.Forms.ComboBox cmbUni, cmbDept;
        private System.Windows.Forms.Label lblGender, lblAge;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnThemeToggle;
    }
}
