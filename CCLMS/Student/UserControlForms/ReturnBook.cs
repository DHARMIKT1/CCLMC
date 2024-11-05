using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Student.UserControlForms
{
    public partial class ReturnBook : UserControl
    {
        private readonly SqlConnection con;
        private readonly string loggedInUserId;

        public ReturnBook(string userId)
        {
            InitializeComponent();

            this.loggedInUserId = userId;
            UserIdTextBox.Text = loggedInUserId;
            UserIdTextBox.ReadOnly = true;

            con = new SqlConnection(GetConnectionString());

            LoadIssuedBooks();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoadIssuedBooks()
        {
            string userId = UserIdTextBox.Text;

            string query = "SELECT bookId, bookTitle FROM book WHERE bookId IN (SELECT bookId FROM issueBook WHERE studentId = @userId AND status = 'Issued')";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            BooksListComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                BooksListComboBox.Items.Add(new ComboBoxItem(reader["bookTitle"].ToString(), reader["bookId"].ToString()));
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"An error occurred while loading books: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            if (BooksListComboBox.SelectedItem == null)
            {
                MessageBox.Show("No book selected. Please choose a book from the list to proceed.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboBoxItem selectedBook = (ComboBoxItem)BooksListComboBox.SelectedItem;
            string bookId = selectedBook.Value;
            string userId = UserIdTextBox.Text;
            DateTime returnDate = DateTime.Now;

            string updateIssueBookQuery = "UPDATE issueBook SET returnDate = @returnDate, status = 'Returned' WHERE bookId = @bookId AND studentId = @userId AND status = 'Issued'";
            string insertBookReturnQuery = "INSERT INTO bookReturn (bookId, studentId, returnDate, dueDate, overdueFee) VALUES (@bookId, @userId, @returnDate, @dueDate, @overdueFee)";
            string updateBookCopiesQuery = "UPDATE book SET bookAvailableCopies = bookAvailableCopies + 1 WHERE bookId = @bookId";
            string getDueDateQuery = "SELECT dueDate FROM issueBook WHERE bookId = @bookId AND studentId = @userId AND status = 'Issued'";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                try
                {
                    connection.Open();

                    DateTime dueDate;

                    using (SqlCommand getDueDateCommand = new SqlCommand(getDueDateQuery, connection))
                    {
                        getDueDateCommand.Parameters.AddWithValue("@bookId", bookId);
                        getDueDateCommand.Parameters.AddWithValue("@userId", userId);
                        object result = getDueDateCommand.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("No issued book found with the given Book ID and User ID.");
                            return;
                        }
                        dueDate = (DateTime)result;
                    }

                    decimal overdueFee = 0.00m;
                    if (returnDate.Date > dueDate.Date)
                    {
                        TimeSpan overdueDays = returnDate.Date - dueDate.Date;
                        overdueFee = (decimal)overdueDays.TotalDays * 30.00m;
                    }

                    using (SqlCommand updateIssueBookCommand = new SqlCommand(updateIssueBookQuery, connection))
                    {
                        updateIssueBookCommand.Parameters.AddWithValue("@bookId", bookId);
                        updateIssueBookCommand.Parameters.AddWithValue("@userId", userId);
                        updateIssueBookCommand.Parameters.AddWithValue("@returnDate", returnDate);

                        int updateResult = updateIssueBookCommand.ExecuteNonQuery();
                        if (updateResult < 0)
                        {
                            MessageBox.Show("Error updating issueBook table!");
                            return;
                        }
                    }

                    using (SqlCommand insertBookReturnCommand = new SqlCommand(insertBookReturnQuery, connection))
                    {
                        insertBookReturnCommand.Parameters.AddWithValue("@bookId", bookId);
                        insertBookReturnCommand.Parameters.AddWithValue("@userId", userId);
                        insertBookReturnCommand.Parameters.AddWithValue("@returnDate", returnDate);
                        insertBookReturnCommand.Parameters.AddWithValue("@dueDate", dueDate);
                        insertBookReturnCommand.Parameters.AddWithValue("@overdueFee", overdueFee);

                        int insertResult = insertBookReturnCommand.ExecuteNonQuery();
                        if (insertResult < 0)
                        {
                            MessageBox.Show("Error inserting into bookReturn table!");
                            return;
                        }
                    }

                    using (SqlCommand updateBookCopiesCommand = new SqlCommand(updateBookCopiesQuery, connection))
                    {
                        updateBookCopiesCommand.Parameters.AddWithValue("@bookId", bookId);

                        int updateCopiesResult = updateBookCopiesCommand.ExecuteNonQuery();
                        if (updateCopiesResult < 0)
                        {
                            MessageBox.Show("Error updating Book table!");
                            return;
                        }
                    }

                    MessageBox.Show($"The book '{BooksListComboBox.Text}' has been returned successfully.", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BooksListComboBox.SelectedItem = null;
                    dateTimePickerReturnDate.Value = DateTime.Now;

                    LoadIssuedBooks();
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
                    if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
