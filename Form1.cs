using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Vechile_Renting_System
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwordTxtBox.PasswordChar = '\0';
                ConfirmPassTxtBox.PasswordChar = '\0';

            }
            else
            {
                passwordTxtBox.PasswordChar = '*';
                ConfirmPassTxtBox.PasswordChar = '*';

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsernametxtBox.Clear();
            passwordTxtBox.Clear();
            ConfirmPassTxtBox.Clear();
            SSNTxtbox.Clear();
            addresstxtBox.Clear();

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernametxtBox.Text) ||
            string.IsNullOrWhiteSpace(passwordTxtBox.Text) ||
            string.IsNullOrWhiteSpace(ConfirmPassTxtBox.Text) ||
            string.IsNullOrWhiteSpace(SSNTxtbox.Text) ||
            string.IsNullOrWhiteSpace(addresstxtBox.Text))
            {
                invalidLabel.Visible = true;
                return;
            }
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!emailRegex.IsMatch(UsernametxtBox.Text)){
                invalidLabel.Text = "Email is invalid";
                invalidLabel.Visible = true;
                return;
            }
            //Add some checks on data constraints
            //Password and confrim must be the same;
            if (passwordTxtBox.Text != ConfirmPassTxtBox.Text)
            {
                invalidLabel.Text = "Passwords do not match";
                invalidLabel.Visible = true;
                return;
            }
            //SSN must be some amount of digits
            if (SSNTxtbox.Text.Length != 9)
            {
                invalidLabel.Text = "SSN must be 9 digits";
                invalidLabel.Visible = true;
                return;
            }

            //email has to be unique -> new procedure
            SqlConnection conn = new SqlConnection("Data Source=192.168.100.23;Initial Catalog=\"Vechile Renting System\";Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;Encrypt=True;Trust Server Certificate=True");
           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("validateEmail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", UsernametxtBox.Text));
                SqlParameter myParam =cmd.Parameters.Add( new SqlParameter("@found", System.Data.SqlDbType.Int));
                myParam.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                if((int)myParam.Value != 0)
                {
                    invalidLabel.Text = "Email is already used try logging in";
                    invalidLabel.Visible = true;
                    return;
                }
                String command = "Insert into Customer (Email,customer_password,customer_address,SSN) Values(@email,@password,@address,@SSN)";
                cmd = new SqlCommand(command,conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@email", UsernametxtBox.Text));
                cmd.Parameters.Add(new SqlParameter("@password", passwordTxtBox.Text));
                cmd.Parameters.Add(new SqlParameter("@address", addresstxtBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SSN", SSNTxtbox.Text));
                cmd.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
