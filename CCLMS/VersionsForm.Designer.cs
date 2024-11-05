namespace CCLMS
{
    partial class VersionsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Admin and Student user roles with distinct permissions.\n");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User registration and login functionality.\n");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("User Management:\n", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Add, update, and delete books.");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Book reservation and issue management.");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Return book management with overdue fee calculation.");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Library Management:\n", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Easy-to-navigate interface with clear labels and instructions.");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("DataGridView for displaying issued and returned books.");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Search and filter options for book management.");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("User Interface", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Student feedback submission.");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Student reading history tracking.");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Fine calculation and management for overdue books.");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Additional Features", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Added a \"Forgot Password\" link for user convenience.");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Password reset functionality with email verification.");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Password Reset", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("More specific error messages for invalid inputs.");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Enhanced validation for user inputs during login.");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Improved Error Handling", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Implemented advanced search filters for book management.");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Users can search by book title, author, publication, and category.");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Advanced Search", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Initial release with no known bugs.");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Bug Fixes", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software Version Information for College Campus Library Management System (CCLMS)" +
    "\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version 1.0.0 - Initial Release Release Date: June 20, 2024\r\n";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 66);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Admin and Student user roles with distinct permissions.\n";
            treeNode2.Name = "Node2";
            treeNode2.Text = "User registration and login functionality.\n";
            treeNode3.Name = "Node0";
            treeNode3.Text = "User Management:\n";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Add, update, and delete books.";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Book reservation and issue management.";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Return book management with overdue fee calculation.";
            treeNode7.Name = "Node3";
            treeNode7.Text = "Library Management:\n";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Easy-to-navigate interface with clear labels and instructions.";
            treeNode9.Name = "Node6";
            treeNode9.Text = "DataGridView for displaying issued and returned books.";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Search and filter options for book management.";
            treeNode11.Name = "Node3";
            treeNode11.Text = "User Interface";
            treeNode12.Name = "Node10";
            treeNode12.Text = "Student feedback submission.";
            treeNode13.Name = "Node11";
            treeNode13.Text = "Student reading history tracking.";
            treeNode14.Name = "Node12";
            treeNode14.Text = "Fine calculation and management for overdue books.";
            treeNode15.Name = "Node9";
            treeNode15.Text = "Additional Features";
            treeNode16.Name = "Node16";
            treeNode16.Text = "Added a \"Forgot Password\" link for user convenience.";
            treeNode17.Name = "Node18";
            treeNode17.Text = "Password reset functionality with email verification.";
            treeNode18.Name = "Node15";
            treeNode18.Text = "Password Reset";
            treeNode19.Name = "Node20";
            treeNode19.Text = "More specific error messages for invalid inputs.";
            treeNode20.Name = "Node21";
            treeNode20.Text = "Enhanced validation for user inputs during login.";
            treeNode21.Name = "Node19";
            treeNode21.Text = "Improved Error Handling";
            treeNode22.Name = "Node23";
            treeNode22.Text = "Implemented advanced search filters for book management.";
            treeNode23.Name = "Node25";
            treeNode23.Text = "Users can search by book title, author, publication, and category.";
            treeNode24.Name = "Node22";
            treeNode24.Text = "Advanced Search";
            treeNode25.Name = "Node27";
            treeNode25.Text = "Initial release with no known bugs.";
            treeNode26.Name = "Node26";
            treeNode26.Text = "Bug Fixes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode11,
            treeNode15,
            treeNode18,
            treeNode21,
            treeNode24,
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(990, 417);
            this.treeView1.TabIndex = 2;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(946, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 37);
            this.siticoneControlBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your feedback is important to us as we strive to improve CCLMS continuously.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-11, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 37);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.siticoneControlBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 37);
            this.panel2.TabIndex = 6;
            // 
            // VersionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(990, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VersionsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}