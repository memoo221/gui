using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vechile_Renting_System
{
    public partial class Checkout : Form
    {
        private string startDate;
        private string endDate;
        private int vechileID;
        private int customerID;
        private float price;
        private int pickUp;
        private int dropOff;
        private float totalPriceBefore;
        private float tax;

        public Checkout(string startDate, string endDate, int vechileID, float price, int pickUp, int dropOff)
        {
            InitializeComponent();
            this.startDate = startDate;
            this.endDate = endDate;
            this.vechileID = vechileID;
            this.price = price;
            this.pickUp = pickUp;
            this.dropOff = dropOff;
            customerID = 1;
            priceValuelbl.Text = price.ToString();
            StartDateValue.Text = startDate;
            returnDateValue.Text = endDate;
            DateTime start1 = DateTime.Parse(startDate);
            DateTime end1 = DateTime.Parse(endDate);
            TimeSpan diff = end1 - start1;
            totalPriceBefore = diff.Days * price;
            tax = totalPriceBefore * 12 / 100;
            taxValuelbl.Text = tax.ToString() + " EGP";
            totalValueLbl.Text = (totalPriceBefore + tax).ToString() + " EGP";
            SqlConnection conn = new SqlConnection("Data Source=192.168.100.23;Initial Catalog=\"Vechile Renting System\";Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;Encrypt=True;Trust Server Certificate=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from locations where location_Id in (@pickup,@dropoff)",conn);
                cmd.Parameters.Add(new SqlParameter("@pickup", pickUp));
                cmd.Parameters.Add(new SqlParameter("@dropoff", dropOff));
                SqlDataReader rdr = cmd.ExecuteReader();
                int count = 0;
                while (rdr.Read())
                {
                    if(count == 0)
                    pickUpValue.Text = (string)rdr["Location_name"];
                    if (count == 1)
                    dropOffValue.Text = (string)rdr["Location_name"];
                    count++;
                }

               

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Creditbtn_CheckedChanged(object sender, EventArgs e)
        {
            CardDetailspanel.Visible = true;

        }

        private void CasHbtn_CheckedChanged(object sender, EventArgs e)
        {
            CardDetailspanel.Visible = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            invalidLabel.Visible = false;
            if(!CasHbtn.Checked && !Creditbtn.Checked)
            {
                invalidLabel.Text = "Please select a payment method";
                invalidLabel.Visible = true;
                return;
            }
            if(Creditbtn.Checked && (cardNumTxtBox.Text.Length == 0 || ExpDateTxtbox.Text.Length == 0 || CCVtxtbox.Text.Length == 0))
            {
                invalidLabel.Text = "Please fill out all the card details";
                invalidLabel.Visible = true;
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=192.168.100.23;Initial Catalog=\"Vechile Renting System\";Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;Encrypt=True;Trust Server Certificate=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("bookAndBill1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@customerID", customerID));
                cmd.Parameters.Add(new SqlParameter("@vechileID", vechileID));
                cmd.Parameters.Add(new SqlParameter("@Pickup", pickUp));
                cmd.Parameters.Add(new SqlParameter("@dropOff", dropOff));
                DateTime start = DateTime.Parse(startDate);
                DateTime returnD = DateTime.Parse(endDate);
                cmd.Parameters.Add(new SqlParameter("@startDate", start.Date));
                cmd.Parameters.Add(new SqlParameter("@endDate", returnD.Date));
                cmd.Parameters.Add(new SqlParameter("@price", tax+totalPriceBefore));
                cmd.Parameters.Add(new SqlParameter("@tax", tax));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking completed succesfully");


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
