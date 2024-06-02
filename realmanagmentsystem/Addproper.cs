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
    public partial class Addproper : Form
    {
        
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Remax;Integrated Security=True;Encrypt=False";

        public Addproper()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string buildingType = txtBuildingType.Text;
            int bedrooms = Convert.ToInt32(txtBedrooms.Text);
            string builtIn = txtBuiltIn.Text;
            string neighbourhood = txtNeighbourhood.Text;
            string address = txtAddress.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            string description = txtDescription.Text;
            string pool = txtPool.Text;
            string elevator = txtElevator.Text;
            string imageUrl = txtImageUrl.Text; // Assuming user input for image URL
            int clientid = Convert.ToInt32(ClientIDcom.SelectedValue);
            int employeeid = Convert.ToInt32(EmployeeIDtxt.SelectedValue);
            int branchid = Convert.ToInt32(BranchIDw.SelectedValue);
            string statues = Statuestxt.Text;

            // Insert the new property into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HouseFeatures (EstateID,[Building Type], BedRooms, [Built in], Neighbourhood, Address, Price, Description, Pool, Elevator, ImageUrl) " +
                               "VALUES ((SELECT ISNULL(MAX(EstateID),0) + 1 FROM HouseFeatures), @BuildingType, @Bedrooms, @BuiltIn, @Neighbourhood, @Address, @Price, @Description, @Pool, @Elevator, @ImageUrl)";
                string query2 = "INSERT INTO Houses (EstateID, Status, ClientID, EmployeeID, BranchID) " +
                                "VALUES ((SELECT ISNULL(MAX(EstateID), 0) FROM HouseFeatures), @Status, @ClientID, @EmployeeID, @BranchID)";
                string query3 = "INSERT INTO Transactions (Status, SellerName, Phone, ClientID, ContractPath, PaymentDate, Amount, PropertyID) " +
                                "VALUES (@Status, @Seller, @Phone, @ClientID, @Path, @Date, @Amount, (SELECT ISNULL(MAX(EstateID), 0) FROM HouseFeatures))";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BuildingType", buildingType);
                    command.Parameters.AddWithValue("@Bedrooms", bedrooms);
                    command.Parameters.AddWithValue("@BuiltIn", builtIn);
                    command.Parameters.AddWithValue("@Neighbourhood", neighbourhood);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Pool", pool);
                    command.Parameters.AddWithValue("@Elevator", elevator);
                    command.Parameters.AddWithValue("@ImageUrl", imageUrl);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@Status", statues);
                            command2.Parameters.AddWithValue("@ClientID", clientid);
                            command2.Parameters.AddWithValue("@EmployeeID", employeeid);
                            command2.Parameters.AddWithValue("@BranchID", branchid);
                            int rowsAffected2 = command2.ExecuteNonQuery();

                            if (rowsAffected2 > 0)
                            {
                                using (SqlCommand command3 = new SqlCommand(query3, connection))
                                {
                                    command3.Parameters.AddWithValue("@Status", tranStuts.Text);
                                    command3.Parameters.AddWithValue("@Seller", txtSaller.Text);
                                    command3.Parameters.AddWithValue("@Phone", trnphone.Text);
                                    command3.Parameters.AddWithValue("@ClientID", clientid);
                                    command3.Parameters.AddWithValue("@Path", path.Text);
                                    command3.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                                    command3.Parameters.AddWithValue("@Amount", Convert.ToDecimal(transammount.Text));

                                    command3.ExecuteNonQuery();
                                }
                                MessageBox.Show("Property added successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add property details to Houses.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add property to HouseFeatures.");
                    }
                }
            }
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
                    BranchIDw.DataSource = dataTable;
                    BranchIDw.DisplayMember = "Location";
                    BranchIDw.ValueMember = "BranchID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AddProperty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'remaxDataSet5.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.remaxDataSet5.Branches);
            // TODO: This line of code loads data into the 'remaxDataSet4.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.remaxDataSet4.Employees);
            // TODO: This line of code loads data into the 'remaxDataSet3.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.remaxDataSet3.Clients);
            // TODO: This line of code loads data into the 'remaxDataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.remaxDataSet2.Clients);
            LoadBranchData();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Statuestxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BranchIDw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeIDtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientIDcom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtImageUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtElevator_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPool_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNeighbourhood_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
