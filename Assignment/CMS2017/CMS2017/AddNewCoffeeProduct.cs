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
    public partial class AddNewCoffeeProduct : Form
    {
        public AddNewCoffeeProduct()
        {
            InitializeComponent();
        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

            // Connection string may change
            // The rest of it is following the process

            SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
            SqlCommand comm = new SqlCommand("INSERT INTO coffeeDetails VALUES(@name, @strength, @grind, @coffeeOrigin, @coffeePrice, @coffeeQuantity, @coffeeImage)", conn); // Sql Command

            comm.Parameters.AddWithValue("@name", txtCoffeeName.Text);
            comm.Parameters.AddWithValue("@strength", txtCoffeeStrength.Text);
            comm.Parameters.AddWithValue("@grind", txtCoffeeGrind.Text);
            comm.Parameters.AddWithValue("@coffeeOrigin", txtOrigin.Text);
            comm.Parameters.AddWithValue("@coffeePrice", txtPrice.Text);
            comm.Parameters.AddWithValue("@coffeeQuantity", txtQuantity.Text);
            comm.Parameters.AddWithValue("@coffeeImage", txtImageLink.Text);

            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            comm.ExecuteNonQuery(); // Run the query
            comm.Connection.Close(); // Closes the SQL Database connection.

            txtCoffeeName.Text = string.Empty;
            txtCoffeeStrength.Text = string.Empty;
            txtCoffeeGrind.Text = string.Empty;
            txtOrigin.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtImageLink.Text = string.Empty;

            MessageBox.Show("A new item has been added to the database", "Important Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu form1 = new MainMenu();
            form1.Show();
        }
    }
}
