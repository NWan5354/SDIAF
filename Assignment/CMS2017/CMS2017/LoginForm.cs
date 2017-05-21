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
    public partial class LoginForm : Form
    {
        public static string userLoggedIn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    userLoggedIn = txtUsername.Text;

                    string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

                    SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                    SqlCommand comm = new SqlCommand("SELECT userName, passWord FROM registeredUsers WHERE userName LIKE @user AND passWord LIKE @userPass", conn); // Sql Command
                    comm.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                    comm.Parameters.AddWithValue("@userPass", txtPassword.Text.Trim());
                    comm.Connection = conn;
                    comm.Connection.Open(); // Opens the SQL Database connection.

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        //MessageBox.Show("Login Successful", "User Authentication was successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu entryForm = new MainMenu();
                        entryForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, either your username or password is incorrect, Please try again!", "Warning: User Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                    }

                    // comm.ExecuteNonQuery(); // Run the query
                    comm.Connection.Close(); // Closes the SQL Database connection.

                    
                }
                else
                {
                    MessageBox.Show("Password is Required", "User Authentication: Password Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Username is Required", "User Authentication: Username Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterStaff getRegistered = new RegisterStaff();
            getRegistered.Show();
        }
    }
}
