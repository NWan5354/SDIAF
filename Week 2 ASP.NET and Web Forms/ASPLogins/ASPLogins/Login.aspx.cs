using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPLogins
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Basic Testing of a Login with specified variables

            string userName = "admin";
            string passWord = "abc123";

            if (userName == txtUserName.Text)
            {
                if (passWord == txtPassword.Text)
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    lblUserValidation.Text = "The password you have entered is invalid";
                }
            }
            else
            {
                lblUserValidation.Text = "The username you entered does not exist";
            }
        }
    }
}