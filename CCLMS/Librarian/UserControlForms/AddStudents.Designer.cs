namespace CCLMS.Admin.UserControlForms
{
    partial class AddStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudents));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfirmPasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ShowPasswordCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.ClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AddStudentButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.NameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.EmailTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PhoneNumberTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.DepartmentTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SemesterTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.UserIdTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelPasswordStrength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(12, 254);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '\0';
            this.ConfirmPasswordTextBox.PlaceholderText = "Enter Confirm Password";
            this.ConfirmPasswordTextBox.SelectedText = "";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(422, 41);
            this.ConfirmPasswordTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.ConfirmPasswordTextBox.TabIndex = 5;
            this.ConfirmPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmPasswordTextBox_KeyDown);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ShowPasswordCheckBox.CheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.CheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(317, 301);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(117, 20);
            this.ShowPasswordCheckBox.TabIndex = 0;
            this.ShowPasswordCheckBox.TabStop = false;
            this.ShowPasswordCheckBox.Text = "Show Password?";
            this.ShowPasswordCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.UncheckedState.BorderRadius = 0;
            this.ShowPasswordCheckBox.UncheckedState.BorderThickness = 0;
            this.ShowPasswordCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
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
            this.ClearButton.Location = new System.Drawing.Point(3, 53);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(333, 44);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Animated = true;
            this.AddStudentButton.AutoRoundedCorners = true;
            this.AddStudentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddStudentButton.BorderRadius = 21;
            this.AddStudentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddStudentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddStudentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddStudentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddStudentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddStudentButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddStudentButton.ForeColor = System.Drawing.Color.White;
            this.AddStudentButton.Location = new System.Drawing.Point(3, 3);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(333, 44);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.TabStop = false;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
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
            this.NameTextBox.Location = new System.Drawing.Point(12, 113);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderText = "Enter Your Name";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(422, 41);
            this.NameTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
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
            this.EmailTextBox.Location = new System.Drawing.Point(12, 160);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderText = "Enter Your Email";
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(422, 41);
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
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 207);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.PlaceholderText = "Enter Your Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(422, 41);
            this.PasswordTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
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
            this.PhoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.PhoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(12, 327);
            this.PhoneNumberTextBox.MaxLength = 10;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PasswordChar = '\0';
            this.PhoneNumberTextBox.PlaceholderText = "Enter Your Phone Number";
            this.PhoneNumberTextBox.SelectedText = "";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(422, 41);
            this.PhoneNumberTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumberTextBox_KeyDown);
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
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
            this.DepartmentTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.DepartmentTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.DepartmentTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.DepartmentTextBox.Location = new System.Drawing.Point(12, 374);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.PasswordChar = '\0';
            this.DepartmentTextBox.PlaceholderText = "Enter Your Department";
            this.DepartmentTextBox.SelectedText = "";
            this.DepartmentTextBox.Size = new System.Drawing.Size(422, 41);
            this.DepartmentTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.DepartmentTextBox.TabIndex = 7;
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
            this.SemesterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.SemesterTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.SemesterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.SemesterTextBox.Location = new System.Drawing.Point(12, 421);
            this.SemesterTextBox.Name = "SemesterTextBox";
            this.SemesterTextBox.PasswordChar = '\0';
            this.SemesterTextBox.PlaceholderText = "Enter Your Semester";
            this.SemesterTextBox.SelectedText = "";
            this.SemesterTextBox.Size = new System.Drawing.Size(422, 41);
            this.SemesterTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.SemesterTextBox.TabIndex = 8;
            this.SemesterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SemesterTextBox_KeyDown);
            this.SemesterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SemesterTextBox_KeyPress);
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
            this.UserIdTextBox.Location = new System.Drawing.Point(12, 66);
            this.UserIdTextBox.MaxLength = 9;
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.PasswordChar = '\0';
            this.UserIdTextBox.PlaceholderText = "Enter Your User Id";
            this.UserIdTextBox.SelectedText = "";
            this.UserIdTextBox.Size = new System.Drawing.Size(422, 41);
            this.UserIdTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.UserIdTextBox.TabIndex = 1;
            this.UserIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserIdTextBox_KeyDown);
            this.UserIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIdTextBox_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AddStudentButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClearButton, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(46, 504);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(345, 100);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // LabelPasswordStrength
            // 
            this.LabelPasswordStrength.AutoSize = true;
            this.LabelPasswordStrength.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordStrength.Location = new System.Drawing.Point(9, 301);
            this.LabelPasswordStrength.Name = "LabelPasswordStrength";
            this.LabelPasswordStrength.Size = new System.Drawing.Size(0, 16);
            this.LabelPasswordStrength.TabIndex = 11;
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelPasswordStrength);
            this.Controls.Add(this.SemesterTextBox);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddStudents";
            this.Size = new System.Drawing.Size(1024, 681);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ConfirmPasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ShowPasswordCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AddStudentButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox NameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox EmailTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PhoneNumberTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox DepartmentTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SemesterTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UserIdTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelPasswordStrength;
    }
}
