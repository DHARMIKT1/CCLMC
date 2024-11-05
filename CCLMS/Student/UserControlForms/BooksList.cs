using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CCLMS.Student.DataGridViewDetailViews;
using Siticone.Desktop.UI.WinForms;

namespace CCLMS.Student.UserControlForms
{
    public partial class BooksList : UserControl
    {
        private readonly SqlConnection con;

        public BooksList()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

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
                            ViewBooksListDataGridView.DataSource = dataTable;

                            ViewBooksListDataGridView.Columns["bookId"].HeaderText = "Book Id";
                            ViewBooksListDataGridView.Columns["bookTitle"].HeaderText = "Title";
                            ViewBooksListDataGridView.Columns["bookAuthor"].HeaderText = "Author";
                            ViewBooksListDataGridView.Columns["bookPublication"].HeaderText = "Publication";
                            ViewBooksListDataGridView.Columns["ISBN"].HeaderText = "ISBN";
                            ViewBooksListDataGridView.Columns["bookPrice"].HeaderText = "Price";
                            ViewBooksListDataGridView.Columns["bookPage"].HeaderText = "Page";
                            ViewBooksListDataGridView.Columns["bookLanguage"].HeaderText = "Language";
                            ViewBooksListDataGridView.Columns["bookCategory"].HeaderText = "Category";
                            ViewBooksListDataGridView.Columns["bookPublishedYear"].HeaderText = "Published Year";
                            ViewBooksListDataGridView.Columns["bookQuantity"].HeaderText = "Quantity";
                            ViewBooksListDataGridView.Columns["bookAvailableCopies"].HeaderText = "Available Copies";
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
                            ViewBooksListDataGridView.DataSource = dataTable;
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            GetBookSearchData(SearchTextBox.Text.Trim());
        }

        private void ViewBooksListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SiticoneDataGridView dataGridView = sender as SiticoneDataGridView;

                if (dataGridView != null)
                {
                    DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                    int bookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value.ToString());
                    string bookTitle = selectedRow.Cells["bookTitle"].Value.ToString();
                    string bookAuthor = selectedRow.Cells["bookAuthor"].Value.ToString();
                    string bookPublication = selectedRow.Cells["bookPublication"].Value.ToString();
                    string ISBN = selectedRow.Cells["ISBN"].Value.ToString();
                    decimal bookPrice = Convert.ToDecimal(selectedRow.Cells["bookPrice"].Value.ToString());
                    int bookPage = Convert.ToInt32(selectedRow.Cells["bookPage"].Value.ToString());
                    int bookQuantity = Convert.ToInt32(selectedRow.Cells["bookQuantity"].Value.ToString());
                    string bookLanguage = selectedRow.Cells["bookLanguage"].Value.ToString();
                    string bookCategory = selectedRow.Cells["bookCategory"].Value.ToString();
                    int bookPublishedYear = Convert.ToInt32(selectedRow.Cells["bookPublishedYear"].Value.ToString());
                    int bookAvailableCopies = Convert.ToInt32(selectedRow.Cells["bookAvailableCopies"].Value.ToString());

                    BookDetailsForm bookDetailsForm = new BookDetailsForm(bookId, bookTitle, bookAuthor, bookPublication, ISBN, bookPrice, bookPage, bookQuantity, bookLanguage, bookCategory, bookPublishedYear, bookAvailableCopies);
                    bookDetailsForm.ShowDialog();
                }
            }

        }
    }
}
