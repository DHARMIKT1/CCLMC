using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CCLMS
{
    public partial class CreateAccountForm : Form
    {
        private readonly SqlConnection con;

        public CreateAccountForm()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            TextBoxUserId.KeyDown += HandleEnterKey;
            TextBoxName.KeyDown += HandleEnterKey;
            TextBoxEmail.KeyDown += HandleEnterKey;
            TextBoxPassword.KeyDown += HandleEnterKey;
            TextBoxPhoneNumber.KeyDown += HandleEnterKey;
            TextBoxDepartment.KeyDown += HandleEnterKey;
            TextBoxSemester.KeyDown += HandleEnterKey;

            TextBoxUserId.KeyDown += HandleClearKey;
            TextBoxName.KeyDown += HandleClearKey;
            TextBoxEmail.KeyDown += HandleClearKey;
            TextBoxPassword.KeyDown += HandleClearKey;
            TextBoxPhoneNumber.KeyDown += HandleClearKey;
            TextBoxDepartment.KeyDown += HandleClearKey;
            TextBoxSemester.KeyDown += HandleClearKey;

            TextBoxUserId.KeyDown += HandleArrowKeys;
            TextBoxName.KeyDown += HandleArrowKeys;
            TextBoxEmail.KeyDown += HandleArrowKeys;
            TextBoxPassword.KeyDown += HandleArrowKeys;
            TextBoxPhoneNumber.KeyDown += HandleArrowKeys;
            TextBoxDepartment.KeyDown += HandleArrowKeys;
            TextBoxSemester.KeyDown += HandleArrowKeys;

            TextBoxPassword.PasswordChar = '\u25CF';
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private bool ValidateFormInputs()
        {
            return !string.IsNullOrEmpty(TextBoxUserId.Text) &&
                   !string.IsNullOrEmpty(TextBoxName.Text) &&
                   !string.IsNullOrEmpty(TextBoxEmail.Text) &&
                   !string.IsNullOrEmpty(TextBoxPassword.Text) &&
                   !string.IsNullOrEmpty(TextBoxPhoneNumber.Text) &&
                   !string.IsNullOrEmpty(TextBoxDepartment.Text) &&
                   !string.IsNullOrEmpty(TextBoxSemester.Text);
        }

        private void PasswordShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordShowCheckBox.Checked)
            {
                TextBoxPassword.PasswordChar = '\0';
            }
            else
            {
                TextBoxPassword.PasswordChar = '\u25CF';
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|protonmail\.com|mail\.com|outlook\.com|applemail\.com|zoho\.com)$";
            return Regex.IsMatch(email, pattern);
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBoxUserId.Clear();
            TextBoxName.Clear();
            TextBoxEmail.Clear();
            TextBoxPassword.Clear();
            TextBoxDepartment.Clear();
            TextBoxPhoneNumber.Clear();
            TextBoxSemester.Clear();
            TextBoxUserId.Focus();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFormInputs())
            {
                MessageBox.Show("Please fill in all required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(TextBoxEmail.Text))
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
                        string hashedPassword = HashPassword(TextBoxPassword.Text);

                        string Query = @"INSERT INTO student (studentId, name, email, password, phoneNumber, department, semester) VALUES (@userId, @name, @Email, @password, @phoneNumber, @department, @semester)";

                        using (SqlCommand sqlCommand = new SqlCommand(Query, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@userId", TextBoxUserId.Text);
                            sqlCommand.Parameters.AddWithValue("@name", TextBoxName.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@password", hashedPassword);
                            sqlCommand.Parameters.AddWithValue("@phoneNumber", TextBoxPhoneNumber.Text);
                            sqlCommand.Parameters.AddWithValue("@department", TextBoxDepartment.Text);
                            sqlCommand.Parameters.AddWithValue("@semester", TextBoxSemester.Text);

                            sqlCommand.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show("SignUp Successfully", "SignUp Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            TextBoxUserId.Clear();
                            TextBoxName.Clear();
                            TextBoxEmail.Clear();
                            TextBoxPassword.Clear();
                            TextBoxDepartment.Clear();
                            TextBoxPhoneNumber.Clear();
                            TextBoxSemester.Clear();
                            TextBoxUserId.Focus();
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

        private void BackLoginFormLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void TextBoxUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxUserId.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxName.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxEmail.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxPassword.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxPhoneNumber.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxDepartment.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxSemester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxSemester.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void HandleEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUpButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void HandleClearKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                ClearButton.PerformClick();
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

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string passwordStrength = CheckPasswordStrength(TextBoxPassword.Text.Trim());
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
