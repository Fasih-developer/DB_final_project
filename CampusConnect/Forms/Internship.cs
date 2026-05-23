using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Internship : Form
    {
        public Internship()
        {
            InitializeComponent();
        }

        private void Internship_Load(object sender, EventArgs e)
        {
            LoadInternships();
        }

        private void LoadInternships()
        {
            try
            {
                panelContent.Controls.Clear();

                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = @"SELECT CompanyName, JobRole, StartDate, EndDate 
                                 FROM internships 
                                 WHERE ProfileID = (SELECT ProfileID FROM user_profiles WHERE AccountID = @accountID)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accountID", Session.AccountID);

                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                bool hasIntern = false;

                while (reader.Read())
                {
                    hasIntern = true;

                    Label lbl = new Label();
                    lbl.Text = "• " + reader["CompanyName"].ToString() +
                               " | " + reader["JobRole"].ToString() +
                               " | " + Convert.ToDateTime(reader["StartDate"]).ToString("dd MMM yyyy") +
                               " - " + Convert.ToDateTime(reader["EndDate"]).ToString("dd MMM yyyy");
                    lbl.Font = new System.Drawing.Font("Montserrat", 10F);
                    lbl.ForeColor = System.Drawing.Color.White;
                    lbl.Location = new System.Drawing.Point(10, y);
                    lbl.AutoSize = true;
                    panelContent.Controls.Add(lbl);

                    y += 35;
                }

                reader.Close();
                con.Close();

                if (!hasIntern)
                {
                    Label lbl = new Label();
                    lbl.Text = "My Internships will appear here...";
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
            Add_Internships form = new Add_Internships();
            form.Show(); this.Hide();
        }
    }
}