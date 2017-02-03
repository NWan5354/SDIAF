using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Experimenting
{
    public partial class Default : System.Web.UI.Page
    {
        private encryption enc = new encryption();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                NameLabel.Text = enc.rot13(NameBox.Text);
            }
        }
    }
}