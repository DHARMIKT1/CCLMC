using System;
using System.Windows.Forms;

namespace CCLMS.Admin.DataGridViewDetailViews
{
    public partial class StudentFeedbackDetailsViews : Form
    {
        public StudentFeedbackDetailsViews(int feedbackId, int userId, string name, string email, string message, DateTime createdAt)
        {
            InitializeComponent();

            FeedbackIdTextBox.Text = feedbackId.ToString();
            UserIdTextBox.Text = userId.ToString();
            NameTextBox.Text = name.ToString();
            EmailTextBox.Text = email.ToString();
            MessageTextBox.Text = message.ToString();
            CreatedAtTextBox.Text = createdAt.ToString();
        }
    }
}
