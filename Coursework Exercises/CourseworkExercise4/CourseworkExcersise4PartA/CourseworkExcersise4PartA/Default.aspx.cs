using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseworkExcersise4PartA
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvertValue_Click(object sender, EventArgs e)
        {
            double areaValue = Convert.ToDouble(txtUserAreaValue.Text);
            string fromValue = Convert.ToString(dropDownFrom.Text);
            string toValue = Convert.ToString(dropDownTo.Text);

            Webref1.AreaUnit ref1 = new Webref1.AreaUnit();

            Webref1.Areas fromUnit;
            Webref1.Areas toUnit;

            Enum.TryParse(fromValue, out fromUnit);
            Enum.TryParse(toValue, out toUnit);

            double answer = ref1.ChangeAreaUnit(areaValue, fromUnit, toUnit);

            lblConversionResult.Text = Convert.ToString(answer);
            
        }
    }
}