using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CCLMS.Student.UserControlForms;
using Siticone.Desktop.UI.WinForms;

namespace CCLMS.Student
{
    public partial class StudentDashboardForm : Form
    {
        public Dictionary<string, string> UserInfo { get; set; }

        public string LoggedInUserId { get; set; } // Property to receive logged-in user ID

        public StudentDashboardForm()
        {
            InitializeComponent();
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            DashboardStudent dashboardStudent = new DashboardStudent();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(dashboardStudent);
            dashboardStudent.Dock = DockStyle.Fill;

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
            DashboardStudent dashboardStudent = new DashboardStudent();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(dashboardStudent);
            dashboardStudent.Dock = DockStyle.Fill;
        }

        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook(LoggedInUserId);
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(issueBook);
            issueBook.Dock = DockStyle.Fill;
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook(LoggedInUserId);
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(returnBook);
            returnBook.Dock = DockStyle.Fill;
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(LoggedInUserId);
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(feedback);
            feedback.Dock = DockStyle.Fill;
        }

        private void BookReservationButton_Click(object sender, EventArgs e)
        {
            BookReservation bookReservation = new BookReservation(LoggedInUserId);
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(bookReservation);
            bookReservation.Dock = DockStyle.Fill;
        }

        private void VIewBooksReservationButton_Click(object sender, EventArgs e)
        {
            ViewReservation viewReservation = new ViewReservation();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(viewReservation);
            viewReservation.Dock = DockStyle.Fill;
        }

        private void CompleteBookButton_Click(object sender, EventArgs e)
        {
            CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(completeBookDetails);
            completeBookDetails.Dock = DockStyle.Fill;
        }

        private void CompleteStudentsDetailsButton_Click(object sender, EventArgs e)
        {
            CompleteStudentsDetails completeStudentsDetails = new CompleteStudentsDetails();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(completeStudentsDetails);
            completeStudentsDetails.Dock = DockStyle.Fill;
        }
        private void ReadingHistoryButton_Click(object sender, EventArgs e)
        {
            ReadingHistory readingHistory = new ReadingHistory(LoggedInUserId);
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(readingHistory);
            readingHistory.Dock = DockStyle.Fill;
        }

        private void BookListButton_Click(object sender, EventArgs e)
        {
            BooksList booksList = new BooksList();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(booksList);
            booksList.Dock = DockStyle.Fill;
        }

        private void UserCirclePictureBox_Click(object sender, EventArgs e)
        {
            AccountInfoStudent accstudent = new AccountInfoStudent();
            accstudent.UserInfo = UserInfo;
            accstudent.ShowDialog();
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

        private void lblUserName_Click(object sender, EventArgs e)
        {
            AccountInfoStudent accountInfoStudent = new AccountInfoStudent();
            accountInfoStudent.UserInfo = UserInfo;
            accountInfoStudent.ShowDialog();
        }
    }
}
