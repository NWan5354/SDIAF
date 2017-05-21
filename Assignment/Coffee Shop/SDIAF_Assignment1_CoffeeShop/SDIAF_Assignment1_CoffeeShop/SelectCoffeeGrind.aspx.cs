using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseworkExercise1__ASP_Login_Web_
{
    public partial class SelectCoffeeGrind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coffeeName = GridView1.SelectedRow.Cells[2].Text;
            string coffeeID = GridView1.SelectedRow.Cells[1].Text;
            string strength = GridView1.SelectedRow.Cells[3].Text;
            string grind = GridView1.SelectedRow.Cells[4].Text;
            string origin = GridView1.SelectedRow.Cells[5].Text;
            string price = GridView1.SelectedRow.Cells[6].Text;


            lblID.Text = coffeeID;
            lblSelectedCoffee.Text = "Coffee Name: " + coffeeName;
            lblCoffeeStrength.Text = "Coffee Strength: " + strength;
            lblGrind.Text = "Grind Type: " + grind;
            lblOrigin.Text = "Origin: " + origin;
            lblPrice.Text = "Price: " + price;
        }

        protected void btnBuyCoffee_Click(object sender, EventArgs e)
        {
            Session["CoffeeID"] = lblID.Text;
            Response.Redirect("~/Purchase.aspx");
        }
    }
}