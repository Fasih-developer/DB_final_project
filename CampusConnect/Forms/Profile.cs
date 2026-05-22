using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class Profile : Form
    {
        private int _accountID;

        public Profile()
        {
            InitializeComponent();
            _accountID = Session.AccountID; 
            HighlightNavButton(btnNavProfile);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = @"
                    SELECT 
                        up.FirstName, up.LastName, up.Age, up.Gender, up.Bio,
                        ua.Username, ua.CreatedAt,
                        u.CampusName,
                        d.DepartmentName
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
                    txtName.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    txtAge.Text = reader["Age"].ToString();
                    txtGender.Text = reader["Gender"].ToString();
                    txtCreatedAt.Text = Convert.ToDateTime(reader["CreatedAt"]).ToString("dd MMM yyyy");
                    txtUni.Text = reader["CampusName"].ToString();
                    txtDept.Text = reader["DepartmentName"].ToString();
                    lblUsername.Text = "@" + reader["Username"].ToString();
                    txtBio.Text = reader["Bio"].ToString();
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Button[] allNav = { btnNavProfile, btnNavSearch, btnNavConnections, btnNavUniversities, btnNavPosts, btnNavMessages, btnNavEvents };
            foreach (var b in allNav)
                b.BackColor = System.Drawing.Color.FromArgb(68, 72, 71);
            active.BackColor = System.Drawing.Color.FromArgb(52, 193, 164);
        }

        private void btnNavProfile_Click(object sender, EventArgs e) { }

        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            Search_Person form = new Search_Person();
            form.Show(); this.Hide();
        }

        private void btnNavConnections_Click(object sender, EventArgs e)
        {
            Connections form = new Connections();
            form.Show(); this.Hide();
        }

        private void btnNavUniversities_Click(object sender, EventArgs e)
        {
            University form = new University();
            form.Show(); this.Hide();
        }

        private void btnNavPosts_Click(object sender, EventArgs e)
        {
            Posts form = new Posts();
            form.Show(); this.Hide();
        }

        private void btnNavMessages_Click(object sender, EventArgs e)
        {
            Messages form = new Messages();
            form.Show(); this.Hide();
        }

        private void btnNavEvents_Click(object sender, EventArgs e)
        {
            Events form = new Events();
            form.Show(); this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(); this.Hide();
        }

        private void btnMyPosts_Click(object sender, EventArgs e)
        {
            My_Posts form = new My_Posts();
            form.Show(); this.Hide();
        }

        private void btnCheckSkills_Click(object sender, EventArgs e)
        {
            Skills form = new Skills();
            form.Show(); this.Hide();
        }

        private void btnCheckCertificates_Click(object sender, EventArgs e)
        {
            Certificates form = new Certificates();
            form.Show(); this.Hide();
        }

        private void btnCheckEducation_Click(object sender, EventArgs e)
        {
            Education form = new Education();
            form.Show(); this.Hide();
        }

        private void btnCheckInternships_Click(object sender, EventArgs e)
        {
            Internship form = new Internship();
            form.Show(); this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void textBox7_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}