namespace CampusConnect.Forms
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.lblAdminDesc = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUserDesc = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelAdmin.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(390, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Campus Connect";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblSubtitle.Location = new System.Drawing.Point(460, 122);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(260, 22);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Select your access point";
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelAdmin.Controls.Add(this.lblAdminTitle);
            this.panelAdmin.Controls.Add(this.lblAdminDesc);
            this.panelAdmin.Controls.Add(this.btnAdmin);
            this.panelAdmin.Location = new System.Drawing.Point(160, 200);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(380, 280);
            this.panelAdmin.TabIndex = 2;
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblAdminTitle.ForeColor = System.Drawing.Color.White;
            this.lblAdminTitle.Location = new System.Drawing.Point(30, 40);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Size = new System.Drawing.Size(200, 36);
            this.lblAdminTitle.TabIndex = 0;
            this.lblAdminTitle.Text = "Admin Panel";
            // 
            // lblAdminDesc
            // 
            this.lblAdminDesc.Font = new System.Drawing.Font("Montserrat", 9.5F);
            this.lblAdminDesc.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblAdminDesc.Location = new System.Drawing.Point(30, 90);
            this.lblAdminDesc.Name = "lblAdminDesc";
            this.lblAdminDesc.Size = new System.Drawing.Size(310, 80);
            this.lblAdminDesc.TabIndex = 1;
            this.lblAdminDesc.Text = "Manage users, view reports and oversee platform activity.";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(30, 200);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(140, 42);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Enter";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelUser.Controls.Add(this.lblUserTitle);
            this.panelUser.Controls.Add(this.lblUserDesc);
            this.panelUser.Controls.Add(this.btnUser);
            this.panelUser.Location = new System.Drawing.Point(640, 200);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(380, 280);
            this.panelUser.TabIndex = 3;
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblUserTitle.ForeColor = System.Drawing.Color.White;
            this.lblUserTitle.Location = new System.Drawing.Point(30, 40);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(200, 36);
            this.lblUserTitle.TabIndex = 0;
            this.lblUserTitle.Text = "User Panel";
            // 
            // lblUserDesc
            // 
            this.lblUserDesc.Font = new System.Drawing.Font("Montserrat", 9.5F);
            this.lblUserDesc.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblUserDesc.Location = new System.Drawing.Point(30, 90);
            this.lblUserDesc.Name = "lblUserDesc";
            this.lblUserDesc.Size = new System.Drawing.Size(310, 80);
            this.lblUserDesc.TabIndex = 1;
            this.lblUserDesc.Text = "Access your profile, connect with peers and explore opportunities.";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(30, 200);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(140, 42);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Enter";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(30, 590);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campus Connect";
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Label lblAdminDesc;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUserDesc;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnExit;
    }
}
