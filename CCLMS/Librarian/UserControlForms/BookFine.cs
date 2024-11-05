using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CCLMS.Admin.UserControlForms
{
    public partial class BookFine : UserControl
    {
        private readonly SqlConnection con;
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int smtpPort = 587;
        private readonly string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
        private readonly string senderPassword = ConfigurationManager.AppSettings["SenderPassword"];

        public BookFine()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            LoadFines();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoadFines()
        {
            DataTable fines = GetFines();
            FineDataGridView.DataSource = fines;

            FineDataGridView.Columns["fineId"].HeaderText = "Fine Id";
            FineDataGridView.Columns["StudentName"].HeaderText = "Student Name";
            FineDataGridView.Columns["Email"].HeaderText = "Email";
            FineDataGridView.Columns["bookTitle"].HeaderText = "Book Title";
            FineDataGridView.Columns["dueDate"].HeaderText = "Due Date";
            FineDataGridView.Columns["returnDate"].HeaderText = "Return Date";
            FineDataGridView.Columns["fineAmount"].HeaderText = "Fine Amount";
            FineDataGridView.Columns["imposedDate"].HeaderText = "Imposed Date";
        }

        private DataTable GetFines()
        {
            string query = @"
                SELECT 
                    bf.fineId, 
                    s.name AS StudentName,
                    s.email AS Email,
                    b.bookTitle, 
                    bf.dueDate, 
                    bf.returnDate, 
                    bf.fineAmount, 
                    bf.imposedDate
                FROM 
                    bookFine bf
                JOIN 
                    student s ON bf.studentId = s.studentId
                JOIN 
                    book b ON bf.bookId = b.bookId
            ";

            DataTable dataTable = new DataTable();

            try
            {
                con.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return dataTable;
        }

        private void DeleteFineButton_Click(object sender, EventArgs e)
        {
            if (FineDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                string deleteQuery = "DELETE FROM bookFine WHERE fineId = @fineId";

                                foreach (DataGridViewRow selectedRow in FineDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["fineId"].Value != null && int.TryParse(selectedRow.Cells["FineId"].Value.ToString(), out int bookId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@fineId", bookId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        FineDataGridView.Rows.Remove(selectedRow);
                                    }
                                }
                                transaction.Commit();
                                MessageBox.Show("Records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException sqlEx)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    finally
                    {
                        if (con != null && con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select rows to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckInternetConnection()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com", 3000);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            if (!CheckInternetConnection())
            {
                MessageBox.Show("No internet connection detected. Please check your connection and try again.", "No Internet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FineDataGridView.SelectedRows.Count > 0)
            {
                // Get selected row data
                DataGridViewRow selectedRow = FineDataGridView.SelectedRows[0];
                string StudentEmailAddress = selectedRow.Cells["Email"].Value.ToString();
                decimal fineAmount = Convert.ToDecimal(selectedRow.Cells["fineAmount"].Value);
                string bookTitle = selectedRow.Cells["bookTitle"].Value.ToString();
                string studentName = selectedRow.Cells["StudentName"].Value.ToString();

                // Send email to the student
                SendFineEmail(StudentEmailAddress, fineAmount, bookTitle, studentName);
            }
            else
            {
                MessageBox.Show("Please select a row to send an email.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SendFineEmail(string StudentEmailAddress, decimal fineAmount, string bookTitle, string studentName)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail, "CCLMS");
                    mail.To.Add(StudentEmailAddress);
                    mail.Subject = "CCLMS Fine Notification";
                    mail.Body = $@"
                        Dear Student {studentName},
                        <br/><br/>
                        This is to inform you that you have been fined <b>{fineAmount}</b> for overdue library book <b>'{bookTitle}'</b>.
                        <br/><br/>
                        Please settle the fine at your earliest convenience.
                        <br/><br/>
                        (This is an auto-generated email, so please do not reply back.)
                        <br/><br/>
                        Happy reading! 😊📚
                        <br/><br/>
                        Best regards,
                        <br/>
                        📚 Your College Library Team 📚
                    ";

                    mail.IsBodyHtml = true;

                    using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mail);
                    }
                    MessageBox.Show($"An email has been successfully sent to {StudentEmailAddress} regarding a fine of {fineAmount} for the book '{bookTitle}'.", "Email Notification Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"Failed to send email: {smtpEx.Message}. Please check your internet connection and try again.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
