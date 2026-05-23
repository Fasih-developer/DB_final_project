using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Certificates : Form
    {
        public Certificates()
        {
            InitializeComponent();
        }

        private void Certificates_Load(object sender, EventArgs e)
        {
            LoadCertificates();
        }

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

                int y = 10;
                bool hasCerts = false;

                while (reader.Read())
                {
                    hasCerts = true;

                    Label lbl = new Label();
                    lbl.Text = "• " + reader["CertificateName"].ToString() +
                               " | " + reader["IssuingOrganization"].ToString() +
                               " | " + Convert.ToDateTime(reader["DateEarned"]).ToString("dd MMM yyyy");
                    lbl.Font = new System.Drawing.Font("Montserrat", 10F);
                    lbl.ForeColor = System.Drawing.Color.White;
                    lbl.Location = new System.Drawing.Point(10, y);
                    lbl.AutoSize = true;
                    panelContent.Controls.Add(lbl);

                    y += 35;
                }

                reader.Close();
                con.Close();

                if (!hasCerts)
                {
                    Label lbl = new Label();
                    lbl.Text = "My Certificates will appear here...";
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
            Add_Certifications form = new Add_Certifications();
            form.Show(); this.Hide();
        }
    }
}