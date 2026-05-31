using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Certificates : Form
    {
        public Certificates() {
            ApplyTheme(); InitializeComponent(); }
        private void Certificates_Load(object sender, EventArgs e) { LoadCertificates(); }

        private void LoadCertificates()
        {
            try
            {
                panelContent.Controls.Clear();
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();
                string query = @"SELECT CertificateName, IssuingOrganization, DateEarned 
                                 FROM certifications 
                                 INNER JOIN user_profiles up ON certifications.ProfileID = up.ProfileID
                                 WHERE up.AccountID = @accountID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 12; bool has = false;
                while (reader.Read())
                {
                    has = true;
                    Panel card = CreateCard(y);
                    AddRow(card, "Certificate", reader["CertificateName"].ToString(), 12);
                    AddRow(card, "Organization", reader["IssuingOrganization"].ToString(), 50);
                    AddRow(card, "Date Earned", Convert.ToDateTime(reader["DateEarned"]).ToString("dd MMM yyyy"), 88);
                    card.Height = 134;
                    panelContent.Controls.Add(card);
                    y += 148;
                }
                reader.Close(); con.Close();
                if (!has) AddEmpty(panelContent, "No certificates added yet.");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private Panel CreateCard(int y)
        {
            Panel card = new Panel();
            card.BackColor = System.Drawing.Color.FromArgb(56, 60, 60);
            card.Location = new System.Drawing.Point(12, y);
            card.Width = panelContent.Width - 30;
            return card;
        }

        private void AddRow(Panel card, string label, string value, int top)
        {
            Label lbl = new Label();
            lbl.Text = label + ":";
            lbl.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(52, 193, 164);
            lbl.Location = new Point(14, top);
            lbl.Size = new Size(160, 26);
            card.Controls.Add(lbl);

            Label val = new Label();
            val.Text = value;
            val.Font = new Font("Montserrat", 10F);
            val.ForeColor = Color.White;
            val.Location = new Point(180, top);
            val.Size = new Size(card.Width - 200, 26);
            card.Controls.Add(val);
        }

        private void AddEmpty(Panel p, string msg)
        {
            Label lbl = new Label();
            lbl.Text = msg;
            lbl.Font = new Font("Montserrat", 11F);
            lbl.ForeColor = Color.FromArgb(120, 120, 120);
            lbl.Location = new Point(16, 16);
            lbl.AutoSize = true;
            p.Controls.Add(lbl);
        }

        private void btnExit_Click(object sender, EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnAddMore_Click(object sender, EventArgs e) { new Add_Certifications().Show(); this.Hide(); }
        private void ApplyTheme()
        {
            ThemeManager.Apply(this);
            if (btnThemeToggle != null)
                btnThemeToggle.Text = ThemeManager.ToggleButtonLabel;
        }

        private void btnThemeToggle_Click(object sender, EventArgs e)
        {
            ThemeManager.Toggle();
            ApplyTheme();
        }

    }
}
