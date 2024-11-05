using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CCLMS.Student.UserControlForms;

namespace CCLMS.Student
{
    public partial class ReservationBookSelectDatagridView : Form
    {
        private readonly SqlConnection con;
        private readonly BookReservation bookReservation;

        public ReservationBookSelectDatagridView(BookReservation bookReservation)
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            this.bookReservation = bookReservation;

            LoadBooksData();
            GetBookSearchData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoadBooksData()
        {
            try
            {
                con.Open();

                string BooksDataQuery = @"SELECT * FROM book";

                using (SqlCommand sqlCommand = new SqlCommand(BooksDataQuery, con))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ReservationBookDataGridView.DataSource = dataTable;

                            ReservationBookDataGridView.Columns["bookId"].HeaderText = "Book Id";
                            ReservationBookDataGridView.Columns["bookTitle"].HeaderText = "Title";
                            ReservationBookDataGridView.Columns["bookAuthor"].HeaderText = "Author";
                            ReservationBookDataGridView.Columns["bookPublication"].HeaderText = "Publication";
                            ReservationBookDataGridView.Columns["ISBN"].HeaderText = "ISBN";
                            ReservationBookDataGridView.Columns["bookPrice"].HeaderText = "Price";
                            ReservationBookDataGridView.Columns["bookPage"].HeaderText = "Page";
                            ReservationBookDataGridView.Columns["bookLanguage"].HeaderText = "Language";
                            ReservationBookDataGridView.Columns["bookCategory"].HeaderText = "Category";
                            ReservationBookDataGridView.Columns["bookPublishedYear"].HeaderText = "Published Year";
                            ReservationBookDataGridView.Columns["bookQuantity"].HeaderText = "Quantity";
                            ReservationBookDataGridView.Columns["bookAvailableCopies"].HeaderText = "Available Copies";
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("A database error occurred while loading book data: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading book data: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void GetBookSearchData(string searchTerm = "")
        {
            try
            {
                con.Open();

                string SearchQuery = "SELECT * FROM book";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                {
                    SearchQuery += " WHERE bookTitle LIKE @searchTerm OR bookAuthor LIKE @searchTerm OR bookCategory LIKE @searchTerm OR bookLanguage LIKE @searchTerm OR bookPublication LIKE @searchTerm OR bookId LIKE @searchTerm";
                }

                using (SqlCommand sqlCommand = new SqlCommand(SearchQuery, con))
                {
                    if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                    {
                        sqlCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    }

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ReservationBookDataGridView.DataSource = dataTable;
                        }
                    }
                }
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
        }

        private void ReservationBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ReservationBookDataGridView.Rows[e.RowIndex];
                string bookTitle = selectedRow.Cells["bookTitle"].Value.ToString();
                bookReservation.BookTitle = bookTitle;
                this.Close();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            GetBookSearchData(SearchTextBox.Text.Trim());
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = SearchTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(SearchTextBox.Text[start]))
                    {
                        start--;
                    }
                    SearchTextBox.Text = SearchTextBox.Text.Remove(start, pos - start);
                    SearchTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
