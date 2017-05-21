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
    public partial class UpdateCoffee : Form
    {
        public UpdateCoffee()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu getMainMenu = new MainMenu();
            getMainMenu.Show();

            this.Hide();
        }

        //private MainMenu getData = new MainMenu();

        private void btnUpdateCoffee_Click(object sender, EventArgs e)
        {
            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

            SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                                                                   //SqlCommand comm = new SqlCommand("INSERT INTO Contacts VALUES(@firstName, @lastName, @emailAddress)", conn); // Sql Command
            SqlCommand comm = new SqlCommand("UPDATE coffeeDetails SET coffeeName = @coffeeName, coffeeStrength = @coffeeStrength, coffeeGrind = @coffeeGrind, origin = @origin, price = @price, stockQuantity = @stockQuantity, imageLink = @imageLink WHERE coffeeID = @Id", conn); // Sql Command

            comm.Parameters.AddWithValue("@Id", lblCoffeeID.Text);

            comm.Parameters.AddWithValue("@coffeeName", txtCoffeeName.Text);
            comm.Parameters.AddWithValue("@coffeeStrength", txtCoffeeStrength.Text);
            comm.Parameters.AddWithValue("@coffeeGrind", txtCoffeeGrind.Text);
            comm.Parameters.AddWithValue("@origin", txtOrigin.Text);
            comm.Parameters.AddWithValue("@price", txtPrice.Text);
            comm.Parameters.AddWithValue("@stockQuantity", txtQuantity.Text);
            comm.Parameters.AddWithValue("@imageLink", txtImageLink.Text);

            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            comm.ExecuteNonQuery(); // Run the query
            comm.Connection.Close(); // Closes the SQL Database connection.

            MessageBox.Show("Coffee details successfully updated\n" + "\n Coffee ID: " + lblCoffeeID.Text + "\n Coffee Name: " + txtCoffeeName.Text + "\n Coffee Strength: " + txtCoffeeStrength.Text + "\n Coffee Grind: " + txtCoffeeGrind.Text + "\n Origin: " + txtOrigin.Text + "\n Price: £" + txtPrice.Text + "\n Quantity: " + txtQuantity.Text + "\n Image: " + txtImageLink.Text , "Coffee Details Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            MainMenu getMenu = new MainMenu();
            getMenu.Show();
        }

        private void UpdateCoffee_Load(object sender, EventArgs e)
        {
            lblCoffeeID.Text = MainMenu.coffeeID;

            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

            SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection

            SqlDataReader readData = null;
            SqlCommand comm = new SqlCommand("SELECT * FROM coffeeDetails WHERE coffeeID = @id", conn);

            comm.Parameters.AddWithValue("@id", lblCoffeeID.Text);

            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            readData = comm.ExecuteReader();

            while (readData.Read())
            {
                txtCoffeeName.Text = (readData["coffeeName"].ToString());
                txtCoffeeStrength.Text = (readData["coffeeStrength"].ToString());
                txtCoffeeGrind.Text = (readData["coffeeGrind"].ToString());
                txtOrigin.Text = (readData["origin"].ToString());
                txtPrice.Text = (readData["price"].ToString());
                txtQuantity.Text = (readData["stockQuantity"].ToString());
                txtImageLink.Text = (readData["imageLink"].ToString());
            }

            //comm.ExecuteNonQuery(); // Run the query
            comm.Connection.Close(); // Closes the SQL Database connection.
        }
    }
}
