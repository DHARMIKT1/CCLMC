using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CCLMS.Forget_Password_Form
{
    public partial class ResetPasswordForm : Form
    {
        private readonly SqlConnection con;

        public ResetPasswordForm()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            TextBoxNewPaasword.PasswordChar = '\u25CF';
            TextBoxConfirmPassword.PasswordChar = '\u25cf';

            TextBoxNewPaasword.KeyDown += HandleSResetPasswordButtonEnterKey;
            TextBoxConfirmPassword.KeyDown += HandleSResetPasswordButtonEnterKey;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
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
            TextBoxNewPaasword.Clear();
            TextBoxConfirmPassword.Clear();
            TextBoxNewPaasword.Focus();
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxNewPaasword.Text.Trim()))
            {
                MessageBox.Show("Please enter your new password.", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(TextBoxConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("Please enter confirm password.", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = TextBoxNewPaasword.Text.Trim();
            string confirmPassword = TextBoxConfirmPassword.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userEmail = SendOtpForm.recipientEmail;

            try
            {
                con.Open();

                string hashedPassword = HashPassword(newPassword);
                bool userFound = false;
                string checkLibrarianQuery = "SELECT COUNT(*) FROM librarian WHERE email = @Email";

                using (SqlCommand sqlCommand = new SqlCommand(checkLibrarianQuery, con))
                {
                    sqlCommand.Parameters.AddWithValue("@Email", userEmail);
                    int count = (int)sqlCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        UpdatePassword("librarian", userEmail, hashedPassword);
                        userFound = true;
                    }
                }

                if (!userFound)
                {
                    string checkStudentQuery = "SELECT COUNT(*) FROM student WHERE email = @Email";

                    using (SqlCommand sqlCommand = new SqlCommand(checkStudentQuery, con))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", userEmail);
                        int count = (int)sqlCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            UpdatePassword("student", userEmail, hashedPassword);
                            userFound = true;
                        }
                    }
                }

                if (!userFound)
                {
                    MessageBox.Show("No user found with the specified email. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void UpdatePassword(string userType, string userEmail, string newPassword)
        {
            string updateQuery;

            if (userType == "librarian")
            {
                updateQuery = "UPDATE librarian SET password = @NewPassword WHERE email = @Email";
            }
            else
            {
                updateQuery = "UPDATE student SET password = @NewPassword WHERE email = @Email";
            }

            using (SqlCommand sqlCommand = new SqlCommand(updateQuery, con))
            {
                sqlCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                sqlCommand.Parameters.AddWithValue("@Email", userEmail);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                TextBoxNewPaasword.PasswordChar = '\0';
                TextBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                TextBoxNewPaasword.PasswordChar = '\u25CF';
                TextBoxConfirmPassword.PasswordChar = '\u25CF';
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

        private void TextBoxNewPaasword_TextChanged(object sender, EventArgs e)
        {
            string passwordStrength = CheckPasswordStrength(TextBoxNewPaasword.Text.Trim());
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

        private void HandleSResetPasswordButtonEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ResetPasswordButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
