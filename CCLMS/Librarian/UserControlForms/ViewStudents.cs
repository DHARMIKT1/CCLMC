using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Siticone.Desktop.UI.WinForms;
using CCLMS.Admin.DataGridViewDetailViews;

namespace CCLMS.Admin.UserControlForms
{
    public partial class ViewStudents : UserControl
    {
        private readonly SqlConnection con;

        public ViewStudents()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            GetStudentsData();
            GetSearchData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void GetSearchData(string searchTerm = "")
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM student";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                {
                    query += " WHERE name LIKE @searchTerm OR email LIKE @searchTerm OR phoneNumber LIKE @searchTerm OR studentId LIKE @searchTerm";
                }

                using (SqlCommand sqlCommand = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                    {
                        sqlCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    }

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ViewStudentDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void GetStudentsData()
        {
            try
            {
                con.Open();

                string StudentQuery = @"SELECT * FROM student";

                using (SqlCommand sqlCommand = new SqlCommand(StudentQuery, con))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ViewStudentDataGridView.DataSource = dataTable;
                        }

                        ViewStudentDataGridView.Columns["studentId"].HeaderText = "Student Id";
                        ViewStudentDataGridView.Columns["name"].HeaderText = "Name";
                        ViewStudentDataGridView.Columns["email"].HeaderText = "Email";
                        ViewStudentDataGridView.Columns["password"].HeaderText = "Password";
                        ViewStudentDataGridView.Columns["phoneNumber"].HeaderText = "Phone Number";
                        ViewStudentDataGridView.Columns["department"].HeaderText = "Department";
                        ViewStudentDataGridView.Columns["semester"].HeaderText = "Semester";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                SearchTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            GetSearchData(SearchTextBox.Text.Trim());
        }

        private void ViewStudentDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SiticoneDataGridView dataGridView = sender as SiticoneDataGridView;

                if (dataGridView != null)
                {
                    DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                    int userId = Convert.ToInt32(selectedRow.Cells["studentId"].Value.ToString());
                    string name = selectedRow.Cells["name"].Value.ToString();
                    string email = selectedRow.Cells["email"].Value.ToString();
                    string password = selectedRow.Cells["password"].Value.ToString();
                    long phoneNumber = Convert.ToInt64(selectedRow.Cells["phoneNumber"].Value.ToString());
                    string department = selectedRow.Cells["department"].Value.ToString();
                    int semester = Convert.ToInt32(selectedRow.Cells["semester"].Value.ToString());

                    StudentDetailsViews studentDetailsViews = new StudentDetailsViews(userId, name, email, password, phoneNumber, department, semester);
                    studentDetailsViews.ShowDialog();
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewStudentDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ViewStudentDataGridView.SelectedRows[0];
                    if (int.TryParse(selectedRow.Cells["studentId"].Value.ToString(), out int userId))
                    {
                        int StudentId = Convert.ToInt32(selectedRow.Cells["studentId"].Value);
                        string Name = selectedRow.Cells["Name"].Value.ToString();
                        string Email = selectedRow.Cells["Email"].Value.ToString();
                        string Password = selectedRow.Cells["Password"].Value.ToString();
                        string PhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                        string Department = selectedRow.Cells["Department"].Value.ToString();
                        string Semester = selectedRow.Cells["Semester"].Value.ToString();

                        UpdateStudentInfo updateStudentInfo = new UpdateStudentInfo(StudentId, Name, Email, Password, PhoneNumber, Department, Semester, con);
                        if (updateStudentInfo.ShowDialog() == DialogResult.OK)
                        {
                            GetStudentsData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ViewStudentDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                string deleteQuery = "DELETE FROM student WHERE studentId = @userId";

                                foreach (DataGridViewRow selectedRow in ViewStudentDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["studentId"].Value != null && int.TryParse(selectedRow.Cells["studentId"].Value.ToString(), out int userId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@userId", userId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        ViewStudentDataGridView.Rows.Remove(selectedRow);
                                    }
                                }
                                transaction.Commit();
                                MessageBox.Show("Records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException sqlEx)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    finally
                    {
                        if (con != null && con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select rows to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
