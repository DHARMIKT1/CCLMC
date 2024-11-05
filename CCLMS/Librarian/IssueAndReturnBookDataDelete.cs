using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Admin
{
    public partial class IssueAndReturnBookDataDelete : Form
    {
        private readonly SqlConnection con;

        public IssueAndReturnBookDataDelete()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            LoadBookReturnData();
            LoadIssueBookData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void LoadIssueBookData()
        {
            try
            {
                string issueBookDataQuery = @"
                    SELECT 
                        i.issueId,
                        i.bookId,
                        a.bookTitle,
                        s.name AS Name,
                        i.studentId,
                        i.issueDate,
                        i.dueDate,
                        i.returnDate,
                        i.status
                    FROM 
                        issueBook i
                    INNER JOIN 
                        book a ON i.bookId = a.bookId
                    INNER JOIN
                        student s ON i.studentId = s.studentId
                ";

                using (SqlCommand sqlCommand = new SqlCommand(issueBookDataQuery, con))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {

                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            ViewIssueBooksDataGridView.DataSource = dataTable;
                        }
                    }

                    ViewIssueBooksDataGridView.Columns["issueId"].HeaderText = "Issue ID";
                    ViewIssueBooksDataGridView.Columns["bookId"].HeaderText = "Book ID";
                    ViewIssueBooksDataGridView.Columns["bookTitle"].HeaderText = "Book Title";
                    ViewIssueBooksDataGridView.Columns["studentId"].HeaderText = "Student Id";
                    ViewIssueBooksDataGridView.Columns["Name"].HeaderText = "Student Name";
                    ViewIssueBooksDataGridView.Columns["issueDate"].HeaderText = "Issue Date";
                    ViewIssueBooksDataGridView.Columns["dueDate"].HeaderText = "Due Date";
                    ViewIssueBooksDataGridView.Columns["returnDate"].HeaderText = "Return Date";
                    ViewIssueBooksDataGridView.Columns["status"].HeaderText = "Status";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("A database error occurred while loading issue book data: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading issue book data: " + ex.Message);
            }
        }

        void LoadBookReturnData()
        {
            try
            {
                string bookReturnDataQuery = @"
                    SELECT 
                        br.returnId,
                        br.bookId,
                        a.bookTitle,
                        st.name AS Name,
                        br.studentId,
                        br.returnDate,
                        br.dueDate,
                        br.overdueFee
                    FROM 
                        bookReturn br
                    INNER JOIN 
                        book a ON br.bookId = a.bookId
                    INNER JOIN
                        student st ON br.studentId = st.studentId
                ";

                using (SqlCommand sqlCommand = new SqlCommand(bookReturnDataQuery, con))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            ViewReturnBooksDataGridView.DataSource = dataTable;

                        }
                    }

                    ViewReturnBooksDataGridView.Columns["returnId"].HeaderText = "Return ID";
                    ViewReturnBooksDataGridView.Columns["bookId"].HeaderText = "Book ID";
                    ViewReturnBooksDataGridView.Columns["bookTitle"].HeaderText = "Book Title";
                    ViewReturnBooksDataGridView.Columns["studentId"].HeaderText = "Student Id";
                    ViewReturnBooksDataGridView.Columns["Name"].HeaderText = "Student Name";
                    ViewReturnBooksDataGridView.Columns["returnDate"].HeaderText = "Return Date";
                    ViewReturnBooksDataGridView.Columns["dueDate"].HeaderText = "Due Date";
                    ViewReturnBooksDataGridView.Columns["overdueFee"].HeaderText = "Overdue Fee";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("A database error occurred while loading book return data: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading book return data: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ViewIssueBooksDataGridView.SelectedRows.Count > 0 || ViewReturnBooksDataGridView.SelectedRows.Count > 0)
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
                                string deleteIssueBookQuery = "DELETE FROM issueBook WHERE issueId = @issueId";
                                string deleteReturnBookQuery = "DELETE FROM bookReturn WHERE returnId = @returnId";

                                foreach (DataGridViewRow selectedRow in ViewIssueBooksDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["issueId"].Value != null && int.TryParse(selectedRow.Cells["issueId"].Value.ToString(), out int issueId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteIssueBookQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@issueId", issueId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        ViewIssueBooksDataGridView.Rows.Remove(selectedRow);
                                    }
                                }

                                foreach (DataGridViewRow selectedRow in ViewReturnBooksDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["returnId"].Value != null && int.TryParse(selectedRow.Cells["returnId"].Value.ToString(), out int returnId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteReturnBookQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@returnId", returnId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        ViewReturnBooksDataGridView.Rows.Remove(selectedRow);
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

        private void SelectAllRecordButton_Click(object sender, EventArgs e)
        {
            if (ViewIssueBooksDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in ViewIssueBooksDataGridView.Rows)
                {
                    row.Selected = true;
                }
            }
            else
            {
                MessageBox.Show("No issue book records found.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ViewReturnBooksDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in ViewReturnBooksDataGridView.Rows)
                {
                    row.Selected = true;
                }
            }
            else
            {
                MessageBox.Show("No return book records found.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
