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
            this.lblPageTitle.Size = new System.Drawing.Size(263, 53);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "My Education";
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
            // btnAddMore
            // 
            this.btnAddMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnAddMore.FlatAppearance.BorderSize = 0;
            this.btnAddMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMore.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMore.ForeColor = System.Drawing.Color.White;
            this.btnAddMore.Location = new System.Drawing.Point(1360, 37);
            this.btnAddMore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(173, 49);
            this.btnAddMore.TabIndex = 2;
            this.btnAddMore.Text = "+ Add More";
            this.btnAddMore.UseVisualStyleBackColor = false;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelContent.Controls.Add(this.lblPlaceholder);
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Location = new System.Drawing.Point(53, 116);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1480, 591);
            this.panelContent.TabIndex = 3;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblPlaceholder.Location = new System.Drawing.Point(27, 25);
            this.lblPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(1413, 37);
            this.lblPlaceholder.TabIndex = 0;
            this.lblPlaceholder.Text = "My Education will appear here...";
            // 
            // Education
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.Name = "Education";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Education";
            this.Load += new System.EventHandler(this.Education_Load);
            this.panelContent.ResumeLayout(false);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
