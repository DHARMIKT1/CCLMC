namespace CCLMS.Student.UserControlForms
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.ClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.IssueBookButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.UserIdTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IssueBookSelectButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.IssueBookNameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.ClearButton.Location = new System.Drawing.Point(18, 302);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(364, 45);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // IssueBookButton
            // 
            this.IssueBookButton.Animated = true;
            this.IssueBookButton.AutoRoundedCorners = true;
            this.IssueBookButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.IssueBookButton.BorderRadius = 21;
            this.IssueBookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.IssueBookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.IssueBookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.IssueBookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.IssueBookButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.IssueBookButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBookButton.ForeColor = System.Drawing.Color.White;
            this.IssueBookButton.Location = new System.Drawing.Point(18, 251);
            this.IssueBookButton.Name = "IssueBookButton";
            this.IssueBookButton.Size = new System.Drawing.Size(364, 45);
            this.IssueBookButton.TabIndex = 24;
            this.IssueBookButton.Text = "Issue Book";
            this.IssueBookButton.Click += new System.EventHandler(this.IssueBookButton_Click);
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
            this.UserIdTextBox.Location = new System.Drawing.Point(18, 69);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.PasswordChar = '\0';
            this.UserIdTextBox.PlaceholderText = "Enter User Id";
            this.UserIdTextBox.SelectedText = "";
            this.UserIdTextBox.Size = new System.Drawing.Size(416, 41);
            this.UserIdTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.UserIdTextBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(18, 193);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(416, 27);
            this.dateTimePickerDueDate.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Due Date";
            // 
            // IssueBookSelectButton
            // 
            this.IssueBookSelectButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.IssueBookSelectButton.BorderThickness = 1;
            this.IssueBookSelectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.IssueBookSelectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.IssueBookSelectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.IssueBookSelectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.IssueBookSelectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IssueBookSelectButton.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.IssueBookSelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IssueBookSelectButton.Location = new System.Drawing.Point(450, 116);
            this.IssueBookSelectButton.Name = "IssueBookSelectButton";
            this.IssueBookSelectButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IssueBookSelectButton.Size = new System.Drawing.Size(106, 41);
            this.IssueBookSelectButton.TabIndex = 30;
            this.IssueBookSelectButton.Text = "Select book";
            this.IssueBookSelectButton.Click += new System.EventHandler(this.IssueBookSelectButton_Click);
            // 
            // IssueBookNameTextBox
            // 
            this.IssueBookNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IssueBookNameTextBox.DefaultText = "";
            this.IssueBookNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IssueBookNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IssueBookNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IssueBookNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IssueBookNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.IssueBookNameTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.IssueBookNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.IssueBookNameTextBox.Location = new System.Drawing.Point(18, 116);
            this.IssueBookNameTextBox.Name = "IssueBookNameTextBox";
            this.IssueBookNameTextBox.PasswordChar = '\0';
            this.IssueBookNameTextBox.PlaceholderText = "Enter Book Title";
            this.IssueBookNameTextBox.ReadOnly = true;
            this.IssueBookNameTextBox.SelectedText = "";
            this.IssueBookNameTextBox.Size = new System.Drawing.Size(416, 41);
            this.IssueBookNameTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.IssueBookNameTextBox.TabIndex = 31;
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.IssueBookNameTextBox);
            this.Controls.Add(this.IssueBookSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.IssueBookButton);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IssueBook";
            this.Size = new System.Drawing.Size(1024, 686);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton IssueBookButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UserIdTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton IssueBookSelectButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox IssueBookNameTextBox;
    }
}
