using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Student.UserControlForms
{
    public partial class IssueBook : UserControl
    {
        private readonly SqlConnection con;
        private readonly string loggedInUserId;

        public IssueBook(string userId)
        {
            InitializeComponent();

            this.loggedInUserId = userId;
            UserIdTextBox.Text = loggedInUserId;
            UserIdTextBox.ReadOnly = true;

            con = new SqlConnection(GetConnectionString());

        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            IssueBookNameTextBox.Clear();
            dateTimePickerDueDate.Value = DateTime.Now;
        }

        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IssueBookNameTextBox.Text))
            {
                MessageBox.Show("No book selected. Please choose a book from the list to proceed.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePickerDueDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The due date cannot be in the past. Please select a valid due date.", "Invalid Due Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookTitle = IssueBookNameTextBox.Text; // Get the book title from the TextBox
            string bookId = GetBookIdByTitle(bookTitle);

            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Book not found. Please choose a valid book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string countQuery = "SELECT COUNT(*) FROM issueBook WHERE studentId = @userId AND status = 'Issued'";
            string checkBookIssuedQuery = "SELECT COUNT(*) FROM issueBook WHERE studentId = @userId AND bookId = @bookId AND status = 'Issued'";
            string insertQuery = "INSERT INTO issueBook (bookId, studentId, dueDate) VALUES (@bookId, @userId, @dueDate)";
            string updateBookCopiesQuery = "UPDATE book SET bookAvailableCopies = bookAvailableCopies - 1 WHERE bookId = @bookId";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    countCommand.Parameters.AddWithValue("@userId", UserIdTextBox.Text);

                    try
                    {
                        int issuedBooksCount = (int)countCommand.ExecuteScalar();

                        if (issuedBooksCount >= 5)
                        {
                            MessageBox.Show("You have reached the limit of 5 issued books. Please return a book before issuing a new one.", "Issue Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        using (SqlCommand checkBookIssuedCommand = new SqlCommand(checkBookIssuedQuery, connection))
                        {
                            checkBookIssuedCommand.Parameters.AddWithValue("@userId", UserIdTextBox.Text);
                            checkBookIssuedCommand.Parameters.AddWithValue("@bookId", bookId);
                            int bookIssuedCount = (int)checkBookIssuedCommand.ExecuteScalar();

                            if (bookIssuedCount > 0)
                            {
                                MessageBox.Show($"This '{bookTitle}' book has already been issued to you. Please choose a different book.", "Book Already Issued", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@bookId", bookId);
                                insertCommand.Parameters.AddWithValue("@userId", UserIdTextBox.Text);
                                insertCommand.Parameters.AddWithValue("@dueDate", dateTimePickerDueDate.Value);

                                int result = insertCommand.ExecuteNonQuery();

                                if (result < 0)
                                {
                                    MessageBox.Show("Error issuing book!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                using (SqlCommand updateBookCopiesCommand = new SqlCommand(updateBookCopiesQuery, connection))
                                {

                                    updateBookCopiesCommand.Parameters.AddWithValue("@bookId", bookId);

                                    int updateCopiesResult = updateBookCopiesCommand.ExecuteNonQuery();

                                    if (updateCopiesResult < 0)
                                    {
                                        MessageBox.Show("Failed to update available copies of the book.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }

                                MessageBox.Show($"The book '{bookTitle}' has been successfully issued to user ID: {UserIdTextBox.Text}.", "Book Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                IssueBookNameTextBox.Text = string.Empty;
                                dateTimePickerDueDate.Value = DateTime.Now;
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"An error occurred while issuing the book: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection != null && connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private string GetBookIdByTitle(string bookTitle)
        {

            string query = "SELECT bookId FROM book WHERE bookTitle = @bookTitle";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                        object result = sqlCommand.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred while fetching the book ID: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void IssueBookSelectButton_Click(object sender, EventArgs e)
        {
            IssueBookDatagrid issueBookDatagrid = new IssueBookDatagrid(this);
            issueBookDatagrid.ShowDialog();
        }

        public string BookTitle
        {
            get { return IssueBookNameTextBox.Text; }
            set { IssueBookNameTextBox.Text = value; }
        }
    }
}
