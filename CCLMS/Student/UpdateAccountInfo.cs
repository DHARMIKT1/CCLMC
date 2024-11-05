using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CCLMS.Student
{
    public partial class UpdateAccountInfo : Form
    {
        private readonly SqlConnection con;

        public Dictionary<string, string> UserInfo { get; set; }

        public UpdateAccountInfo()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            NameTextBox.KeyDown += HandleArrowKeys;
            EmailTextBox.KeyDown += HandleArrowKeys;
            PhoneNumberTextBox.KeyDown += HandleArrowKeys;
            SemesterTextBox.KeyDown += HandleArrowKeys;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = NameTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(NameTextBox.Text[start]))
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

        private void PhoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = PhoneNumberTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(PhoneNumberTextBox.Text[start]))
                    {
                        start--;
                    }
                    PhoneNumberTextBox.Text = PhoneNumberTextBox.Text.Remove(start, pos - start);
                    PhoneNumberTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void SemesterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = SemesterTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(SemesterTextBox.Text[start]))
                    {
                        start--;
                    }
                    SemesterTextBox.Text = SemesterTextBox.Text.Remove(start, pos - start);
                    SemesterTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
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

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|protonmail\.com|mail\.com|outlook\.com|applemail\.com|zoho\.com)$";
            return Regex.IsMatch(email, pattern);
        }

        private bool ValidateFormInputs()
        {
            return !string.IsNullOrEmpty(NameTextBox.Text) &&
                   !string.IsNullOrEmpty(EmailTextBox.Text) &&
                   !string.IsNullOrEmpty(PhoneNumberTextBox.Text) &&
                   !string.IsNullOrEmpty(SemesterTextBox.Text);
        }

        private void UpdateAccountInfo_Load(object sender, EventArgs e)
        {
            if (UserInfo != null && UserInfo.Count > 0)
            {
                NameTextBox.Text = UserInfo.ContainsKey("name") ? UserInfo["name"] : string.Empty;
                EmailTextBox.Text = UserInfo.ContainsKey("email") ? UserInfo["email"] : string.Empty;
                PhoneNumberTextBox.Text = UserInfo.ContainsKey("phoneNumber") ? UserInfo["phoneNumber"] : string.Empty;
                SemesterTextBox.Text = UserInfo.ContainsKey("semester") ? UserInfo["semester"] : string.Empty;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
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

            if (UserInfo == null || !UserInfo.ContainsKey("userId"))
            {
                MessageBox.Show("User information is not available. Please ensure user is logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userId = UserInfo["userId"];

            try
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = @"UPDATE student SET name = @Name, email = @Email, phoneNumber = @PhoneNumber, semester = @Semester WHERE studentId = @UserId";

                        using (SqlCommand sqlCommand = new SqlCommand(updateQuery, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@Semester", SemesterTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@UserId", userId);

                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Update StudentInfo dictionary
                                UserInfo["name"] = NameTextBox.Text;
                                UserInfo["email"] = EmailTextBox.Text;
                                UserInfo["phoneNumber"] = PhoneNumberTextBox.Text;
                                UserInfo["semester"] = SemesterTextBox.Text;

                                transaction.Commit();
                                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
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
    }
}
