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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.Session["userName"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SQLDatabaseConnectionClass obtainUserPassword = new SQLDatabaseConnectionClass();

            SqlConnection connection = new SqlConnection(obtainUserPassword.ConnToSQL.ConnectionString);
            connection.Open();
            string checkPassword = ("select password from \"Table\" where \"userName\" ='" + Session["userName"] + "' ");
            SqlCommand command = new SqlCommand(checkPassword, connection);
            string passWord = command.ExecuteScalar().ToString().Replace(" ", "");

            if (passWord == txtPassword.Text)
            {
                Response.Redirect("~/ChangePasswordPart2.aspx");
            }
            else
            {
                Response.Write("Incorrect");
            }
            connection.Close();
        }
    }
}