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
    public partial class RecoverPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecoverPassword_Click(object sender, EventArgs e)
        {
            SQLDatabaseConnectionClass getUserLogin = new SQLDatabaseConnectionClass();
            getUserLogin.getData("select email from \"Table\" where \"email\" = '" + txtEmail.Text.Trim() + "' ");

            if (getUserLogin.SQLTable.Rows.Count == 1)
            {

                SqlConnection connection = new SqlConnection(getUserLogin.ConnToSQL.ConnectionString);
                connection.Open();
                string check = ("select securityQuestion from \"Table\" where \"email\" ='" + txtEmail.Text.Trim() + "' ");
                SqlCommand command = new SqlCommand(check, connection);
                string securityQuestion = command.ExecuteScalar().ToString().Trim();

               

                if (securityQuestion == selectSecurityQuestion.Text)
                {
                    SqlConnection connection2 = new SqlConnection(getUserLogin.ConnToSQL.ConnectionString);
                    connection2.Open();
                    string check2 = ("select sqAnswer from \"Table\" where \"email\" ='" + txtEmail.Text.Trim() + "' ");
                    SqlCommand command2 = new SqlCommand(check2, connection2);
                    string securityQuesAns = command2.ExecuteScalar().ToString().Replace(" ", "");

                    if (securityQuesAns == txtSecQuesAns.Text)
                    {
                        SqlConnection connection3 = new SqlConnection(getUserLogin.ConnToSQL.ConnectionString);
                        connection3.Open();
                        string check3 = ("select password from \"Table\" where \"email\" ='" + txtEmail.Text.Trim() + "' ");
                        SqlCommand command3 = new SqlCommand(check3, connection3);
                        string password = command3.ExecuteScalar().ToString().Replace(" ", "");
                        lblUserMessage.Text = "Your password is: " + password;
                    }
                    else
                    {
                        lblUserMessage.Text = "The security question answer provided is incorrect";
                    }

                }
                else
                {
                    
                    lblUserMessage.Text = "The security question is incorrect, please try again!";
                }
                

            }
            else
            {
                lblUserMessage.Text = "The email provided is not registered, please try again!";
            }

            txtEmail.Text = string.Empty;
            selectSecurityQuestion.Text = string.Empty;
            txtSecQuesAns.Text = string.Empty;
        }
    }
}