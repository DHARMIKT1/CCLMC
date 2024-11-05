using System.Windows.Forms;

namespace CCLMS.Admin.UserControlForms
{
    partial class DashboardLibrarian
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
            this.TotalStudentLabel = new System.Windows.Forms.Label();
            this.TotalStudentNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBookNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalIssuesBooksNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalReturnedBooksNumberLabel = new System.Windows.Forms.Label();
            this.TotalReservationBooksNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalFeedbackNumberLabel = new System.Windows.Forms.Label();
            this.TotalAdminNumberLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalBooksFineNumberLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReservationRemoveButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.IssueAndReturnBookDataDeleteButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalStudentLabel
            // 
            this.TotalStudentLabel.AutoSize = true;
            this.TotalStudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalStudentLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudentLabel.ForeColor = System.Drawing.Color.White;
            this.TotalStudentLabel.Location = new System.Drawing.Point(7, 9);
            this.TotalStudentLabel.Name = "TotalStudentLabel";
            this.TotalStudentLabel.Size = new System.Drawing.Size(139, 21);
            this.TotalStudentLabel.TabIndex = 1;
            this.TotalStudentLabel.Text = "Total Students";
            // 
            // TotalStudentNumberLabel
            // 
            this.TotalStudentNumberLabel.AutoSize = true;
            this.TotalStudentNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalStudentNumberLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudentNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TotalStudentNumberLabel.Location = new System.Drawing.Point(16, 89);
            this.TotalStudentNumberLabel.Name = "TotalStudentNumberLabel";
            this.TotalStudentNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.TotalStudentNumberLabel.TabIndex = 2;
            this.TotalStudentNumberLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Books";
            // 
            // TotalBookNumberLabel
            // 
            this.TotalBookNumberLabel.AutoSize = true;
            this.TotalBookNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalBookNumberLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalBookNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TotalBookNumberLabel.Location = new System.Drawing.Point(12, 89);
            this.TotalBookNumberLabel.Name = "TotalBookNumberLabel";
            this.TotalBookNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.TotalBookNumberLabel.TabIndex = 10;
            this.TotalBookNumberLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Issue Books";
            // 
            // TotalIssuesBooksNumberLabel
            // 
            this.TotalIssuesBooksNumberLabel.AutoSize = true;
            this.TotalIssuesBooksNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalIssuesBooksNumberLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalIssuesBooksNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TotalIssuesBooksNumberLabel.Location = new System.Drawing.Point(16, 56);
            this.TotalIssuesBooksNumberLabel.Name = "TotalIssuesBooksNumberLabel";
            this.TotalIssuesBooksNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.TotalIssuesBooksNumberLabel.TabIndex = 13;
            this.TotalIssuesBooksNumberLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Returned Book";
            // 
            // TotalReturnedBooksNumberLabel
            // 
            this.TotalReturnedBooksNumberLabel.AutoSize = true;
            this.TotalReturnedBooksNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalReturnedBooksNumberLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalReturnedBooksNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TotalReturnedBooksNumberLabel.Location = new System.Drawing.Point(7, 75);
            this.TotalReturnedBooksNumberLabel.Name = "TotalReturnedBooksNumberLabel";
            this.TotalReturnedBooksNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.TotalReturnedBooksNumberLabel.TabIndex = 16;
            this.TotalReturnedBooksNumberLabel.Text = "0";
            // 
            // TotalReservationBooksNumber
            // 
            this.TotalReservationBooksNumber.AutoSize = true;
            this.TotalReservationBooksNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalReservationBooksNumber.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalReservationBooksNumber.ForeColor = System.Drawing.Color.White;
            this.TotalReservationBooksNumber.Location = new System.Drawing.Point(3, 75);
            this.TotalReservationBooksNumber.Name = "TotalReservationBooksNumber";
            this.TotalReservationBooksNumber.Size = new System.Drawing.Size(30, 32);
            this.TotalReservationBooksNumber.TabIndex = 20;
            this.TotalReservationBooksNumber.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label8.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Feedback";
            // 
            // TotalFeedbackNumberLabel
            // 
            this.TotalFeedbackNumberLabel.AutoSize = true;
            this.TotalFeedbackNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalFeedbackNumberLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalFeedbackNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TotalFeedbackNumberLabel.Location = new System.Drawing.Point(40, 75);
            this.TotalFeedbackNumberLabel.Name = "TotalFeedbackNumberLabel";
            this.TotalFeedbackNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.TotalFeedbackNumberLabel.TabIndex = 24;
            this.TotalFeedbackNumberLabel.Text = "0";
            // 
            // TotalAdminNumberLabel
            // 
            this.TotalAdminNumberLabel.AutoSize = true;
            this.TotalAdminNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalAdminNumberLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalAdminNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TotalAdminNumberLabel.Location = new System.Drawing.Point(52, 75);
            this.TotalAdminNumberLabel.Name = "TotalAdminNumberLabel";
            this.TotalAdminNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.TotalAdminNumberLabel.TabIndex = 27;
            this.TotalAdminNumberLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label11.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Total Librarian";
            // 
            // TotalBooksFineNumberLabel
            // 
            this.TotalBooksFineNumberLabel.AutoSize = true;
            this.TotalBooksFineNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TotalBooksFineNumberLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalBooksFineNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TotalBooksFineNumberLabel.Location = new System.Drawing.Point(18, 76);
            this.TotalBooksFineNumberLabel.Name = "TotalBooksFineNumberLabel";
            this.TotalBooksFineNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.TotalBooksFineNumberLabel.TabIndex = 30;
            this.TotalBooksFineNumberLabel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label13.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total Book Fine";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(430, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 33;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel9);
            this.flowLayoutPanel2.Controls.Add(this.panel8);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1024, 550);
            this.flowLayoutPanel2.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.TotalStudentLabel);
            this.panel2.Controls.Add(this.TotalStudentNumberLabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 132);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TotalBookNumberLabel);
            this.panel3.Location = new System.Drawing.Point(3, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 132);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.TotalBooksFineNumberLabel);
            this.panel4.Location = new System.Drawing.Point(753, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 132);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.TotalIssuesBooksNumberLabel);
            this.panel5.Location = new System.Drawing.Point(253, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 132);
            this.panel5.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.TotalReturnedBooksNumberLabel);
            this.panel6.Location = new System.Drawing.Point(503, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 132);
            this.panel6.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.TotalReservationBooksNumber);
            this.panel7.Location = new System.Drawing.Point(753, 141);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(244, 132);
            this.panel7.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Book Reservations";
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.TotalFeedbackNumberLabel);
            this.panel8.Location = new System.Drawing.Point(503, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(244, 132);
            this.panel8.TabIndex = 35;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.TotalAdminNumberLabel);
            this.panel9.Location = new System.Drawing.Point(253, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(244, 132);
            this.panel9.TabIndex = 36;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ReservationRemoveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IssueAndReturnBookDataDeleteButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(364, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 102);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // ReservationRemoveButton
            // 
            this.ReservationRemoveButton.Animated = true;
            this.ReservationRemoveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReservationRemoveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReservationRemoveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReservationRemoveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReservationRemoveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ReservationRemoveButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationRemoveButton.ForeColor = System.Drawing.Color.White;
            this.ReservationRemoveButton.Location = new System.Drawing.Point(3, 56);
            this.ReservationRemoveButton.Name = "ReservationRemoveButton";
            this.ReservationRemoveButton.Size = new System.Drawing.Size(301, 43);
            this.ReservationRemoveButton.TabIndex = 32;
            this.ReservationRemoveButton.Text = "Reservation Data Delete";
            this.ReservationRemoveButton.Click += new System.EventHandler(this.ReservationRemoveButton_Click);
            // 
            // IssueAndReturnBookDataDeleteButton
            // 
            this.IssueAndReturnBookDataDeleteButton.Animated = true;
            this.IssueAndReturnBookDataDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.IssueAndReturnBookDataDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.IssueAndReturnBookDataDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.IssueAndReturnBookDataDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.IssueAndReturnBookDataDeleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.IssueAndReturnBookDataDeleteButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.IssueAndReturnBookDataDeleteButton.ForeColor = System.Drawing.Color.White;
            this.IssueAndReturnBookDataDeleteButton.Location = new System.Drawing.Point(3, 3);
            this.IssueAndReturnBookDataDeleteButton.Name = "IssueAndReturnBookDataDeleteButton";
            this.IssueAndReturnBookDataDeleteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IssueAndReturnBookDataDeleteButton.Size = new System.Drawing.Size(301, 47);
            this.IssueAndReturnBookDataDeleteButton.TabIndex = 31;
            this.IssueAndReturnBookDataDeleteButton.Text = "Issue And Return Book Data Detele";
            this.IssueAndReturnBookDataDeleteButton.Click += new System.EventHandler(this.IssueAndReturnBookDataDeleteButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 556);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(350, 0, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 130);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // DashboardLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardLibrarian";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 686);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TotalStudentLabel;
        private System.Windows.Forms.Label TotalStudentNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalBookNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalIssuesBooksNumberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalReturnedBooksNumberLabel;
        private System.Windows.Forms.Label TotalReservationBooksNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalFeedbackNumberLabel;
        private System.Windows.Forms.Label TotalAdminNumberLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TotalBooksFineNumberLabel;
        private System.Windows.Forms.Label label13;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton IssueAndReturnBookDataDeleteButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ReservationRemoveButton;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
