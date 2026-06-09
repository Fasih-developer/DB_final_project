using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public partial class Add_event : Form
    {
        public Add_event()
        {
            InitializeComponent();
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UniversityID, CampusName FROM universities;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbUniversity.DataSource = dt;
                        cmbUniversity.DisplayMember = "CampusName"; 
                        cmbUniversity.ValueMember = "UniversityID"; 
                        cmbUniversity.SelectedIndex = -1; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading campuses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDegree_Click(object sender, EventArgs e)
        {

        }

        private void txtEventTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInstitute_Click(object sender, EventArgs e)
        {

        }

        private void cmbUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            string title = txtEventTitle.Text.Trim();
            string description = txtDescription.Text.Trim();

            //Basic Validation
            if (string.IsNullOrWhiteSpace(title) || cmbUniversity.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter an Event Title and select a Hosting Campus.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Only letters and spaces 
            if (!Regex.IsMatch(title, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Event Title can only contain letters and spaces. Numbers and symbols are not allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Description 
            if (description.Length < 25)
            {
                MessageBox.Show("Description must be at least 25 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(description, @"^[a-zA-Z\s.,!?'-]+$"))
            {
                MessageBox.Show("Description cannot contain numbers or special symbols.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO events (UniversityID, EventTitle, Description, EventDate) 
                                     VALUES (@univID, @title, @desc, @eventDate);";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@univID", cmbUniversity.SelectedValue);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@eventDate", dtpEventDate.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEventTitle.Clear();
                            txtDescription.Clear();
                            cmbUniversity.SelectedIndex = -1;
                            dtpEventDate.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Failed to create event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new ADMIN_UI().Show();
            this.Hide();
        }
    }
}