namespace CCLMS.Admin
{
    partial class UpdateStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudentInfo));
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.EmailTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PhoneNumberTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.NameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.UserIdTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.DepartmentTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SemesterTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.UpdateButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ShowPasswordCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(511, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 38);
            this.siticoneControlBox1.TabIndex = 7;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.EmailTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.EmailTextBox.Location = new System.Drawing.Point(77, 123);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderText = "Enter Your Email";
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(370, 38);
            this.EmailTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTextBox_KeyDown);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(77, 167);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.PlaceholderText = "Enter Your Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(370, 38);
            this.PasswordTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTextBox.DefaultText = "";
            this.PhoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.PhoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(77, 237);
            this.PhoneNumberTextBox.MaxLength = 10;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PasswordChar = '\0';
            this.PhoneNumberTextBox.PlaceholderText = "Enter Your Phone Number";
            this.PhoneNumberTextBox.SelectedText = "";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(370, 38);
            this.PhoneNumberTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.PhoneNumberTextBox.TabIndex = 5;
            this.PhoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumberTextBox_KeyDown);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.NameTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.NameTextBox.Location = new System.Drawing.Point(77, 79);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderText = "Enter Your Name";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(370, 38);
            this.NameTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserIdTextBox.DefaultText = "";
            this.UserIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.UserIdTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.UserIdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.UserIdTextBox.Location = new System.Drawing.Point(77, 34);
            this.UserIdTextBox.MaxLength = 9;
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.PasswordChar = '\0';
            this.UserIdTextBox.PlaceholderText = "Enter Your User Id";
            this.UserIdTextBox.SelectedText = "";
            this.UserIdTextBox.Size = new System.Drawing.Size(370, 38);
            this.UserIdTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.UserIdTextBox.TabIndex = 1;
            this.UserIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserIdTextBox_KeyDown);
            this.UserIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIdTextBox_KeyPress);
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "BCA",
            "MCA",
            "Bsc.IT",
            "Bsc"});
            this.DepartmentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DepartmentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DepartmentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepartmentTextBox.DefaultText = "";
            this.DepartmentTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepartmentTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepartmentTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.DepartmentTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.DepartmentTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.DepartmentTextBox.Location = new System.Drawing.Point(77, 281);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.PasswordChar = '\0';
            this.DepartmentTextBox.PlaceholderText = "Enter Your Department";
            this.DepartmentTextBox.SelectedText = "";
            this.DepartmentTextBox.Size = new System.Drawing.Size(370, 38);
            this.DepartmentTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.DepartmentTextBox.TabIndex = 6;
            this.DepartmentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartmentTextBox_KeyDown);
            // 
            // SemesterTextBox
            // 
            this.SemesterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SemesterTextBox.DefaultText = "";
            this.SemesterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SemesterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SemesterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SemesterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SemesterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.SemesterTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.SemesterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.SemesterTextBox.Location = new System.Drawing.Point(77, 325);
            this.SemesterTextBox.Name = "SemesterTextBox";
            this.SemesterTextBox.PasswordChar = '\0';
            this.SemesterTextBox.PlaceholderText = "Enter Your Semester";
            this.SemesterTextBox.SelectedText = "";
            this.SemesterTextBox.Size = new System.Drawing.Size(370, 38);
            this.SemesterTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.SemesterTextBox.TabIndex = 7;
            this.SemesterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SemesterTextBox_KeyDown);
            this.SemesterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SemesterTextBox_KeyPress);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Animated = true;
            this.UpdateButton.AutoRoundedCorners = true;
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.UpdateButton.BorderRadius = 21;
            this.UpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.UpdateButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(109, 383);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(296, 45);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseTransparentBackground = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ShowPasswordCheckBox.CheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.CheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(330, 211);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(117, 20);
            this.ShowPasswordCheckBox.TabIndex = 24;
            this.ShowPasswordCheckBox.Text = "Show Password?";
            this.ShowPasswordCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.UncheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.UncheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // UpdateStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 460);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SemesterTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudentInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox EmailTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PhoneNumberTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox NameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UserIdTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox DepartmentTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SemesterTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton UpdateButton;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ShowPasswordCheckBox;
    }
}