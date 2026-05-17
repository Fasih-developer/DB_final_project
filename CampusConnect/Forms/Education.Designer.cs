namespace CampusConnect.Forms
{
    partial class Education
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
            this.btnAddMore = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(40, 36);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "My Education";
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
            this.btnAddMore.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnAddMore.FlatAppearance.BorderSize = 0;
            this.btnAddMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMore.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMore.ForeColor = System.Drawing.Color.White;
            this.btnAddMore.Location = new System.Drawing.Point(1020, 30);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(130, 40);
            this.btnAddMore.TabIndex = 2;
            this.btnAddMore.Text = "+ Add More";
            this.btnAddMore.UseVisualStyleBackColor = false;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            this.panelContent.Controls.Add(this.lblPlaceholder);
            this.panelContent.Location = new System.Drawing.Point(40, 94);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1110, 480);
            this.panelContent.TabIndex = 3;
            this.lblPlaceholder.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblPlaceholder.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblPlaceholder.Location = new System.Drawing.Point(20, 20);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(1060, 30);
            this.lblPlaceholder.TabIndex = 0;
            this.lblPlaceholder.Text = "My Education will appear here...";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Education";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Education";
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblPlaceholder;
    }
}
