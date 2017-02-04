using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET__Test_Website_
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(FirstNumber.Text);
            int secondNumber = Convert.ToInt32(SecondNumber.Text);

            int answer = firstNumber + secondNumber;

            Answer.Text = answer.ToString();
        }
    }
}