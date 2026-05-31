using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Internship : Form
    {
        public Internship() {
            ApplyTheme(); InitializeComponent(); }
        private void Internship_Load(object sender, EventArgs e) { LoadInternships(); }

        private void LoadInternships()
        {
            try
            {
                panelContent.Controls.Clear();
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();
                string query = @"SELECT CompanyName, JobRole, Description, StartDate, EndDate 
                                 FROM internships 
                                 WHERE ProfileID = (SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 12; bool has = false;
                while (reader.Read())
                {
                    has = true;
                    Panel card = new Panel();
                    card.BackColor = Color.FromArgb(56, 60, 60);
                    card.Location = new Point(12, y);
                    card.Width = panelContent.Width - 30;
                    card.Height = 160;

                    AddLP(card, "Company",     reader["CompanyName"].ToString(), 12);
                    AddLP(card, "Role",        reader["JobRole"].ToString(), 50);
                    AddLP(card, "Description", reader["Description"].ToString(), 88);
                    AddLP(card, "Period",      Convert.ToDateTime(reader["StartDate"]).ToString("dd MMM yyyy") + " — " + Convert.ToDateTime(reader["EndDate"]).ToString("dd MMM yyyy"), 126);

                    panelContent.Controls.Add(card);
                    y += 174;
                }
                reader.Close(); con.Close();
                if (!has) { Label l = new Label(); l.Text = "No internships added yet."; l.Font = new Font("Montserrat", 11F); l.ForeColor = Color.FromArgb(120, 120, 120); l.Location = new Point(16, 16); l.AutoSize = true; panelContent.Controls.Add(l); }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void AddLP(Panel card, string label, string value, int top)
        {
            Label lbl = new Label(); lbl.Text = label + ":"; lbl.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold); lbl.ForeColor = Color.FromArgb(52, 193, 164); lbl.Location = new Point(14, top); lbl.Size = new Size(120, 26); card.Controls.Add(lbl);
            Label val = new Label(); val.Text = value; val.Font = new Font("Montserrat", 10F); val.ForeColor = Color.White; val.Location = new Point(144, top); val.Size = new Size(card.Width - 160, 26); card.Controls.Add(val);
        }

        private void btnExit_Click(object sender, EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnAddMore_Click(object sender, EventArgs e) { new Add_Internships().Show(); this.Hide(); }
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
