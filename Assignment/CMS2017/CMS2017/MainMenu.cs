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
    public partial class MainMenu : Form
    {
        public static string coffeeID;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblUserLoggedIn.Text = LoginForm.userLoggedIn;

            // TODO: This line of code loads data into the 'coffeeShopDataSet.coffeeDetails' table. You can move, or remove it, as needed.
            this.coffeeDetailsTableAdapter.Fill(this.coffeeShopDataSet.coffeeDetails);

            string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

            SqlConnection conn = new SqlConnection(strConnection);

            SqlDataReader readData = null;
            SqlCommand comm = new SqlCommand("SELECT * FROM CoffeeDetails WHERE stockQuantity <= 5", conn);

            comm.Connection = conn;
            comm.Connection.Open(); // Opens the SQL Database connection. 

            readData = comm.ExecuteReader();

            while (readData.Read())
            {
                MessageBox.Show("Coffee Name: " + readData["coffeeName"].ToString() + "\n" + "Coffee ID: " + readData["coffeeID"].ToString() + " is running low." + "\n" + "\n" + "Order more stock immediately!", "Stock Running Low", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //comm.ExecuteNonQuery(); // Run the query
            comm.Connection.Close(); // Closes the SQL Database connection. 

            coffeeShopDataSet.GetChanges();
            coffeeDetailsTableAdapter.Fill(coffeeShopDataSet.coffeeDetails);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.coffeeDetailsTableAdapter.Update(this.coffeeShopDataSet.coffeeDetails);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCoffeeName.Text == string.Empty)
            {
                MessageBox.Show("No coffee seleted for deletion", "Error: Cannot Remove Coffee Product",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\nickw\OneDrive\Documents\UserDetails.mdf';Integrated Security=False;Connect Timeout=30";
                string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\nickw\OneDrive\Documents\coffeeShop.mdf'; Integrated Security = True; Connect Timeout = 30";

                // Connection string may change
                // The rest of it is following the process

                SqlConnection conn = new SqlConnection(strConnection); // Creates a new instance Sql Connection
                SqlCommand comm = new SqlCommand(); // Sql Command

                comm.CommandText = "DELETE FROM coffeeDetails WHERE coffeeName LIKE '" + txtCoffeeName.Text + "'";
                comm.Connection = conn;
                comm.Connection.Open(); // Opens the SQL Database connection. 

                comm.ExecuteNonQuery(); // Run the query
                comm.Connection.Close(); // Closes the SQL Database connection. 

                coffeeShopDataSet.GetChanges();
                coffeeDetailsTableAdapter.Fill(coffeeShopDataSet.coffeeDetails);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCoffeeName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblSelectedCoffeeForEdit.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txtImageFile.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            lblCoffeeName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblStrength.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblGrind.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblOrigin.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lblPrice.Text = "£" + dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            AddNewCoffeeProduct form2 = new AddNewCoffeeProduct();

            form2.Show();

            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void btnEditCoffee_Click(object sender, EventArgs e)
        {
            if (lblSelectedCoffeeForEdit.Text == "No Coffee Selected")
            {
                MessageBox.Show("Please select a coffee to edit", "No Coffee Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                coffeeID = lblSelectedCoffeeForEdit.Text;

                UpdateCoffee getForm = new UpdateCoffee();
                getForm.Show();
                this.Hide();
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            coffeeShopDataSet.GetChanges();
            coffeeDetailsTableAdapter.Fill(coffeeShopDataSet.coffeeDetails);
        }

        private void btnCustomerOrders_Click(object sender, EventArgs e)
        {
            OrdersPlaced getOrderInfo = new OrdersPlaced();
            getOrderInfo.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Loading an image in the Picture box

            if (txtImageFile.Text == string.Empty)
            {
                pictureBox1.Hide();
            }
            else
            {
                pictureBox1.Show();
                Image img = Image.FromFile(@"Images\" + txtImageFile.Text);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = System.DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["originDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
            coffeeShopDataSet.GetChanges();
            coffeeDetailsTableAdapter.Fill(coffeeShopDataSet.coffeeDetails);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["coffeeStrengthDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
            coffeeShopDataSet.GetChanges();
            coffeeDetailsTableAdapter.Fill(coffeeShopDataSet.coffeeDetails);
        }
    }
}
