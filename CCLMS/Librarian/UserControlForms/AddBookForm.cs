using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CCLMS.Admin.UserControlForms
{
    public partial class AddBookForm : UserControl
    {
        private readonly SqlConnection con;
        public AddBookForm()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            BookTitleTextBox.KeyDown += HandleArrowKeys;
            BookAuthorTextBox.KeyDown += HandleArrowKeys;
            BookPublicationTextBox.KeyDown += HandleArrowKeys;
            BookPriceTextBox.KeyDown += HandleArrowKeys;
            BookPageTextBox.KeyDown += HandleArrowKeys;
            BookQuantityTextBox.KeyDown += HandleArrowKeys;
            BookLanguageTextBox.KeyDown += HandleArrowKeys;
            BookCategoryTextBox.KeyDown += HandleArrowKeys;
            BookPublishedYearTextBox.KeyDown += HandleArrowKeys;
            BookAvailableCopiesTextBox.KeyDown += HandleArrowKeys;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private bool ValidateFormInputs()
        {
            return !string.IsNullOrEmpty(BookTitleTextBox.Text) &&
                   !string.IsNullOrEmpty(BookAuthorTextBox.Text) &&
                   !string.IsNullOrEmpty(BookPublicationTextBox.Text) &&
                   !string.IsNullOrEmpty(BookPriceTextBox.Text) &&
                   !string.IsNullOrEmpty(BookPageTextBox.Text) &&
                   !string.IsNullOrEmpty(BookQuantityTextBox.Text) &&
                   !string.IsNullOrEmpty(BookLanguageTextBox.Text) &&
                   !string.IsNullOrEmpty(BookCategoryTextBox.Text) &&
                   !string.IsNullOrEmpty(BookPublishedYearTextBox.Text) &&
                   !string.IsNullOrEmpty(BookAvailableCopiesTextBox.Text) &&
                   !string.IsNullOrEmpty(IsbnTextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BookTitleTextBox.Clear();
            BookAuthorTextBox.Clear();
            BookPublicationTextBox.Clear();
            BookPriceTextBox.Clear();
            BookPageTextBox.Clear();
            BookQuantityTextBox.Clear();
            BookLanguageTextBox.Clear();
            BookCategoryTextBox.Clear();
            BookPublishedYearTextBox.Clear();
            BookAvailableCopiesTextBox.Clear();
            IsbnTextBox.Clear();
            BookTitleTextBox.Focus();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFormInputs())
            {
                MessageBox.Show("Please fill in all required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string Query = @"INSERT INTO book (bookTitle, bookAuthor, bookPublication, ISBN, bookPrice, bookPage, bookQuantity, bookLanguage, bookCategory, bookPublishedYear, bookAvailableCopies) VALUES (@BookTitle, @BookAuthor, @BookPublication, @isbn, @BookPrice, @BookPage, @BookQuantity, @BookLanguage, @BookCategory, @BookPublishedYear, @BookAvailableCopies);";

                        using (SqlCommand sqlCommand = new SqlCommand(Query, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@BookTitle", BookTitleTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookAuthor", BookAuthorTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookPublication", BookPublicationTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@isbn", IsbnTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookPrice", BookPriceTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookPage", BookPageTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookQuantity", BookQuantityTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookLanguage", BookLanguageTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookCategory", BookCategoryTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookPublishedYear", BookPublishedYearTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@BookAvailableCopies", BookAvailableCopiesTextBox.Text);

                            sqlCommand.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show($"The Book '{BookTitleTextBox.Text}' Added Successfully", "Added Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            BookTitleTextBox.Clear();
                            BookAuthorTextBox.Clear();
                            BookPublicationTextBox.Clear();
                            BookPriceTextBox.Clear();
                            BookPageTextBox.Clear();
                            BookQuantityTextBox.Clear();
                            BookLanguageTextBox.Clear();
                            BookCategoryTextBox.Clear();
                            BookPublishedYearTextBox.Clear();
                            BookAvailableCopiesTextBox.Clear();
                            IsbnTextBox.Clear();
                            BookTitleTextBox.Focus();
                        }
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
                BookPublishedYearTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookAvailableCopiesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                BookAvailableCopiesTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void BookAvailableCopiesTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BookPageTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
