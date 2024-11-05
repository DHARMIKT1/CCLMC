using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Configuration;

namespace CCLMS.Admin
{
    public partial class UpdateStudentInfo : Form
    {
        // SQL Server Connection String
        private readonly SqlConnection con;

        // Store the old user ID for reference during updates
        private readonly int oldUserid;

        public UpdateStudentInfo(int userId, string Name, string Email, string Password, string phoneNumebr, string Department, string Semester, SqlConnection connection)
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            // Store the old user ID and connection
            this.oldUserid = userId;
            this.con = connection;

            PasswordTextBox.PasswordChar = '\u25CF';

            UserIdTextBox.Text = userId.ToString();
            NameTextBox.Text = Name;
            EmailTextBox.Text = Email;
            PhoneNumberTextBox.Text = phoneNumebr.ToString();
            DepartmentTextBox.Text = Department;
            SemesterTextBox.Text = Semester.ToString();

            UserIdTextBox.KeyDown += HandleArrowKeys;
            NameTextBox.KeyDown += HandleArrowKeys;
            EmailTextBox.KeyDown += HandleArrowKeys;
            PasswordTextBox.KeyDown += HandleArrowKeys;
            PhoneNumberTextBox.KeyDown += HandleArrowKeys;
            DepartmentTextBox.KeyDown += HandleArrowKeys;
            SemesterTextBox.KeyDown += HandleArrowKeys;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool ValidateFormInputs()
        {
            return !string.IsNullOrEmpty(UserIdTextBox.Text) &&
                   !string.IsNullOrEmpty(NameTextBox.Text) &&
                   !string.IsNullOrEmpty(EmailTextBox.Text) &&
                   !string.IsNullOrEmpty(PasswordTextBox.Text) &&
                   !string.IsNullOrEmpty(PhoneNumberTextBox.Text) &&
                   !string.IsNullOrEmpty(DepartmentTextBox.Text) &&
                   !string.IsNullOrEmpty(SemesterTextBox.Text);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|protonmail\.com|mail\.com|outlook\.com|applemail\.com|zoho\.com)$";
            return Regex.IsMatch(email, pattern);
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

            string newUserId = UserIdTextBox.Text.Trim();
            string name = NameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string phoneNumber = PhoneNumberTextBox.Text.Trim();
            string department = DepartmentTextBox.Text.Trim();
            string semester = SemesterTextBox.Text.Trim();
            string password = PasswordTextBox.Text; // Original password
            string hashedPassword = HashPassword(password); // Hashed password

            try
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = "UPDATE student SET studentId = @newStudentId, name = @name, email = @email, password = @password, phoneNumber = @phoneNumber, department = @department, semester = @semester WHERE studentId = @studentId";

                        using (SqlCommand sqlCommand = new SqlCommand(updateQuery, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("newStudentId", newUserId);
                            sqlCommand.Parameters.AddWithValue("@name", name);
                            sqlCommand.Parameters.AddWithValue("@email", email);
                            sqlCommand.Parameters.AddWithValue("@password", hashedPassword);
                            sqlCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                            sqlCommand.Parameters.AddWithValue("@department", department);
                            sqlCommand.Parameters.AddWithValue("@semester", semester);
                            sqlCommand.Parameters.AddWithValue("@studentId", oldUserid);

                            sqlCommand.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show($"Record '{NameTextBox.Text}' updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
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
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '\u25CF';
            }
        }

        private void SemesterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UserIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void UserIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = UserIdTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(UserIdTextBox.Text[start]))
                    {
                        start--;
                    }
                    UserIdTextBox.Text = UserIdTextBox.Text.Remove(start, pos - start);
                    UserIdTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
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

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = PasswordTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(PasswordTextBox.Text[start]))
                    {
                        start--;
                    }
                    PasswordTextBox.Text = PasswordTextBox.Text.Remove(start, pos - start);
                    PasswordTextBox.SelectionStart = start;
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

        private void DepartmentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = DepartmentTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(DepartmentTextBox.Text[start]))
                    {
                        start--;
                    }
                    DepartmentTextBox.Text = DepartmentTextBox.Text.Remove(start, pos - start);
                    DepartmentTextBox.SelectionStart = start;
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
    }
}
