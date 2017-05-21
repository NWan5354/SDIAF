using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLClass;


namespace CourseworkExercise1__ASP_Login_Web_
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            SQLDatabaseConnectionClass insertData = new SQLDatabaseConnectionClass();
            //insertData.execute("insert into \"Table\" values (N'" + txtName.Text.Trim() + "', N'" + txtEmail.Text.Trim() +"', N'" + txtUsername.Text.Trim() + "', N'" + txtPassword.Text.Trim() + "' ) ");
            insertData.execute("insert into \"Table\" values (N'" + txtName.Text.Trim() + "', N'" + txtEmail.Text.Trim() + "', N'" + txtUsername.Text.Trim() + "', N'" + txtPassword.Text.Trim() + "', N'" + selectSecurityQuestion.Text.Trim() + "', N'" + txtSecQuesAnswer.Text.Trim() + "' ) ");

            // Clearing the previous submissison user information
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;

            selectSecurityQuestion.Text = string.Empty;
            txtSecQuesAnswer.Text = string.Empty;
        }
    }
}