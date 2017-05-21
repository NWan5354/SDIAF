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

using System.Net.Mail;
using System.Net;

namespace CMS2017
{
    public partial class OrdersPlaced : Form
    {
        public static string orderID;

        public OrdersPlaced()
        {
            InitializeComponent();
        }

        private void OrdersPlaced_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerOrderDataSet.coffeeSales' table. You can move, or remove it, as needed.
            this.coffeeSalesTableAdapter.Fill(this.customerOrderDataSet.coffeeSales);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            customerOrderDataSet.GetChanges();
            coffeeSalesTableAdapter.Fill(customerOrderDataSet.coffeeSales);
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSelectedOrderID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblSelectedOrderID.Text == string.Empty)
            {
                MessageBox.Show("No order selected", "Please select an order to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";

                // Connection string may change
                // The rest of it is following the process

                SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                SqlCommand comm = new SqlCommand(); // Sql Command

                comm.CommandText = "DELETE FROM coffeeSales WHERE orderID = @orderID";
                comm.Parameters.AddWithValue("@orderID", lblSelectedOrderID.Text);
                comm.Connection = conn;
                comm.Connection.Open(); // Opens the SQL Database connection. 

                comm.ExecuteNonQuery(); // Run the query
                comm.Connection.Close(); // Closes the SQL Database connection. 

                customerOrderDataSet.GetChanges();
                coffeeSalesTableAdapter.Fill(customerOrderDataSet.coffeeSales);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                                                                   //SqlCommand comm = new SqlCommand("INSERT INTO Contacts VALUES(@firstName, @lastName, @emailAddress)", conn); // Sql Command
            SqlCommand comm = new SqlCommand("UPDATE coffeeSales SET delivered = 'Yes' WHERE orderID = @Id", conn); // Sql Command

            comm.Parameters.AddWithValue("@Id", lblSelectedOrderID.Text);
            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            comm.ExecuteNonQuery(); // Run the query
            comm.Connection.Close(); // Closes the SQL Database connection.

            // Send email to customer to say that the order has been dispatched

            #region Fetch the current customer email address using Order ID
            

            customerOrderDataSet.GetChanges();
            coffeeSalesTableAdapter.Fill(customerOrderDataSet.coffeeSales);

            string strConn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";
            SqlConnection conn1 = new SqlConnection(strConn);
            SqlDataReader readData1 = null;
            SqlCommand comm1 = new SqlCommand("SELECT * FROM coffeeSales WHERE orderID = @id", conn1);

            comm1.Parameters.AddWithValue("@id", lblSelectedOrderID.Text);
            comm1.Connection = conn1;
            comm1.Connection.Open();

            readData1 = comm1.ExecuteReader();
            while (readData1.Read())
            {
                lblCustomerEmail.Text = (readData1["emailAddress"].ToString());
                lblName.Text = (readData1["name"].ToString());
            }

            comm1.Connection.Close();
            #endregion

            #region Send Confirmation Email
            MailMessage mail = new MailMessage();
            NetworkCredential cred = new NetworkCredential("nickucp1234@gmail.com", "sausage4321-");

            mail.From = new MailAddress("nickucp1234@gmail.com");
            mail.To.Add(lblCustomerEmail.Text.Trim());
            mail.Subject = "Order Dispatched: " + lblSelectedOrderID.Text;
            mail.IsBodyHtml = true;
            mail.Body = "<html><head><strong>ORDER DISPATCHED: #" + lblSelectedOrderID.Text + "</strong></head><p><body>Hi " + lblName.Text + ", " + "<br></br>" + "Your order has now been dispatched from the warehouse.<br></br>It should be with one of our delivery couriers.<br></br>Thanks,<br>Nick Wan (Technical Developer)</p></body></html>";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false; // Setting our own credentials
            smtp.EnableSsl = true; // Enabling SSL will ensure that the email it is signed
            smtp.Credentials = cred;
            smtp.Port = 587;

            smtp.Send(mail);
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\CustomerOrder.mdf'; Integrated Security = True; Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                                                                   //SqlCommand comm = new SqlCommand("INSERT INTO Contacts VALUES(@firstName, @lastName, @emailAddress)", conn); // Sql Command
            SqlCommand comm = new SqlCommand("UPDATE coffeeSales SET delivered = 'No' WHERE orderID = @Id", conn); // Sql Command

            comm.Parameters.AddWithValue("@Id", lblSelectedOrderID.Text);
            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            comm.ExecuteNonQuery(); // Run the query
            comm.Connection.Close(); // Closes the SQL Database connection.

            customerOrderDataSet.GetChanges();
            coffeeSalesTableAdapter.Fill(customerOrderDataSet.coffeeSales);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderID = lblSelectedOrderID.Text;

            UpdateOrders getForm = new UpdateOrders();
            getForm.Show();

            
        }
    }
}
