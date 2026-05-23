using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();
        }

        private void Education_Load(object sender, EventArgs e)
        {
            LoadEducation();
        }

        private void LoadEducation()
        {
            try
            {
                panelContent.Controls.Clear();

                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = @"SELECT InstitutionName, Degree, StartYear, EndYear 
                                 FROM educations 
                                 WHERE ProfileID = (SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accountID", Session.AccountID);

                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                bool hasEdu = false;

                while (reader.Read())
                {
                    hasEdu = true;

                    Label lbl = new Label();
                    lbl.Text = "• " + reader["InstitutionName"].ToString() +
                               " | " + reader["Degree"].ToString() +
                               " | " + reader["StartYear"].ToString() +
                               " - " + reader["EndYear"].ToString();
                    lbl.Font = new System.Drawing.Font("Montserrat", 10F);
                    lbl.ForeColor = System.Drawing.Color.White;
                    lbl.Location = new System.Drawing.Point(10, y);
                    lbl.AutoSize = true;
                    panelContent.Controls.Add(lbl);

                    y += 35;
                }

                reader.Close();
                con.Close();

                if (!hasEdu)
                {
                    Label lbl = new Label();
                    lbl.Text = "My Education will appear here...";
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
            Add_Education form = new Add_Education();
            form.Show(); this.Hide();
        }
    }
}