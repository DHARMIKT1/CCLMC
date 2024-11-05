using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CCLMS.Student.UserControlForms
{
    public partial class CompleteBookDetails : UserControl
    {
        private readonly SqlConnection con;

        public CompleteBookDetails()
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
                        s.name AS StudentName,
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
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ViewIssueBooksDataGridView.DataSource = dataTable;

                            ViewIssueBooksDataGridView.Columns["issueId"].HeaderText = "Issue ID";
                            ViewIssueBooksDataGridView.Columns["bookId"].HeaderText = "Book ID";
                            ViewIssueBooksDataGridView.Columns["bookTitle"].HeaderText = "Book Title";
                            ViewIssueBooksDataGridView.Columns["studentId"].HeaderText = "Student Id";
                            ViewIssueBooksDataGridView.Columns["StudentName"].HeaderText = "Student Name";
                            ViewIssueBooksDataGridView.Columns["issueDate"].HeaderText = "Issue Date";
                            ViewIssueBooksDataGridView.Columns["dueDate"].HeaderText = "Due Date";
                            ViewIssueBooksDataGridView.Columns["returnDate"].HeaderText = "Return Date";
                            ViewIssueBooksDataGridView.Columns["status"].HeaderText = "Status";
                        }
                    }
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
                        st.name AS StudentName,
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
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ViewReturnBooksDataGridView.DataSource = dataTable;

                            ViewReturnBooksDataGridView.Columns["returnId"].HeaderText = "Return ID";
                            ViewReturnBooksDataGridView.Columns["bookId"].HeaderText = "Book ID";
                            ViewReturnBooksDataGridView.Columns["bookTitle"].HeaderText = "Book Title";
                            ViewReturnBooksDataGridView.Columns["studentId"].HeaderText = "Student Id";
                            ViewReturnBooksDataGridView.Columns["StudentName"].HeaderText = "Student Name";
                            ViewReturnBooksDataGridView.Columns["returnDate"].HeaderText = "Return Date";
                            ViewReturnBooksDataGridView.Columns["dueDate"].HeaderText = "Due Date";
                            ViewReturnBooksDataGridView.Columns["overdueFee"].HeaderText = "Overdue Fee";
                        }
                    }
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
    }
}
