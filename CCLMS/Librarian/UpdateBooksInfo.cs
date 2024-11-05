using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CCLMS.Admin
{
    public partial class UpdateBooksInfo : Form
    {
        private readonly SqlConnection con;

        public UpdateBooksInfo(int bookId, string bookTitle, string bookAuthor, string bookPublication, string ISBN, decimal bookPrice, int bookPage, int bookQuantity, string bookLanguage, string bookCategory, int bookPublishedYear, int bookAvailableCopies, SqlConnection connection)
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            BookIdTextBox.Text = bookId.ToString();
            BookTitleTextBox.Text = bookTitle;
            BookAuthorTextBox.Text = bookAuthor;
            BookPublicationTextBox.Text = bookPublication;
            IsbnTextBox.Text = ISBN.ToString();
            BookPriceTextBox.Text = bookPrice.ToString();
            BookPageTextBox.Text = bookPage.ToString();
            BookQuantityTextBox.Text = bookQuantity.ToString();
            BookLanguageTextBox.Text = bookLanguage;
            BookCategoryTextBox.Text = bookCategory;
            BookPublishedYearTextBox.Text = bookPublishedYear.ToString();
            BookAvailabelCopiesTextBox.Text = bookAvailableCopies.ToString();

            BookIdTextBox.KeyDown += HandleArrowKeys;
            BookTitleTextBox.KeyDown += HandleArrowKeys;
            BookAuthorTextBox.KeyDown += HandleArrowKeys;
            BookPublicationTextBox.KeyDown += HandleArrowKeys;
            BookPriceTextBox.KeyDown += HandleArrowKeys;
            BookPageTextBox.KeyDown += HandleArrowKeys;
            BookQuantityTextBox.KeyDown += HandleArrowKeys;
            BookLanguageTextBox.KeyDown += HandleArrowKeys;
            BookCategoryTextBox.KeyDown += HandleArrowKeys;
            BookPublishedYearTextBox.KeyDown += HandleArrowKeys;
            BookAvailabelCopiesTextBox.KeyDown += HandleArrowKeys;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private bool ValidateForm()
        {
            return !string.IsNullOrWhiteSpace(BookTitleTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(BookAuthorTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(BookPublicationTextBox.Text) &&
                   !string.IsNullOrEmpty(IsbnTextBox.Text) &&
                   decimal.TryParse(BookPriceTextBox.Text, out _) &&
                   int.TryParse(BookPageTextBox.Text, out _) &&
                   int.TryParse(BookQuantityTextBox.Text, out _) &&
                   !string.IsNullOrWhiteSpace(BookLanguageTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(BookCategoryTextBox.Text) &&
                   int.TryParse(BookPublishedYearTextBox.Text, out _) &&
                   int.TryParse(BookAvailabelCopiesTextBox.Text, out _);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = @"UPDATE book
                                SET 
                                    bookTitle = @Title, 
                                    bookAuthor = @Author, 
                                    bookPublication = @Publication, 
                                    ISBN = @isbn,
                                    bookPrice = @Price, 
                                    bookPage = @Page, 
                                    bookQuantity = @Quantity, 
                                    bookLanguage = @Language, 
                                    bookCategory = @Category, 
                                    bookPublishedYear = @PublishedYear, 
                                    bookAvailableCopies = @AvailableCopies 
                                WHERE
                                    bookId = @BookId
                        ";

                        using (SqlCommand sqlCommand = new SqlCommand(updateQuery, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@Title", BookTitleTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Author", BookAuthorTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Publication", BookPublicationTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@isbn", IsbnTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Price", decimal.Parse(BookPriceTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@Page", BookPageTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Quantity", int.Parse(BookQuantityTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@Language", BookLanguageTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Category", BookCategoryTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@PublishedYear", int.Parse(BookPublishedYearTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@AvailableCopies", int.Parse(BookAvailabelCopiesTextBox.Text));
                            sqlCommand.Parameters.AddWithValue("@BookId", int.Parse(BookIdTextBox.Text));

                            sqlCommand.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show($"Book '{BookTitleTextBox.Text}' updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric data for Price, Page, Quantity, Published Year, and Available Copies.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void BookIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookIdTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookTitleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookTitleTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookAuthorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookAuthorTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookPublicationTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookPublicationTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookPriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookPriceTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookPageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookPageTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookQuantityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookQuantityTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookLanguageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookLanguageTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookCategoryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookCategoryTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookPublishedYearTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookPublicationTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookAvailabelCopiesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookAvailabelCopiesTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookAvailabelCopiesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookPageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HandleArrowKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
