using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realmanagmentsystem
{
    public partial class AddClient : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Remax;Integrated Security=True;Encrypt=False";
        public AddClient()
        {
            InitializeComponent();
        }
        private void LoadBranchData()
        {

            // Step 2: Define the SQL query to retrieve BranchID and Location
            string query = "SELECT BranchID, Location FROM Branches";

            // Step 3: Retrieve data from the database and bind to the ComboBox
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Step 4: Bind the DataTable to the ComboBox
                    txtBID.DataSource = dataTable;
                    txtBID.DisplayMember = "Location"; // The column to display
                    txtBID.ValueMember = "BranchID"; // The column to use as value
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            // Step 3: Get the input values
            string clientName = txtCName.Text;
            string clientStatus = txtCStatus.Text;
            string phone = txtCPhone.Text;
            string email = txtCEmail.Text;
            int branchID = Convert.ToInt32(txtBID.SelectedValue);

            // Step 5: Define the SQL insert command
            string insertQuery = "INSERT INTO Clients (ClientName, ClientStatus, Phone, [E-mail], BranchID) " +
                                 "VALUES (@ClientName, @ClientStatus, @Phone, @Email, @BranchID)";

            // Step 6: Execute the insert command
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ClientName", clientName);
                        command.Parameters.AddWithValue("@ClientStatus", clientStatus);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@BranchID", branchID);

                        // Open the connection, execute the command, and close the connection
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Client added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add client.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            LoadBranchData();
        }
    }
    }

