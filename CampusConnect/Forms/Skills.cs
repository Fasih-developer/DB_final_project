using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Skills : Form
    {
        public Skills() {
            ApplyTheme(); InitializeComponent(); }

        private void Skills_Load(object sender, EventArgs e) { LoadSkills(); }

        private void LoadSkills()
        {
            try
            {
                panelContent.Controls.Clear();
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();
                string query = @"SELECT s.SkillName 
                                 FROM skills s
                                 INNER JOIN profile_skills ps ON s.SkillID = ps.SkillID
                                 INNER JOIN user_profiles up ON ps.ProfileID = up.ProfileID
                                 WHERE up.AccountID = @accountID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accountID", Session.AccountID);
                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 16; bool has = false;
                while (reader.Read())
                {
                    has = true;
                    Panel chip = new Panel();
                    chip.BackColor = Color.FromArgb(52, 193, 164);
                    chip.Size = new Size(200, 44);
                    chip.Location = new Point(16 + ((panelContent.Controls.Count) % 6) * 220, y + (panelContent.Controls.Count / 6) * 60);

                    Label lbl = new Label();
                    lbl.Text = reader["SkillName"].ToString();
                    lbl.Font = new Font("Montserrat Medium", 10F, FontStyle.Bold);
                    lbl.ForeColor = Color.White;
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    chip.Controls.Add(lbl);
                    panelContent.Controls.Add(chip);
                }
                reader.Close(); con.Close();

                if (!has)
                {
                    Label lbl = new Label();
                    lbl.Text = "No skills added yet.";
                    lbl.Font = new Font("Montserrat", 11F);
                    lbl.ForeColor = Color.FromArgb(120, 120, 120);
                    lbl.Location = new Point(16, 16);
                    lbl.AutoSize = true;
                    panelContent.Controls.Add(lbl);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnExit_Click(object sender, EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnAddMore_Click(object sender, EventArgs e) { new Add_Skills().Show(); this.Hide(); }
        private void panelContent_Paint(object sender, PaintEventArgs e) { }
        private void ApplyTheme() { ThemeManager.Apply(this); }
    }
}
