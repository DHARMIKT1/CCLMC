namespace CCLMS.Student.UserControlForms
{
    partial class BookReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookReservation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UnreservationButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ReservationsListComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ReservationBooksButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DateTimePickerExpectedPickupDate = new System.Windows.Forms.DateTimePicker();
            this.UserIdTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.ExpectedPickupDateLabel = new System.Windows.Forms.Label();
            this.CompleteReadingButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationBookNameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ReservationBookSelectButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UnreservationButton
            // 
            this.UnreservationButton.AutoRoundedCorners = true;
            this.UnreservationButton.BorderRadius = 21;
            this.UnreservationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UnreservationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UnreservationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UnreservationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UnreservationButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnreservationButton.ForeColor = System.Drawing.Color.White;
            this.UnreservationButton.Location = new System.Drawing.Point(257, 455);
            this.UnreservationButton.Name = "UnreservationButton";
            this.UnreservationButton.Size = new System.Drawing.Size(180, 45);
            this.UnreservationButton.TabIndex = 29;
            this.UnreservationButton.Text = "Unreservation Book";
            this.UnreservationButton.Click += new System.EventHandler(this.UnreservationButton_Click);
            // 
            // ReservationsListComboBox
            // 
            this.ReservationsListComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ReservationsListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReservationsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReservationsListComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReservationsListComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReservationsListComboBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationsListComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ReservationsListComboBox.ItemHeight = 30;
            this.ReservationsListComboBox.Location = new System.Drawing.Point(49, 399);
            this.ReservationsListComboBox.Name = "ReservationsListComboBox";
            this.ReservationsListComboBox.Size = new System.Drawing.Size(388, 36);
            this.ReservationsListComboBox.TabIndex = 28;
            // 
            // ReservationBooksButton
            // 
            this.ReservationBooksButton.AutoRoundedCorners = true;
            this.ReservationBooksButton.BorderRadius = 21;
            this.ReservationBooksButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReservationBooksButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReservationBooksButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReservationBooksButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReservationBooksButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationBooksButton.ForeColor = System.Drawing.Color.White;
            this.ReservationBooksButton.Location = new System.Drawing.Point(156, 235);
            this.ReservationBooksButton.Name = "ReservationBooksButton";
            this.ReservationBooksButton.Size = new System.Drawing.Size(180, 45);
            this.ReservationBooksButton.TabIndex = 27;
            this.ReservationBooksButton.Text = "Reservation Book";
            this.ReservationBooksButton.Click += new System.EventHandler(this.ReservationBooksButton_Click);
            // 
            // DateTimePickerExpectedPickupDate
            // 
            this.DateTimePickerExpectedPickupDate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerExpectedPickupDate.Location = new System.Drawing.Point(49, 183);
            this.DateTimePickerExpectedPickupDate.Name = "DateTimePickerExpectedPickupDate";
            this.DateTimePickerExpectedPickupDate.Size = new System.Drawing.Size(388, 27);
            this.DateTimePickerExpectedPickupDate.TabIndex = 26;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserIdTextBox.DefaultText = "";
            this.UserIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserIdTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserIdTextBox.Location = new System.Drawing.Point(49, 46);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.PasswordChar = '\0';
            this.UserIdTextBox.PlaceholderText = "Enter User Id";
            this.UserIdTextBox.SelectedText = "";
            this.UserIdTextBox.Size = new System.Drawing.Size(388, 36);
            this.UserIdTextBox.TabIndex = 25;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Location = new System.Drawing.Point(49, 314);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(388, 20);
            this.siticoneSeparator1.TabIndex = 30;
            // 
            // ExpectedPickupDateLabel
            // 
            this.ExpectedPickupDateLabel.AutoSize = true;
            this.ExpectedPickupDateLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpectedPickupDateLabel.Location = new System.Drawing.Point(46, 164);
            this.ExpectedPickupDateLabel.Name = "ExpectedPickupDateLabel";
            this.ExpectedPickupDateLabel.Size = new System.Drawing.Size(132, 16);
            this.ExpectedPickupDateLabel.TabIndex = 31;
            this.ExpectedPickupDateLabel.Text = "Expected Pickup Date";
            // 
            // CompleteReadingButton
            // 
            this.CompleteReadingButton.AutoRoundedCorners = true;
            this.CompleteReadingButton.BorderRadius = 21;
            this.CompleteReadingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CompleteReadingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CompleteReadingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CompleteReadingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CompleteReadingButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteReadingButton.ForeColor = System.Drawing.Color.White;
            this.CompleteReadingButton.Location = new System.Drawing.Point(49, 455);
            this.CompleteReadingButton.Name = "CompleteReadingButton";
            this.CompleteReadingButton.Size = new System.Drawing.Size(180, 45);
            this.CompleteReadingButton.TabIndex = 32;
            this.CompleteReadingButton.Text = "Complete Reading";
            this.CompleteReadingButton.Click += new System.EventHandler(this.CompleteReadingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Select a Book for Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "If you have finished reading the book, click on \'Complete Reading\'. \r\nIf the book" +
    " was reserved by mistake, click on \'Unreserve Book\'.";
            // 
            // ReservationBookNameTextBox
            // 
            this.ReservationBookNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReservationBookNameTextBox.DefaultText = "";
            this.ReservationBookNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReservationBookNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReservationBookNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReservationBookNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReservationBookNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReservationBookNameTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.ReservationBookNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReservationBookNameTextBox.Location = new System.Drawing.Point(49, 116);
            this.ReservationBookNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReservationBookNameTextBox.Name = "ReservationBookNameTextBox";
            this.ReservationBookNameTextBox.PasswordChar = '\0';
            this.ReservationBookNameTextBox.PlaceholderText = "Enter Book Title";
            this.ReservationBookNameTextBox.ReadOnly = true;
            this.ReservationBookNameTextBox.SelectedText = "";
            this.ReservationBookNameTextBox.Size = new System.Drawing.Size(388, 36);
            this.ReservationBookNameTextBox.TabIndex = 35;
            // 
            // ReservationBookSelectButton
            // 
            this.ReservationBookSelectButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ReservationBookSelectButton.BorderThickness = 1;
            this.ReservationBookSelectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReservationBookSelectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReservationBookSelectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReservationBookSelectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReservationBookSelectButton.FillColor = System.Drawing.SystemColors.Window;
            this.ReservationBookSelectButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationBookSelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ReservationBookSelectButton.Location = new System.Drawing.Point(443, 116);
            this.ReservationBookSelectButton.Name = "ReservationBookSelectButton";
            this.ReservationBookSelectButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReservationBookSelectButton.Size = new System.Drawing.Size(106, 36);
            this.ReservationBookSelectButton.TabIndex = 36;
            this.ReservationBookSelectButton.Text = "Select book";
            this.ReservationBookSelectButton.Click += new System.EventHandler(this.IssueBookSelectButton_Click);
            // 
            // BookReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReservationBookSelectButton);
            this.Controls.Add(this.ReservationBookNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompleteReadingButton);
            this.Controls.Add(this.ExpectedPickupDateLabel);
            this.Controls.Add(this.siticoneSeparator1);
            this.Controls.Add(this.UnreservationButton);
            this.Controls.Add(this.ReservationsListComboBox);
            this.Controls.Add(this.ReservationBooksButton);
            this.Controls.Add(this.DateTimePickerExpectedPickupDate);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookReservation";
            this.Size = new System.Drawing.Size(1024, 686);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton UnreservationButton;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ReservationsListComboBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ReservationBooksButton;
        private System.Windows.Forms.DateTimePicker DateTimePickerExpectedPickupDate;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UserIdTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private System.Windows.Forms.Label ExpectedPickupDateLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CompleteReadingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ReservationBookNameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ReservationBookSelectButton;
    }
}
