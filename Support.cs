using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private int customerID = 1;
        private int employeeID = 2;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IdBox.Text, out int bookingId))
            {
                MessageBox.Show("Please enter a valid booking ID number.");
                return;
            }

            string constring = @"Data Source=DESKTOP-FGS6HH7;Initial Catalog=Vehicle_Renting_System2;Integrated Security=SSPI";


            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string query1 = @"SELECT dbo.checkDate(@bookingId);";

            string query2 = @"DELETE FROM Booking WHERE Booking_ID = " + bookingId + ";";

            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@bookingId", bookingId);
            Boolean flag = (Boolean)cmd1.ExecuteScalar(); // This will now correctly return 1 or 0

            if (flag) {
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted last booking.");

            }
            else
            {
                MessageBox.Show("Cannot delete: Booking start date has passed or booking does not exist.");
            }




            con.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-FGS6HH7;Initial Catalog=Vehicle_Renting_System2;Integrated Security=SSPI";


            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string insertStr = @"INSERT INTO Customer_Service 
                         (Date_Of_Report, Issue, Issue_Status, Customer_ID, Employee_ID) 
                         VALUES (@DateOfReport, @Issue, @IssueStatus, @CustomerID, @EmployeeID)";

            SqlCommand cmd = new SqlCommand(insertStr, con);

            cmd.Parameters.AddWithValue("@DateOfReport", DateTime.Now);
            cmd.Parameters.AddWithValue("@Issue", inquiryTxt.Text);
            cmd.Parameters.AddWithValue("@IssueStatus", "Pending");
            cmd.Parameters.AddWithValue("@CustomerID", customerID);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Inquiry submitted successfully!");

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
