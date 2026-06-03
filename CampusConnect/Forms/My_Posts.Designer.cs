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
            this.btnNewPost   = new System.Windows.Forms.Button();
            this.btnExit      = new System.Windows.Forms.Button();
            this.flowPosts    = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // lblPageTitle
            this.lblPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(40, 30);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "My Posts";
            // btnNewPost
            this.btnNewPost.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
            this.btnNewPost.FlatAppearance.BorderSize = 0;
            this.btnNewPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPost.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewPost.ForeColor = System.Drawing.Color.White;
            this.btnNewPost.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnNewPost.Location = new System.Drawing.Point(1400, 26);
            this.btnNewPost.Name = "btnNewPost";
            this.btnNewPost.Size = new System.Drawing.Size(160, 46);
            this.btnNewPost.TabIndex = 1;
            this.btnNewPost.Text = "+ New Post";
            this.btnNewPost.UseVisualStyleBackColor = false;
            this.btnNewPost.Click += new System.EventHandler(this.btnNewPost_Click);
            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.btnExit.Location = new System.Drawing.Point(40, 734);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // flowPosts - scrollable list of post cards
            this.flowPosts.AutoScroll = true;
            this.flowPosts.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.flowPosts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPosts.WrapContents = false;
            this.flowPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPosts.Location = new System.Drawing.Point(40, 100);
            this.flowPosts.Name = "flowPosts";
            this.flowPosts.Size = new System.Drawing.Size(1520, 610);
            this.flowPosts.TabIndex = 3;
            // Form












            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1600, 807);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnNewPost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.flowPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        this.Name = "My_Posts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Posts";
            this.Load += new System.EventHandler(this.My_Posts_Load);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnNewPost, btnExit;
        private System.Windows.Forms.FlowLayoutPanel flowPosts;
    }
}
