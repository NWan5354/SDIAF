using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseworkExcersise4PartA
{
    public partial class ComputerConvert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double computerConvertValue = Convert.ToDouble(txtUserSpecifiedValue.Text);
            string fromValue = Convert.ToString(dropDownFrom.Text);
            string toValue = Convert.ToString(dropDownTo.Text);

            Webref2.ComputerUnit ref2 = new Webref2.ComputerUnit();

            Webref2.Computers fromUnit;
            Webref2.Computers toUnit;

            Enum.TryParse(fromValue, out fromUnit);
            Enum.TryParse(toValue, out toUnit);

            double answer = ref2.ChangeComputerUnit(computerConvertValue, fromUnit, toUnit);

            lblConvertedValue.Text = Convert.ToString(answer);
        }
    }
}