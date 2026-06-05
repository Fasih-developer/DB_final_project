using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

                        // Bind the data to the ComboBox
                        cmbUniversity.DataSource = dt;
                        cmbUniversity.DisplayMember = "CampusName"; // What the user sees
                        cmbUniversity.ValueMember = "UniversityID"; // The ID stored behind the scenes
                        cmbUniversity.SelectedIndex = -1; // Keep it blank initially
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
            // 1. Basic Validation to ensure fields aren't empty
            if (string.IsNullOrWhiteSpace(txtEventTitle.Text) || cmbUniversity.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter an Event Title and select a Hosting Campus.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Insert into the database
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // We use parameterized queries (@title, @desc, etc.) to prevent SQL Injection
                    string query = @"INSERT INTO events (UniversityID, EventTitle, Description, EventDate) 
                             VALUES (@univID, @title, @desc, @eventDate);";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@univID", cmbUniversity.SelectedValue);
                        cmd.Parameters.AddWithValue("@title", txtEventTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@eventDate", dtpEventDate.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the form for the next entry
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
