using System.Windows.Forms;

namespace CCLMS.Admin.DataGridViewDetailViews
{
    public partial class BookDetailsForm : Form
    {
        public BookDetailsForm(int bookId, string bookTitle, string bookAuthor, string bookPublication, string ISBN, decimal bookPrice, int bookPage, int bookQuantity, string bookLanguage, string bookCategory, int bookPublishedYear, int bookAvailableCopies)
        {
            InitializeComponent();

            BookIdTextBox.Text = bookId.ToString();
            BookTitleTextBox.Text = bookTitle;
            BookAuthorTextBox.Text = bookAuthor;
            BookPublicationTextBox.Text = bookPublication;
            BookPriceTextBox.Text = bookPrice.ToString();
            BookPageTextBox.Text = bookPage.ToString();
            BookQuantityTextBox.Text = bookQuantity.ToString();
            BookLanguageTextBox.Text = bookLanguage;
            BookCategoryTextBox.Text = bookCategory;
            BookPublishedYearTextBox.Text = bookPublishedYear.ToString();
            BookAvailableCopiesTextBox.Text = bookAvailableCopies.ToString();
            LsbnTextBox.Text = ISBN;
        }
    }
}
