using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    public partial class University : Form
    {
        public University() {
            ApplyTheme(); InitializeComponent(); }

        private void University_Load(object sender, EventArgs e) { LoadUniversities(); }

        private void LoadUniversities()
        {
            try
            {
                flowPanel.Controls.Clear();
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                // Load all universities
                string uniQuery = "SELECT UniversityID, CampusName, Location FROM universities ORDER BY CampusName";
                MySqlCommand uniCmd = new MySqlCommand(uniQuery, con);
                MySqlDataReader uniReader = uniCmd.ExecuteReader();

                System.Collections.Generic.List<(int id, string name, string location)> unis
                    = new System.Collections.Generic.List<(int, string, string)>();
                while (uniReader.Read())
                    unis.Add((Convert.ToInt32(uniReader["UniversityID"]), uniReader["CampusName"].ToString(), uniReader["Location"].ToString()));
                uniReader.Close();

                foreach (var uni in unis)
                {
                    // University header card
                    Panel uniCard = new Panel();
                    uniCard.BackColor = Color.FromArgb(68, 72, 71);
                    uniCard.Width = flowPanel.Width - 20;
                    uniCard.Padding = new Padding(18, 14, 18, 14);
                    uniCard.Margin = new Padding(0, 0, 0, 16);

                    Label lblName = new Label();
                    lblName.Text = uni.name;
                    lblName.Font = new Font("Montserrat", 15F, FontStyle.Bold);
                    lblName.ForeColor = Color.White;
                    lblName.Location = new Point(18, 14);
                    lblName.AutoSize = true;
                    uniCard.Controls.Add(lblName);

                    Label lblLoc = new Label();
                    lblLoc.Text = "📍 " + uni.location;
                    lblLoc.Font = new Font("Montserrat", 9.5F);
                    lblLoc.ForeColor = Color.FromArgb(52, 193, 164);
                    lblLoc.AutoSize = true;
                    lblLoc.Location = new Point(18, lblName.Bottom + 6);
                    uniCard.Controls.Add(lblLoc);

                    // Departments subheading
                    Label lblDeptHead = new Label();
                    lblDeptHead.Text = "Departments:";
                    lblDeptHead.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold);
                    lblDeptHead.ForeColor = Color.FromArgb(180, 180, 180);
                    lblDeptHead.AutoSize = true;
                    lblDeptHead.Location = new Point(18, lblLoc.Bottom + 12);
                    uniCard.Controls.Add(lblDeptHead);

                    // Load departments for this university
                    string deptQuery = @"SELECT d.DepartmentName 
                                         FROM departments d
                                         INNER JOIN campus_enrollments ce ON d.DepartmentID = ce.DepartmentID
                                         WHERE ce.UniversityID = @uniID
                                         GROUP BY d.DepartmentID, d.DepartmentName
                                         ORDER BY d.DepartmentName";
                    MySqlCommand deptCmd = new MySqlCommand(deptQuery, con);
                    deptCmd.Parameters.AddWithValue("@uniID", uni.id);
                    MySqlDataReader deptReader = deptCmd.ExecuteReader();

                    int chipX = 18; int chipY = lblDeptHead.Bottom + 8;
                    bool hasDept = false;
                    while (deptReader.Read())
                    {
                        hasDept = true;
                        Panel chip = new Panel();
                        chip.BackColor = Color.FromArgb(44, 49, 49);
                        chip.Size = new Size(140, 34);
                        chip.Location = new Point(chipX, chipY);

                        Label chipLbl = new Label();
                        chipLbl.Text = deptReader["DepartmentName"].ToString();
                        chipLbl.Font = new Font("Montserrat", 9F);
                        chipLbl.ForeColor = Color.White;
                        chipLbl.Dock = DockStyle.Fill;
                        chipLbl.TextAlign = ContentAlignment.MiddleCenter;
                        chip.Controls.Add(chipLbl);
                        uniCard.Controls.Add(chip);

                        chipX += 150;
                        if (chipX + 140 > uniCard.Width - 30) { chipX = 18; chipY += 44; }
                    }
                    deptReader.Close();

                    if (!hasDept)
                    {
                        Label noDept = new Label();
                        noDept.Text = "No departments enrolled yet.";
                        noDept.Font = new Font("Montserrat", 9F);
                        noDept.ForeColor = Color.FromArgb(120, 120, 120);
                        noDept.AutoSize = true;
                        noDept.Location = new Point(18, lblDeptHead.Bottom + 8);
                        uniCard.Controls.Add(noDept);
                        chipY = noDept.Bottom;
                    }

                    uniCard.Height = chipY + 44 + 16;
                    flowPanel.Controls.Add(uniCard);
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnNavProfile_Click(object sender, System.EventArgs e) { new Profile().Show(); this.Hide(); }
        private void btnNavSearch_Click(object sender, System.EventArgs e) { new Search_Person().Show(); this.Hide(); }
        private void btnNavConnections_Click(object sender, System.EventArgs e) { new Connections().Show(); this.Hide(); }
        private void btnNavUniversities_Click(object sender, System.EventArgs e) { }
        private void btnNavPosts_Click(object sender, System.EventArgs e) { new Posts().Show(); this.Hide(); }
        private void btnNavMessages_Click(object sender, System.EventArgs e) { new Messages().Show(); this.Hide(); }
        private void btnNavEvents_Click(object sender, System.EventArgs e) { new Events().Show(); this.Hide(); }
        private void btnLogout_Click(object sender, System.EventArgs e) { new Form1().Show(); this.Hide(); }
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
