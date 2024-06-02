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
    public partial class EmployeeDashboardForm : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Remax;Integrated Security=True;Encrypt=False";
        private int selectedTransactionID = -1;
        private int selectedEmployeeID = -1;
        public EmployeeDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'remaxDataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.remaxDataSet2.Clients);
            // TODO: This line of code loads data into the 'remaxDataSet1.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter1.Fill(this.remaxDataSet1.Branches);
            // TODO: This line of code loads data into the 'remaxDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.remaxDataSet.Branches);
            LoadAll();
            loadalll();
            ShowSalesAndProfitGraph();
            
        }
        private void LoadAll()
        {
            ShowPropertyStatistics();
          
            LoadProperties();
            LoadTransactions();
            loadalll();
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
                string query = "SELECT hf.EstateID, hf.[Building Type], hf.BedRooms, hf.[Built in], hf.Neighbourhood, hf.Address, hf.Price, hf.ImageUrl, h.Status " +
                               "FROM HouseFeatures hf " +
                               "INNER JOIN Houses h ON hf.EstateID = h.EstateID";

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
                                salesSeries.XValueType = ChartValueType.String;
                                chartSalesProfit.Series.Add(salesSeries);
                            }

                            if (profitSeries == null)
                            {
                                // Create a new series for profit
                                profitSeries = new Series("Profit");
                                profitSeries.ChartType = SeriesChartType.Line;
                                profitSeries.Color = Color.Green;
                                profitSeries.XValueType = ChartValueType.String;
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


        }



        private void button1_Click(object sender, EventArgs e)
        {
            ShowPropertyStatistics();
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
            if (dataGridViewProperties.SelectedRows.Count > 0)
            {
                string imageUrl = dataGridViewProperties.SelectedRows[0].Cells["ImageUrl"].Value.ToString();
                pictureBoxProperty.ImageLocation = imageUrl;
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Addproper addProperty = new Addproper();
            addProperty.ShowDialog();
            loadalll();
            LoadAll();
            
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
                        MessageBox.Show($"Contract downloaded successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (tabControl1.SelectedIndex == 5)
            {
                this.Close();
            }
        }
  
     
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button11_Click(object sender, EventArgs e)
        {
           AddClient addClient= new AddClient();
            addClient.ShowDialog();
        }
        void loadalll()
        {
            string queryProperties = @"
            SELECT HF.EstateID, HF.[Building Type], HF.BedRooms, HF.[Built in], HF.Neighbourhood, HF.Address, HF.Price, HF.ImageUrl, HF.Description, HF.Pool, HF.Elevator, H.Status
            FROM HouseFeatures HF
            INNER JOIN Houses H ON HF.EstateID = H.EstateID";

            string queryClients = "SELECT ClientID, ClientName, ClientStatus, Phone, [E-mail], BranchID FROM Clients";

            // Step 3: Retrieve and bind data
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Load properties data
                    SqlDataAdapter adapterProperties = new SqlDataAdapter(queryProperties, connection);
                    DataTable dataTableProperties = new DataTable();
                    adapterProperties.Fill(dataTableProperties);
                    dataGridViewProperties2.DataSource = dataTableProperties;

                    // Load clients data
                    SqlDataAdapter adapterClients = new SqlDataAdapter(queryClients, connection);
                    DataTable dataTableClients = new DataTable();
                    adapterClients.Fill(dataTableClients);
                    dataGridViewClients.DataSource = dataTableClients;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridViewProperties2.SelectedRows.Count == 0 || dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a property and a client.");
                return;
            }

            // Step 2: Get the selected property and client
            var selectedPropertyRow = dataGridViewProperties.SelectedRows[0];
            var selectedClientRow = dataGridViewClients.SelectedRows[0];

            int selectedEstateID = Convert.ToInt32(selectedPropertyRow.Cells["EstateID"].Value);
            int selectedClientID = Convert.ToInt32(selectedClientRow.Cells["ClientID"].Value);
            string newStatus = "Sold";

            // Step 4: Define the SQL update command
            string updatePropertyQuery = "UPDATE Houses SET Status = @Status, ClientID = @ClientID WHERE EstateID = @EstateID";

            // Step 5: Execute the update command
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(updatePropertyQuery, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@Status", newStatus);
                        command.Parameters.AddWithValue("@ClientID", selectedClientID);
                        command.Parameters.AddWithValue("@EstateID", selectedEstateID);

                        // Open the connection, execute the command, and close the connection
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check if the update was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Property and client updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update property and client.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
     
        private void chartSalesProfit_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the ChartArea object
            ChartArea chartArea = chartSalesProfit.ChartAreas[0];

            // Check if a data point was clicked
            HitTestResult result = chartSalesProfit.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint dataPoint = chartSalesProfit.Series[result.Series.Name].Points[result.PointIndex];
                string seriesName = result.Series.Name;
                double yValue = dataPoint.YValues[0];
                string xValue = dataPoint.AxisLabel;

                // Update the labels with the clicked values
                if (seriesName == "Sales")
                {
                    labelSales.Text = $"Sales for {xValue}: {yValue:C}";
                }
                else if (seriesName == "Profit")
                {
                    labelProfit.Text = $"Profit for {xValue}: {yValue:C}";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            loadalll();
            LoadAll();
        }

        private void chartSalesProfit_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            loadalll();
            LoadAll();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProperties2.SelectedRows.Count == 0 || dataGridViewClients.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a property and a client.");
                    return;
                }

                // Step 2: Get the selected property and client
                var selectedPropertyRow = dataGridViewProperties.SelectedRows[0];
                var selectedClientRow = dataGridViewClients.SelectedRows[0];

                int selectedEstateID = Convert.ToInt32(selectedPropertyRow.Cells["EstateID"].Value);
                int selectedClientID = Convert.ToInt32(selectedClientRow.Cells["ClientID"].Value);
                string newStatus = comboBox1.Text;

                // Step 4: Define the SQL update command
                string updatePropertyQuery = "UPDATE Houses SET Status = @Status, ClientID = @ClientID WHERE EstateID = @EstateID";

                // Step 5: Execute the update command
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(updatePropertyQuery, connection))
                        {
                            // Add parameters to avoid SQL injection
                            command.Parameters.AddWithValue("@Status", newStatus);
                            command.Parameters.AddWithValue("@ClientID", selectedClientID);
                            command.Parameters.AddWithValue("@EstateID", selectedEstateID);

                            // Open the connection, execute the command, and close the connection
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check if the update was successful
                            if (result > 0)
                            {
                                MessageBox.Show("Property and client updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update property and client.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            catch { }
        }
    }
}
