using System.Windows.Forms;

namespace CCLMS.Admin.DataGridViewDetailViews
{
    public partial class LibrarianDetailsView : Form
    {
        public LibrarianDetailsView(int userId, string name, string email, string password, long phoneNumber)
        {
            InitializeComponent();

            UserIdTextBox.Text = userId.ToString();
            NameTextBox.Text = name.ToString();
            EmailTextBox.Text = email.ToString();
            PasswordTextBox.Text = password.ToString();
            PhoneNumberTextBox.Text = phoneNumber.ToString();
        }
    }
}
