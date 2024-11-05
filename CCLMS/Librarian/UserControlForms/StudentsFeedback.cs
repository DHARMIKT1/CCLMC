using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Siticone.Desktop.UI.WinForms;
using CCLMS.Admin.DataGridViewDetailViews;

namespace CCLMS.Admin.UserControlForms
{
    public partial class StudentsFeedback : UserControl
    {
        private readonly SqlConnection con;

        public StudentsFeedback()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            GetFeedbackData();
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

                string query = "SELECT * FROM feedback";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                {
                    query += " WHERE name LIKE @searchTerm OR email LIKE @searchTerm OR feedbackId LIKE @searchTerm OR studentId LIKE @searchTerm";
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            GetSearchData(SearchTextBox.Text.Trim());
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                SearchTextBox.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void GetFeedbackData()
        {
            try
            {
                con.Open();

                string FeedbackQuery = @"SELECT * FROM feedback";

                using (SqlCommand sqlCommand = new SqlCommand(FeedbackQuery, con))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ViewStudentDataGridView.DataSource = dataTable;
                        }

                        ViewStudentDataGridView.Columns["feedbackId"].HeaderText = "Feedback Id";
                        ViewStudentDataGridView.Columns["studentId"].HeaderText = "Student Id";
                        ViewStudentDataGridView.Columns["name"].HeaderText = "Student Name";
                        ViewStudentDataGridView.Columns["email"].HeaderText = "Email";
                        ViewStudentDataGridView.Columns["message"].HeaderText = "Message";
                        ViewStudentDataGridView.Columns["createdAt"].HeaderText = "Message Created Time";
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ViewStudentDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = ViewStudentDataGridView.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = ViewStudentDataGridView.Rows[selectedRowIndex];
                int feedbackId = Convert.ToInt32(selectedRow.Cells["FeedbackId"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this feedback?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                string deleteQuery = "DELETE FROM feedback WHERE feedbackId = @FeedbackId";

                                using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, con, transaction))
                                {
                                    sqlCommand.Parameters.AddWithValue("@FeedbackId", feedbackId);
                                    sqlCommand.ExecuteNonQuery();
                                }
                                ViewStudentDataGridView.Rows.RemoveAt(selectedRowIndex);

                                transaction.Commit();
                                MessageBox.Show("Feedback deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void StudentFeedbackDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SiticoneDataGridView dataGridView = sender as SiticoneDataGridView;

                if (dataGridView != null)
                {
                    DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                    int feedbackId = Convert.ToInt32(selectedRow.Cells["feedbackId"].Value.ToString());
                    int userId = Convert.ToInt32(selectedRow.Cells["studentId"].Value.ToString());
                    string name = selectedRow.Cells["name"].Value.ToString();
                    string email = selectedRow.Cells["email"].Value.ToString();
                    string message = selectedRow.Cells["message"].Value.ToString();
                    DateTime dateTime = Convert.ToDateTime(selectedRow.Cells["createdAt"].Value.ToString());

                    StudentFeedbackDetailsViews studentFeedbackDetailsViews = new StudentFeedbackDetailsViews(feedbackId, userId, name, email, message, dateTime);
                    studentFeedbackDetailsViews.ShowDialog();
                }
            }
        }
    }
}
