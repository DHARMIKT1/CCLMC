using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Siticone.Desktop.UI.WinForms;
using CCLMS.Admin.DataGridViewDetailViews;

namespace CCLMS.Admin.UserControlForms
{
    public partial class ViewLibrarian : UserControl
    {
        private readonly SqlConnection con;

        public ViewLibrarian()
        {
            InitializeComponent();

            con = new SqlConnection(GetConnectionString());

            GetLibrarianData();
            GetLibrarianSearchData();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCLMS"].ConnectionString;
        }

        private void GetLibrarianSearchData(string searchTerm = "")
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM librarian";

                if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "Search")
                {
                    query += " WHERE name LIKE @searchTerm OR email LIKE @searchTerm OR phoneNumber LIKE @searchTerm OR librarianId LIKE @searchTerm";
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
                            ViewAdminDataGridView.DataSource = dataTable;
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
            GetLibrarianSearchData(SearchTextBox.Text.Trim());
        }

        private void GetLibrarianData()
        {
            try
            {
                con.Open();

                string librarianQuery = @"SELECT * FROM librarian";

                using (SqlCommand sqlCommand = new SqlCommand(librarianQuery, con))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            sqlDataAdapter.Fill(dataTable);
                            ViewAdminDataGridView.DataSource = dataTable;
                        }

                        ViewAdminDataGridView.Columns["librarianId"].HeaderText = "Librarian Id";
                        ViewAdminDataGridView.Columns["name"].HeaderText = "Name";
                        ViewAdminDataGridView.Columns["email"].HeaderText = "Email";
                        ViewAdminDataGridView.Columns["password"].HeaderText = "Password";
                        ViewAdminDataGridView.Columns["phoneNumber"].HeaderText = "Phone Number";
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewAdminDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ViewAdminDataGridView.SelectedRows[0];

                    int UserId = Convert.ToInt32(selectedRow.Cells["librarianId"].Value);
                    string Name = selectedRow.Cells["Name"].Value.ToString();
                    string Email = selectedRow.Cells["Email"].Value.ToString();
                    string Password = selectedRow.Cells["Password"].Value.ToString();
                    string PhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();

                    UpdateLibrarianInfo updateAdminForm = new UpdateLibrarianInfo(UserId, Name, Email, Password, PhoneNumber, con);
                    if (updateAdminForm.ShowDialog() == DialogResult.OK)
                    {
                        GetLibrarianData();
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
            if (ViewAdminDataGridView.SelectedRows.Count > 0)
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
                                string deleteQuery = "DELETE FROM librarian WHERE librarianId = @userId";

                                foreach (DataGridViewRow selectedRow in ViewAdminDataGridView.SelectedRows)
                                {
                                    if (selectedRow.Cells["librarianId"].Value != null && int.TryParse(selectedRow.Cells["librarianId"].Value.ToString(), out int userId))
                                    {
                                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, con, transaction))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@userId", userId);
                                            sqlCommand.ExecuteNonQuery();
                                        }
                                        ViewAdminDataGridView.Rows.Remove(selectedRow);

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

        private void ViewAdminDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SiticoneDataGridView dataGridView = sender as SiticoneDataGridView;

                if (dataGridView != null)
                {
                    DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                    int userId = Convert.ToInt32(selectedRow.Cells["librarianId"].Value.ToString());
                    string name = selectedRow.Cells["name"].Value.ToString();
                    string email = selectedRow.Cells["email"].Value.ToString();
                    string password = selectedRow.Cells["Password"].Value.ToString();
                    long phoneNumber = Convert.ToInt64(selectedRow.Cells["phoneNumber"].Value.ToString());

                    LibrarianDetailsView adminDetailsView = new LibrarianDetailsView(userId, name, email, password, phoneNumber);
                    adminDetailsView.ShowDialog();
                }
            }
        }
    }
}
