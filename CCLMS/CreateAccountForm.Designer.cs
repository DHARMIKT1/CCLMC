namespace CCLMS
{
    partial class CreateAccountForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.TextBoxEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxDepartment = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxSemester = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TextBoxUserId = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SignUpButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PasswordShowCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.LabelCCLMSLogin = new System.Windows.Forms.Label();
            this.BackLoginFormLabel = new System.Windows.Forms.Label();
            this.CloseBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.MinimizeBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.LabelPasswordStrength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(0, -108);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(1231, 655);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 25;
            this.pictureBoxLogin.TabStop = false;
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
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxEmail.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxEmail.Location = new System.Drawing.Point(749, 137);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PlaceholderText = "Enter Your Email";
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.Size = new System.Drawing.Size(409, 37);
            this.TextBoxEmail.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxEmail.TabIndex = 3;
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
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxPassword.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(749, 182);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Enter Your Password";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.Size = new System.Drawing.Size(409, 37);
            this.TextBoxPassword.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxPassword.TabIndex = 28;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Animated = true;
            this.TextBoxPhoneNumber.BorderRadius = 1;
            this.TextBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPhoneNumber.DefaultText = "";
            this.TextBoxPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(749, 251);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPhoneNumber.MaxLength = 10;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.PasswordChar = '\0';
            this.TextBoxPhoneNumber.PlaceholderText = "Enter Your Phone Number";
            this.TextBoxPhoneNumber.SelectedText = "";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(409, 37);
            this.TextBoxPhoneNumber.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxPhoneNumber.TabIndex = 29;
            this.TextBoxPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPhoneNumber_KeyDown);
            this.TextBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPhoneNumber_KeyPress);
            // 
            // TextBoxDepartment
            // 
            this.TextBoxDepartment.Animated = true;
            this.TextBoxDepartment.AutoCompleteCustomSource.AddRange(new string[] {
            "BCA",
            "Bsc.IT",
            "BSC",
            "MCA"});
            this.TextBoxDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxDepartment.BorderRadius = 1;
            this.TextBoxDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDepartment.DefaultText = "";
            this.TextBoxDepartment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDepartment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxDepartment.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxDepartment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxDepartment.Location = new System.Drawing.Point(749, 296);
            this.TextBoxDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDepartment.Name = "TextBoxDepartment";
            this.TextBoxDepartment.PasswordChar = '\0';
            this.TextBoxDepartment.PlaceholderText = "Enter Your Department";
            this.TextBoxDepartment.SelectedText = "";
            this.TextBoxDepartment.Size = new System.Drawing.Size(409, 37);
            this.TextBoxDepartment.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxDepartment.TabIndex = 30;
            this.TextBoxDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDepartment_KeyDown);
            // 
            // TextBoxSemester
            // 
            this.TextBoxSemester.Animated = true;
            this.TextBoxSemester.BorderRadius = 1;
            this.TextBoxSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSemester.DefaultText = "";
            this.TextBoxSemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxSemester.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxSemester.Location = new System.Drawing.Point(749, 341);
            this.TextBoxSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSemester.Name = "TextBoxSemester";
            this.TextBoxSemester.PasswordChar = '\0';
            this.TextBoxSemester.PlaceholderText = "Enter Your Semester";
            this.TextBoxSemester.SelectedText = "";
            this.TextBoxSemester.Size = new System.Drawing.Size(409, 37);
            this.TextBoxSemester.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxSemester.TabIndex = 31;
            this.TextBoxSemester.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSemester_KeyDown);
            this.TextBoxSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSemester_KeyPress);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Animated = true;
            this.TextBoxName.BorderRadius = 1;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.DefaultText = "";
            this.TextBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxName.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxName.Location = new System.Drawing.Point(749, 92);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.PlaceholderText = "Enter Your Name";
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.Size = new System.Drawing.Size(409, 37);
            this.TextBoxName.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxName.TabIndex = 2;
            this.TextBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxName_KeyDown);
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
            this.TextBoxUserId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxUserId.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.TextBoxUserId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.TextBoxUserId.Location = new System.Drawing.Point(749, 47);
            this.TextBoxUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUserId.MaxLength = 9;
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
            // SignUpButton
            // 
            this.SignUpButton.Animated = true;
            this.SignUpButton.AutoRoundedCorners = true;
            this.SignUpButton.BorderRadius = 21;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.SignUpButton.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.SignUpButton.Location = new System.Drawing.Point(749, 385);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(157, 45);
            this.SignUpButton.TabIndex = 34;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
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
            this.ClearButton.Location = new System.Drawing.Point(912, 385);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(157, 45);
            this.ClearButton.TabIndex = 35;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PasswordShowCheckBox
            // 
            this.PasswordShowCheckBox.AutoSize = true;
            this.PasswordShowCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordShowCheckBox.CheckedState.BorderRadius = 0;
            this.PasswordShowCheckBox.CheckedState.BorderThickness = 0;
            this.PasswordShowCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordShowCheckBox.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.PasswordShowCheckBox.Location = new System.Drawing.Point(1028, 226);
            this.PasswordShowCheckBox.Name = "PasswordShowCheckBox";
            this.PasswordShowCheckBox.Size = new System.Drawing.Size(130, 23);
            this.PasswordShowCheckBox.TabIndex = 36;
            this.PasswordShowCheckBox.Text = "Show Password";
            this.PasswordShowCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.PasswordShowCheckBox.UncheckedState.BorderRadius = 0;
            this.PasswordShowCheckBox.UncheckedState.BorderThickness = 0;
            this.PasswordShowCheckBox.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.PasswordShowCheckBox.CheckedChanged += new System.EventHandler(this.PasswordShowCheckBox_CheckedChanged);
            // 
            // LabelCCLMSLogin
            // 
            this.LabelCCLMSLogin.AutoSize = true;
            this.LabelCCLMSLogin.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCCLMSLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.LabelCCLMSLogin.Location = new System.Drawing.Point(134, 9);
            this.LabelCCLMSLogin.Name = "LabelCCLMSLogin";
            this.LabelCCLMSLogin.Size = new System.Drawing.Size(279, 50);
            this.LabelCCLMSLogin.TabIndex = 37;
            this.LabelCCLMSLogin.Text = "CCLMS SignUp";
            // 
            // BackLoginFormLabel
            // 
            this.BackLoginFormLabel.AutoSize = true;
            this.BackLoginFormLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLoginFormLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLoginFormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));
            this.BackLoginFormLabel.Location = new System.Drawing.Point(852, 453);
            this.BackLoginFormLabel.Name = "BackLoginFormLabel";
            this.BackLoginFormLabel.Size = new System.Drawing.Size(99, 17);
            this.BackLoginFormLabel.TabIndex = 38;
            this.BackLoginFormLabel.Text = "Back To Login ";
            this.BackLoginFormLabel.Click += new System.EventHandler(this.BackLoginFormLabel_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Location = new System.Drawing.Point(1188, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(43, 29);
            this.CloseBox.TabIndex = 39;
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.MinimizeBox.IconColor = System.Drawing.Color.White;
            this.MinimizeBox.Location = new System.Drawing.Point(1145, 0);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(43, 29);
            this.MinimizeBox.TabIndex = 40;
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_ACTIVATE;
            this.siticoneAnimateWindow1.TargetForm = this;
            // 
            // LabelPasswordStrength
            // 
            this.LabelPasswordStrength.AutoSize = true;
            this.LabelPasswordStrength.Location = new System.Drawing.Point(746, 226);
            this.LabelPasswordStrength.Name = "LabelPasswordStrength";
            this.LabelPasswordStrength.Size = new System.Drawing.Size(0, 13);
            this.LabelPasswordStrength.TabIndex = 41;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 547);
            this.Controls.Add(this.LabelPasswordStrength);
            this.Controls.Add(this.MinimizeBox);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.BackLoginFormLabel);
            this.Controls.Add(this.LabelCCLMSLogin);
            this.Controls.Add(this.PasswordShowCheckBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.TextBoxUserId);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxSemester);
            this.Controls.Add(this.TextBoxDepartment);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.pictureBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxDepartment;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxSemester;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxUserId;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SignUpButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearButton;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox PasswordShowCheckBox;
        private System.Windows.Forms.Label LabelCCLMSLogin;
        private System.Windows.Forms.Label BackLoginFormLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox MinimizeBox;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private System.Windows.Forms.Label LabelPasswordStrength;
    }
}