namespace CampusConnect.Forms
{
    partial class New_Post
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
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnPost = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(40, 36);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "New Post";
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
            this.panelCard.Controls.Add(this.lblContent);
            this.panelCard.Controls.Add(this.txtContent);
            this.panelCard.Controls.Add(this.lblDate);
            this.panelCard.Controls.Add(this.dtpDate);
            this.panelCard.Controls.Add(this.btnPost);
            this.panelCard.Location = new System.Drawing.Point(280, 100);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(620, 420);
            this.panelCard.TabIndex = 2;
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(24, 24);
            this.lblContent.Name = "lblContent";
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "What's on your mind?";
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtContent.ForeColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(24, 56);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(572, 220);
            this.txtContent.TabIndex = 1;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(24, 300);
            this.lblDate.Name = "lblDate";
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            this.dtpDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Montserrat", 10F);
            this.dtpDate.Location = new System.Drawing.Point(24, 330);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(280, 28);
            this.dtpDate.TabIndex = 3;
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(24, 370);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(140, 44);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "New_Post";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Post";
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnPost;
    }
}
