using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Profile : Form
    {
        private int _accountID;
        private bool _hasBio = false;

        public Profile()
        {
            InitializeComponent();
            _accountID = Session.AccountID;
            HighlightNavButton(btnNavProfile);
            ApplyTheme();
        }

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

        private void Profile_Load(object sender, EventArgs e)
        {
            // Make all info fields read-only
            txtName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtCreatedAt.ReadOnly = true;
            txtUni.ReadOnly = true;
            txtDept.ReadOnly = true;
            txtBio.ReadOnly = true;

            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = @"
                    SELECT up.FirstName, up.LastName, up.Age, up.Gender, up.Bio,
                           ua.Username, ua.CreatedAt,
                           u.CampusName, d.DepartmentName
                    FROM user_accounts ua
                    INNER JOIN user_profiles up ON ua.AccountID = up.AccountID
                    INNER JOIN campus_enrollments ce ON up.ProfileID = ce.ProfileID
                    INNER JOIN universities u ON ce.UniversityID = u.UniversityID
                    INNER JOIN departments d ON ce.DepartmentID = d.DepartmentID
                    WHERE ua.AccountID = @accountID";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accountID", _accountID);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text      = reader["FirstName"] + " " + reader["LastName"];
                    txtAge.Text       = reader["Age"].ToString();

                    // Resolve gender ID to readable text
                    string gRaw = reader["Gender"].ToString();
                    txtGender.Text    = gRaw == "1" ? "Male" : gRaw == "2" ? "Female" : gRaw;

                    txtCreatedAt.Text = Convert.ToDateTime(reader["CreatedAt"]).ToString("dd MMM yyyy");
                    txtUni.Text       = reader["CampusName"].ToString();
                    txtDept.Text      = reader["DepartmentName"].ToString();
                    lblUsername.Text  = "@" + reader["Username"];

                    string bio = reader["Bio"].ToString().Trim();
                    _hasBio = bio.Length > 0;

                    if (_hasBio)
                    {
                        txtBio.Text      = bio;
                        txtBio.ReadOnly  = true;
                        txtBio.Visible   = true;
                        btnSaveBio.Text  = "Save";
                        btnSaveBio.Visible = false;   // hide save, show edit
                        btnAddBio.Visible  = false;
                        btnEditBio.Visible = true;
                        label8.Text = "Bio";
                    }
                    else
                    {
                        txtBio.Text     = "";
                        txtBio.Visible  = false;
                        btnSaveBio.Visible  = false;
                        btnAddBio.Visible   = true;
                        btnEditBio.Visible  = false;
                        label8.Text = "Bio";
                    }
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBio_Click(object sender, EventArgs e)
        {
            txtBio.ReadOnly  = false;
            txtBio.Text      = "";
            txtBio.Visible   = true;
            txtBio.Focus();
            btnAddBio.Visible  = false;
            btnSaveBio.Visible = true;
            btnEditBio.Visible = false;
        }

        private void btnEditBio_Click(object sender, EventArgs e)
        {
            txtBio.ReadOnly  = false;
            txtBio.Visible   = true;
            txtBio.Focus();
            btnEditBio.Visible = false;
            btnSaveBio.Visible = true;
            btnAddBio.Visible  = false;
        }

        private void btnSaveBio_Click(object sender, EventArgs e)
        {
            string bio = txtBio.Text.Trim();
            if (bio.Length > 150)
            {
                MessageBox.Show("Bio cannot exceed 150 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();
                string q = "UPDATE user_profiles SET Bio = @bio WHERE AccountID = @accountID";
                MySqlCommand cmd = new MySqlCommand(q, con);
                cmd.Parameters.AddWithValue("@bio", bio);
                cmd.Parameters.AddWithValue("@accountID", _accountID);
                cmd.ExecuteNonQuery();
                con.Close();

                txtBio.ReadOnly    = true;
                btnSaveBio.Visible = false;
                btnEditBio.Visible = true;
                btnAddBio.Visible  = false;
                _hasBio = true;
                MessageBox.Show("Bio saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBio_TextChanged(object sender, EventArgs e)
        {
            if (txtBio.Text.Length > 150)
            {
                txtBio.Text = txtBio.Text.Substring(0, 150);
                txtBio.SelectionStart = 150;
            }
        }

        private void HighlightNavButton(Button active)
        {
            Button[] all = { btnNavProfile, btnNavSearch, btnNavConnections, btnNavUniversities, btnNavPosts, btnNavMessages, btnNavEvents };
            foreach (var b in all) b.BackColor = ThemeManager.NavBtn;
            active.BackColor = ThemeManager.NavActive;
        }

        private void btnNavProfile_Click(object sender, EventArgs e) { }
        private void btnNavSearch_Click(object sender, EventArgs e) { new Search_Person().Show(); this.Hide(); }
        private void btnNavConnections_Click(object sender, EventArgs e) { new Connections().Show(); this.Hide(); }
        private void btnNavUniversities_Click(object sender, EventArgs e) { new University().Show(); this.Hide(); }
        private void btnNavPosts_Click(object sender, EventArgs e) { new Posts().Show(); this.Hide(); }
        private void btnNavMessages_Click(object sender, EventArgs e) { new Messages().Show(); this.Hide(); }
        private void btnNavEvents_Click(object sender, EventArgs e) { new Events().Show(); this.Hide(); }
        private void btnLogout_Click(object sender, EventArgs e) { new Form1().Show(); this.Hide(); }
        private void btnMyPosts_Click(object sender, EventArgs e) { new My_Posts().Show(); this.Hide(); }
        private void btnCheckSkills_Click(object sender, EventArgs e) { new Skills().Show(); this.Hide(); }
        private void btnCheckCertificates_Click(object sender, EventArgs e) { new Certificates().Show(); this.Hide(); }
        private void btnCheckEducation_Click(object sender, EventArgs e) { new Education().Show(); this.Hide(); }
        private void btnCheckInternships_Click(object sender, EventArgs e) { new Internship().Show(); this.Hide(); }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
    }
}
