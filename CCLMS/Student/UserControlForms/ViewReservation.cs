using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CCLMS.Student.UserControlForms
{
    public partial class ViewReservation : UserControl
    {
        private readonly SqlConnection con;

        public ViewReservation()
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
                        student s ON br.studentId= s.studentId
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
                            ViewBooksReservationDataGridView.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
