using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CCLMS.Admin.UserControlForms;
using Siticone.Desktop.UI.WinForms;

namespace CCLMS.Admin
{
    public partial class LibrarianDashboardForm : Form
    {
        // Dictionary to hold user information
        public Dictionary<string, string> UserInfo { get; set; }

        public LibrarianDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            DashboardLibrarian dashboardAdmin = new DashboardLibrarian();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(dashboardAdmin);
            dashboardAdmin.Dock = DockStyle.Fill;

            // Display the user's name if available
            if (UserInfo != null && UserInfo.ContainsKey("name"))
            {
                lblUserName.Text = UserInfo.ContainsKey("name") ? UserInfo["name"] : string.Empty;
            }
            else
            {
                lblUserName.Text = "Welcome, User";
            }
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            DashboardLibrarian dashboardAdmin = new DashboardLibrarian();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(dashboardAdmin);
            dashboardAdmin.Dock = DockStyle.Fill;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudents addStudents = new AddStudents();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(addStudents);
            addStudents.Dock = DockStyle.Fill;
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(addBook);
            addBook.Dock = DockStyle.Fill;
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            AddLibrarian addAdmin = new AddLibrarian();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(addAdmin);
            addAdmin.Dock = DockStyle.Fill;
        }

        private void ViewStudentsButton_Click(object sender, EventArgs e)
        {
            ViewStudents viewStudents = new ViewStudents();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(viewStudents);
            panelCenter.Dock = DockStyle.Fill;
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(viewBooks);
            panelCenter.Dock = DockStyle.Fill;
        }

        private void ViewAdminButton_Click(object sender, EventArgs e)
        {
            ViewLibrarian viewAdmin = new ViewLibrarian();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(viewAdmin);
            viewAdmin.Dock = DockStyle.Fill;
        }

        private void StudentFeedbackButton_Click(object sender, EventArgs e)
        {
            StudentsFeedback studentsFeedback = new StudentsFeedback();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(studentsFeedback);
            studentsFeedback.Dock = DockStyle.Fill;
        }

        private void BookFineButton_Click(object sender, EventArgs e)
        {
            BookFine bookFine = new BookFine();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(bookFine);
            bookFine.Dock = DockStyle.Fill;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageDialog.Show("Are you sure you want to logout?", "logout", MessageDialogButtons.YesNo, MessageDialogIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void UserCirclePictureBox_Click(object sender, EventArgs e)
        {
            AccountInfoLibrarian accountInfoAdmin = new AccountInfoLibrarian();
            accountInfoAdmin.UserInfo = UserInfo; // Pass the user information to the form
            accountInfoAdmin.ShowDialog();
        }



        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            AccountInfoLibrarian accountInfoAdmin = new AccountInfoLibrarian();
            accountInfoAdmin.UserInfo = UserInfo; // Pass the user information to the form
            accountInfoAdmin.ShowDialog();
        }
    }
}
