using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Admin
{
    public partial class ReservationRemove : Form
    {
        private readonly SqlConnection con;

        public ReservationRemove()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            GetBookReservationData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void GetBookReservationData()
        {
            string query = @"
                    SELECT 
                        br.reservationId AS [Reservation Id], 
                        s.name AS Name, 
                        br.bookId AS [Book Id], 
                        b.bookTitle AS [Book Title],
                        br.reservationDate AS [Reservation Date], 
                        br.expectedPickupDate AS [Expected PickupDate], 
                        br.reservationStatus AS [Reservation Status]
                    FROM 
                        bookReservation br
                    JOIN 
                        student s ON br.studentId = s.studentId
                    JOIN
                        book b ON br.bookId = b.bookId
            ";

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            BooksReservationDataGridView.DataSource = dataTable;
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
        }

        private void RemoveReservationButton_Click(object sender, EventArgs e)
        {
            if (BooksReservationDataGridView.SelectedRows.Count > 0)
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
                                string deleteQuery = "DELETE FROM bookReservation WHERE reservationId = @reservationId";

                                foreach (DataGridViewRow selectedRow in BooksReservationDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["Reservation Id"].Value != null && int.TryParse(selectedRow.Cells["Reservation Id"].Value.ToString(), out int reservationId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@reservationId", reservationId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        BooksReservationDataGridView.Rows.Remove(selectedRow);
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
            if (BooksReservationDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in BooksReservationDataGridView.Rows)
                {
                    row.Selected = true;
                }
            }
            else
            {
                MessageBox.Show("No reservation book record found", "No records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
