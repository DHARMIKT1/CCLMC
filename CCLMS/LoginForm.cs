using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Collections.Generic;
using CCLMS.Student;
using CCLMS.Admin;
using CCLMS.Forget_Password_Form;

namespace CCLMS
{
    public partial class LoginForm : Form
    {
        private readonly SqlConnection con;

        public string LoggedInUserId { get; private set; }

        public LoginForm()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            TextBoxUserId.KeyDown += HandleEnterKey;
            TextBoxEmail.KeyDown += HandleEnterKey;
            TextBoxPassword.KeyDown += HandleEnterKey;
            RoleComboBox.KeyDown += HandleEnterKey;

            TextBoxUserId.KeyDown += HandleArrowKeys;
            TextBoxEmail.KeyDown += HandleArrowKeys;
            TextBoxPassword.KeyDown += HandleArrowKeys;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RoleComboBox.SelectedItem = "Student";
            TextBoxPassword.PasswordChar = '\u25CF';
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBoxUserId.Clear();
            TextBoxEmail.Clear();
            TextBoxPassword.Clear();
            TextBoxUserId.Focus();
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

        private bool ValidateFormInputs()
        {
            return !string.IsNullOrEmpty(TextBoxUserId.Text) &&
                !string.IsNullOrEmpty(TextBoxEmail.Text) &&
                !string.IsNullOrEmpty(TextBoxPassword.Text);
        }

        private Dictionary<string, string> GetStudentInformation(string userId)
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();

            string query = "SELECT name, email, phoneNumber, department, semester FROM student WHERE studentId = @userId";

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString))
                {
                    con.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, con))
                    {
                        sqlCommand.Parameters.AddWithValue("@userId", userId);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            // Read the first row of the result set
                            if (reader.Read())
                            {
                                userInfo["userId"] = userId;
                                userInfo["name"] = reader["name"].ToString();
                                userInfo["email"] = reader["email"].ToString();
                                userInfo["phoneNumber"] = reader["phoneNumber"].ToString();
                                userInfo["department"] = reader["department"].ToString();
                                userInfo["semester"] = reader["semester"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching student information: " + ex.Message);
            }

            return userInfo;
        }

        private Dictionary<string, string> GetLibrarianInformation(string userId)
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();

            string query = "SELECT name, email, phoneNumber FROM librarian WHERE librarianId = @userId";

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString))
                {
                    con.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, con))
                    {
                        sqlCommand.Parameters.AddWithValue("@userId", userId);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userInfo["userId"] = userId;
                                userInfo["name"] = reader["name"].ToString();
                                userInfo["email"] = reader["email"].ToString();
                                userInfo["phoneNumber"] = reader["phoneNumber"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching librarian information: " + ex.Message);
            }

            return userInfo;
        }

        public Dictionary<string, string> VerifyStudentCredentials(string userId, string email, string password)
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();

            string hashedPassword = HashPassword(password);

            try
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM student WHERE studentId = @userId AND email = @Email AND password = @password";

                using (SqlCommand sqlCommand = new SqlCommand(query, con))
                {
                    sqlCommand.Parameters.AddWithValue("@userId", userId);
                    sqlCommand.Parameters.AddWithValue("@Email", email);
                    sqlCommand.Parameters.AddWithValue("@password", hashedPassword);
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        userInfo = GetStudentInformation(userId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying student credentials: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return userInfo;
        }

        public Dictionary<string, string> VerifyLibrarianCredentials(string userId, string email, string password)
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();

            string hashedPassword = HashPassword(password);

            try
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM librarian WHERE librarianId = @userId AND email = @Email AND password = @password";

                using (SqlCommand sqlCommand = new SqlCommand(query, con))
                {
                    sqlCommand.Parameters.AddWithValue("@userId", userId);
                    sqlCommand.Parameters.AddWithValue("@Email", email);
                    sqlCommand.Parameters.AddWithValue("@password", hashedPassword);
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        userInfo = GetLibrarianInformation(userId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying librarian credentials: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return userInfo;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userId = TextBoxUserId.Text;
            string email = TextBoxEmail.Text;
            string password = TextBoxPassword.Text;
            string selectedRole = RoleComboBox.SelectedItem.ToString();
            bool credentialsValid = false;

            Dictionary<string, string> userInfo = new Dictionary<string, string>();

            if (!ValidateFormInputs())
            {
                MessageBox.Show("Please fill in all required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedRole == "Student")
            {
                userInfo = VerifyStudentCredentials(userId, email, password);

                credentialsValid = userInfo.Count > 0;

                if (credentialsValid)
                {
                    LoggedInUserId = userId;

                    StudentDashboardForm studentDashboard = new StudentDashboardForm();
                    studentDashboard.UserInfo = userInfo; // Pass user info to StudentDashboard form
                    studentDashboard.LoggedInUserId = LoggedInUserId; // Pass logged-in user ID to StudentDashboard form
                    this.Hide();
                    studentDashboard.ShowDialog();
                    this.Close();
                }
            }
            else if (selectedRole == "Librarian")
            {
                userInfo = VerifyLibrarianCredentials(userId, email, password);

                // Check if user information is retrieved
                credentialsValid = userInfo.Count > 0;

                if (credentialsValid)
                {
                    LibrarianDashboardForm librarianDashboard = new LibrarianDashboardForm();
                    librarianDashboard.UserInfo = userInfo; // Pass user info to Librarian Dashboard form
                    this.Hide();
                    librarianDashboard.ShowDialog();
                    this.Close();
                }
            }

            if (!credentialsValid)
            {
                MessageBox.Show("Invalid credentials. Please check your user ID, email, and password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void TextBoxUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                TextBoxUserId.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {
            VersionsForm versionsForm = new VersionsForm();
            versionsForm.ShowDialog();
        }

        private void LabelAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void ForgetPasswordLabel_Click(object sender, EventArgs e)
        {
            SendOtpForm sendOtpForm = new SendOtpForm();
            sendOtpForm.ShowDialog();
        }

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            this.Hide();
            createAccount.ShowDialog();
            this.Close();
        }

        private void HandleEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
