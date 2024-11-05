using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Student.UserControlForms
{
    public partial class CompleteStudentsDetails : UserControl
    {
        private readonly SqlConnection con;

        public CompleteStudentsDetails()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            LoadStudentDetailsData();
            GetStudentSearchData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoadStudentDetailsData()
        {
            try
            {
                con.Open();

                string StudentDetailsDataQuery = @"SELECT studentId, name, email, department, semester FROM student";

                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(StudentDetailsDataQuery, con))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        sqlDataAdapter.Fill(dataTable);
                        ViewCompleteStudentsDetailsDataGridView.DataSource = dataTable;

                        ViewCompleteStudentsDetailsDataGridView.Columns["studentId"].HeaderText = "Student Id";
                        ViewCompleteStudentsDetailsDataGridView.Columns["name"].HeaderText = "Name";
                        ViewCompleteStudentsDetailsDataGridView.Columns["email"].HeaderText = "Email";
                        ViewCompleteStudentsDetailsDataGridView.Columns["department"].HeaderText = "Department";
                        ViewCompleteStudentsDetailsDataGridView.Columns["semester"].HeaderText = "Semester";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("A database error occurred while loading student details: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading student details: " + ex.Message);

            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void GetStudentSearchData(string searchTerm = "")
        {
            try
            {
                con.Open();

                string SearchQuery = @"SELECT studentId, name, email, department, semester FROM student";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                {
                    SearchQuery += " WHERE studentId LIKE @searchTerm OR name LIKE @searchTerm OR email LIKE @searchTerm OR semester LIKE @searchTerm OR department LIKE @searchTerm";
                }

                using (SqlCommand sqlCommand = new SqlCommand(SearchQuery, con))
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
                            ViewCompleteStudentsDetailsDataGridView.DataSource = dataTable;
                        }
                    }
                }
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

        private void SearchStudentTextBox_TextChanged(object sender, EventArgs e)
        {
            GetStudentSearchData(SearchStudentTextBox.Text.Trim());
        }

        private void SearchStudentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int pos = SearchStudentTextBox.SelectionStart;
                if (pos > 0)
                {
                    int start = pos - 1;
                    while (start > 0 && !char.IsWhiteSpace(SearchStudentTextBox.Text[start]))
                    {
                        start--;
                    }
                    SearchStudentTextBox.Text = SearchStudentTextBox.Text.Remove(start, pos - start);
                    SearchStudentTextBox.SelectionStart = start;
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
