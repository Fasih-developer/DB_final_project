namespace CampusConnect.Forms
{
    partial class Add_Skills
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
            this.lblSkillName = new System.Windows.Forms.Label();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(40, 36);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Add Skill";
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
            this.panelCard.Controls.Add(this.txtSkillName);
            this.panelCard.Controls.Add(this.lblSkillName);
            this.panelCard.Location = new System.Drawing.Point(300, 193);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(580, 270);
            this.panelCard.TabIndex = 2;
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblSkillName.ForeColor = System.Drawing.Color.White;
            this.lblSkillName.Location = new System.Drawing.Point(30, 90);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.TabIndex = 0;
            this.lblSkillName.Text = "Skill Name";
            this.txtSkillName.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtSkillName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkillName.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtSkillName.ForeColor = System.Drawing.Color.White;
            this.txtSkillName.Location = new System.Drawing.Point(30, 116);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(500, 32);
            this.txtSkillName.TabIndex = 1;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 190);
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
            this.Name = "Add_Skills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Skill";
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
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.TextBox txtSkillName;
    }
}
