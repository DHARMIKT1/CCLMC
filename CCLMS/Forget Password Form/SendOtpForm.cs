using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Configuration;

namespace CCLMS.Forget_Password_Form
{
    public partial class SendOtpForm : Form
    {
        private readonly SqlConnection con;

        private string randomCode;
        private DateTime otpGenerationTime;
        public static string recipientEmail;

        public SendOtpForm()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            OtpTextBox1.TextChanged += OtpTextBox1_TextChanged;
            OtpTextBox2.TextChanged += OtpTextBox2_TextChanged;
            OtpTextBox3.TextChanged += OtpTextBox3_TextChanged;
            OtpTextBox4.TextChanged += OtpTextBox4_TextChanged;
            OtpTextBox5.TextChanged += OtpTextBox5_TextChanged;

            OtpTextBox1.KeyPress += OtpTextBox1_KeyPress;
            OtpTextBox2.KeyPress += OtpTextBox2_KeyPress;
            OtpTextBox3.KeyPress += OtpTextBox3_KeyPress;
            OtpTextBox4.KeyPress += OtpTextBox4_KeyPress;
            OtpTextBox5.KeyPress += OtpTextBox5_KeyPress;
            OtpTextBox6.KeyPress += OtpTextBox6_KeyPress;

            TextBoxEmail.KeyDown += HandleSendButtonEnterKey;
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Clear();
            OtpTextBox1.Clear();
            OtpTextBox2.Clear();
            OtpTextBox3.Clear();
            OtpTextBox4.Clear();
            OtpTextBox5.Clear();
            OtpTextBox6.Clear();
            TextBoxEmail.Focus();
        }

        private void OtpTextBox1_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

            if (currentTextBox.Text.Length == 1)
            {
                SelectNextControl(currentTextBox, true, true, true, true);
            }
        }

        private void OtpTextBox2_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

            if (currentTextBox.Text.Length == 1)
            {
                SelectNextControl(currentTextBox, true, true, true, true);
            }
        }

        private void OtpTextBox3_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

            if (currentTextBox.Text.Length == 1)
            {
                SelectNextControl(currentTextBox, true, true, true, true);
            }
        }

        private void OtpTextBox4_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

            if (currentTextBox.Text.Length == 1)
            {
                SelectNextControl(currentTextBox, true, true, true, true);
            }
        }

        private void OtpTextBox5_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

            if (currentTextBox.Text.Length == 1)
            {
                SelectNextControl(currentTextBox, true, true, true, true);
            }
        }


        private void OtpTextBox6_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

            if (currentTextBox.Text.Length == 1)
            {
                SelectNextControl(currentTextBox, true, true, true, true);
            }
        }

        private void OtpTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

                if (currentTextBox != null && string.IsNullOrEmpty(currentTextBox.Text))
                {
                    SelectNextControl(currentTextBox, false, true, true, true);
                }
            }
        }

        private void OtpTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

                if (currentTextBox != null && string.IsNullOrEmpty(currentTextBox.Text))
                {
                    SelectNextControl(currentTextBox, false, true, true, true);
                }
            }
        }

        private void OtpTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

                if (currentTextBox != null && string.IsNullOrEmpty(currentTextBox.Text))
                {
                    SelectNextControl(currentTextBox, false, true, true, true);
                }
            }
        }

        private void OtpTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

                if (currentTextBox != null && string.IsNullOrEmpty(currentTextBox.Text))
                {
                    SelectNextControl(currentTextBox, false, true, true, true);
                }
            }
        }

        private void OtpTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

                if (currentTextBox != null && string.IsNullOrEmpty(currentTextBox.Text))
                {
                    SelectNextControl(currentTextBox, false, true, true, true);
                }
            }
        }

        private void OtpTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                var currentTextBox = sender as Siticone.Desktop.UI.WinForms.SiticoneTextBox;

                if (currentTextBox != null && string.IsNullOrEmpty(currentTextBox.Text))
                {
                    SelectNextControl(currentTextBox, false, true, true, true);
                }
            }
        }

        private void HandleSendButtonEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton.PerformClick();
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

        private bool CheckEmailExists(string email)
        {
            bool emailFound = false;

            string checkLibrarianQuery = "SELECT COUNT(*) FROM librarian WHERE email = @Email";
            using (SqlCommand sqlCommand = new SqlCommand(checkLibrarianQuery, con))
            {
                sqlCommand.Parameters.AddWithValue("@Email", email);
                int count = (int)sqlCommand.ExecuteScalar();

                if (count > 0)
                {
                    emailFound = true;
                }
            }

            if (!emailFound)
            {
                string checkStudentQuery = "SELECT COUNT(*) FROM student WHERE email = @Email";
                using (SqlCommand sqlCommand = new SqlCommand(checkStudentQuery, con))
                {
                    sqlCommand.Parameters.AddWithValue("@Email", email);
                    int count = (int)sqlCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        emailFound = true;
                    }
                }
            }
            return emailFound;
        }

        private bool CheckInternetConnection()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com", 3000);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void SendOtpEmail()
        {
            string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
            string senderPassword = ConfigurationManager.AppSettings["SenderPassword"];

            // Generate a random 6-digit OTP code
            Random random = new Random();
            randomCode = random.Next(100000, 1000000).ToString();

            // Stores the time the OTP is generated
            otpGenerationTime = DateTime.Now;

            string messageBody = $@"
                   Hello {recipientEmail},
                   <br/><br/>
                   We received a request to change your password for your account. To proceed, please use the following one-time password (OTP):
                   <br/><br/>
                   <b>Your OTP 🔑: {randomCode}</b>
                   <br/><br/>
                   This code is valid for the next 5 minutes. If you did not request a password change, please ignore this email or contact our support team for further assistance.
                   <br/><br/>
                   For your security, please do not share this code with anyone.
                   <br/><br/>
                   Thank you for choosing us! 😊
                   <br/><br/>
                   (This is an auto-generated email, so please do not reply back.)
                   <br/><br/>
                   Best regards,
                   <br/>
                   📚 Your College Library Team 📚
            ";

            MailMessage message = new MailMessage
            {
                From = new MailAddress(senderEmail, "CCLMS"),
                Subject = "🔒 Password Change OTP Request",
                Body = messageBody,
                IsBodyHtml = true
            };

            message.To.Add(recipientEmail);

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(senderEmail, senderPassword)
            };

            try
            {
                smtpClient.Send(message);

                MessageBox.Show("OTP successfully sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Failed to send OTP. SMTP error: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the OTP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            recipientEmail = TextBoxEmail.Text.Trim();

            if (!CheckInternetConnection())
            {
                MessageBox.Show("No internet connection detected. Please check your connection and try again.", "No Internet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(recipientEmail))
            {
                MessageBox.Show("Please enter your email.", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                bool emailExists = CheckEmailExists(recipientEmail);

                if (emailExists)
                {
                    SendOtpEmail();
                }
                else
                {
                    MessageBox.Show("The email address was not found in our database. Please ensure you entered it correctly and try again.", "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void VerifyOtpButton_Click(object sender, EventArgs e)
        {
            string enteredOTP = OtpTextBox1.Text.Trim() + OtpTextBox2.Text.Trim() + OtpTextBox3.Text.Trim() + OtpTextBox4.Text.Trim() + OtpTextBox5.Text.Trim() + OtpTextBox6.Text.Trim();

            if (string.IsNullOrEmpty(enteredOTP) || enteredOTP.Length != 6)
            {
                MessageBox.Show("Please enter the full OTP.", "Empty OTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Now > otpGenerationTime.AddMinutes(5))
            {
                MessageBox.Show("OTP has expired. Please request a new OTP.", "Expired OTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (randomCode == enteredOTP)
            {
                ResetPasswordForm resetPassword = new ResetPasswordForm();
                resetPassword.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResendOtpButton_Click(object sender, EventArgs e)
        {
            recipientEmail = TextBoxEmail.Text.Trim();

            if (!CheckInternetConnection())
            {
                MessageBox.Show("No internet connection detected. Please check your connection and try again.", "No Internet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(recipientEmail))
            {
                MessageBox.Show("Please enter your email.", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                bool emailExists = CheckEmailExists(recipientEmail);

                if (emailExists)
                {
                    SendOtpEmail();
                }
                else
                {
                    MessageBox.Show("The email address was not found in our database. Please ensure you entered it correctly and try again.", "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
