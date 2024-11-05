using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CCLMS.Admin.UserControlForms
{
    public partial class AddStudents : UserControl
    {
        private readonly SqlConnection con;

        public AddStudents()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            PasswordTextBox.PasswordChar = '\u25CF';
            ConfirmPasswordTextBox.PasswordChar = '\u25CF';

            UserIdTextBox.KeyDown += HandleArrowKeys;
            NameTextBox.KeyDown += HandleArrowKeys;
            EmailTextBox.KeyDown += HandleArrowKeys;
            PasswordTextBox.KeyDown += HandleArrowKeys;
            ConfirmPasswordTextBox.KeyDown += HandleArrowKeys;
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
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
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

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '\u25CF';
                ConfirmPasswordTextBox.PasswordChar = '\u25CF';
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserIdTextBox.Clear();
            NameTextBox.Clear();
            EmailTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
            PhoneNumberTextBox.Clear();
            DepartmentTextBox.Clear();
            SemesterTextBox.Clear();
            UserIdTextBox.Focus();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFormInputs())
            {
                MessageBox.Show("Please fill in all required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string query = @"INSERT INTO student (studentId, name, email, password, phoneNumber, department, semester) VALUES (@userId, @name, @email, @password, @phoneNumber, @department, @semester);";

                        string hashedPassword = HashPassword(PasswordTextBox.Text);

                        using (SqlCommand sqlCommand = new SqlCommand(query, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@userId", UserIdTextBox.Text.ToString());
                            sqlCommand.Parameters.AddWithValue("@name", NameTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@email", EmailTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@password", hashedPassword);
                            sqlCommand.Parameters.AddWithValue("@phoneNumber", PhoneNumberTextBox.Text.ToString());
                            sqlCommand.Parameters.AddWithValue("@department", DepartmentTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@semester", SemesterTextBox.Text.ToString());

                            sqlCommand.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show($"The Student '{NameTextBox.Text}' Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UserIdTextBox.Clear();
                            NameTextBox.Clear();
                            EmailTextBox.Clear();
                            PasswordTextBox.Clear();
                            ConfirmPasswordTextBox.Clear();
                            PhoneNumberTextBox.Clear();
                            DepartmentTextBox.Clear();
                            SemesterTextBox.Clear();
                            UserIdTextBox.Focus();
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

        private void UserIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SemesterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UserIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                UserIdTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                NameTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void EmailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                EmailTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                PasswordTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void ConfirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                ConfirmPasswordTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void PhoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                PhoneNumberTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void DepartmentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                DepartmentTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void SemesterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                SemesterTextBox.Clear();
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

        private string CheckPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8) score++;
            if (Regex.IsMatch(password, @"[a-z]")) score++;
            if (Regex.IsMatch(password, @"[A-Z]")) score++;
            if (Regex.IsMatch(password, @"[0-9]")) score++;
            if (Regex.IsMatch(password, @"[!@#$%^&*(),.?\"":{}|<>]")) score++;

            switch (score)
            {
                case 5:
                    return "Strong";
                case 4:
                    return "Medium";
                case 3:
                    return "Weak";
                default:
                    return "Very Weak";
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string passwordStrength = CheckPasswordStrength(PasswordTextBox.Text.Trim());
            LabelPasswordStrength.Text = $"Password Strength: {passwordStrength}";

            switch (passwordStrength)
            {
                case "Strong":
                    LabelPasswordStrength.ForeColor = System.Drawing.Color.Green;
                    break;
                case "Medium":
                    LabelPasswordStrength.ForeColor = System.Drawing.Color.Orange;
                    break;
                case "Weak":
                case "Very Weak":
                    LabelPasswordStrength.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    LabelPasswordStrength.ForeColor = System.Drawing.Color.Black;
                    break;
            }
        }
    }
}
