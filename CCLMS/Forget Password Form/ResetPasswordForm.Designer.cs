namespace CCLMS.Forget_Password_Form
{
    partial class ResetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.Close = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.TextBoxNewPaasword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxConfirmPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ResetPasswordButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ShowPasswordCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.LabelPasswordStrength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.IconColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(534, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(48, 36);
            this.Close.TabIndex = 1;
            // 
            // TextBoxNewPaasword
            // 
            this.TextBoxNewPaasword.BorderRadius = 1;
            this.TextBoxNewPaasword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNewPaasword.DefaultText = "";
            this.TextBoxNewPaasword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNewPaasword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNewPaasword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNewPaasword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNewPaasword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.TextBoxNewPaasword.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.TextBoxNewPaasword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.TextBoxNewPaasword.Location = new System.Drawing.Point(69, 31);
            this.TextBoxNewPaasword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxNewPaasword.Name = "TextBoxNewPaasword";
            this.TextBoxNewPaasword.PasswordChar = '\0';
            this.TextBoxNewPaasword.PlaceholderText = "Enter New Password";
            this.TextBoxNewPaasword.SelectedText = "";
            this.TextBoxNewPaasword.Size = new System.Drawing.Size(421, 41);
            this.TextBoxNewPaasword.TabIndex = 6;
            this.TextBoxNewPaasword.TextChanged += new System.EventHandler(this.TextBoxNewPaasword_TextChanged);
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.BorderRadius = 1;
            this.TextBoxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConfirmPassword.DefaultText = "";
            this.TextBoxConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.TextBoxConfirmPassword.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.TextBoxConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(69, 78);
            this.TextBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.PasswordChar = '\0';
            this.TextBoxConfirmPassword.PlaceholderText = "Enter Confirm Password";
            this.TextBoxConfirmPassword.SelectedText = "";
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(421, 41);
            this.TextBoxConfirmPassword.TabIndex = 7;
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.Animated = true;
            this.ResetPasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ResetPasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetPasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetPasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetPasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetPasswordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ResetPasswordButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.ResetPasswordButton.ForeColor = System.Drawing.Color.White;
            this.ResetPasswordButton.Location = new System.Drawing.Point(69, 156);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(421, 50);
            this.ResetPasswordButton.TabIndex = 8;
            this.ResetPasswordButton.Text = "Reset Password";
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Animated = true;
            this.ClearButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClearButton.BorderThickness = 1;
            this.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearButton.FillColor = System.Drawing.Color.White;
            this.ClearButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClearButton.Location = new System.Drawing.Point(69, 212);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(421, 50);
            this.ClearButton.TabIndex = 26;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ShowPasswordCheckBox.CheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.CheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(373, 130);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(117, 20);
            this.ShowPasswordCheckBox.TabIndex = 27;
            this.ShowPasswordCheckBox.Text = "Show Password?";
            this.ShowPasswordCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.UncheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.UncheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LabelPasswordStrength
            // 
            this.LabelPasswordStrength.AutoSize = true;
            this.LabelPasswordStrength.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordStrength.Location = new System.Drawing.Point(66, 130);
            this.LabelPasswordStrength.Name = "LabelPasswordStrength";
            this.LabelPasswordStrength.Size = new System.Drawing.Size(0, 16);
            this.LabelPasswordStrength.TabIndex = 29;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 275);
            this.Controls.Add(this.LabelPasswordStrength);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.TextBoxConfirmPassword);
            this.Controls.Add(this.TextBoxNewPaasword);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox Close;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxNewPaasword;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxConfirmPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ResetPasswordButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearButton;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label LabelPasswordStrength;
    }
}