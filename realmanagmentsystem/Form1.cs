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
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Remax;Integrated Security=True;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (AuthenticateUser(username, password))
            {
               
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;
            string position = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Position FROM Employees WHERE Username = @Username AND Pin = @Pin";
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Pin", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            position = reader["Position"].ToString();
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(position))
            {
                // Check the position and set isAuthenticated accordingly
                if (position == "Admin")
                {
                    isAuthenticated = true;
                    // Redirect to admin dashboard
                    AdminDashboardForm adminDashboard = new AdminDashboardForm();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    isAuthenticated = true;
                    // Redirect to employee dashboard
                    EmployeeDashboardForm employeeDashboard = new EmployeeDashboardForm();
                    employeeDashboard.Show();
                    this.Hide();
                }
            }

            return isAuthenticated;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
