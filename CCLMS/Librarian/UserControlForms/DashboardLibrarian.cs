using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CCLMS.Admin.UserControlForms
{
    public partial class DashboardLibrarian : UserControl
    {
        private readonly SqlConnection con;

        public DashboardLibrarian()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            LoadData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        // Method to load all the necessary data
        private void LoadData()
        {
            try
            {
                LoadTotalStudents();
                LoadTotalBooks();
                LoadTotleIssueBooks();
                LoadTotalReturnedBooks();
                LoadTotalReservationBooks();
                LoadTotalLibrarian();
                LoadTotalFeedback();
                LoadTotalBookFine();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("An error occurred while loading data: " + sqlEx.Message, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void UpdateLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => label.Text = text));
            }
            else
            {
                label.Text = text;
            }
        }

        // Load total number of students and update label
        private void LoadTotalStudents()
        {
            int totalStudents = GetTotalStudents();
            UpdateLabel(TotalStudentNumberLabel, totalStudents.ToString());
        }

        // Get total number of students from the database
        private int GetTotalStudents()
        {

            int totalStudents = 0;
            string StudentQuery = @"SELECT COUNT(*) FROM student";
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(@StudentQuery, con))
                {
                    con.Open();
                    totalStudents = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalStudents;
        }

        // Load total number of books and update label
        private void LoadTotalBooks()
        {
            int totalBooks = GetTotalBooks();
            UpdateLabel(TotalBookNumberLabel, totalBooks.ToString());
        }

        // Get total number of books from the database
        private int GetTotalBooks()
        {
            int totalBooks = 0;
            string BooksQuery = @"SELECT COUNT(*) FROM book";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(@BooksQuery, con))
                {
                    totalBooks = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalBooks;
        }

        // Load total number of issued books and update label
        private void LoadTotleIssueBooks()
        {
            int totleIssueBooks = GetTotleIssueBooks();
            UpdateLabel(TotalIssuesBooksNumberLabel, totleIssueBooks.ToString());
        }

        // Get total number of issued books from the database
        private int GetTotleIssueBooks()
        {
            int totleIssueBooks = 0;
            string IssueBookQuery = @"SELECT COUNT(*) FROM issueBook";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(@IssueBookQuery, con))
                {
                    totleIssueBooks = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totleIssueBooks;
        }

        // Load total number of returned books and update label
        private void LoadTotalReturnedBooks()
        {
            int TotalReturnedBooks = GetReturnedBooks();
            UpdateLabel(TotalReturnedBooksNumberLabel, TotalReturnedBooks.ToString());
        }

        // Get total number of returned books from the database
        private int GetReturnedBooks()
        {
            int TotalReturnedBooks = 0;
            string ReturnedbooksQuery = @"SELECT COUNT(*) FROM bookReturn";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(@ReturnedbooksQuery, con))
                {
                    TotalReturnedBooks = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TotalReturnedBooks;
        }

        // Load total number of reserved books and update label
        private void LoadTotalReservationBooks()
        {
            int TotalReservationBooks = GetTotalReservations();
            UpdateLabel(TotalReservationBooksNumber, TotalReservationBooks.ToString());
        }

        // Get total number of reserved books from the database
        private int GetTotalReservations()
        {
            int totalReservations = 0;
            string ReservationBooksQuery = @"SELECT COUNT(*) FROM bookReservation";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(@ReservationBooksQuery, con))
                {
                    totalReservations = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalReservations;
        }

        // Load total number of admin and update label
        private void LoadTotalLibrarian()
        {
            int totalLibrarian = GetTotalLibrarian();
            UpdateLabel(TotalAdminNumberLabel, totalLibrarian.ToString());
        }

        // Get total number of admin from the database
        private int GetTotalLibrarian()
        {
            int totalLibrarian = 0;
            string LibrarianQuery = @"SELECT COUNT(*) FROM librarian";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(@LibrarianQuery, con))
                {
                    totalLibrarian = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalLibrarian;
        }

        // Load total number of feedbacks and update label
        private void LoadTotalFeedback()
        {
            int totalFeedback = GetTotalFeedback();
            UpdateLabel(TotalFeedbackNumberLabel, totalFeedback.ToString());
        }

        // Get total number of feedbacks from the database
        private int GetTotalFeedback()
        {
            int totalFeedback = 0;
            string FeedbackQuery = @"SELECT COUNT(*) FROM feedback";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(@FeedbackQuery, con))
                {
                    totalFeedback = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalFeedback;
        }

        // Load total number of book fines and update label
        private void LoadTotalBookFine()
        {
            int totalBookFine = GetTotalBookFine();
            UpdateLabel(TotalBooksFineNumberLabel, totalBookFine.ToString());
        }

        // Get total number of book fines from the database
        private int GetTotalBookFine()
        {
            int totalBookFine = 0;
            string BookFineQuery = @"SELECT COUNT(*) FROM bookFine";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(BookFineQuery, con))
                {
                    totalBookFine = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalBookFine;
        }

        private void IssueAndReturnBookDataDeleteButton_Click(object sender, EventArgs e)
        {
            IssueAndReturnBookDataDelete issueAndReturnBookDataDelete = new IssueAndReturnBookDataDelete();
            issueAndReturnBookDataDelete.ShowDialog();
        }

        private void ReservationRemoveButton_Click(object sender, EventArgs e)
        {
            ReservationRemove reservationRemove = new ReservationRemove();
            reservationRemove.ShowDialog();
        }
    }
}
