using System;
using System.Windows.Forms;

namespace CCLMS
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTime_Tick(object sender, EventArgs e)
        {
            try
            {
                SplashScreenTime.Enabled = true;

                SplashScreenProgressBar.Increment(2);

                SplashScreenProgressBar.Visible = false;

                if (SplashScreenProgressBar.Value == 100)
                {
                    SplashScreenTime.Enabled = false;

                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
