using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CCLMS.Student.UserControlForms
{
    public partial class BookReservation : UserControl
    {
        private readonly SqlConnection con;
        private readonly string loggedInUserId;

        public BookReservation(string userId)
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            this.loggedInUserId = userId;
            UserIdTextBox.Text = loggedInUserId;
            UserIdTextBox.ReadOnly = true;

            LoadAvailableBooks();
            LoadReservedBooks();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoadAvailableBooks()
        {
            string query = "SELECT bookId, bookTitle FROM book WHERE bookAvailableCopies > 0";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ReservationBookNameTextBox.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading books: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
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

        private void ReservationBooksButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ReservationBookNameTextBox.Text))
            {
                MessageBox.Show("Please select a book.");
                return;
            }

            if (DateTimePickerExpectedPickupDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The Pickup date cannot be in the past. Please select a valid pickup date.", "Invalid Pickup Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookId = GetBookIdFromTitle(ReservationBookNameTextBox.Text);
            string userId = UserIdTextBox.Text;
            DateTime? expectedPickupDate = null;

            if (DateTimePickerExpectedPickupDate.Checked)
            {
                expectedPickupDate = DateTimePickerExpectedPickupDate.Value;
            }

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM bookReservation WHERE bookId = @bookId AND studentId= @userId AND reservationStatus = 'Active'";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@bookId", bookId);
                    checkCommand.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        connection.Open();
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("You have already reserved this book.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while checking reservations: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }

                string countReservationsQuery = "SELECT COUNT(*) FROM bookReservation WHERE studentId = @userId AND reservationStatus = 'Active'";

                using (SqlCommand countReservationsCommand = new SqlCommand(countReservationsQuery, connection))
                {
                    countReservationsCommand.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        connection.Open();
                        int reservationCount = (int)countReservationsCommand.ExecuteScalar();

                        if (reservationCount >= 3)
                        {
                            MessageBox.Show("You have reached the limit of 3 reserved books. Please cancel a reservation before reserving a new one.", "Reservation Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }

                string insertQuery = "INSERT INTO bookReservation (bookId, studentId, expectedPickupDate, reservationStatus) VALUES (@bookId, @userId, @expectedPickupDate, 'Active')";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@bookId", bookId);
                    insertCommand.Parameters.AddWithValue("@userId", userId);
                    insertCommand.Parameters.AddWithValue("@expectedPickupDate", (object)expectedPickupDate ?? DBNull.Value);

                    try
                    {
                        connection.Open();
                        int result = insertCommand.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("Error reserving book!");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }

                string updateBookCopiesQuery = "UPDATE book SET bookAvailableCopies = bookAvailableCopies - 1 WHERE bookId = @bookId";

                using (SqlCommand updateBookCopiesCommand = new SqlCommand(updateBookCopiesQuery, connection))
                {
                    updateBookCopiesCommand.Parameters.AddWithValue("@bookId", bookId);

                    try
                    {
                        connection.Open();
                        int updateResult = updateBookCopiesCommand.ExecuteNonQuery();
                        if (updateResult < 0)
                        {
                            MessageBox.Show("Error updating available copies!");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }

                MessageBox.Show($"The Book '{ReservationBookNameTextBox.Text}' reserved successfully!", "Reservation Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DateTimePickerExpectedPickupDate.Value = DateTime.Today;
                DateTimePickerExpectedPickupDate.Checked = false;
                LoadReservedBooks();
                LoadAvailableBooks();
            }
        }

        private string GetBookIdFromTitle(string bookTitle)
        {
            string bookId = null;
            string query = "SELECT bookId FROM book WHERE bookTitle = @bookTitle";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookTitle", bookTitle);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bookId = reader["bookId"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving the book ID: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            return bookId;
        }

        private void LoadReservedBooks()
        {
            string query = @"
                SELECT 
                    br.bookId, 
                    b.bookTitle 
                FROM
                    bookReservation br 
                INNER JOIN 
                    book b ON br.bookId = b.bookId 
                WHERE
                    br.studentId = @userId AND br.reservationStatus = 'Active'
            ";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", loggedInUserId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ReservationsListComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                ReservationsListComboBox.Items.Add(new ComboBoxItem(reader["bookTitle"].ToString(), reader["bookId"].ToString()));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading reserved books: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void UnreservationButton_Click(object sender, EventArgs e)
        {
            if (ReservationsListComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to unreserve.");
                return;
            }

            ComboBoxItem selectedBook = (ComboBoxItem)ReservationsListComboBox.SelectedItem;
            string bookId = selectedBook.Value;
            string userId = UserIdTextBox.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string deleteReservationBookQuery = "DELETE FROM bookReservation WHERE bookId = @bookId AND studentId = @userId AND reservationStatus = 'Active'";

                    using (SqlCommand deleteReservationBookCommand = new SqlCommand(deleteReservationBookQuery, connection))
                    {
                        deleteReservationBookCommand.Parameters.AddWithValue("@bookId", bookId);
                        deleteReservationBookCommand.Parameters.AddWithValue("@userId", userId);

                        int deleteResult = deleteReservationBookCommand.ExecuteNonQuery();
                        if (deleteResult <= 0)
                        {
                            MessageBox.Show("Error deleting reservation!");
                            return;
                        }
                    }

                    string updateBookCopiesQuery = "UPDATE book SET bookAvailableCopies = bookAvailableCopies + 1 WHERE bookId = @bookId";

                    using (SqlCommand updateBookCopiesCommand = new SqlCommand(updateBookCopiesQuery, connection))
                    {
                        updateBookCopiesCommand.Parameters.AddWithValue("@bookId", bookId);

                        int updateResult = updateBookCopiesCommand.ExecuteNonQuery();
                        if (updateResult <= 0)
                        {
                            MessageBox.Show("Error updating available copies!");
                            return;
                        }
                    }

                    MessageBox.Show($"The Book '{ReservationsListComboBox.Text}' unreserved successfully!", "Unreservation Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReservedBooks();
                    LoadAvailableBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void CompleteReadingButton_Click(object sender, EventArgs e)
        {
            if (ReservationsListComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to complete reading.", "Select a book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ComboBoxItem selectedBook = (ComboBoxItem)ReservationsListComboBox.SelectedItem;
            string bookId = selectedBook.Value;
            string userId = UserIdTextBox.Text;

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string completeReservationQuery = "UPDATE bookReservation SET reservationStatus = 'Completed Reading' WHERE bookId = @bookId AND studentId = @userId AND reservationStatus = 'Active'";

                    using (SqlCommand completeReservationCommand = new SqlCommand(completeReservationQuery, connection))
                    {
                        completeReservationCommand.Parameters.AddWithValue("@bookId", bookId);
                        completeReservationCommand.Parameters.AddWithValue("@userId", userId);

                        int completeResult = completeReservationCommand.ExecuteNonQuery();
                        if (completeResult <= 0)
                        {
                            MessageBox.Show("Error marking reservation as completed!");
                            return;
                        }
                    }

                    string updateBookCopiesQuery = "UPDATE book SET bookAvailableCopies = bookAvailableCopies + 1 WHERE bookId = @bookId";

                    using (SqlCommand updateBookCopiesCommand = new SqlCommand(updateBookCopiesQuery, connection))
                    {
                        updateBookCopiesCommand.Parameters.AddWithValue("@bookId", bookId);

                        int updateResult = updateBookCopiesCommand.ExecuteNonQuery();
                        if (updateResult <= 0)
                        {
                            MessageBox.Show("Error updating available copies!");
                            return;
                        }
                    }

                    MessageBox.Show($"The Book '{ReservationsListComboBox.Text}' reading completed successfully!", "reading completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReservedBooks();
                    LoadAvailableBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void IssueBookSelectButton_Click(object sender, EventArgs e)
        {
            ReservationBookSelectDatagridView bookSelectDatagridView = new ReservationBookSelectDatagridView(this);
            bookSelectDatagridView.ShowDialog();
        }

        public string BookTitle
        {
            get { return ReservationBookNameTextBox.Text; }
            set { ReservationBookNameTextBox.Text = value; }
        }
    }
}
