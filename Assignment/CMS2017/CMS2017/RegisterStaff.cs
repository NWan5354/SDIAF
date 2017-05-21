using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CMS2017
{
    public partial class RegisterStaff : Form
    {
        public RegisterStaff()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" || txtLastName.Text != "" || txtUserName.Text != "" || txtEmailAddress.Text != "" || txtPassword.Text != "")
            {
                string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

                SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                SqlCommand comm = new SqlCommand("INSERT INTO registeredUsers VALUES(@firstName, @lastName, @userName, @emailAddress, @passWord)", conn); // Sql Command

                comm.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                comm.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comm.Parameters.AddWithValue("@userName", txtUserName.Text);
                comm.Parameters.AddWithValue("@emailAddress", txtEmailAddress.Text);
                comm.Parameters.AddWithValue("@passWord", txtPassword.Text);

                comm.Connection = conn;
                comm.Connection.Open(); // Opens the SQL Database connection. 

                comm.ExecuteNonQuery(); // Run the query
                comm.Connection.Close(); // Closes the SQL Database connection.

                MessageBox.Show("User: " + txtUserName.Text + " has been successfully registered", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Register Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
