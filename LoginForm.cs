using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Vechile_Renting_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            EmailTxtBox.Clear();
            passwordTxtBox.Clear();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (EmailTxtBox.Text.Length == 0 || passwordTxtBox.Text.Length == 0)
            {
                invalidLabel.Text = "Email or password cannot be empty";
                invalidLabel.Visible = true;
                return;
            }
            invalidLabel.Visible = false;
            invalidLabel.Text = "Email or password are incorrect";
            invalidLabel.ForeColor = Color.Red;
            SqlConnection con = new SqlConnection("Data Source=192.168.100.23;Initial Catalog=\"Vechile Renting System\";Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;Trust Server Certificate=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("validateLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", EmailTxtBox.Text));
                cmd.Parameters.Add(new SqlParameter("@password", passwordTxtBox.Text));
                SqlParameter myParam = cmd.Parameters.Add("@found", SqlDbType.Int);
                myParam.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int ValidBit = (int)cmd.Parameters["@found"].Value;
                if (ValidBit == 0)
                {
                    invalidLabel.Visible = true;
                    return;
                }
                else if (ValidBit == 1)
                {
                    invalidLabel.Visible = true;
                    invalidLabel.Text = "YAAY IT WORKED!";
                    invalidLabel.ForeColor = Color.Green;

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("WOAAH " + exception.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void showPassTxtBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassTxtBox.Checked)
                passwordTxtBox.PasswordChar = '\0';
            else
            {
                passwordTxtBox.PasswordChar = '*';

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Close();
        }
    }
}
