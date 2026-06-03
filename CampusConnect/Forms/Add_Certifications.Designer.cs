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
            this.txtCertName = new System.Windows.Forms.TextBox();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.txtDateEarned = new System.Windows.Forms.TextBox();
            this.lblCertName = new System.Windows.Forms.Label();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.lblDateEarned = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(53, 44);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(289, 53);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Add Certificate";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.btnExit.Location = new System.Drawing.Point(53, 734);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelCard.Controls.Add(this.btnAdd);
            this.panelCard.Controls.Add(this.txtCertName);
            this.panelCard.Controls.Add(this.txtOrgName);
            this.panelCard.Controls.Add(this.txtDateEarned);
            this.panelCard.Controls.Add(this.lblCertName);
            this.panelCard.Controls.Add(this.lblOrgName);
            this.panelCard.Controls.Add(this.lblDateEarned);
            this.panelCard.Location = new System.Drawing.Point(400, 139);
            this.panelCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(773, 529);
            this.panelCard.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(40, 431);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 54);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCertName
            // 
            this.txtCertName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtCertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCertName.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtCertName.ForeColor = System.Drawing.Color.White;
            this.txtCertName.Location = new System.Drawing.Point(40, 143);
            this.txtCertName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCertName.Name = "txtCertName";
            this.txtCertName.Size = new System.Drawing.Size(666, 28);
            this.txtCertName.TabIndex = 1;
            // 
            // txtOrgName
            // 
            this.txtOrgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtOrgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrgName.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtOrgName.ForeColor = System.Drawing.Color.White;
            this.txtOrgName.Location = new System.Drawing.Point(40, 241);
            this.txtOrgName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(666, 28);
            this.txtOrgName.TabIndex = 3;
            // 
            // txtDateEarned
            // 
            this.txtDateEarned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtDateEarned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateEarned.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtDateEarned.ForeColor = System.Drawing.Color.White;
            this.txtDateEarned.Location = new System.Drawing.Point(40, 340);
            this.txtDateEarned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDateEarned.Name = "txtDateEarned";
            this.txtDateEarned.Size = new System.Drawing.Size(666, 28);
            this.txtDateEarned.TabIndex = 5;
            // 
            // lblCertName
            // 
            this.lblCertName.AutoSize = true;
            this.lblCertName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblCertName.ForeColor = System.Drawing.Color.White;
            this.lblCertName.Location = new System.Drawing.Point(40, 111);
            this.lblCertName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCertName.Name = "lblCertName";
            this.lblCertName.Size = new System.Drawing.Size(164, 26);
            this.lblCertName.TabIndex = 0;
            this.lblCertName.Text = "Certificate Name";
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrgName.ForeColor = System.Drawing.Color.White;
            this.lblOrgName.Location = new System.Drawing.Point(40, 209);
            this.lblOrgName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(186, 26);
            this.lblOrgName.TabIndex = 2;
            this.lblOrgName.Text = "Organization Name";
            // 
            // lblDateEarned
            // 
            this.lblDateEarned.AutoSize = true;
            this.lblDateEarned.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateEarned.ForeColor = System.Drawing.Color.White;
            this.lblDateEarned.Location = new System.Drawing.Point(40, 308);
            this.lblDateEarned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEarned.Name = "lblDateEarned";
            this.lblDateEarned.Size = new System.Drawing.Size(125, 26);
            this.lblDateEarned.TabIndex = 4;
            this.lblDateEarned.Text = "Date Earned";
            // 
            // Add_Certifications
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.Name = "Add_Certifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Certificate";
            this.Load += new System.EventHandler(this.Add_Certifications_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
