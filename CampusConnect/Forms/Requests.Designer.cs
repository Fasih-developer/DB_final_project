namespace CampusConnect.Forms
{
    partial class Requests
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnExit      = new System.Windows.Forms.Button();
            this.flowRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // lblPageTitle
            this.lblPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(40, 30);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Connection Requests";
            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            this.btnExit.Location = new System.Drawing.Point(40, 738);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // flowRequests
            this.flowRequests.AutoScroll = true;
            this.flowRequests.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.flowRequests.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowRequests.WrapContents = false;
            this.flowRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flowRequests.Location = new System.Drawing.Point(40, 96);
            this.flowRequests.Name = "flowRequests";
            this.flowRequests.Size = new System.Drawing.Size(1520, 620);
            this.flowRequests.TabIndex = 2;
            // Form












            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(44, 49, 49);
            this.ClientSize = new System.Drawing.Size(1600, 807);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.flowRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        this.Name = "Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Requests";
            this.Load += new System.EventHandler(this.Requests_Load);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel flowRequests;
    }
}
