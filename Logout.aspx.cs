using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace DBHandIn3
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["Email"] = null;
            HttpContext.Current.Session["D_name"] = null;

            LabelMessageLogout.Text = "You have succesfully logged out.";
        }
    }
}