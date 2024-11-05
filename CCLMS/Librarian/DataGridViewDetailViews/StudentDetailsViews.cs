using System.Windows.Forms;

namespace CCLMS.Admin.DataGridViewDetailViews
{
    public partial class StudentDetailsViews : Form
    {
        public StudentDetailsViews(int userId, string name, string email, string password, long phoneNumber, string department, int semester)
        {
            InitializeComponent();

            UserIdTextBox.Text = userId.ToString();
            NameTextBox.Text = name;
            EmailTextBox.Text = email;
            PasswordTextBox.Text = password;
            PhoneNumberTextBox.Text = phoneNumber.ToString();
            DepartmentTextBox.Text = department;
            SemesterTextBox.Text = semester.ToString();

            PasswordTextBox.PasswordChar = '\u24CF';
        }
    }
}
