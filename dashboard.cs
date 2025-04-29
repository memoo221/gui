using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
// Make them public static so other forms can access them

namespace car_rental
{
    public partial class dashboard : Form
    {
        private string connectionString = "Server=localhost;Database=carrental;Trusted_Connection=True;";
        public static string pickupLocation;
        public static string returnLocation;
        public static DateTime pickupDate;
        public static DateTime returnDate;
        public static string selectedCategory;
        public dashboard()
        {
            InitializeComponent();

      
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void menu_MouseEnter(object sender, EventArgs e)
        {
            menu.Font = new Font(menu.Font, FontStyle.Underline);
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Font = new Font(menu.Font, FontStyle.Regular);
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void login_MouseEnter(object sender, EventArgs e)
        {
            login.Font = new Font(login.Font, FontStyle.Underline); // Underline when hovered
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.Font = new Font(login.Font, FontStyle.Regular); // Remove underline when not hovered
        }
        private void register_MouseEnter(object sender, EventArgs e)
        {
            register.Font = new Font(register.Font, FontStyle.Underline); // Underline when hovered
        }

        private void register_MouseLeave(object sender, EventArgs e)
        {
            register.Font = new Font(register.Font, FontStyle.Regular); // Remove underline when not hovered
        }
        private bool isMaximized = false;

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Restore the window to its previous size and position
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
                //maximizeButton.Text = "Max";  // Change text to "Max"
            }
            else
            {
                // Maximize the window
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
                // maximizeButton.Text = "Restore";  // Change text to "Restore"
            }
        }

        private void register_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }


        private void dashboard_Resize(object sender, EventArgs e)
        {
            // Resize top panel
            this.paneltop.Width = this.ClientSize.Width;
            this.paneltop.Height = this.ClientSize.Height / 2;

            // Center the slogan label
            this.label1.Left = (this.paneltop.Width - this.label1.Width) / 2;
            this.label1.Top = this.paneltop.Height - this.label1.Height - 20;

            // Adjust nav buttons
            int spacing = 20;
            this.menu.Left = 180;
            this.login.Left = this.menu.Right + spacing;
            this.register.Left = this.login.Right + spacing;
            this.maximizeButton.Left = this.ClientSize.Width - this.maximizeButton.Width - 20;

            // Resize category panel
            this.panelcategories.Width = this.ClientSize.Width;
            this.panelcategories.Height = this.ClientSize.Height / 2;

            // Resize table layout
            this.tableLayoutPanel1.Width = this.panelcategories.Width;
            this.tableLayoutPanel1.Height = this.panelcategories.Height - 60;

            // Resize each panel inside tableLayoutPanel
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                ctrl.Width = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount - 10;
                ctrl.Height = tableLayoutPanel1.Height / tableLayoutPanel1.RowCount - 10;
            }
        }

            private void paneltop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        // Event handler for searchButton click
        //private void searchButton_Click(object sender, EventArgs e)
        //{
        //    // Example of handling search logic
        //    string searchText = searchTextBox.Text;
        //    MessageBox.Show("Searching for: " + searchText);
        //}
        //private void newReturnLocationButton_Click(object sender, EventArgs e)
        //{
        //    // Show the return location text box next to the search bar
        //    this.returnLocationTextBox.Visible = true;
        //    this.returnLocationTextBox.Location = new Point(this.searchTextBox.Left + 10, this.searchTextBox.Top);
        //}

        private void returnLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckDatabaseConnection()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Try to open connection

                    if (conn.State == ConnectionState.Open)
                    {
                        MessageBox.Show("✅ Database Connection Successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Connection Failed!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pickupLocation = cityComboBox.Text;
            returnLocation = cityreturn.Text;
            pickupDate = pickupCalendar.SelectionStart;  // Assuming you have a calendar control
            returnDate = returnCalendar.SelectionStart;  // Assuming you have a calendar control
            selectedCategory = "sedan";  // This is the category for button 1
            MessageBox.Show($"Pickup Location: {pickupLocation}\n" +
                    $"Return Location: {returnLocation}\n" +
                    $"Pickup Date: {pickupDate.ToShortDateString()}\n" +
                    $"Return Date: {returnDate.ToShortDateString()}\n" +
                    $"Category: {selectedCategory}",
                    "Review Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Pass these values to the ResultsForm
            //ResultsForm resultsForm = new ResultsForm(pickupLocation, returnLocation, pickupDate, returnDate, selectedCategory);
            // resultsForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pickupLocation = cityComboBox.Text;
            returnLocation = cityreturn.Text;
            pickupDate = pickupCalendar.SelectionStart;
            returnDate = returnCalendar.SelectionStart;
            selectedCategory = "suv";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pickupLocation = cityComboBox.Text;
            returnLocation = cityreturn.Text;
            pickupDate = pickupCalendar.SelectionStart;
            returnDate = returnCalendar.SelectionStart;
            selectedCategory = "luxury";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pickupLocation = cityComboBox.Text;
            returnLocation = cityreturn.Text;
            pickupDate = pickupCalendar.SelectionStart;
            returnDate = returnCalendar.SelectionStart;
            selectedCategory = "motorcycle";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pickupLocation = cityComboBox.Text;
            returnLocation = cityreturn.Text;
            pickupDate = pickupCalendar.SelectionStart;
            returnDate = returnCalendar.SelectionStart;
            selectedCategory = "electric";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pickupLocation = cityComboBox.Text;
            returnLocation = cityreturn.Text;
            pickupDate = pickupCalendar.SelectionStart;
            returnDate = returnCalendar.SelectionStart;
            selectedCategory = "family";

        }

        private void returnLocationTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
        // This method is called when the form is loaded
        private void dashboard_Load(object sender, EventArgs e)
        {
            // Call the method to populate the ComboBox with cities from the database
            LoadCitiesIntoComboBox();
        }

        // Method to load cities into the ComboBox from the database
        private void LoadCitiesIntoComboBox()
        {
            // Create a new SqlConnection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Query to select city names from the database
                    string query = "SELECT City FROM Locations";  // Replace 'Cities' with your actual table name

                    // Create a SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Execute the query and get the results
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear any existing items in the ComboBox
                    cityComboBox.Items.Clear();

                    // Loop through the result set and add each city to the ComboBox
                    while (reader.Read())
                    {
                        cityComboBox.Items.Add(reader["City"].ToString());
                        cityreturn.Items.Add(reader["City"].ToString());
                    }

                    // Close the reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    MessageBox.Show("Error loading cities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }

}

