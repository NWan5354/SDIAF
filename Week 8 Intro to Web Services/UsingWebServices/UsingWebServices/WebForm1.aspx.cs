using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingWebServices
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.Calculations newCalc = new localhost.Calculations();
            //txtHello.Text = newCalc.HelloWorld();


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            localhost.Calculations newCalc = new localhost.Calculations();

            double num1 = Convert.ToDouble(txtFirstNum.Text);
            double num2 = Convert.ToDouble(txtSecondNum.Text);
            double answer = newCalc.add(num1, num2);

            txtResultBox.Text = newCalc.add(num1, num2).ToString();
        }
    }
}