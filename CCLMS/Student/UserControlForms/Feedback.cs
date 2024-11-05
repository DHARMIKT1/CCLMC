using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CCLMS.Student.UserControlForms
{
    public partial class Feedback : UserControl
    {
        private readonly SqlConnection con;
        private readonly string loggedInUserId;

        public Feedback(string userId)
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            this.loggedInUserId = userId;
            UserIdTextBox.Text = loggedInUserId;
            UserIdTextBox.ReadOnly = true;

            UserIdTextBox.KeyDown += HandleArrowKeys;
            NameTextBox.KeyDown += HandleArrowKeys;
            EmailTextBox.KeyDown += HandleArrowKeys;
            MessageTextBox.KeyDown += HandleArrowKeys;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private bool ValidateFormInputs()
        {
            return !string.IsNullOrEmpty(UserIdTextBox.Text) &&
                   !string.IsNullOrEmpty(NameTextBox.Text) &&
                   !string.IsNullOrEmpty(EmailTextBox.Text) &&
                   !string.IsNullOrEmpty(MessageTextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            EmailTextBox.Clear();
            MessageTextBox.Clear();
            NameTextBox.Focus();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|protonmail\.com|mail\.com|outlook\.com|applemail\.com|zoho\.com)$";
            return Regex.IsMatch(email, pattern);
        }

        private void SubmitFeedbackButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFormInputs())
            {
                MessageBox.Show("Please fill in all required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string FeedbackQuery = @"INSERT INTO feedback (studentId, name, email, message) VALUES (@UserId, @Name, @Email, @Message);";

                        using (SqlCommand sqlCommand = new SqlCommand(FeedbackQuery, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@UserId", UserIdTextBox.Text.ToString());
                            sqlCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Message", MessageTextBox.Text.ToString());

                            sqlCommand.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show("Feedback Submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        transaction.Rollback();
                        MessageBox.Show("A database error occurred: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            finally
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
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

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = NameTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !Char.IsWhiteSpace(NameTextBox.Text[start]))
                    {
                        start--;
                    }
                    NameTextBox.Text = NameTextBox.Text.Remove(start, pos - start);
                    NameTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void EmailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = EmailTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(EmailTextBox.Text[start]))
                    {
                        start--;
                    }
                    EmailTextBox.Text = EmailTextBox.Text.Remove(start, pos - start);
                    EmailTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = MessageTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(MessageTextBox.Text[start]))
                    {
                        start--;
                    }
                    MessageTextBox.Text = MessageTextBox.Text.Remove(start, pos - start);
                    MessageTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
