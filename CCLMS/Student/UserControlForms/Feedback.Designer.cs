namespace CCLMS.Student.UserControlForms
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SubmitFeedbackButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.MessageTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.EmailTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.NameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.UserIdTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 838);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SubmitFeedbackButton
            // 
            this.SubmitFeedbackButton.Animated = true;
            this.SubmitFeedbackButton.AutoRoundedCorners = true;
            this.SubmitFeedbackButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitFeedbackButton.BorderRadius = 21;
            this.SubmitFeedbackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitFeedbackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitFeedbackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitFeedbackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitFeedbackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.SubmitFeedbackButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold);
            this.SubmitFeedbackButton.ForeColor = System.Drawing.Color.White;
            this.SubmitFeedbackButton.Location = new System.Drawing.Point(29, 501);
            this.SubmitFeedbackButton.Name = "SubmitFeedbackButton";
            this.SubmitFeedbackButton.Size = new System.Drawing.Size(302, 45);
            this.SubmitFeedbackButton.TabIndex = 15;
            this.SubmitFeedbackButton.TabStop = false;
            this.SubmitFeedbackButton.Text = "Submit Feedback";
            this.SubmitFeedbackButton.Click += new System.EventHandler(this.SubmitFeedbackButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.DefaultText = "";
            this.MessageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MessageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MessageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.MessageTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.MessageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.MessageTextBox.Location = new System.Drawing.Point(29, 194);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.PasswordChar = '\0';
            this.MessageTextBox.PlaceholderText = "Enter Your Feedback Message";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.SelectedText = "";
            this.MessageTextBox.Size = new System.Drawing.Size(370, 227);
            this.MessageTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.MessageTextBox.TabIndex = 4;
            this.MessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.EmailTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.EmailTextBox.Location = new System.Drawing.Point(29, 150);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderText = "Enter Your Email";
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(370, 38);
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
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.NameTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.NameTextBox.Location = new System.Drawing.Point(29, 106);
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
            this.UserIdTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.UserIdTextBox.DefaultText = "";
            this.UserIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.UserIdTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.UserIdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.UserIdTextBox.Location = new System.Drawing.Point(29, 62);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.PasswordChar = '\0';
            this.UserIdTextBox.PlaceholderText = "Enter Your User Id";
            this.UserIdTextBox.ReadOnly = true;
            this.UserIdTextBox.SelectedText = "";
            this.UserIdTextBox.Size = new System.Drawing.Size(370, 38);
            this.UserIdTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.UserIdTextBox.TabIndex = 1;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 21;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(29, 552);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(302, 45);
            this.siticoneButton1.TabIndex = 16;
            this.siticoneButton1.TabStop = false;
            this.siticoneButton1.Text = "CLEAR";
            this.siticoneButton1.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.SubmitFeedbackButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Feedback";
            this.Size = new System.Drawing.Size(1024, 686);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SubmitFeedbackButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox MessageTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox EmailTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox NameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UserIdTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}
