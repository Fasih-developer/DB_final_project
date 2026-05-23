using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Skills : Form
    {
        public Skills()
        {
            InitializeComponent();
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            LoadSkills();
        }

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

                int y = 10;
                bool hasSkills = false;

                while (reader.Read())
                {
                    hasSkills = true;

                    Label lbl = new Label();
                    lbl.Text = "• " + reader["SkillName"].ToString();
                    lbl.Font = new System.Drawing.Font("Montserrat", 11F);
                    lbl.ForeColor = System.Drawing.Color.White;
                    lbl.Location = new System.Drawing.Point(10, y);
                    lbl.AutoSize = true;
                    panelContent.Controls.Add(lbl);

                    y += 35;
                }

                reader.Close();
                con.Close();

                if (!hasSkills)
                {
                    Label lbl = new Label();
                    lbl.Text = "My Skills will appear here...";
                    lbl.Font = new System.Drawing.Font("Montserrat", 10F);
                    lbl.ForeColor = System.Drawing.Color.Gray;
                    lbl.Location = new System.Drawing.Point(10, 10);
                    lbl.AutoSize = true;
                    panelContent.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Show(); this.Hide();
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            Add_Skills form = new Add_Skills();
            form.Show(); this.Hide();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e) { }
    }
}