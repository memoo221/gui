using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayCars
{
    public partial class Checkout : Form
    {
        // Constants for window manipulation
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Import necessary Windows API functions
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private string startDate;
        private string endDate;
        private int vechileID;
        private int customerID;
        private float price;
        private int pickUp;
        private int dropOff;
        private float totalPriceBefore;
        private float tax;
        public string connectionString = "Data Source=BASEMW\\SQL;Initial Catalog=Vehicle_renting;Integrated Security=True";

        // Close button
        private Button closeButton;

        public Checkout(string startDate, string endDate, int vechileID, float price, int pickUp, int dropOff)
        {
            InitializeComponent();

            // Set form properties without rounded corners
            this.FormBorderStyle = FormBorderStyle.None;

            // Add close button to form
            AddCloseButton();

            // Initialize data
            this.startDate = startDate;
            this.endDate = endDate;
            this.vechileID = vechileID;
            this.price = price;
            this.pickUp = pickUp;
            this.dropOff = dropOff;
            customerID = 1;

            // Set UI values
            priceValuelbl.Text = price.ToString();
            StartDateValue.Text = startDate;
            returnDateValue.Text = endDate;

            // Calculate price
            DateTime start1 = DateTime.Parse(startDate);
            DateTime end1 = DateTime.Parse(endDate);
            TimeSpan diff = end1 - start1;
            totalPriceBefore = diff.Days * price;
            tax = totalPriceBefore * 12 / 100;
            taxValuelbl.Text = tax.ToString() + " EGP";
            totalValueLbl.Text = (totalPriceBefore + tax).ToString() + " EGP";

            // Load location data
            LoadLocationData();

            // Handle form resize to update button position
            this.Resize += new EventHandler(Checkout_Resize);

            // Make the form draggable from anywhere
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
        }

        private void AddCloseButton()
        {
            // Create close (X) button in the top-right corner
            closeButton = new Button
            {
                Text = "✕",
                FlatStyle = FlatStyle.Flat,
                Size = new Size(30, 30),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(this.ClientSize.Width - 30, 0),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                UseVisualStyleBackColor = true,
                Cursor = Cursors.Hand
            };

            // Remove border from button
            closeButton.FlatAppearance.BorderSize = 0;

            // Add event handler
            closeButton.Click += new EventHandler(CloseButton_Click);

            // Add button to form
            this.Controls.Add(closeButton);

            // Make sure the button is at the top of the z-order
            closeButton.BringToFront();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Checkout_Resize(object sender, EventArgs e)
        {
            // Update close button position
            if (closeButton != null)
                closeButton.Location = new Point(this.ClientSize.Width - 30, 0);
        }

        private void LoadLocationData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from locations where location_Id in (@pickup,@dropoff)", conn);
                cmd.Parameters.Add(new SqlParameter("@pickup", pickUp));
                cmd.Parameters.Add(new SqlParameter("@dropoff", dropOff));
                SqlDataReader rdr = cmd.ExecuteReader();
                int count = 0;
                while (rdr.Read())
                {
                    if (count == 0)
                        pickUpValue.Text = (string)rdr["Location_name"];
                    if (count == 1)
                        dropOffValue.Text = (string)rdr["Location_name"];
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Creditbtn_CheckedChanged(object sender, EventArgs e)
        {
            CardDetailspanel.Visible = true;
        }

        private void CasHbtn_CheckedChanged(object sender, EventArgs e)
        {
            CardDetailspanel.Visible = false;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // Initial form load
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            invalidLabel.Visible = false;
            if (!CasHbtn.Checked && !Creditbtn.Checked)
            {
                invalidLabel.Text = "Please select a payment method";
                invalidLabel.Visible = true;
                return;
            }
            if (Creditbtn.Checked && (cardNumTxtBox.Text.Length == 0 || ExpDateTxtbox.Text.Length == 0 || CCVtxtbox.Text.Length == 0))
            {
                invalidLabel.Text = "Please fill out all the card details";
                invalidLabel.Visible = true;
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
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
                cmd.Parameters.Add(new SqlParameter("@price", tax + totalPriceBefore));
                cmd.Parameters.Add(new SqlParameter("@tax", tax));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking completed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        // Override WndProc to make the form draggable from anywhere
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    Point pos = new Point(m.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.Y < 40) // If the cursor is within title bar height
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        // You can add these methods back if they're connected to your controls
        // Empty event handlers can be removed
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void lblDays_Click(object sender, EventArgs e) { }
        private void Checkout_Load_1(object sender, EventArgs e) { }
        private void CardDetailspanel_Paint(object sender, PaintEventArgs e) { }
        private void Creditbtn_CheckedChanged_1(object sender, EventArgs e)
        {
            CardDetailspanel.Visible = true;
        }
        private void dropOffValue_Click(object sender, EventArgs e) { }

        private void CasHbtn_CheckedChanged_1(object sender, EventArgs e)
        {
            CardDetailspanel.Visible = false;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}