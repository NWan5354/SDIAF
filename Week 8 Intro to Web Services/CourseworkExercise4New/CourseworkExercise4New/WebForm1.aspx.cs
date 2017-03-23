using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseworkExercise4New
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            localhost.ConversionTemp newConv = new localhost.ConversionTemp();
            double temp = Convert.ToDouble(txtInputCelsius.Text);
            double result = newConv.CelsiusToFarenheit(temp);

            txtOutputFarenheit.Text = result.ToString();
        }

        protected void btnFarenheitToCelsius_Click(object sender, EventArgs e)
        {
            localhost.ConversionTemp newConv1 = new localhost.ConversionTemp();
            double temp = Convert.ToDouble(txtOutputFarenheit.Text);
            double result = newConv1.FarenheitToCelsius(temp);

            txtInputCelsius.Text = result.ToString();
        }
    }
}