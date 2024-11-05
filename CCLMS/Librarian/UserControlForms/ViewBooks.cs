using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Siticone.Desktop.UI.WinForms;
using CCLMS.Admin.DataGridViewDetailViews;

namespace CCLMS.Admin.UserControlForms
{
    public partial class ViewBooks : UserControl
    {
        private readonly SqlConnection con;

        public ViewBooks()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            GetBookData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void GetBookData()
        {
            try
            {
                con.Open();

                string BookQuery = @"SELECT * FROM book";

                using (SqlCommand sqlCommand = new SqlCommand(BookQuery, con))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ViewBooksDataGridView.DataSource = dataTable;
                        }

                        ViewBooksDataGridView.Columns["bookId"].HeaderText = "Book Id";
                        ViewBooksDataGridView.Columns["bookTitle"].HeaderText = "Title";
                        ViewBooksDataGridView.Columns["bookAuthor"].HeaderText = "Author";
                        ViewBooksDataGridView.Columns["bookPublication"].HeaderText = "Publication";
                        ViewBooksDataGridView.Columns["ISBN"].HeaderText = "ISBN";
                        ViewBooksDataGridView.Columns["bookPrice"].HeaderText = "Price";
                        ViewBooksDataGridView.Columns["bookPage"].HeaderText = "Page";
                        ViewBooksDataGridView.Columns["bookQuantity"].HeaderText = "Quantity";
                        ViewBooksDataGridView.Columns["bookLanguage"].HeaderText = "Language";
                        ViewBooksDataGridView.Columns["bookCategory"].HeaderText = "Category";
                        ViewBooksDataGridView.Columns["bookPublishedYear"].HeaderText = "Published Year";
                        ViewBooksDataGridView.Columns["bookAvailableCopies"].HeaderText = "Available Copies";
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
        }

        private void GetSearchData(string searchTerm = "")
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM book";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                {
                    query += " WHERE bookId LIKE @searchTerm OR bookTitle LIKE @searchTerm OR bookAuthor LIKE @searchTerm OR bookLanguage LIKE @searchTerm OR bookPublication LIKE @searchTerm OR bookCategory LIKE @searchTerm OR bookPublishedYear LIKE @searchTerm";
                }

                using (SqlCommand sqlCommand = new SqlCommand(query, con))
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
                            ViewBooksDataGridView.DataSource = dataTable;
                        }
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
        }

        private void BookSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            GetSearchData(BookSearchTextBox.Text.Trim());
        }

        private void BookSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookSearchTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void ViewBooksDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewBooksDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ViewBooksDataGridView.SelectedRows[0];
                    if (int.TryParse(selectedRow.Cells["bookId"].Value.ToString(), out int userId))
                    {
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

                        UpdateBooksInfo updateBooksInfo = new UpdateBooksInfo(bookId, bookTitle, bookAuthor, bookPublication, ISBN, bookPrice, bookPage, bookQuantity, bookLanguage, bookCategory, bookPublishedYear, bookAvailableCopies, con);
                        if (updateBooksInfo.ShowDialog() == DialogResult.OK)
                        {
                            GetBookData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ViewBooksDataGridView.SelectedRows.Count > 0)
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
                                string deleteQuery = "DELETE FROM book WHERE bookId = @BookId";

                                foreach (DataGridViewRow selectedRow in ViewBooksDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["BookId"].Value != null && int.TryParse(selectedRow.Cells["BookId"].Value.ToString(), out int userId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@BookId", userId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        ViewBooksDataGridView.Rows.Remove(selectedRow);
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
    }
}
