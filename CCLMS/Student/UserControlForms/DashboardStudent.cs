using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Student.UserControlForms
{
    public partial class DashboardStudent : UserControl
    {
        private readonly SqlConnection con;

        public DashboardStudent()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            LoadData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoadData()
        {
            try
            {
                LoadTotalStudents();
                LoadTotalBooks();
                LoadTotleIssueBooks();
                LoadTotalReturnedBooks();
                LoadTotalReservationBooks();
                LoadTotalFeedback();
                LoadToalBookFine();
                LoadTotalLibrarian();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("An error occurred while loading data: " + sqlEx.Message, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoadTotalStudents()
        {
            int totalStudents = GetTotalStudents();
            UpdateLabel(TotalStudentNumberLabel, totalStudents.ToString());
        }

        private int GetTotalStudents()
        {
            int totalStudents = 0;
            string StudentQuery = @"SELECT COUNT(*) FROM student";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(StudentQuery, con))
                {
                    totalStudents = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return totalStudents;
        }

        private void LoadTotalBooks()
        {
            int totalBooks = GetTotalBooks();
            UpdateLabel(TotalBookNumberLabel, totalBooks.ToString());
        }

        private int GetTotalBooks()
        {
            int totalBooks = 0;
            string BooksQuery = @"SELECT COUNT(*) FROM book";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(BooksQuery, con))
                {
                    totalBooks = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return totalBooks;
        }

        private void LoadTotleIssueBooks()
        {
            int totleIssueBooks = GetTotleIssueBooks();
            UpdateLabel(TotalIssuesBooksNumberLabel, totleIssueBooks.ToString());
        }

        private int GetTotleIssueBooks()
        {
            int totleIssueBooks = 0;
            string IssueBookQuery = @"SELECT COUNT(*) FROM issueBook";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(IssueBookQuery, con))
                {
                    totleIssueBooks = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return totleIssueBooks;
        }

        private void LoadTotalReturnedBooks()
        {
            int TotalReturnedBooks = GetReturnedBooks();
            UpdateLabel(TotalReturnedBooksNumberLabel, TotalReturnedBooks.ToString());
        }

        private int GetReturnedBooks()
        {
            int TotalReturnedBooks = 0;
            string ReturnedbooksQuery = @"SELECT COUNT(*) FROM bookReturn";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(ReturnedbooksQuery, con))
                {
                    TotalReturnedBooks = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return TotalReturnedBooks;
        }

        private void LoadTotalReservationBooks()
        {
            int TotalReservationBooks = GetTotalReservations();
            UpdateLabel(TotalReservationBooksNumber, TotalReservationBooks.ToString());
        }

        private int GetTotalReservations()
        {
            int totalReservations = 0;
            string ReservationBooksQuery = @"SELECT COUNT(*) FROM bookReservation";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(ReservationBooksQuery, con))
                {
                    totalReservations = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return totalReservations;
        }

        private void LoadTotalFeedback()
        {
            int totalFeedback = GetTotalFeedback();
            UpdateLabel(TotalFeedbackNumberLabel, totalFeedback.ToString());
        }

        private int GetTotalFeedback()
        {
            int totalFeedback = 0;
            string FeedbackQuery = @"SELECT COUNT(*) FROM feedback";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(FeedbackQuery, con))
                {
                    totalFeedback = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return totalFeedback;
        }

        private void LoadToalBookFine()
        {
            int TotalBookFine = GetToalBookFine();
            UpdateLabel(TotalBooksFineNumberLabel, TotalBookFine.ToString());
        }

        private int GetToalBookFine()
        {
            int TotalBookFine = 0;
            string BookFineQuery = @"SELECT COUNT(*) FROM bookFine";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(BookFineQuery, con))
                {
                    TotalBookFine = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return TotalBookFine;
        }

        private void LoadTotalLibrarian()
        {
            int totalLibrarian = GetTotalLibrarian();
            UpdateLabel(TotalLibrarianLabel, totalLibrarian.ToString());
        }

        private int GetTotalLibrarian()
        {
            int totalLibrarian = 0;
            string LibrarianQuery = @"SELECT COUNT(*) FROM librarian";

            try
            {
                con.Open();
                using (SqlCommand sqlCommand = new SqlCommand(@LibrarianQuery, con))
                {
                    totalLibrarian = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return totalLibrarian;
        }
    }
}
