namespace CampusConnect.Forms
{
    partial class Add_event
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblInstitute = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblStartYear = new System.Windows.Forms.Label();
            this.lblEndYear = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cmbUniversity = new System.Windows.Forms.ComboBox();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(38, 26);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(167, 42);
            this.lblPageTitle.TabIndex = 3;
            this.lblPageTitle.Text = "Add Event";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 668);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Go Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.panelCard.Controls.Add(this.cmbUniversity);
            this.panelCard.Controls.Add(this.dtpEventDate);
            this.panelCard.Controls.Add(this.btnSaveEvent);
            this.panelCard.Controls.Add(this.txtEventTitle);
            this.panelCard.Controls.Add(this.txtDescription);
            this.panelCard.Controls.Add(this.lblInstitute);
            this.panelCard.Controls.Add(this.lblDegree);
            this.panelCard.Controls.Add(this.lblStartYear);
            this.panelCard.Controls.Add(this.lblEndYear);
            this.panelCard.Location = new System.Drawing.Point(319, 77);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(580, 541);
            this.panelCard.TabIndex = 5;
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(193)))), ((int)(((byte)(164)))));
            this.btnSaveEvent.FlatAppearance.BorderSize = 0;
            this.btnSaveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEvent.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveEvent.ForeColor = System.Drawing.Color.White;
            this.btnSaveEvent.Location = new System.Drawing.Point(26, 455);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(140, 44);
            this.btnSaveEvent.TabIndex = 99;
            this.btnSaveEvent.Text = "Add";
            this.btnSaveEvent.UseVisualStyleBackColor = false;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtEventTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventTitle.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtEventTitle.ForeColor = System.Drawing.Color.White;
            this.txtEventTitle.Location = new System.Drawing.Point(26, 76);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(500, 24);
            this.txtEventTitle.TabIndex = 1;
            this.txtEventTitle.TextChanged += new System.EventHandler(this.txtEventTitle_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(26, 146);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(500, 119);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblInstitute
            // 
            this.lblInstitute.AutoSize = true;
            this.lblInstitute.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstitute.ForeColor = System.Drawing.Color.White;
            this.lblInstitute.Location = new System.Drawing.Point(26, 50);
            this.lblInstitute.Name = "lblInstitute";
            this.lblInstitute.Size = new System.Drawing.Size(87, 22);
            this.lblInstitute.TabIndex = 0;
            this.lblInstitute.Text = "Event Title";
            this.lblInstitute.Click += new System.EventHandler(this.lblInstitute_Click);
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblDegree.ForeColor = System.Drawing.Color.White;
            this.lblDegree.Location = new System.Drawing.Point(26, 120);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(95, 22);
            this.lblDegree.TabIndex = 2;
            this.lblDegree.Text = "Description";
            this.lblDegree.Click += new System.EventHandler(this.lblDegree_Click);
            // 
            // lblStartYear
            // 
            this.lblStartYear.AutoSize = true;
            this.lblStartYear.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblStartYear.ForeColor = System.Drawing.Color.White;
            this.lblStartYear.Location = new System.Drawing.Point(26, 284);
            this.lblStartYear.Name = "lblStartYear";
            this.lblStartYear.Size = new System.Drawing.Size(45, 22);
            this.lblStartYear.TabIndex = 4;
            this.lblStartYear.Text = "Date";
            // 
            // lblEndYear
            // 
            this.lblEndYear.AutoSize = true;
            this.lblEndYear.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.lblEndYear.ForeColor = System.Drawing.Color.White;
            this.lblEndYear.Location = new System.Drawing.Point(26, 355);
            this.lblEndYear.Name = "lblEndYear";
            this.lblEndYear.Size = new System.Drawing.Size(56, 22);
            this.lblEndYear.TabIndex = 6;
            this.lblEndYear.Text = "Venue";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dtpEventDate.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Location = new System.Drawing.Point(26, 309);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(281, 23);
            this.dtpEventDate.TabIndex = 100;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cmbUniversity
            // 
            this.cmbUniversity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cmbUniversity.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUniversity.FormattingEnabled = true;
            this.cmbUniversity.ItemHeight = 20;
            this.cmbUniversity.Location = new System.Drawing.Point(26, 382);
            this.cmbUniversity.Name = "cmbUniversity";
            this.cmbUniversity.Size = new System.Drawing.Size(500, 28);
            this.cmbUniversity.TabIndex = 6;
            this.cmbUniversity.SelectedIndexChanged += new System.EventHandler(this.cmbUniversity_SelectedIndexChanged);
            // 
            // Add_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1238, 718);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelCard);
            this.Name = "Add_event";
            this.Text = "Add_event";
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblInstitute;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblStartYear;
        private System.Windows.Forms.Label lblEndYear;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox cmbUniversity;
    }
}