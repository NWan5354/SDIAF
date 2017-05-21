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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            SQLDatabaseConnectionClass obtainUserLogin = new SQLDatabaseConnectionClass();

            obtainUserLogin.getData("select userName from \"Table\" where \"userName\" = '" + txtUsername.Text.Trim() + "' ");
            
            if (obtainUserLogin.SQLTable.Rows.Count == 1)
            {
                SqlConnection connection = new SqlConnection(obtainUserLogin.ConnToSQL.ConnectionString);
                connection.Open();
                string ckPassword = ("select password from \"Table\" where \"userName\" ='" + txtUsername.Text.Trim() + "' ");
                SqlCommand command = new SqlCommand(ckPassword, connection);
                string password = command.ExecuteScalar().ToString().Replace(" ", "");
                

                if (password == txtPassword.Text)
                {
                    Session["userName"] = txtUsername.Text;
                    Response.Redirect("~/Default.aspx");
                    
                }
                else
                {
                    lblUserMessage.Text = "The password is incorrect, please try again!";
                }
                connection.Close();
            }
            else
            {
                lblUserMessage.Text = "The user that you have entered does not exist";
            }

        }
    }
}