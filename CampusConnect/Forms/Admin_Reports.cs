using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CampusConnect.Forms
{
    public partial class Admin_Reports : Form
    {
        public Admin_Reports()
        {
            ApplyTheme();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ADMIN_UI form = new ADMIN_UI();
            form.Show();
            this.Hide();
        }

        private void Admin_Reports_Load(object sender, EventArgs e)
        {

        }
        private void ApplyTheme() { ThemeManager.Apply(this); }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog so the user can pick where to save the PDF
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "University_Enrollment_Report.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // 2. Use your DBConnection helper class
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        string query = @"SELECT u.CampusName, COUNT(ce.ProfileID) AS TotalStudents
                             FROM universities u
                             LEFT JOIN campus_enrollments ce ON u.UniversityID = ce.UniversityID
                             GROUP BY u.UniversityID, u.CampusName;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- NEW DESIGN HIERARCHY ---

                            // A. Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5; // Small gap between brand and title
                            pdfDoc.Add(brandName);

                            // B. Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Total Users per University", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30; // Larger gap before the table starts to separate it
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table
                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100; // Stretches the table across the page

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(33, 37, 41); // Dark charcoal background

                            // Header Cell 1
                            PdfPCell cell1 = new PdfPCell(new Phrase("University Campus", headerFont));
                            cell1.BackgroundColor = headerBackground;
                            cell1.Padding = 8;
                            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell1);

                            // Header Cell 2
                            PdfPCell cell2 = new PdfPCell(new Phrase("Total Enrolled Students", headerFont));
                            cell2.BackgroundColor = headerBackground;
                            cell2.Padding = 8;
                            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell2);

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                            while (reader.Read())
                            {
                                PdfPCell dataCell1 = new PdfPCell(new Phrase(reader["CampusName"].ToString(), rowFont));
                                dataCell1.Padding = 6;
                                dataCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(dataCell1);

                                PdfPCell dataCell2 = new PdfPCell(new Phrase(reader["TotalStudents"].ToString(), rowFont));
                                dataCell2.Padding = 6;
                                dataCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(dataCell2);
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "User_Activity_Dashboard.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query: Joining the two views on FullName
                        // We use IFNULL so that if a user has no messages, it shows 0 instead of a blank space
                        string query = @"SELECT 
                                p.FullName, 
                                p.Username, 
                                IFNULL(p.TotalPosts, 0) AS TotalPosts, 
                                p.LastPostDate, 
                                IFNULL(m.MessagesSent, 0) AS MessagesSent, 
                                IFNULL(m.MessagesReceived, 0) AS MessagesReceived
                             FROM vw_post_activity p
                             LEFT JOIN vw_message_activity m ON p.FullName = m.FullName
                             ORDER BY p.TotalPosts DESC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Switched to Landscape so 6 columns fit nicely)
                            Document pdfDoc = new Document(PageSize.A4.Rotate(), 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("User Activity Dashboard", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 6 columns
                            PdfPTable table = new PdfPTable(6);
                            table.WidthPercentage = 100;

                            // Adjust column widths so names/dates get more space than raw numbers
                            table.SetWidths(new float[] { 2.5f, 2f, 1.2f, 2f, 1.5f, 1.5f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(33, 37, 41);

                            // Array of header names to make adding them cleaner
                            string[] headers = { "Full Name", "Username", "Total Posts", "Last Post Date", "Msgs Sent", "Msgs Received" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add Name & Username
                                table.AddCell(new PdfPCell(new Phrase(reader["FullName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                                table.AddCell(new PdfPCell(new Phrase(reader["Username"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Posts
                                table.AddCell(new PdfPCell(new Phrase(reader["TotalPosts"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Safely handle LastPostDate (it could be NULL if they've never posted)
                                string lastPost = reader["LastPostDate"] == DBNull.Value ? "Never" : Convert.ToDateTime(reader["LastPostDate"]).ToString("yyyy-MM-dd");
                                table.AddCell(new PdfPCell(new Phrase(lastPost, rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Messages Sent & Received
                                table.AddCell(new PdfPCell(new Phrase(reader["MessagesSent"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                                table.AddCell(new PdfPCell(new Phrase(reader["MessagesReceived"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "Network_Growth_Report.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query: Pulling from your connection stats view
                        // Ordering by AcceptedConnections DESC puts the top networkers at the top of the report
                        string query = @"SELECT FullName, AcceptedConnections, PendingRequests 
                             FROM vw_connection_stats 
                             ORDER BY AcceptedConnections DESC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Using standard Portrait mode for 3 columns)
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Network Growth Report", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 3 columns
                            PdfPTable table = new PdfPTable(3);
                            table.WidthPercentage = 100;

                            // Adjust column widths: Give the Full Name column a bit more room
                            table.SetWidths(new float[] { 3f, 2f, 2f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(33, 37, 41);

                            // Array of header names
                            string[] headers = { "Full Name", "Accepted Connections", "Pending Requests" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add Name
                                table.AddCell(new PdfPCell(new Phrase(reader["FullName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Accepted Connections
                                table.AddCell(new PdfPCell(new Phrase(reader["AcceptedConnections"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Pending Requests
                                table.AddCell(new PdfPCell(new Phrase(reader["PendingRequests"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Network Growth Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "Campus_Enrollment_Distribution.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        // Ordering by CampusName first, then by EnrolledStudents DESC to show the biggest departments at the top of each campus block
                        string query = @"SELECT CampusName, DepartmentName, EnrolledStudents 
                             FROM vw_university_enrollment 
                             ORDER BY CampusName ASC, EnrolledStudents DESC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Standard Portrait Mode)
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Campus Enrollment Distribution", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 3 columns
                            PdfPTable table = new PdfPTable(3);
                            table.WidthPercentage = 100;

                            // Adjust column widths: Give the Department Name a bit more space since some majors have long names
                            table.SetWidths(new float[] { 2f, 2.5f, 1.5f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(33, 37, 41);

                            // Array of header names
                            string[] headers = { "Campus", "Department", "Enrolled Students" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add Campus Name
                                table.AddCell(new PdfPCell(new Phrase(reader["CampusName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Department Name
                                table.AddCell(new PdfPCell(new Phrase(reader["DepartmentName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Enrolled Students Count
                                table.AddCell(new PdfPCell(new Phrase(reader["EnrolledStudents"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Enrollment Distribution Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "Top_Trending_Skills_Report.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        // Joining the skills and profile_skills tables, grouping by the skill, and sorting highest to lowest
                        string query = @"SELECT s.SkillName, COUNT(ps.ProfileID) AS StudentCount
                             FROM skills s
                             JOIN profile_skills ps ON s.SkillID = ps.SkillID
                             GROUP BY s.SkillID, s.SkillName
                             ORDER BY StudentCount DESC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Standard Portrait Mode for 2 columns)
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Top Trending Skills Report", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 2 columns
                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100;

                            // Adjust column widths: Give the Skill Name column a bit more room
                            table.SetWidths(new float[] { 3f, 2f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(33, 37, 41);

                            // Array of header names
                            string[] headers = { "Technical Skill", "Number of Students" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add Skill Name
                                table.AddCell(new PdfPCell(new Phrase(reader["SkillName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Student Count
                                table.AddCell(new PdfPCell(new Phrase(reader["StudentCount"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Trending Skills Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport6_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "Event_Attendance_Roster.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        // Using LEFT JOIN ensures events with 0 attendees still appear on the roster
                        // Ordering by EventDate so it reads like a proper chronological schedule
                        string query = @"SELECT 
                                e.EventTitle, 
                                e.EventDate, 
                                u.CampusName, 
                                COUNT(ea.ProfileID) AS TotalAttendees
                             FROM events e
                             JOIN universities u ON e.UniversityID = u.UniversityID
                             LEFT JOIN event_attendees ea ON e.EventID = ea.EventID
                             GROUP BY e.EventID, e.EventTitle, e.EventDate, u.CampusName
                             ORDER BY e.EventDate ASC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Standard Portrait Mode)
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Event Attendance Roster", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 4 columns
                            PdfPTable table = new PdfPTable(4);
                            table.WidthPercentage = 100;

                            // Adjust column widths: Title gets the most room, Attendees needs the least
                            table.SetWidths(new float[] { 3f, 2.5f, 2f, 1.5f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(33, 37, 41);

                            // Array of header names
                            string[] headers = { "Event Title", "Date & Time", "Hosting Campus", "Attendees" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add Event Title
                                table.AddCell(new PdfPCell(new Phrase(reader["EventTitle"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Event Date (Formatted cleanly)
                                DateTime eventDate = Convert.ToDateTime(reader["EventDate"]);
                                string formattedDate = eventDate.ToString("MMM dd, yyyy - hh:mm tt");
                                table.AddCell(new PdfPCell(new Phrase(formattedDate, rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Campus Name
                                table.AddCell(new PdfPCell(new Phrase(reader["CampusName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Total Attendees Count
                                table.AddCell(new PdfPCell(new Phrase(reader["TotalAttendees"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Event Attendance Roster saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport7_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "Account_Deletion_Audit_Log.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        // Joining the backup tables on AccountID. 
                        // ORDER BY DeletedAt DESC ensures the most recently deleted accounts appear first.
                        string query = @"SELECT 
                                bp.FirstName, 
                                bp.LastName, 
                                ba.Username, 
                                ba.DeletedAt 
                             FROM backup_accounts ba
                             JOIN backup_profiles bp ON ba.AccountID = bp.AccountID
                             ORDER BY ba.DeletedAt DESC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Standard Portrait Mode)
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Account Deletion Audit Log", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 4 columns
                            PdfPTable table = new PdfPTable(4);
                            table.WidthPercentage = 100;

                            // Adjust column widths
                            table.SetWidths(new float[] { 2f, 2f, 2.5f, 2.5f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(139, 0, 0); // Using a dark red to signify a deletion/security report

                            // Array of header names
                            string[] headers = { "First Name", "Last Name", "Username", "Deletion Date" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add First Name
                                table.AddCell(new PdfPCell(new Phrase(reader["FirstName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Last Name
                                table.AddCell(new PdfPCell(new Phrase(reader["LastName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Username
                                table.AddCell(new PdfPCell(new Phrase(reader["Username"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Deletion Date (Formatted cleanly for an audit log)
                                DateTime deletedAt = Convert.ToDateTime(reader["DeletedAt"]);
                                string formattedDate = deletedAt.ToString("MMM dd, yyyy - hh:mm tt");
                                table.AddCell(new PdfPCell(new Phrase(formattedDate, rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Audit Log saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport8_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "Content_Moderation_Report.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        // Joining backup_posts with user_profiles.
                        // Ordering by DeletedAt DESC to put the most recent moderation actions at the top.
                        string query = @"SELECT 
                                up.FirstName, 
                                up.LastName, 
                                bp.Description, 
                                bp.PostedAt, 
                                bp.DeletedAt 
                             FROM backup_posts bp
                             JOIN user_profiles up ON bp.ProfileID = up.ProfileID
                             ORDER BY bp.DeletedAt DESC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Switched to Landscape Mode for long text)
                            Document pdfDoc = new Document(PageSize.A4.Rotate(), 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Content Moderation Report", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 5 columns
                            PdfPTable table = new PdfPTable(5);
                            table.WidthPercentage = 100;

                            // Adjust column widths: The Post Content (index 2) gets a massive 4f ratio to give it room to wrap
                            table.SetWidths(new float[] { 1.5f, 1.5f, 4f, 1.5f, 1.5f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(25, 25, 112); // Midnight Blue to distinguish it as an Admin report

                            // Array of header names
                            string[] headers = { "First Name", "Last Name", "Original Post Content", "Date Posted", "Date Deleted" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add First Name
                                table.AddCell(new PdfPCell(new Phrase(reader["FirstName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Last Name
                                table.AddCell(new PdfPCell(new Phrase(reader["LastName"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Post Description (Horizontal alignment set to LEFT here for easier reading)
                                table.AddCell(new PdfPCell(new Phrase(reader["Description"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_LEFT });

                                // Add Posted Date
                                DateTime postedAt = Convert.ToDateTime(reader["PostedAt"]);
                                table.AddCell(new PdfPCell(new Phrase(postedAt.ToString("MMM dd, yyyy"), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Deleted Date
                                DateTime deletedAt = Convert.ToDateTime(reader["DeletedAt"]);
                                table.AddCell(new PdfPCell(new Phrase(deletedAt.ToString("MMM dd, yyyy"), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Moderation Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport9_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "User_Demographic_Breakdown.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        // We use a CASE statement to create dynamic 'Age Brackets' out of the raw Age integers.
                        // We filter by ua.IsActive = 1 to only count currently active accounts.
                        string query = @"SELECT 
                                CASE 
                                    WHEN up.Age < 20 THEN 'Under 20'
                                    WHEN up.Age BETWEEN 20 AND 23 THEN '20 - 23'
                                    WHEN up.Age > 23 THEN 'Over 23'
                                    ELSE 'Not Specified'
                                END AS AgeBracket,
                                IFNULL(l.LookupValue, 'Not Specified') AS GenderIdentity,
                                COUNT(up.ProfileID) AS TotalUsers
                             FROM user_profiles up
                             JOIN user_accounts ua ON up.AccountID = ua.AccountID
                             LEFT JOIN lookups l ON up.Gender = l.LookupID AND l.Category = 'Gender'
                             WHERE ua.IsActive = 1
                             GROUP BY AgeBracket, GenderIdentity
                             ORDER BY AgeBracket ASC, GenderIdentity ASC;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Standard Portrait Mode)
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Active User Demographic Breakdown", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 3 columns
                            PdfPTable table = new PdfPTable(3);
                            table.WidthPercentage = 100;

                            // Adjust column widths evenly
                            table.SetWidths(new float[] { 2f, 2f, 2f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(0, 128, 128); // Deep Teal for demographic data

                            // Array of header names
                            string[] headers = { "Age Bracket", "Gender Identity", "Total Active Users" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add Age Bracket
                                table.AddCell(new PdfPCell(new Phrase(reader["AgeBracket"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Gender Identity
                                table.AddCell(new PdfPCell(new Phrase(reader["GenderIdentity"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Total Users Count
                                table.AddCell(new PdfPCell(new Phrase(reader["TotalUsers"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Demographic Breakdown saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport10_Click(object sender, EventArgs e)
        {
            // 1. Open the Save File dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "Platform_Activity_Timeline.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // 3. The SQL Query
                        // We use the WEEK() and YEAR() functions to group posts into weekly buckets.
                        // Ordering by Year and Week DESC ensures the most recent weeks appear at the top.
                        string query = @"SELECT 
                    CONCAT('Week ', PostWeek, ' of ', PostYear) AS TimePeriod, 
                    TotalPosts
                 FROM (
                    SELECT 
                        YEAR(PostedAt) AS PostYear, 
                        WEEK(PostedAt, 1) AS PostWeek, 
                        COUNT(PostID) AS TotalPosts
                    FROM posts
                    GROUP BY YEAR(PostedAt), WEEK(PostedAt, 1)
                 ) AS WeeklyData
                 ORDER BY PostYear DESC, PostWeek DESC;";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Create the PDF Document (Standard Portrait Mode)
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // --- DESIGN HIERARCHY ---

                            // Master Brand Heading
                            iTextSharp.text.Font brandFont = FontFactory.GetFont("Helvetica", 24, iTextSharp.text.Font.BOLD, new BaseColor(44, 62, 80));
                            Paragraph brandName = new Paragraph("CAMPUS CONNECT", brandFont);
                            brandName.Alignment = Element.ALIGN_CENTER;
                            brandName.SpacingAfter = 5;
                            pdfDoc.Add(brandName);

                            // Report Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                            Paragraph reportTitle = new Paragraph("Platform Activity Timeline", titleFont);
                            reportTitle.Alignment = Element.ALIGN_CENTER;
                            reportTitle.SpacingAfter = 30;
                            pdfDoc.Add(reportTitle);

                            // --- END DESIGN HIERARCHY ---

                            // 5. Create an Enhanced Table with 2 columns
                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100;

                            // Adjust column widths
                            table.SetWidths(new float[] { 3f, 2f });

                            // Set up custom styling for the table headers
                            iTextSharp.text.Font headerFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            BaseColor headerBackground = new BaseColor(72, 61, 139); // Dark Slate Blue for analytics

                            // Array of header names
                            string[] headers = { "Time Period", "Total Posts Generated" };

                            foreach (string header in headers)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(header, headerFont));
                                headerCell.BackgroundColor = headerBackground;
                                headerCell.Padding = 8;
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(headerCell);
                            }

                            // 6. Loop through the database results and fill the rows
                            iTextSharp.text.Font rowFont = FontFactory.GetFont("Helvetica", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            while (reader.Read())
                            {
                                // Add Time Period
                                table.AddCell(new PdfPCell(new Phrase(reader["TimePeriod"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });

                                // Add Total Posts
                                table.AddCell(new PdfPCell(new Phrase(reader["TotalPosts"].ToString(), rowFont)) { Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            }

                            // 7. Put the table inside the PDF and save it
                            pdfDoc.Add(table);
                            pdfDoc.Close();

                            MessageBox.Show("Activity Timeline saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops, something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
