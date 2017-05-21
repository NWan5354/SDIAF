using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseworkExercise1__ASP_Login_Web_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = "admin";
            string passWord = "abc123";

            if (userName == txtUsername.Text)
            {
                if (passWord == txtPassword.Text)
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    lblUserMessage.Text = "The password is incorrect, please try again!";
                }
            }
            else
            {
                lblUserMessage.Text = "The user that you have entered does not exist";
                
            }
        }
    }
}