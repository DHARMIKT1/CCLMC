using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CCLMS.Admin
{
    public partial class UpdateLibrarianInfo : Form
    {
        private readonly SqlConnection con;

        // Stores the original user ID
        private readonly int oldUserId;

        public UpdateLibrarianInfo(int userId, string name, string email, string password, string phoneNumber, SqlConnection connection)
        {
            InitializeComponent();

            this.oldUserId = userId;
            this.con = connection;

            PasswordTextBox.PasswordChar = '\u25CF';

            UserIdTextBox.Text = userId.ToString();
            NameTextBox.Text = name;
            EmailTextBox.Text = email;
            PhoneNumberTextBox.Text = phoneNumber;

            UserIdTextBox.KeyDown += HandleArrowKeys;
            NameTextBox.KeyDown += HandleArrowKeys;
            EmailTextBox.KeyDown += HandleArrowKeys;
            PhoneNumberTextBox.KeyDown += HandleArrowKeys;
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string newUserIdStr = UserIdTextBox.Text.Trim();

            if (!int.TryParse(newUserIdStr, out int newUserId))
            {
                MessageBox.Show("User ID must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = NameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text; // Original password
            string hashedPassword = HashPassword(password); // Hashed password
            string phoneNumber = PhoneNumberTextBox.Text.Trim();

            try
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = "UPDATE librarian SET librarianId = @newLibrarianId, name = @name, email = @email, password = @password, phoneNumber = @phoneNumber WHERE librarianId = @oldLibrarianId";

                        using (SqlCommand sqlCommand = new SqlCommand(updateQuery, con, transaction))
                        {
                            sqlCommand.Parameters.AddWithValue("@newLibrarianId", newUserId);
                            sqlCommand.Parameters.AddWithValue("@name", name);
                            sqlCommand.Parameters.AddWithValue("@email", email);
                            sqlCommand.Parameters.AddWithValue("@password", hashedPassword); // Store hashed password
                            sqlCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                            sqlCommand.Parameters.AddWithValue("@oldLibrarianId", oldUserId);

                            sqlCommand.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show($"Librarian '{NameTextBox.Text}' record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (con != null && con.State == ConnectionState.Open)
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

        private void PhoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                PhoneNumberTextBox.Clear();
                e.SuppressKeyPress = true;
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
    }
}
