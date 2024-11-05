namespace CCLMS.Forget_Password_Form
{
    partial class SendOtpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendOtpForm));
            this.Close = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.TextBoxEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SendButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.OtpTextBox6 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.OtpTextBox5 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.OtpTextBox4 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.OtpTextBox3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.OtpTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.OtpTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.VerifyOtpButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ResendOtpButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.IconColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(464, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(45, 29);
            this.Close.TabIndex = 0;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BorderRadius = 1;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.DefaultText = "";
            this.TextBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.TextBoxEmail.Font = new System.Drawing.Font("Gadugi", 12F);
            this.TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.TextBoxEmail.Location = new System.Drawing.Point(37, 50);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PlaceholderText = "Enter Your Email Address";
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.Size = new System.Drawing.Size(421, 41);
            this.TextBoxEmail.TabIndex = 5;
            this.TextBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEmail_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.Animated = true;
            this.SendButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SendButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(37, 97);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(421, 50);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send OTP";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OtpTextBox6
            // 
            this.OtpTextBox6.Animated = true;
            this.OtpTextBox6.BorderRadius = 2;
            this.OtpTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OtpTextBox6.DefaultText = "";
            this.OtpTextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OtpTextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OtpTextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtpTextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox6.Location = new System.Drawing.Point(358, 154);
            this.OtpTextBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtpTextBox6.Name = "OtpTextBox6";
            this.OtpTextBox6.PasswordChar = '\0';
            this.OtpTextBox6.PlaceholderText = "-";
            this.OtpTextBox6.SelectedText = "";
            this.OtpTextBox6.Size = new System.Drawing.Size(50, 50);
            this.OtpTextBox6.TabIndex = 32;
            this.OtpTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtpTextBox6.TextChanged += new System.EventHandler(this.OtpTextBox6_TextChanged);
            this.OtpTextBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtpTextBox6_KeyPress);
            // 
            // OtpTextBox5
            // 
            this.OtpTextBox5.Animated = true;
            this.OtpTextBox5.BorderRadius = 2;
            this.OtpTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OtpTextBox5.DefaultText = "";
            this.OtpTextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OtpTextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OtpTextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtpTextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox5.Location = new System.Drawing.Point(300, 154);
            this.OtpTextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtpTextBox5.Name = "OtpTextBox5";
            this.OtpTextBox5.PasswordChar = '\0';
            this.OtpTextBox5.PlaceholderText = "-";
            this.OtpTextBox5.SelectedText = "";
            this.OtpTextBox5.Size = new System.Drawing.Size(50, 50);
            this.OtpTextBox5.TabIndex = 31;
            this.OtpTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtpTextBox5.TextChanged += new System.EventHandler(this.OtpTextBox5_TextChanged);
            this.OtpTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtpTextBox5_KeyPress);
            // 
            // OtpTextBox4
            // 
            this.OtpTextBox4.Animated = true;
            this.OtpTextBox4.BorderRadius = 2;
            this.OtpTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OtpTextBox4.DefaultText = "";
            this.OtpTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OtpTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OtpTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtpTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox4.Location = new System.Drawing.Point(242, 154);
            this.OtpTextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtpTextBox4.Name = "OtpTextBox4";
            this.OtpTextBox4.PasswordChar = '\0';
            this.OtpTextBox4.PlaceholderText = "-";
            this.OtpTextBox4.SelectedText = "";
            this.OtpTextBox4.Size = new System.Drawing.Size(50, 50);
            this.OtpTextBox4.TabIndex = 30;
            this.OtpTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtpTextBox4.TextChanged += new System.EventHandler(this.OtpTextBox4_TextChanged);
            this.OtpTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtpTextBox4_KeyPress);
            // 
            // OtpTextBox3
            // 
            this.OtpTextBox3.Animated = true;
            this.OtpTextBox3.BorderRadius = 2;
            this.OtpTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OtpTextBox3.DefaultText = "";
            this.OtpTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OtpTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OtpTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtpTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox3.Location = new System.Drawing.Point(184, 154);
            this.OtpTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtpTextBox3.Name = "OtpTextBox3";
            this.OtpTextBox3.PasswordChar = '\0';
            this.OtpTextBox3.PlaceholderText = "-";
            this.OtpTextBox3.SelectedText = "";
            this.OtpTextBox3.Size = new System.Drawing.Size(50, 50);
            this.OtpTextBox3.TabIndex = 29;
            this.OtpTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtpTextBox3.TextChanged += new System.EventHandler(this.OtpTextBox3_TextChanged);
            this.OtpTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtpTextBox3_KeyPress);
            // 
            // OtpTextBox2
            // 
            this.OtpTextBox2.Animated = true;
            this.OtpTextBox2.BorderRadius = 2;
            this.OtpTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OtpTextBox2.DefaultText = "";
            this.OtpTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OtpTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OtpTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtpTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox2.Location = new System.Drawing.Point(126, 154);
            this.OtpTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtpTextBox2.Name = "OtpTextBox2";
            this.OtpTextBox2.PasswordChar = '\0';
            this.OtpTextBox2.PlaceholderText = "-";
            this.OtpTextBox2.SelectedText = "";
            this.OtpTextBox2.Size = new System.Drawing.Size(50, 50);
            this.OtpTextBox2.TabIndex = 28;
            this.OtpTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtpTextBox2.TextChanged += new System.EventHandler(this.OtpTextBox2_TextChanged);
            this.OtpTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtpTextBox2_KeyPress);
            // 
            // OtpTextBox1
            // 
            this.OtpTextBox1.Animated = true;
            this.OtpTextBox1.BorderRadius = 2;
            this.OtpTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OtpTextBox1.DefaultText = "";
            this.OtpTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OtpTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OtpTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OtpTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox1.Font = new System.Drawing.Font("Gadugi", 12F);
            this.OtpTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.OtpTextBox1.Location = new System.Drawing.Point(68, 154);
            this.OtpTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtpTextBox1.Name = "OtpTextBox1";
            this.OtpTextBox1.PasswordChar = '\0';
            this.OtpTextBox1.PlaceholderText = "-";
            this.OtpTextBox1.SelectedText = "";
            this.OtpTextBox1.Size = new System.Drawing.Size(50, 50);
            this.OtpTextBox1.TabIndex = 27;
            this.OtpTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtpTextBox1.TextChanged += new System.EventHandler(this.OtpTextBox1_TextChanged);
            this.OtpTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtpTextBox1_KeyPress);
            // 
            // VerifyOtpButton
            // 
            this.VerifyOtpButton.Animated = true;
            this.VerifyOtpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.VerifyOtpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VerifyOtpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VerifyOtpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VerifyOtpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VerifyOtpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.VerifyOtpButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.VerifyOtpButton.ForeColor = System.Drawing.Color.White;
            this.VerifyOtpButton.Location = new System.Drawing.Point(37, 211);
            this.VerifyOtpButton.Name = "VerifyOtpButton";
            this.VerifyOtpButton.Size = new System.Drawing.Size(421, 50);
            this.VerifyOtpButton.TabIndex = 26;
            this.VerifyOtpButton.Text = "Verfiry OTP";
            this.VerifyOtpButton.Click += new System.EventHandler(this.VerifyOtpButton_Click);
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
            this.ClearButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClearButton.Location = new System.Drawing.Point(37, 323);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(421, 50);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ResendOtpButton
            // 
            this.ResendOtpButton.Animated = true;
            this.ResendOtpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ResendOtpButton.BorderThickness = 1;
            this.ResendOtpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResendOtpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResendOtpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResendOtpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResendOtpButton.FillColor = System.Drawing.Color.White;
            this.ResendOtpButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResendOtpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ResendOtpButton.Location = new System.Drawing.Point(37, 267);
            this.ResendOtpButton.Name = "ResendOtpButton";
            this.ResendOtpButton.Size = new System.Drawing.Size(421, 50);
            this.ResendOtpButton.TabIndex = 33;
            this.ResendOtpButton.Text = "Resend OTP";
            this.ResendOtpButton.Click += new System.EventHandler(this.ResendOtpButton_Click);
            // 
            // SendOtpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 398);
            this.Controls.Add(this.ResendOtpButton);
            this.Controls.Add(this.OtpTextBox6);
            this.Controls.Add(this.OtpTextBox5);
            this.Controls.Add(this.OtpTextBox4);
            this.Controls.Add(this.OtpTextBox3);
            this.Controls.Add(this.OtpTextBox2);
            this.Controls.Add(this.OtpTextBox1);
            this.Controls.Add(this.VerifyOtpButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendOtpForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendOtpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox Close;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SendButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox OtpTextBox6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox OtpTextBox5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox OtpTextBox4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox OtpTextBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox OtpTextBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox OtpTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton VerifyOtpButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ResendOtpButton;
    }
}