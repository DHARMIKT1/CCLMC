﻿namespace CCLMS.Admin.UserControlForms
{
    partial class ViewStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.UpdateButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ViewStudentDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 50);
            this.panel1.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AutoRoundedCorners = true;
            this.SearchTextBox.BorderRadius = 20;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(261, 4);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Find a student";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(501, 42);
            this.SearchTextBox.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 51);
            this.panel2.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Animated = true;
            this.DeleteButton.AutoRoundedCorners = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.DeleteButton.BorderRadius = 21;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.DeleteButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(506, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(180, 45);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseTransparentBackground = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.UpdateButton.Location = new System.Drawing.Point(310, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(180, 45);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseTransparentBackground = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.ViewStudentDataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 585);
            this.panel3.TabIndex = 2;
            // 
            // ViewStudentDataGridView
            // 
            this.ViewStudentDataGridView.AllowUserToAddRows = false;
            this.ViewStudentDataGridView.AllowUserToDeleteRows = false;
            this.ViewStudentDataGridView.AllowUserToResizeColumns = false;
            this.ViewStudentDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ViewStudentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewStudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ViewStudentDataGridView.ColumnHeadersHeight = 40;
            this.ViewStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewStudentDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ViewStudentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewStudentDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewStudentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ViewStudentDataGridView.Name = "ViewStudentDataGridView";
            this.ViewStudentDataGridView.ReadOnly = true;
            this.ViewStudentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewStudentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ViewStudentDataGridView.RowHeadersVisible = false;
            this.ViewStudentDataGridView.RowTemplate.Height = 30;
            this.ViewStudentDataGridView.Size = new System.Drawing.Size(1024, 585);
            this.ViewStudentDataGridView.TabIndex = 0;
            this.ViewStudentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ViewStudentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ViewStudentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ViewStudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ViewStudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ViewStudentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ViewStudentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewStudentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ViewStudentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ViewStudentDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ViewStudentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ViewStudentDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.ViewStudentDataGridView.ThemeStyle.ReadOnly = true;
            this.ViewStudentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ViewStudentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ViewStudentDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ViewStudentDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.ViewStudentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewStudentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ViewStudentDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewStudentDataGridView_CellContentDoubleClick);
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewStudents";
            this.Size = new System.Drawing.Size(1024, 686);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewStudentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SearchTextBox;
        private System.Windows.Forms.Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton DeleteButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton UpdateButton;
        private System.Windows.Forms.Panel panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView ViewStudentDataGridView;
    }
}