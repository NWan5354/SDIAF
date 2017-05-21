using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using SQLClass;

namespace CourseworkExercise1__ASP_Login_Web_
{
    public partial class ChangePasswordPart2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.Session["userName"] == null)
            {
                Response.Redirect("~/ChangePassword.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SQLDatabaseConnectionClass updatePassword = new SQLDatabaseConnectionClass();

            updatePassword.execute("update \"Table\" set \"password\" = '" + txtNewPassword.Text.Trim() + "' where \"userName\" = '" + Session["userName"] + "' ");

            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }
    }
}