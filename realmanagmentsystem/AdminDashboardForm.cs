using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace realmanagmentsystem
{
    public partial class AdminDashboardForm : Form
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Remax;Integrated Security=True;Encrypt=False";
        private int selectedTransactionID = -1;
        private int selectedEmployeeID = -1;
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'remaxDataSet6.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter2.Fill(this.remaxDataSet6.Branches);
            // TODO: This line of code loads data into the 'remaxDataSet4.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.remaxDataSet4.Clients);
            // TODO: This line of code loads data into the 'remaxDataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.remaxDataSet2.Clients);
            // TODO: This line of code loads data into the 'remaxDataSet1.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter1.Fill(this.remaxDataSet1.Branches);
            // TODO: This line of code loads data into the 'remaxDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.remaxDataSet.Branches);
            LoadAll();
        }
        private void LoadAll()
        {
            ShowPropertyStatistics();
            ShowSalesAndProfitGraph();
            LoadProperties();
            LoadTransactions();
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeID, Name, Position, Phone, Birthday, Gender, Email, City, BranchID FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewEmployees.DataSource = dataTable;
            }
        }
        private void LoadTransactions()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT t.TransactionID, t.Status,t.ContractPath,t.PaymentDate,t.Amount, t.SellerName, t.Phone, c.ClientName " +
                               "FROM Transactions t " +
                               "INNER JOIN Clients c ON t.ClientID = c.ClientID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewTransactions.DataSource = dataTable;
            }
        }
        private void LoadProperties()
        {
            // Load properties into DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT hf.EstateID, hf.[Building Type], hf.BedRooms, hf.[Built in], hf.Neighbourhood, hf.Address, hf.Price, hf.ImageUrl " +
                               "FROM HouseFeatures hf ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewProperties.DataSource = dataTable;
            }
        }
        private void ShowPropertyStatistics()
        {
            int totalProperties = 0;
            int propertiesSold = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM HouseFeatures";
                string soldQuery = "SELECT COUNT(*) FROM Houses WHERE Status = 'Sold'";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    totalProperties = (int)command.ExecuteScalar();
                }

                using (SqlCommand command = new SqlCommand(soldQuery, connection))
                {
                    propertiesSold = (int)command.ExecuteScalar();
                }
            }

            lblTotalProperties.Text = "Total Properties: " + totalProperties.ToString();
            lblPropertiesSold.Text = "Properties Sold: " + propertiesSold.ToString();
        }

        private void ShowSalesAndProfitGraph()
        {
            // Clear any existing data in the chart
            chartSalesProfit.Series.Clear();
            chartSalesProfit.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartSalesProfit.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                            T.TransactionID,
                            T.Amount AS Sales,
                            T.Amount - H.Price AS Profit,
                            H.Price AS Cost,
                            T.SellerName
                        FROM
                            Transactions T
                        JOIN
                            HouseFeatures H ON T.PropertyID = H.EstateID";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve data from the database
                            decimal sales = (decimal)reader["Sales"];
                            decimal profit = (decimal)reader["Profit"];
                            string sellerName = (string)reader["SellerName"];

                            // Check if the series already exists
                            Series salesSeries = chartSalesProfit.Series.FindByName("Sales");
                            Series profitSeries = chartSalesProfit.Series.FindByName("Profit");

                            if (salesSeries == null)
                            {
                                // Create a new series for sales
                                salesSeries = new Series("Sales");
                                salesSeries.ChartType = SeriesChartType.Line;
                                salesSeries.Color = Color.Blue;
                                chartSalesProfit.Series.Add(salesSeries);
                            }

                            if (profitSeries == null)
                            {
                                // Create a new series for profit
                                profitSeries = new Series("Profit");
                                profitSeries.ChartType = SeriesChartType.Column;
                                profitSeries.Color = Color.Green;
                                chartSalesProfit.Series.Add(profitSeries);
                            }

                            // Add data points to the chart
                            salesSeries.Points.AddXY(sellerName, sales);
                            profitSeries.Points.AddXY(sellerName, profit);
                        }
                    }
                }
            }

            // Set chart properties
            chartSalesProfit.ChartAreas[0].AxisX.Title = "Seller";
            chartSalesProfit.ChartAreas[0].AxisY.Title = "Amount ($)";
            chartSalesProfit.ChartAreas[0].AxisX.Interval = 1;
            chartSalesProfit.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate X-axis labels
            chartSalesProfit.ChartAreas[0].AxisX.Interval = 1;
            chartSalesProfit.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Auto;
            chartSalesProfit.ChartAreas[0].AxisX.IsMarginVisible = true;
            chartSalesProfit.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep90;

            chartSalesProfit.Legends[0].Enabled = true;
            chartSalesProfit.Legends[0].Docking = Docking.Bottom; // Position legend at the bottom

            chartSalesProfit.Titles.Add("Sales and Profit by Seller");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ShowPropertyStatistics();
            ShowSalesAndProfitGraph();
            LoadAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewProperties.SelectedRows.Count > 0)
            {
                int estateID = Convert.ToInt32(dataGridViewProperties.SelectedRows[0].Cells["EstateID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM HouseFeatures WHERE EstateID = @EstateID";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EstateID", estateID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Property deleted successfully.");
                            LoadProperties();

                        }
                        else
                        {
                            MessageBox.Show("Failed to delete property.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a property to delete.");
            }
        }

        private void dataGridViewProperties_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string location = txtLocation.Text;
                decimal minPrice = Convert.ToDecimal(txtMinPrice.Text);
                decimal maxPrice = Convert.ToDecimal(txtMaxPrice.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT hf.EstateID, hf.[Building Type], hf.BedRooms, hf.[Built in], hf.Neighbourhood, hf.Address, hf.Price, hf.ImageUrl, h.Status " +
                                   "FROM HouseFeatures hf " +
                                   "INNER JOIN Houses h ON hf.EstateID = h.EstateID " +
                                   "WHERE hf.Neighbourhood = @Location AND hf.Price BETWEEN @MinPrice AND @MaxPrice";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Location", location);
                    adapter.SelectCommand.Parameters.AddWithValue("@MinPrice", minPrice);
                    adapter.SelectCommand.Parameters.AddWithValue("@MaxPrice", maxPrice);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewProperties.DataSource = dataTable;
                }
            }
            catch {
            LoadAll();
            }
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
            int clientid =Convert.ToInt32( ClientIDcom.Text);
            int employeeid= Convert.ToInt32(EmployeeIDtxt.Text);
            int branchid= Convert.ToInt32(BranchIDw.Text);
            string statues = Statuestxt.Text;
            // Insert the new property into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HouseFeatures (EstateID,[Building Type], BedRooms, [Built in], Neighbourhood, Address, Price, Description, Pool, Elevator, ImageUrl) " +
                               "VALUES ((select ISNULL(max(EstateID),0)+1 FROM HouseFeatures),@BuildingType, @Bedrooms, @BuiltIn, @Neighbourhood, @Address, @Price, @Description, @Pool, @Elevator, @ImageUrl)";
                string query2 = "INSERT INTO House (EstateID,Status,ClientID,EmployeeID,BranchID) " +
                               "VALUES ((select ISNULL(max(EstateID),0) FROM HouseFeatures),@Status, @ClientID, @EmployeeID, @BranchID)";

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
                            // Add parameters
                            command.Parameters.AddWithValue("@Status", statues);
                            command.Parameters.AddWithValue("@ClientID", clientid);
                            command.Parameters.AddWithValue("@EmployeeID", employeeid);
                            command.Parameters.AddWithValue("@BranchID", branchid);
                            int rowsAffected2 = command.ExecuteNonQuery();

                        }
                            MessageBox.Show("Property added successfully.");
                        // Clear input fields or refresh DataGridView if needed
                        LoadAll();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add property.");
                    }
                }
            }
        }

        private void dataGridViewTransactions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count > 0)
            {
                selectedTransactionID = Convert.ToInt32(dataGridViewTransactions.SelectedRows[0].Cells["TransactionID"].Value);
                LoadTransactionDetails(selectedTransactionID);
            }
        }
        private void LoadTransactionDetails(int transactionID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT t.TransactionID, t.Status,t.Amount,t.ContractPath,t.PaymentDate, t.SellerName, t.Phone, c.ClientName, c.Phone AS ClientPhone " +
                               "FROM Transactions t " +
                               "INNER JOIN Clients c ON t.ClientID = c.ClientID " +
                               "WHERE t.TransactionID = @TransactionID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@TransactionID", transactionID);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    txtStatus.Text = row["Status"].ToString();
                    txtSellerName.Text = row["SellerName"].ToString();
                    txtPhone.Text = row["Phone"].ToString();
                    txtClientName.Text = row["ClientName"].ToString();
                    txtClientPhone.Text = row["ClientPhone"].ToString();
                    txtContractPath.Text = row["ContractPath"].ToString();
                    txtPaymentDate.Text = row["PaymentDate"].ToString();
                    txtAmount.Text = row["Amount"].ToString();
                }
            }
        }
        private string GetContractPath(int transactionID)
        {
            string contractPath = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ContractPath FROM Transactions WHERE TransactionID = @TransactionID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionID", transactionID);
                connection.Open();
                contractPath = command.ExecuteScalar()?.ToString();
                connection.Close();
            }
            return contractPath;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedTransactionID != -1)
            {
                string contractPath = GetContractPath(selectedTransactionID);
                if (!string.IsNullOrEmpty(contractPath))
                {
                    try
                    {
                        // Prompt user to choose a location to save the contract file
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = Path.GetFileName(contractPath);
                        saveFileDialog.Filter = "All files (*.*)|*.*";
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Copy the contract file to the selected location
                            File.Copy(contractPath, saveFileDialog.FileName, true);
                            MessageBox.Show("Contract downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error downloading contract: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No contract found for the selected transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No transaction selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                                    T.TransactionID,
                                    T.Amount AS Sales,
                                    T.Amount - H.Price AS Profit,
                                    H.Price AS Cost
                                FROM
                                    Transactions T
                                JOIN
                                    HouseFeatures H ON T.PropertyID = H.EstateID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewReport.DataSource = dataTable;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                                    C.ClientID,
                                    C.ClientName,
                                    C.Phone,
                                    C.[E-mail] AS Email,
                                    COUNT(T.TransactionID) AS PropertiesBought
                                FROM
                                    Clients C
                                LEFT JOIN
                                    Transactions T ON C.ClientID = T.ClientID
                                GROUP BY
                                    C.ClientID, C.ClientName, C.Phone, C.[E-mail]";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewReport.DataSource = dataTable;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                                    H.EstateID AS PropertyID,
                                    H.Price AS Price,
                                    H.[Address] AS Location,
                                    C.ClientName AS OwnerName,
                                    C.ClientID AS OwnerID,
                                    CASE WHEN T.TransactionID IS NULL THEN 'Not Sold' ELSE 'Sold' END AS SoldStatus,
                                    T.Amount AS SoldPrice,
                                    T.Amount - H.Price AS Profit
                                FROM
                                    HouseFeatures H
                                LEFT JOIN
                                    Transactions T ON H.EstateID = T.PropertyID
                                LEFT JOIN
                                    Clients C ON T.ClientID = C.ClientID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewReport.DataSource = dataTable;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 6)
            {
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtPosition.SelectedIndex = -1;
            txtPhone2.Clear();
            cboGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtCity.Clear();
            txtBranchID.SelectedIndex=-1;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                        string query2 = "UPDATE Houses SET EmployeeID=NULL WHERE EmployeeID = @EmployeeID";
                        SqlCommand comm= new SqlCommand(query2, connection);

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);
                        comm.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);
                        connection.Open(); comm.ExecuteNonQuery();
                        command.ExecuteNonQuery();
                       
                    }
                    LoadEmployees();
                    ClearFields();
                    selectedEmployeeID = -1;
                }
            }
            else
            {
                MessageBox.Show("No employee selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPosition.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Employees (EmployeeID,Name, Username, Pin, Position, Phone, Birthday, Gender, Email, City, BranchID) " +
                                   "VALUES ((select ISNULL(max(EmployeeID),0)+1 FROM Employees),@Name, @Username, @Pin, @Position, @Phone, @Birthday, @Gender, @Email, @City, @BranchID)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Username", textBox2.Text);
                    command.Parameters.AddWithValue("@Pin", textBox1.Text);
                    command.Parameters.AddWithValue("@Position", txtPosition.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@Birthday", DateTime.Parse(txtBirthday.Text));
                    command.Parameters.AddWithValue("@Gender", cboGender.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@City", txtCity.Text);
                    command.Parameters.AddWithValue("@BranchID", int.Parse(txtBranchID.Text));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                LoadEmployees();
                ClearFields();
                selectedEmployeeID = -1;
            }
            else
            {
                MessageBox.Show("Name and Position are required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                // Assuming "EmployeeID" is the name of the column
                selectedEmployeeID = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
            }
        }

        private void txtImageUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuildingType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPropertiesSold_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxProperty_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void chartSalesProfit_Click(object sender, EventArgs e)
        {

        }
    }
}
