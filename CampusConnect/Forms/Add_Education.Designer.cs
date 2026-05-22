namespace CampusConnect.Forms
{
    partial class Add_Education
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
            this.txtInstitute = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.lblInstitute = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblStartYear = new System.Windows.Forms.Label();
            this.lblEndYear = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(53, 44);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(283, 53);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Add Education";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
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
            this.panelCard.Controls.Add(this.txtInstitute);
            this.panelCard.Controls.Add(this.txtDegree);
            this.panelCard.Controls.Add(this.txtStartYear);
            this.panelCard.Controls.Add(this.txtEndYear);
            this.panelCard.Controls.Add(this.lblInstitute);
            this.panelCard.Controls.Add(this.lblDegree);
            this.panelCard.Controls.Add(this.lblStartYear);
            this.panelCard.Controls.Add(this.lblEndYear);
            this.panelCard.Location = new System.Drawing.Point(400, 90);
            this.panelCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(773, 628);
            this.panelCard.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(40, 529);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 54);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInstitute
            // 
            this.txtInstitute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtInstitute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstitute.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtInstitute.ForeColor = System.Drawing.Color.White;
            this.txtInstitute.Location = new System.Drawing.Point(40, 143);
            this.txtInstitute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInstitute.Name = "txtInstitute";
            this.txtInstitute.Size = new System.Drawing.Size(666, 28);
            this.txtInstitute.TabIndex = 1;
            // 
            // txtDegree
            // 
            this.txtDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtDegree.ForeColor = System.Drawing.Color.White;
            this.txtDegree.Location = new System.Drawing.Point(40, 241);
            this.txtDegree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(666, 28);
            this.txtDegree.TabIndex = 3;
            // 
            // txtStartYear
            // 
            this.txtStartYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtStartYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartYear.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtStartYear.ForeColor = System.Drawing.Color.White;
            this.txtStartYear.Location = new System.Drawing.Point(40, 340);
            this.txtStartYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(666, 28);
            this.txtStartYear.TabIndex = 5;
            // 
            // txtEndYear
            // 
            this.txtEndYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtEndYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndYear.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtEndYear.ForeColor = System.Drawing.Color.White;
            this.txtEndYear.Location = new System.Drawing.Point(40, 438);
            this.txtEndYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(666, 28);
            this.txtEndYear.TabIndex = 7;
            // 
            // lblInstitute
            // 
            this.lblInstitute.AutoSize = true;
            this.lblInstitute.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstitute.ForeColor = System.Drawing.Color.White;
            this.lblInstitute.Location = new System.Drawing.Point(40, 111);
            this.lblInstitute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstitute.Name = "lblInstitute";
            this.lblInstitute.Size = new System.Drawing.Size(150, 26);
            this.lblInstitute.TabIndex = 0;
            this.lblInstitute.Text = "Institute Name";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblDegree.ForeColor = System.Drawing.Color.White;
            this.lblDegree.Location = new System.Drawing.Point(40, 209);
            this.lblDegree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(77, 26);
            this.lblDegree.TabIndex = 2;
            this.lblDegree.Text = "Degree";
            // 
            // lblStartYear
            // 
            this.lblStartYear.AutoSize = true;
            this.lblStartYear.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblStartYear.ForeColor = System.Drawing.Color.White;
            this.lblStartYear.Location = new System.Drawing.Point(40, 308);
            this.lblStartYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartYear.Name = "lblStartYear";
            this.lblStartYear.Size = new System.Drawing.Size(100, 26);
            this.lblStartYear.TabIndex = 4;
            this.lblStartYear.Text = "Start Year";
            // 
            // lblEndYear
            // 
            this.lblEndYear.AutoSize = true;
            this.lblEndYear.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblEndYear.ForeColor = System.Drawing.Color.White;
            this.lblEndYear.Location = new System.Drawing.Point(40, 406);
            this.lblEndYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndYear.Name = "lblEndYear";
            this.lblEndYear.Size = new System.Drawing.Size(92, 26);
            this.lblEndYear.TabIndex = 6;
            this.lblEndYear.Text = "End Year";
            // 
            // Add_Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1573, 807);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Add_Education";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Education";
            this.Load += new System.EventHandler(this.Add_Education_Load);
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
        private System.Windows.Forms.Label lblInstitute;
        private System.Windows.Forms.TextBox txtInstitute;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Label lblStartYear;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.Label lblEndYear;
        private System.Windows.Forms.TextBox txtEndYear;
    }
}
