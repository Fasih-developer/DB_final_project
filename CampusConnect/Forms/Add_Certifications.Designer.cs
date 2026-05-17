namespace CampusConnect.Forms
{
    partial class Add_Certifications
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCertName = new System.Windows.Forms.Label();
            this.txtCertName = new System.Windows.Forms.TextBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.lblDateEarned = new System.Windows.Forms.Label();
            this.txtDateEarned = new System.Windows.Forms.TextBox();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(40, 36);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Add Certificate";
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(40, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelCard.Controls.Add(this.btnAdd);
            this.panelCard.Controls.Add(this.txtCertName);
            this.panelCard.Controls.Add(this.txtOrgName);
            this.panelCard.Controls.Add(this.txtDateEarned);
            this.panelCard.Controls.Add(this.lblCertName);
            this.panelCard.Controls.Add(this.lblOrgName);
            this.panelCard.Controls.Add(this.lblDateEarned);
            this.panelCard.Location = new System.Drawing.Point(300, 113);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(580, 430);
            this.panelCard.TabIndex = 2;
            this.lblCertName.AutoSize = true;
            this.lblCertName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblCertName.ForeColor = System.Drawing.Color.White;
            this.lblCertName.Location = new System.Drawing.Point(30, 90);
            this.lblCertName.Name = "lblCertName";
            this.lblCertName.TabIndex = 0;
            this.lblCertName.Text = "Certificate Name";
            this.txtCertName.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtCertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCertName.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtCertName.ForeColor = System.Drawing.Color.White;
            this.txtCertName.Location = new System.Drawing.Point(30, 116);
            this.txtCertName.Name = "txtCertName";
            this.txtCertName.Size = new System.Drawing.Size(500, 32);
            this.txtCertName.TabIndex = 1;
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrgName.ForeColor = System.Drawing.Color.White;
            this.lblOrgName.Location = new System.Drawing.Point(30, 170);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.TabIndex = 2;
            this.lblOrgName.Text = "Organization Name";
            this.txtOrgName.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtOrgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrgName.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtOrgName.ForeColor = System.Drawing.Color.White;
            this.txtOrgName.Location = new System.Drawing.Point(30, 196);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(500, 32);
            this.txtOrgName.TabIndex = 3;
            this.lblDateEarned.AutoSize = true;
            this.lblDateEarned.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateEarned.ForeColor = System.Drawing.Color.White;
            this.lblDateEarned.Location = new System.Drawing.Point(30, 250);
            this.lblDateEarned.Name = "lblDateEarned";
            this.lblDateEarned.TabIndex = 4;
            this.lblDateEarned.Text = "Date Earned";
            this.txtDateEarned.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtDateEarned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateEarned.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtDateEarned.ForeColor = System.Drawing.Color.White;
            this.txtDateEarned.Location = new System.Drawing.Point(30, 276);
            this.txtDateEarned.Name = "txtDateEarned";
            this.txtDateEarned.Size = new System.Drawing.Size(500, 32);
            this.txtDateEarned.TabIndex = 5;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 44);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add_Certifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Certificate";
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCertName;
        private System.Windows.Forms.TextBox txtCertName;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Label lblDateEarned;
        private System.Windows.Forms.TextBox txtDateEarned;
    }
}
