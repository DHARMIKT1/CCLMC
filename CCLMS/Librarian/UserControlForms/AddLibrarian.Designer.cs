namespace CCLMS.Admin.UserControlForms
{
    partial class AddLibrarian
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLibrarian));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIdTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PhoneNumberTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.EmailTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.NameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ShowPasswordCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.ConfirmPasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.AddAdminButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPasswordStrength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserIdTextBox.DefaultText = "";
            this.UserIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.UserIdTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.UserIdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.UserIdTextBox.Location = new System.Drawing.Point(3, 3);
            this.UserIdTextBox.MaxLength = 9;
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.PasswordChar = '\0';
            this.UserIdTextBox.PlaceholderText = "Enter Your User Id";
            this.UserIdTextBox.SelectedText = "";
            this.UserIdTextBox.Size = new System.Drawing.Size(406, 41);
            this.UserIdTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.UserIdTextBox.TabIndex = 1;
            this.UserIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserIdTextBox_KeyDown);
            this.UserIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIdTextBox_KeyPress);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTextBox.DefaultText = "";
            this.PhoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.PhoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(3, 264);
            this.PhoneNumberTextBox.MaxLength = 10;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PasswordChar = '\0';
            this.PhoneNumberTextBox.PlaceholderText = "Enter Your Phone Number";
            this.PhoneNumberTextBox.SelectedText = "";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(406, 41);
            this.PhoneNumberTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumberTextBox_KeyDown);
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 144);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.PlaceholderText = "Enter Your Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(406, 41);
            this.PasswordTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.EmailTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.EmailTextBox.Location = new System.Drawing.Point(3, 97);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderText = "Enter Your Email";
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(406, 41);
            this.EmailTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTextBox_KeyDown);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.NameTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.NameTextBox.Location = new System.Drawing.Point(3, 50);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderText = "Enter Your Name";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(406, 41);
            this.NameTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ShowPasswordCheckBox.CheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.CheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(292, 238);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(117, 20);
            this.ShowPasswordCheckBox.TabIndex = 9;
            this.ShowPasswordCheckBox.TabStop = false;
            this.ShowPasswordCheckBox.Text = "Show Password?";
            this.ShowPasswordCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.UncheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.UncheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPasswordTextBox.DefaultText = "";
            this.ConfirmPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.ConfirmPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(3, 191);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '\0';
            this.ConfirmPasswordTextBox.PlaceholderText = "Enter Confirm Password";
            this.ConfirmPasswordTextBox.SelectedText = "";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(406, 41);
            this.ConfirmPasswordTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.ConfirmPasswordTextBox.TabIndex = 5;
            this.ConfirmPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmPasswordTextBox_KeyDown);
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.Animated = true;
            this.AddAdminButton.AutoRoundedCorners = true;
            this.AddAdminButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddAdminButton.BorderRadius = 21;
            this.AddAdminButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAdminButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAdminButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAdminButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAdminButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddAdminButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddAdminButton.ForeColor = System.Drawing.Color.White;
            this.AddAdminButton.Location = new System.Drawing.Point(64, 345);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(302, 44);
            this.AddAdminButton.TabIndex = 7;
            this.AddAdminButton.TabStop = false;
            this.AddAdminButton.Text = "Add Librarian";
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Animated = true;
            this.ClearButton.AutoRoundedCorners = true;
            this.ClearButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ClearButton.BorderRadius = 21;
            this.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ClearButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(64, 395);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(302, 44);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LabelPasswordStrength);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.AddAdminButton);
            this.panel1.Controls.Add(this.UserIdTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.PhoneNumberTextBox);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.ShowPasswordCheckBox);
            this.panel1.Controls.Add(this.ConfirmPasswordTextBox);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Location = new System.Drawing.Point(579, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 472);
            this.panel1.TabIndex = 13;
            // 
            // LabelPasswordStrength
            // 
            this.LabelPasswordStrength.AutoSize = true;
            this.LabelPasswordStrength.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordStrength.Location = new System.Drawing.Point(3, 238);
            this.LabelPasswordStrength.Name = "LabelPasswordStrength";
            this.LabelPasswordStrength.Size = new System.Drawing.Size(0, 16);
            this.LabelPasswordStrength.TabIndex = 14;
            // 
            // AddLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddLibrarian";
            this.Size = new System.Drawing.Size(1024, 681);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UserIdTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PhoneNumberTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox EmailTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox NameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ShowPasswordCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ConfirmPasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AddAdminButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelPasswordStrength;
    }
}
