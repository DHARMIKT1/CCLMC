using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CCLMS.Student
{
    public partial class AccountInfoStudent : Form
    {
        public Dictionary<string, string> UserInfo { get; set; }

        public AccountInfoStudent()
        {
            InitializeComponent();
        }

        private void AccountInfoStudent_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                if (UserInfo != null && UserInfo.Count > 0)
                {
                    lblUserId.Text = UserInfo.ContainsKey("userId") ? UserInfo["userId"] : string.Empty;
                    lblName.Text = UserInfo.ContainsKey("name") ? UserInfo["name"] : string.Empty;
                    lblEmail.Text = UserInfo.ContainsKey("email") ? UserInfo["email"] : string.Empty;
                    lblPhoneNumber.Text = UserInfo.ContainsKey("phoneNumber") ? UserInfo["phoneNumber"] : string.Empty;
                    lblDepartment.Text = UserInfo.ContainsKey("department") ? UserInfo["department"] : string.Empty;
                    lblSemester.Text = UserInfo.ContainsKey("semester") ? UserInfo["semester"] : string.Empty;
                }
                else
                {
                    MessageBox.Show("No user information found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user information: " + ex.Message);
                this.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo updateAccountInfo = new UpdateAccountInfo();
            updateAccountInfo.UserInfo = UserInfo; // Pass UserInfo dictionary to the update form

            if (updateAccountInfo.ShowDialog() == DialogResult.OK)
            {
                LoadUserInfo();
            }
        }
    }
}
