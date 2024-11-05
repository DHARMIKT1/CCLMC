using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CCLMS.Admin
{
    public partial class AccountInfoLibrarian : Form
    {
        // Dictionary to hold user information
        public Dictionary<string, string> UserInfo { get; set; }

        public AccountInfoLibrarian()
        {
            InitializeComponent();
        }

        private void AccountInfoAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                if (UserInfo != null && UserInfo.Count > 0)
                {
                    lblUserId.Text = UserInfo.ContainsKey("userId") ? UserInfo["userId"] : string.Empty;
                    lblName.Text = UserInfo.ContainsKey("name") ? UserInfo["name"] : string.Empty;
                    lblEmail.Text = UserInfo.ContainsKey("email") ? UserInfo["email"] : string.Empty;
                    lblPhoneNumber.Text = UserInfo.ContainsKey("phoneNumber") ? UserInfo["phoneNumber"] : string.Empty;
                }
                else
                {
                    MessageBox.Show("No user information found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
