namespace CCLMS.Admin
{
    partial class LibrarianDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianDashboardForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.UserCirclePictureBox = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.BookFineButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ViewAdminButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DashboardButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AddAdminButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.StudentFeedbackButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ViewBooksButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ViewStudentsButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AddBookButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AddStudentButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.LogoutButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UserCirclePictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(61, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(108, 19);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Welcome, User";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // UserCirclePictureBox
            // 
            this.UserCirclePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserCirclePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserCirclePictureBox.Image")));
            this.UserCirclePictureBox.ImageRotate = 0F;
            this.UserCirclePictureBox.Location = new System.Drawing.Point(3, 3);
            this.UserCirclePictureBox.Name = "UserCirclePictureBox";
            this.UserCirclePictureBox.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.UserCirclePictureBox.Size = new System.Drawing.Size(44, 45);
            this.UserCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserCirclePictureBox.TabIndex = 12;
            this.UserCirclePictureBox.TabStop = false;
            this.UserCirclePictureBox.Click += new System.EventHandler(this.UserCirclePictureBox_Click);
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.Location = new System.Drawing.Point(3, 66);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(237, 10);
            this.siticoneSeparator2.TabIndex = 10;
            this.siticoneSeparator2.Click += new System.EventHandler(this.siticoneSeparator2_Click);
            // 
            // BookFineButton
            // 
            this.BookFineButton.BackColor = System.Drawing.Color.Transparent;
            this.BookFineButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.BookFineButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookFineButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookFineButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookFineButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookFineButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.BookFineButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.BookFineButton.ForeColor = System.Drawing.Color.White;
            this.BookFineButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.BookFineButton.Image = ((System.Drawing.Image)(resources.GetObject("BookFineButton.Image")));
            this.BookFineButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookFineButton.ImageSize = new System.Drawing.Size(30, 30);
            this.BookFineButton.Location = new System.Drawing.Point(3, 530);
            this.BookFineButton.Name = "BookFineButton";
            this.BookFineButton.Size = new System.Drawing.Size(237, 50);
            this.BookFineButton.TabIndex = 9;
            this.BookFineButton.Text = "Book Fine";
            this.BookFineButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookFineButton.TextOffset = new System.Drawing.Point(22, 0);
            this.BookFineButton.UseTransparentBackground = true;
            this.BookFineButton.Click += new System.EventHandler(this.BookFineButton_Click);
            // 
            // ViewAdminButton
            // 
            this.ViewAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewAdminButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.ViewAdminButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewAdminButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewAdminButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewAdminButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewAdminButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.ViewAdminButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.ViewAdminButton.ForeColor = System.Drawing.Color.White;
            this.ViewAdminButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ViewAdminButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewAdminButton.Image")));
            this.ViewAdminButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewAdminButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ViewAdminButton.Location = new System.Drawing.Point(3, 418);
            this.ViewAdminButton.Name = "ViewAdminButton";
            this.ViewAdminButton.Size = new System.Drawing.Size(237, 50);
            this.ViewAdminButton.TabIndex = 7;
            this.ViewAdminButton.Text = "View Librarian";
            this.ViewAdminButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewAdminButton.TextOffset = new System.Drawing.Point(22, 0);
            this.ViewAdminButton.UseTransparentBackground = true;
            this.ViewAdminButton.Click += new System.EventHandler(this.ViewAdminButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.DashboardButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.DashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.DashboardButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardButton.ImageSize = new System.Drawing.Size(25, 25);
            this.DashboardButton.Location = new System.Drawing.Point(3, 82);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Padding = new System.Windows.Forms.Padding(5);
            this.DashboardButton.Size = new System.Drawing.Size(237, 50);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.TabStop = false;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardButton.TextOffset = new System.Drawing.Point(22, 0);
            this.DashboardButton.UseTransparentBackground = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.AddAdminButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.AddAdminButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAdminButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAdminButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAdminButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAdminButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.AddAdminButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddAdminButton.ForeColor = System.Drawing.Color.White;
            this.AddAdminButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddAdminButton.Image = ((System.Drawing.Image)(resources.GetObject("AddAdminButton.Image")));
            this.AddAdminButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddAdminButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AddAdminButton.Location = new System.Drawing.Point(3, 250);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(237, 50);
            this.AddAdminButton.TabIndex = 4;
            this.AddAdminButton.Text = "Add Librarian";
            this.AddAdminButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddAdminButton.TextOffset = new System.Drawing.Point(22, 0);
            this.AddAdminButton.UseTransparentBackground = true;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // StudentFeedbackButton
            // 
            this.StudentFeedbackButton.BackColor = System.Drawing.Color.Transparent;
            this.StudentFeedbackButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.StudentFeedbackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StudentFeedbackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StudentFeedbackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StudentFeedbackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StudentFeedbackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.StudentFeedbackButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.StudentFeedbackButton.ForeColor = System.Drawing.Color.White;
            this.StudentFeedbackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.StudentFeedbackButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentFeedbackButton.Image")));
            this.StudentFeedbackButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StudentFeedbackButton.ImageSize = new System.Drawing.Size(30, 30);
            this.StudentFeedbackButton.Location = new System.Drawing.Point(3, 474);
            this.StudentFeedbackButton.Name = "StudentFeedbackButton";
            this.StudentFeedbackButton.Size = new System.Drawing.Size(237, 50);
            this.StudentFeedbackButton.TabIndex = 8;
            this.StudentFeedbackButton.Text = "Student Feedback";
            this.StudentFeedbackButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StudentFeedbackButton.TextOffset = new System.Drawing.Point(22, 0);
            this.StudentFeedbackButton.UseTransparentBackground = true;
            this.StudentFeedbackButton.Click += new System.EventHandler(this.StudentFeedbackButton_Click);
            // 
            // ViewBooksButton
            // 
            this.ViewBooksButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewBooksButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.ViewBooksButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewBooksButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewBooksButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewBooksButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewBooksButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.ViewBooksButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.ViewBooksButton.ForeColor = System.Drawing.Color.White;
            this.ViewBooksButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ViewBooksButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewBooksButton.Image")));
            this.ViewBooksButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewBooksButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ViewBooksButton.Location = new System.Drawing.Point(3, 362);
            this.ViewBooksButton.Name = "ViewBooksButton";
            this.ViewBooksButton.Size = new System.Drawing.Size(237, 50);
            this.ViewBooksButton.TabIndex = 6;
            this.ViewBooksButton.Text = "View Books";
            this.ViewBooksButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewBooksButton.TextOffset = new System.Drawing.Point(22, 0);
            this.ViewBooksButton.UseTransparentBackground = true;
            this.ViewBooksButton.Click += new System.EventHandler(this.ViewBooksButton_Click);
            // 
            // ViewStudentsButton
            // 
            this.ViewStudentsButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewStudentsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.ViewStudentsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewStudentsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewStudentsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewStudentsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewStudentsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.ViewStudentsButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.ViewStudentsButton.ForeColor = System.Drawing.Color.White;
            this.ViewStudentsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.ViewStudentsButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewStudentsButton.Image")));
            this.ViewStudentsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewStudentsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ViewStudentsButton.Location = new System.Drawing.Point(3, 306);
            this.ViewStudentsButton.Name = "ViewStudentsButton";
            this.ViewStudentsButton.Size = new System.Drawing.Size(237, 50);
            this.ViewStudentsButton.TabIndex = 5;
            this.ViewStudentsButton.Text = "View Students";
            this.ViewStudentsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewStudentsButton.TextOffset = new System.Drawing.Point(22, 0);
            this.ViewStudentsButton.UseTransparentBackground = true;
            this.ViewStudentsButton.Click += new System.EventHandler(this.ViewStudentsButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Transparent;
            this.AddBookButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddBookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBookButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.AddBookButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddBookButton.ForeColor = System.Drawing.Color.White;
            this.AddBookButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddBookButton.Image = ((System.Drawing.Image)(resources.GetObject("AddBookButton.Image")));
            this.AddBookButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddBookButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AddBookButton.Location = new System.Drawing.Point(3, 194);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(237, 50);
            this.AddBookButton.TabIndex = 3;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddBookButton.TextOffset = new System.Drawing.Point(22, 0);
            this.AddBookButton.UseTransparentBackground = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.AddStudentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddStudentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddStudentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddStudentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddStudentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddStudentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.AddStudentButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddStudentButton.ForeColor = System.Drawing.Color.White;
            this.AddStudentButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.AddStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("AddStudentButton.Image")));
            this.AddStudentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddStudentButton.ImageSize = new System.Drawing.Size(25, 25);
            this.AddStudentButton.Location = new System.Drawing.Point(3, 138);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Padding = new System.Windows.Forms.Padding(5);
            this.AddStudentButton.Size = new System.Drawing.Size(237, 50);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddStudentButton.TextOffset = new System.Drawing.Point(22, 0);
            this.AddStudentButton.UseTransparentBackground = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Animated = true;
            this.LogoutButton.AutoRoundedCorners = true;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.LogoutButton.BorderRadius = 17;
            this.LogoutButton.BorderThickness = 1;
            this.LogoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.LogoutButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.Location = new System.Drawing.Point(49, 23);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(138, 36);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseTransparentBackground = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.siticoneSeparator2);
            this.flowLayoutPanel1.Controls.Add(this.DashboardButton);
            this.flowLayoutPanel1.Controls.Add(this.AddStudentButton);
            this.flowLayoutPanel1.Controls.Add(this.AddBookButton);
            this.flowLayoutPanel1.Controls.Add(this.AddAdminButton);
            this.flowLayoutPanel1.Controls.Add(this.ViewStudentsButton);
            this.flowLayoutPanel1.Controls.Add(this.ViewBooksButton);
            this.flowLayoutPanel1.Controls.Add(this.ViewAdminButton);
            this.flowLayoutPanel1.Controls.Add(this.StudentFeedbackButton);
            this.flowLayoutPanel1.Controls.Add(this.BookFineButton);
            this.flowLayoutPanel1.Controls.Add(this.siticoneSeparator1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 686);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserCirclePictureBox);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 57);
            this.panel1.TabIndex = 6;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Location = new System.Drawing.Point(3, 586);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(237, 10);
            this.siticoneSeparator1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LogoutButton);
            this.panel2.Location = new System.Drawing.Point(3, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 72);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(240, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1024, 686);
            this.panelCenter.TabIndex = 6;
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            // 
            // LibrarianDashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 686);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibrarianDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserCirclePictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton DashboardButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton LogoutButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AddStudentButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BookFineButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ViewAdminButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AddAdminButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton StudentFeedbackButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ViewBooksButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ViewStudentsButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AddBookButton;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox UserCirclePictureBox;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCenter;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
    }
}