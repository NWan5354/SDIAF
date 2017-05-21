using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CMS2017
{
    public partial class UpdateOrders : Form
    {
        public UpdateOrders()
        {
            InitializeComponent();
        }

        private void UpdateOrders_Load(object sender, EventArgs e)
        {
            lblOrderID.Text = OrdersPlaced.orderID;

            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";

            SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection

            SqlDataReader readData = null;
            SqlCommand comm = new SqlCommand("SELECT * FROM coffeeSales WHERE orderID = @id", conn);

            comm.Parameters.AddWithValue("@id", lblOrderID.Text);

            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            readData = comm.ExecuteReader();

            while (readData.Read())
            {
                lblOrderID.Text = (readData["orderID"].ToString());
                lblCoffeeName.Text = (readData["coffeeName"].ToString());
                lblCoffeeID.Text = (readData["coffeeID"].ToString());
                lblQuantityRequested.Text = (readData["quantityRequested"].ToString());
                lblTotalCost.Text = (readData["totalCost"].ToString());
                txtName.Text = (readData["name"].ToString());
                txtAddressLine.Text = (readData["addressLine"].ToString());
                txtTown.Text = (readData["town"].ToString());
                txtPostcode.Text = (readData["postCode"].ToString());
                txtTelephoneNo.Text = (readData["telephoneNumber"].ToString());
                txtEmailAddress.Text = (readData["emailAddress"].ToString());
            }
            comm.Connection.Close(); // Closes the SQL Database connection.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";

            SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                                                                   //SqlCommand comm = new SqlCommand("INSERT INTO Contacts VALUES(@firstName, @lastName, @emailAddress)", conn); // Sql Command
            SqlCommand comm = new SqlCommand("UPDATE coffeeSales SET name = @name, addressLine = @addressline, town = @town, postCode = @postcode, telephoneNumber = @telephonenumber, emailAddress = @emailaddress WHERE orderID = @Id", conn); // Sql Command

            comm.Parameters.AddWithValue("@Id", lblOrderID.Text);

            comm.Parameters.AddWithValue("@name", txtName.Text);
            comm.Parameters.AddWithValue("@addressline", txtAddressLine.Text);
            comm.Parameters.AddWithValue("@town", txtTown.Text);
            comm.Parameters.AddWithValue("@postcode", txtPostcode.Text);
            comm.Parameters.AddWithValue("@telephonenumber", txtTelephoneNo.Text);
            comm.Parameters.AddWithValue("@emailaddress", txtEmailAddress.Text);

            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            comm.ExecuteNonQuery(); // Run the query
            comm.Connection.Close(); // Closes the SQL Database connection.

            MessageBox.Show("Update Successful","Customer details have been updated successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
