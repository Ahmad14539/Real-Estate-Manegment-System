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

namespace realmanagmentsystem
{
    public partial class EmployeeDashboardForm : Form
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Remax;Integrated Security=True;Encrypt=False";
        private int selectedTransactionID = -1;
        private int selectedEmployeeID = -1;
        public EmployeeDashboardForm()
        {
            InitializeComponent();
        }

        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {
            ShowPropertyStatistics();
            ShowSalesAndProfitGraph();
            LoadProperties();
            LoadTransactions();
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
            chartSalesProfit.Series.Add("Sales");
            chartSalesProfit.Series.Add("Profit");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT hf.[EstateID], hf.[Price], h.[Status] " +
                               "FROM [dbo].[HouseFeatures] hf " +
                               "INNER JOIN [dbo].[Houses] h ON hf.[EstateID] = h.[EstateID]";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal price = (decimal)reader["Price"];
                            string status = reader["Status"].ToString();

                            if (status == "Sold")
                            {
                                // Calculate profit based on your formula
                                decimal profit = price - (price * 0.1M); // Example formula: 10% profit

                                // Add data points to the chart
                                chartSalesProfit.Series["Sales"].Points.AddY(price);
                                chartSalesProfit.Series["Profit"].Points.AddY(profit);
                            }
                        }
                    }
                }
            }

            // Set chart properties
            chartSalesProfit.ChartAreas[0].AxisX.Title = "Property";
            chartSalesProfit.ChartAreas[0].AxisY.Title = "Amount ($)";
            chartSalesProfit.ChartAreas[0].AxisX.Interval = 1;
            chartSalesProfit.Series["Sales"].LegendText = "Sales";
            chartSalesProfit.Series["Profit"].LegendText = "Profit";
            chartSalesProfit.Series["Sales"].ChartType = SeriesChartType.Column;
            chartSalesProfit.Series["Profit"].ChartType = SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPropertyStatistics();
            ShowSalesAndProfitGraph();
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

            // Insert the new property into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HouseFeatures (EstateID,[Building Type], BedRooms, [Built in], Neighbourhood, Address, Price, Description, Pool, Elevator, ImageUrl) " +
                               "VALUES ((select ISNULL(max(EstateID),0)+1 FROM HouseFeatures),@BuildingType, @Bedrooms, @BuiltIn, @Neighbourhood, @Address, @Price, @Description, @Pool, @Elevator, @ImageUrl)";

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
                        MessageBox.Show("Property added successfully.");
                        // Clear input fields or refresh DataGridView if needed
                    }
                    else
                    {
                        MessageBox.Show("Failed to add property.");
                    }
                }
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

        private void tabPage5_Click(object sender, EventArgs e)
        {

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

        private void dataGridViewTransactions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count > 0)
            {
                selectedTransactionID = Convert.ToInt32(dataGridViewTransactions.SelectedRows[0].Cells["TransactionID"].Value);
                LoadTransactionDetails(selectedTransactionID);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 5)
            {
                this.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chartSalesProfit_Click(object sender, EventArgs e)
        {

        }
    }
}
