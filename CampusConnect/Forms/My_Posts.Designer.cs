namespace CampusConnect.Forms
{
    partial class My_Posts
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
            this.btnNewPost = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.lblPageTitle.Text = "My Posts";
            this.btnNewPost.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnNewPost.FlatAppearance.BorderSize = 0;
            this.btnNewPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPost.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewPost.ForeColor = System.Drawing.Color.White;
            this.btnNewPost.Location = new System.Drawing.Point(1020, 30);
            this.btnNewPost.Name = "btnNewPost";
            this.btnNewPost.Size = new System.Drawing.Size(130, 40);
            this.btnNewPost.TabIndex = 1;
            this.btnNewPost.Text = "+ New Post";
            this.btnNewPost.UseVisualStyleBackColor = false;
            this.btnNewPost.Click += new System.EventHandler(this.btnNewPost_Click);
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(40, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.lblPlaceholder.Text = "Your posts will appear here...";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnNewPost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "My_Posts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Posts";
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnNewPost;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblPlaceholder;
    }
}
