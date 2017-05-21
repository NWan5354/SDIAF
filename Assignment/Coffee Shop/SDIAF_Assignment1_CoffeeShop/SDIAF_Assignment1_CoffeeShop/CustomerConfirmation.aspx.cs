using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Mail;
using System.Net;

namespace CourseworkExercise1__ASP_Login_Web_
{
    public partial class CustomerConfimation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Get Order ID
            if (Session["OrderID"] == null)
            {

            }
            else
            {
                lblOrderRef.Text = Session["OrderID"].ToString();
            }
            #endregion
        }
    }
}