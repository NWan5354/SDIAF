﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET__Test_Website_
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("about.aspx?" + NameField.Text);
        }

        protected void display_time (Object s, EventArgs E)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }
    }
}