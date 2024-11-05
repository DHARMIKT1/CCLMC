namespace CCLMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.CloseBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.TextBoxUserId = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.RoleComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.LoginButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ForgetPasswordLabel = new System.Windows.Forms.Label();
            this.LabelAbout = new System.Windows.Forms.Label();
            this.LabelHome = new System.Windows.Forms.Label();
            this.LabelCCLMSLogin = new System.Windows.Forms.Label();
            this.MinimizeBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.PasswordShowCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, -106);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(1242, 655);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Location = new System.Drawing.Point(1198, -1);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(33, 29);
            this.CloseBox.TabIndex = 2;
            // 
            // TextBoxUserId
            // 
            this.TextBoxUserId.Animated = true;
            this.TextBoxUserId.BorderRadius = 1;
            this.TextBoxUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserId.DefaultText = "";
            this.TextBoxUserId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUserId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUserId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserId.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxUserId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserId.Location = new System.Drawing.Point(754, 125);
            this.TextBoxUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUserId.MaxLength = 10;
            this.TextBoxUserId.Name = "TextBoxUserId";
            this.TextBoxUserId.PasswordChar = '\0';
            this.TextBoxUserId.PlaceholderText = "Enter Your User Id";
            this.TextBoxUserId.SelectedText = "";
            this.TextBoxUserId.Size = new System.Drawing.Size(409, 37);
            this.TextBoxUserId.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxUserId.TabIndex = 1;
            this.TextBoxUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUserId_KeyDown);
            this.TextBoxUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUserId_KeyPress);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Animated = true;
            this.TextBoxEmail.BorderRadius = 1;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.DefaultText = "";
            this.TextBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEmail.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEmail.Location = new System.Drawing.Point(754, 170);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PlaceholderText = "Enter Your Email";
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.Size = new System.Drawing.Size(409, 37);
            this.TextBoxEmail.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxEmail.TabIndex = 2;
            this.TextBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEmail_KeyDown);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Animated = true;
            this.TextBoxPassword.BorderRadius = 1;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(754, 215);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.PlaceholderText = "Enter Your Password";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.Size = new System.Drawing.Size(409, 37);
            this.TextBoxPassword.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoleComboBox.BorderRadius = 1;
            this.RoleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleComboBox.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.RoleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoleComboBox.ItemHeight = 30;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Student",
            "Librarian"});
            this.RoleComboBox.Location = new System.Drawing.Point(754, 288);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(409, 36);
            this.RoleComboBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.RoleComboBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BorderRadius = 21;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.LoginButton.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.LoginButton.Location = new System.Drawing.Point(769, 341);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(176, 45);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Animated = true;
            this.ClearButton.AutoRoundedCorners = true;
            this.ClearButton.BorderRadius = 21;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.ClearButton.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(968, 341);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(176, 45);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ForgetPasswordLabel
            // 
            this.ForgetPasswordLabel.AutoSize = true;
            this.ForgetPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetPasswordLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.ForgetPasswordLabel.Location = new System.Drawing.Point(880, 406);
            this.ForgetPasswordLabel.Name = "ForgetPasswordLabel";
            this.ForgetPasswordLabel.Size = new System.Drawing.Size(149, 17);
            this.ForgetPasswordLabel.TabIndex = 12;
            this.ForgetPasswordLabel.Text = "Forget Your Password?";
            this.ForgetPasswordLabel.Click += new System.EventHandler(this.ForgetPasswordLabel_Click);
            // 
            // LabelAbout
            // 
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAbout.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.LabelAbout.Location = new System.Drawing.Point(887, 9);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(76, 25);
            this.LabelAbout.TabIndex = 14;
            this.LabelAbout.Text = "ABOUT";
            this.LabelAbout.Click += new System.EventHandler(this.LabelAbout_Click);
            // 
            // LabelHome
            // 
            this.LabelHome.AutoSize = true;
            this.LabelHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelHome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.LabelHome.Location = new System.Drawing.Point(790, 9);
            this.LabelHome.Name = "LabelHome";
            this.LabelHome.Size = new System.Drawing.Size(69, 25);
            this.LabelHome.TabIndex = 16;
            this.LabelHome.Text = "HOME";
            // 
            // LabelCCLMSLogin
            // 
            this.LabelCCLMSLogin.AutoSize = true;
            this.LabelCCLMSLogin.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCCLMSLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.LabelCCLMSLogin.Location = new System.Drawing.Point(136, 9);
            this.LabelCCLMSLogin.Name = "LabelCCLMSLogin";
            this.LabelCCLMSLogin.Size = new System.Drawing.Size(260, 50);
            this.LabelCCLMSLogin.TabIndex = 17;
            this.LabelCCLMSLogin.Text = "CCLMS Login ";
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.MinimizeBox.IconColor = System.Drawing.Color.White;
            this.MinimizeBox.Location = new System.Drawing.Point(1165, -1);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(33, 29);
            this.MinimizeBox.TabIndex = 18;
            // 
            // PasswordShowCheckBox
            // 
            this.PasswordShowCheckBox.AutoSize = true;
            this.PasswordShowCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordShowCheckBox.CheckedState.BorderRadius = 0;
            this.PasswordShowCheckBox.CheckedState.BorderThickness = 0;
            this.PasswordShowCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordShowCheckBox.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.PasswordShowCheckBox.Location = new System.Drawing.Point(1033, 259);
            this.PasswordShowCheckBox.Name = "PasswordShowCheckBox";
            this.PasswordShowCheckBox.Size = new System.Drawing.Size(130, 23);
            this.PasswordShowCheckBox.TabIndex = 25;
            this.PasswordShowCheckBox.TabStop = false;
            this.PasswordShowCheckBox.Text = "Show Password";
            this.PasswordShowCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.PasswordShowCheckBox.UncheckedState.BorderRadius = 0;
            this.PasswordShowCheckBox.UncheckedState.BorderThickness = 0;
            this.PasswordShowCheckBox.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.PasswordShowCheckBox.CheckedChanged += new System.EventHandler(this.PasswordShowCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(792, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Don\'t have an account?";
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.CreateAccountLabel.Location = new System.Drawing.Point(942, 434);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(112, 17);
            this.CreateAccountLabel.TabIndex = 24;
            this.CreateAccountLabel.Text = "Create a Account";
            this.CreateAccountLabel.Click += new System.EventHandler(this.CreateAccountLabel_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VersionLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.VersionLabel.Location = new System.Drawing.Point(990, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(93, 25);
            this.VersionLabel.TabIndex = 25;
            this.VersionLabel.Text = "VERSION";
            this.VersionLabel.Click += new System.EventHandler(this.VersionLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1231, 547);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordShowCheckBox);
            this.Controls.Add(this.MinimizeBox);
            this.Controls.Add(this.LabelCCLMSLogin);
            this.Controls.Add(this.LabelHome);
            this.Controls.Add(this.LabelAbout);
            this.Controls.Add(this.ForgetPasswordLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxUserId);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.pictureBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxUserId;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox RoleComboBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton LoginButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearButton;
        private System.Windows.Forms.Label ForgetPasswordLabel;
        private System.Windows.Forms.Label LabelAbout;
        private System.Windows.Forms.Label LabelHome;
        private System.Windows.Forms.Label LabelCCLMSLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox MinimizeBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox PasswordShowCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CreateAccountLabel;
        private System.Windows.Forms.Label VersionLabel;
    }
}

