using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zxtlbs.Model;

namespace Zxtlbs.Web
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AUser user = (AUser)Session["AUser"];
            if (user == null)
            {
                Response.Redirect("login.html");
            }
        }
    }
}
