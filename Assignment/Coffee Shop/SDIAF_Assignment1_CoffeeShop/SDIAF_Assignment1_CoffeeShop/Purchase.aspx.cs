using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

using System.Net.Mail;
using System.Net;

using Google.Maps.Geocoding;
using Google.Maps.StaticMaps;
using Google.Maps;



namespace CourseworkExercise1__ASP_Login_Web_
{
    public partial class Purchase : System.Web.UI.Page
    {
        public static double totalAmount;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Checking if the ASP Session (Session["CoffeeID"]) has a coffee selected

            #region Checking whether Session variable exists for Coffee
            if (Session["CoffeeID"] == null)
            {
                Response.Redirect("~/CoffeeProducts.aspx");
            }
            else
            {

                string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

                SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection

                SqlDataReader readData = null;
                SqlCommand comm = new SqlCommand("SELECT * FROM coffeeDetails WHERE coffeeID = @id", conn);

                string coffeeID = Session["CoffeeID"].ToString();

                comm.Parameters.AddWithValue("@id", Convert.ToInt32(Session["CoffeeID"].ToString()));

                comm.Connection = conn;
                comm.Connection.Open(); // Opens the SQL Database connection. 

                readData = comm.ExecuteReader();

                while (readData.Read())
                {
                    lblCoffeeName.Text = (readData["coffeeName"].ToString());
                    lblCoffeePrice.Text = (readData["price"].ToString());
                    lblTotalAmount.Text = (readData["price"].ToString());
                }

                comm.Connection.Close(); // Closes the SQL Database connection.
                
            }
            #endregion

        }

        protected void btndeincrementQuantity_Click(object sender, EventArgs e)
        {
            int currentQuantity = Convert.ToInt32(txtSetQuantity.Text);

            if (currentQuantity == 0)
            {
                lblTotalAmount.Text = "0.00";
            }
            else
            {
                int quantity = Convert.ToInt32(txtSetQuantity.Text) - 1;
                txtSetQuantity.Text = quantity.ToString();

                double coffeePrice = Convert.ToDouble(lblCoffeePrice.Text);

                totalAmount = totalAmount - coffeePrice;

                lblTotalAmount.Text = totalAmount.ToString();

                lblQuantity.Text = quantity.ToString();

            }
        }

        protected void btnincrementQuantity_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(txtSetQuantity.Text) + 1;
            txtSetQuantity.Text = quantity.ToString();

            double coffeePrice = Convert.ToDouble(lblCoffeePrice.Text);

            double total = quantity * coffeePrice;

            lblTotalAmount.Text = total.ToString();
            totalAmount = Convert.ToDouble(lblTotalAmount.Text);

            lblQuantity.Text = quantity.ToString();

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {

            // Get current stock quantity

            #region 1. Get current stock quantity

            string strConnection2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

            SqlConnection conn2 = new SqlConnection(strConnection2); // Creates a new instance Sql Connection

            SqlDataReader readData = null;
            SqlCommand comm2 = new SqlCommand("SELECT * FROM coffeeDetails WHERE coffeeID = @id", conn2);

            string coffeeID = Session["CoffeeID"].ToString();

            comm2.Parameters.AddWithValue("@id", Convert.ToInt32(Session["CoffeeID"].ToString()));

            comm2.Connection = conn2;
            comm2.Connection.Open(); // Opens the SQL Database connection. 

            readData = comm2.ExecuteReader();

            while (readData.Read())
            {
                lblinStock.Text = (readData["stockQuantity"].ToString());
            }

            comm2.Connection.Close(); // Closes the SQL Database connection.
            #endregion

            int requestedAmount;
            requestedAmount = Convert.ToInt32(txtSetQuantity.Text);

            int currentStockQuantity;
            currentStockQuantity = Convert.ToInt32(lblinStock.Text);

            if (requestedAmount > currentStockQuantity)
            {
                lblInvalidQuantity.Visible = true;
                lblInvalidQuantity.Text = "Sorry, we have only got " + currentStockQuantity + " in stock currently";
            }
            else
            {
                // Updating the stock quantity

                #region 2. Reducing the stock from the coffee warehouse
                string updateConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

                SqlConnection conn1 = new SqlConnection(updateConnection); // Creates a new instance Sql Connection
                                                                           //SqlCommand comm = new SqlCommand("INSERT INTO Contacts VALUES(@firstName, @lastName, @emailAddress)", conn); // Sql Command
                SqlCommand comm1 = new SqlCommand("UPDATE coffeeDetails SET stockQuantity = @stockReduced WHERE coffeeID = @coffeeID", conn1); // Sql Command

                int currentStock = Convert.ToInt32(lblinStock.Text);
                int stockRequired = Convert.ToInt32(lblQuantity.Text);
                int reducedStock = currentStock - stockRequired;


                comm1.Parameters.AddWithValue("@coffeeID", Convert.ToInt32(Session["CoffeeID"].ToString()));
                comm1.Parameters.AddWithValue("@stockReduced", reducedStock);

                comm1.Connection = conn1;
                comm1.Connection.Open(); // Opens the SQL Database connection. 

                comm1.ExecuteNonQuery(); // Run the query
                comm1.Connection.Close(); // Closes the SQL Database connection.
                #endregion

                // Storing the Customer and Sales data into the database

                #region 3. Storing Sales Information
                string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";

                // Connection string may change
                // The rest of it is following the process

                SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                SqlCommand comm = new SqlCommand("INSERT INTO coffeeSales VALUES(@coffeeName, @coffeeID, @quantity, @totalCost, @name, @address, @town, @postCode, @telephoneNumber, @emailAddress, @delivered)", conn); // Sql Command

                string deliveryStatus = "No";

                comm.Parameters.AddWithValue("@coffeeName", lblCoffeeName.Text);
                comm.Parameters.AddWithValue("@coffeeID", Convert.ToInt32(Session["CoffeeID"].ToString()));
                comm.Parameters.AddWithValue("@quantity", lblQuantity.Text);
                comm.Parameters.AddWithValue("@totalCost", totalAmount);
                comm.Parameters.AddWithValue("@name", txtName.Text);
                comm.Parameters.AddWithValue("@address", txtStreetName.Text);
                comm.Parameters.AddWithValue("@town", txtTown.Text);
                comm.Parameters.AddWithValue("@postCode", txtPostcode.Text);
                comm.Parameters.AddWithValue("@telephoneNumber", txtContactNo.Text);
                comm.Parameters.AddWithValue("@emailAddress", txtEmail.Text);
                comm.Parameters.AddWithValue("@delivered", deliveryStatus);

                comm.Connection = conn;
                comm.Connection.Open(); // Opens the SQL Database connection. 

                comm.ExecuteNonQuery(); // Run the query
                comm.Connection.Close(); // Closes the SQL Database connection.
                #endregion

                // Fetch Customer ID for Confirmation Page

                #region 4. Get Order Reference ID
                string strConnection3 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";

                SqlConnection conn3 = new SqlConnection(strConnection3); // Creates a new instance Sql Connection

                SqlDataReader readData3 = null;
                SqlCommand comm3 = new SqlCommand("SELECT * FROM coffeeSales WHERE coffeeID = @id", conn3);

                comm3.Parameters.AddWithValue("@id", Convert.ToInt32(Session["CoffeeID"].ToString()));

                comm3.Connection = conn3;
                comm3.Connection.Open(); // Opens the SQL Database connection. 

                readData3 = comm3.ExecuteReader();

                while (readData3.Read())
                {
                    Session["OrderID"] = (readData3["orderID"].ToString());

                }

                comm3.Connection.Close(); // Closes the SQL Database connection.
                #endregion

                // Send a confirmation email to the customer  

                #region 5. Send Confirmation Email
                MailMessage mail = new MailMessage();
                NetworkCredential cred = new NetworkCredential("nickucp1234@gmail.com", "sausage4321-");

                mail.From = new MailAddress("nickucp1234@gmail.com");
                mail.To.Add(txtEmail.Text.Trim());
                mail.Subject = "Order Reference: " + Session["OrderID"];
                mail.IsBodyHtml = true;
                mail.Body = "<html><head><strong>ORDER ACKNOWLEDGEMENT: #" + Session["OrderID"] + "</strong></head><p><body>Hi " + txtName.Text + ", " + "<br></br>" + "Thanks for placing an order with International Coffee Shop 2017.<br></br>Just a quick update, we have received your order and its currently being processed through our systems.<br></br>Below is an overview of what is ordered:<br></br>----------------------------------------<br></br>Coffee Name: " + lblCoffeeName.Text + "<br><br>Price Per Unit: £" + lblCoffeePrice.Text + "<br></br> Quantity Ordered: " + lblQuantity.Text + "<br></br> Total Cost: £" + totalAmount + "<br></br>" + "----------------------------------------" + "<br></br>" + "Your order will be dispatched to you within 3 - 5 working days.<br></br>Thanks,<br>Nick Wan (Technical Developer)</p></body></html>";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.UseDefaultCredentials = false; // Setting our own credentials
                smtp.EnableSsl = true; // Enabling SSL will ensure that the email it is signed
                smtp.Credentials = cred;
                smtp.Port = 587;

                smtp.Send(mail);
                #endregion

                // Redirect customer to confirmation page

                Response.Redirect("~/CustomerConfirmation.aspx");
            }
        }

        protected void btnFindAddress_Click(object sender, EventArgs e)
        {
            var request = new GeocodingRequest();
            request.Address = textboxPostcode.Text;
            request.Sensor = false;
            var response = new GeocodingService().GetResponse(request);

            var result = response.Results.First();

            txtStreetName.Text = textboxHouseNo.Text + " " + result.AddressComponents[1].LongName;
            txtTown.Text = "" + result.AddressComponents[2].LongName;
            txtPostcode.Text = textboxPostcode.Text;
        }
    }
}