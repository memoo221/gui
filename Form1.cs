using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace DisplayCars
{
    public partial  class DisplayCar : Form
    {
        private string Category;
        private DateTime start;
        private DateTime end;
        private int pickup;
        private int dropoff;
        public string connectionString = "Data Source=BASEMW\\SQL;Initial Catalog=Vehicle_renting;Integrated Security=True;MultipleActiveResultSets=True";
        public DisplayCar(String Category, DateTime Start, DateTime End, int pickup, int dropoff)
        {
            this.start = Start;
            this.end = End;
            this.Category = Category;
            InitializeComponent();
            this.pickup = pickup;
            this.dropoff = dropoff;
        }
        public DisplayCar()
        {
            InitializeComponent();

        }
        private void DisplayCar_load(object sender, EventArgs e)
        {
            PopulateFilterDropdowns();
            LoadVehiclesFromDatabase();

            // Add event handlers for the filter controls
            cmbCategories.SelectedIndexChanged += (s, args) => LoadVehiclesFromDatabase();
            cmbSort.SelectedIndexChanged += (s, args) => LoadVehiclesFromDatabase();
        }
        private void PopulateFilterDropdowns()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get categories from Vehicle_Category table
                    string query = "SELECT Category_name FROM Vehicle_Category ORDER BY Category_name";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Add default option
                    cmbCategories.Items.Add("Select a category:");

                    // Add categories from database
                    while (reader.Read())
                    {
                        string categoryName = reader["Category_name"].ToString();
                        if (!string.IsNullOrEmpty(categoryName))
                        {
                            cmbCategories.Items.Add(categoryName);
                        }
                    }

                    reader.Close();
                }
            }
            catch
            {
                cmbCategories.Items.Add("Select a category:");
                cmbCategories.Items.Add("Compact");
                cmbCategories.Items.Add("SUV");
                cmbCategories.Items.Add("Sedan");
            }

            cmbCategories.SelectedItem = Category;

            // Sort options
            cmbSort.Items.Add("Price Low to High");
            cmbSort.Items.Add("Price High to Low");
            cmbSort.Items.Add("Name A-Z");
            cmbSort.Items.Add("Name Z-A");
            cmbSort.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void LoadVehiclesFromDatabase()
        {
            // Clear existing listings
            flowLayoutCars.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create SQL command with JOIN to get vehicle data including category information
                    string query = @"SELECT v.Vehicle_ID, 
                                  v.Brand + ' ' + v.Model AS name, 
                                  vc.Category_name AS category,
                                  v.price_per_day, 
                                  vc.number_of_people AS passengers, 
                                  vc.Luggage AS luggage,
                                  v.Vehicle_type AS transmission_type, 
                                  v.carImage
                           FROM Vehicle v
                           INNER JOIN Vehicle_Category vc ON v.cat_id = vc.Category_ID";

                    // Add where clauses based on selected filters
                    if (cmbCategories.SelectedIndex > 0)
                    {
                        query += " WHERE vc.Category_name = @categoryName";
                    }

                    // Add order by clause based on selected sort option
                    if (cmbSort.SelectedIndex >= 0)
                    {
                        switch (cmbSort.SelectedItem.ToString())
                        {
                            case "Price Low to High":
                                query += " ORDER BY v.price_per_day ASC";
                                break;
                            case "Price High to Low":
                                query += " ORDER BY v.price_per_day DESC";
                                break;
                            case "Name A-Z":
                                query += " ORDER BY name ASC";
                                break;
                            case "Name Z-A":
                                query += " ORDER BY name DESC";
                                break;
                        }
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameter if filtering by category
                    if (cmbCategories.SelectedIndex > 0)
                    {
                        command.Parameters.AddWithValue("@categoryName", cmbCategories.SelectedItem.ToString());
                    }

                    
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int vehicleId = Convert.ToInt32(reader["Vehicle_ID"]);

                        SqlCommand cmd = new SqlCommand("carAvailable2", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@startDate", start));
                        cmd.Parameters.Add(new SqlParameter("@endDate", end));
                        cmd.Parameters.Add(new SqlParameter("@vehicleID", vehicleId));
                        SqlParameter available =  cmd.Parameters.Add(new SqlParameter("@available", SqlDbType.Int));
                        available.Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        // Create a new car listing control for each vehicle
                        string name = reader["name"].ToString();
                        string category = reader["category"].ToString();
                        decimal pricePerDay = Convert.ToDecimal(reader["price_per_day"]);
                        string price = pricePerDay.ToString("F2") + " EGP";
                        int passengers = Convert.ToInt32(reader["passengers"]);
                        int luggage = Convert.ToInt32(reader["luggage"]);
                        string transmission = reader["transmission_type"].ToString();

                        // Get image data from database
                        Image carImage = null;

                        if ((int)available.Value == 1) continue;
                        // First try to load from URL if present (carImageUrl field)
                        if (reader["carImage"] != DBNull.Value && !string.IsNullOrEmpty(reader["carImage"].ToString()))
                        {
                            try
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] imageBytes = webClient.DownloadData(reader["carImage"].ToString());
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        carImage = Image.FromStream(ms);
                                    }
                                }
                            }
                            catch
                            {
                                // If URL loading fails, try binary data instead
                                carImage = null;
                            }
                        }

                    
                        // If both methods failed, create a placeholder
                        if (carImage == null)
                        {
                            carImage = CreatePlaceholderImage(name);
                        }

                        // Add the car listing
                       
                        CarListingControl carListing = new CarListingControl();
                        carListing.LoadCarDetails( carImage, name, category, price, passengers, luggage, transmission);
                        carListing.BookButtonClicked += (s, e) => {
                            this.Hide();
                            Checkout bigMo = new Checkout(start.Date.ToString(), end.Date.ToString(), vehicleId, (float)pricePerDay, pickup, dropoff);
                            bigMo.Show();
                            bigMo.FormClosed += (sender, args) => {
                               LoadVehiclesFromDatabase();
                               this.Show(); };
                        };
                        carListing.Margin = new Padding(0, 0, 0, 20);
                        flowLayoutCars.Controls.Add(carListing);
                    }

                    reader.Close();

                    // Display message if no vehicles found
                    if (flowLayoutCars.Controls.Count == 0)
                    {
                        Label noResultsLabel = new Label();
                        noResultsLabel.Text = "No vehicles found matching the selected criteria.";
                        noResultsLabel.AutoSize = true;
                        noResultsLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                        noResultsLabel.ForeColor = Color.DarkGray;
                        noResultsLabel.Padding = new Padding(20);
                        flowLayoutCars.Controls.Add(noResultsLabel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Label errorLabel = new Label();
                    errorLabel.Text = "Unable to load vehicle data. Please check your database connection.";
                    errorLabel.AutoSize = true;
                    errorLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Padding = new Padding(20);
                    flowLayoutCars.Controls.Add(errorLabel);
                }
            }
        }

        private Image CreatePlaceholderImage(string vehicleName)
        {
            // Create a simple placeholder image
            Bitmap placeholder = new Bitmap(250, 180);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.LightGray);

                // Draw vehicle name
                using (Font nameFont = new Font("Arial", 12, FontStyle.Bold))
                {
                    StringFormat format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    Rectangle textRect = new Rectangle(0, placeholder.Height / 2 - 30, placeholder.Width, 30);
                    g.DrawString(vehicleName, nameFont, Brushes.Black, textRect, format);
                }

                // Draw "No Image" text
                using (Font noImageFont = new Font("Arial", 10))
                {
                    StringFormat format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    Rectangle textRect = new Rectangle(0, placeholder.Height / 2 + 10, placeholder.Width, 20);
                    g.DrawString("No Image Available", noImageFont, Brushes.DarkGray, textRect, format);
                }

                // Draw border
                using (Pen borderPen = new Pen(Color.DarkGray, 1))
                {
                    g.DrawRectangle(borderPen, 0, 0, placeholder.Width - 1, placeholder.Height - 1);
                }
            }
            return placeholder;
        }

        private void DisplayBookingInfo(int vehicleId, string vehicleName)
        {
            // This method only displays information - it doesn't perform any database write operations
            MessageBox.Show($"Selected vehicle: {vehicleName} (ID: {vehicleId})\n\n" +
                           "To complete booking, please contact our customer service.",
                           "Vehicle Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
