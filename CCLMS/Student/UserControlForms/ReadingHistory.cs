using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Student.UserControlForms
{
    public partial class ReadingHistory : UserControl
    {
        private readonly SqlConnection con;

        // Stores the ID of the currently logged-in student
        private readonly string loggedInUserId;

        public ReadingHistory(string loggedInStudentId)
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            // Assign the logged-in student ID before loading data
            this.loggedInUserId = loggedInStudentId;

            LoadReadingHistory();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void SetColumnHeaders()
        {
            ReadingHistoryDataGridView.Columns["studentId"].Visible = false;
            ReadingHistoryDataGridView.Columns["bookTitle"].HeaderText = "Book Title";
            ReadingHistoryDataGridView.Columns["issueBookDate"].HeaderText = "Issue Date";
            ReadingHistoryDataGridView.Columns["returnBookDate"].HeaderText = "Return Date";
            ReadingHistoryDataGridView.Columns["reservationDate"].HeaderText = "Reservation Date";
            ReadingHistoryDataGridView.Columns["readingHistoryId"].Visible = false;
        }

        private void LoadReadingHistory()
        {
            string Query = @"
                SELECT
                    rh.readingHistoryId,
                    rh.studentId,
                    b.bookTitle,
                    rh.issueBookDate,
                    rh.returnBookDate,
                    rh.reservationDate
                FROM
                    studentReadingHistory rh
                JOIN
                    book b ON rh.bookId = b.bookId
                LEFT JOIN
                    bookReservation br ON rh.studentId = br.studentId AND rh.bookId = br.bookId
                WHERE
                    rh.studentId = @studentId
            ";

            try
            {
                con.Open();

                using (SqlCommand sqlCommand = new SqlCommand(Query, con))
                {
                    sqlCommand.Parameters.AddWithValue("@studentId", loggedInUserId);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ReadingHistoryDataGridView.DataSource = dataTable;
                            SetColumnHeaders();
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

        private void ReadingHistoryDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.Value = "-";
                e.FormattingApplied = true;
            }
        }

        private void DeleteHistoryButton_Click(object sender, EventArgs e)
        {
            if (ReadingHistoryDataGridView.SelectedRows.Count > 0)
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
                                string deleteQuery = "DELETE FROM studentReadingHistory WHERE readingHistoryId = @HistoryId";

                                foreach (DataGridViewRow selectedRow in ReadingHistoryDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["readingHistoryId"].Value != null && int.TryParse(selectedRow.Cells["readingHistoryId"].Value.ToString(), out int bookId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@HistoryId", bookId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        ReadingHistoryDataGridView.Rows.Remove(selectedRow);
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

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            if (ReadingHistoryDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in ReadingHistoryDataGridView.Rows)
                {
                    row.Selected = true;
                }
            }
            else
            {
                MessageBox.Show("No reading history records found.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
