using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class service : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        contactlink.HRef = GetRouteUrl("Contact", null);
        contactlink2.HRef = GetRouteUrl("Contact", null);
        contactlink3.HRef = GetRouteUrl("Contact", null);
        contactlink4.HRef = GetRouteUrl("Contact", null);
        contactlink5.HRef = GetRouteUrl("Contact", null);
        contactlink6.HRef = GetRouteUrl("Contact", null);
        contactlink7.HRef = GetRouteUrl("Contact", null);
    }
}