using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        logo_link.HRef = GetRouteUrl("Index", null);
        logo_link2.HRef = GetRouteUrl("Index", null);
        home_link2.HRef = GetRouteUrl("Index", null);
        home_link.HRef = GetRouteUrl("Index", null);
        about_link2.HRef = GetRouteUrl("About", null);
        about_link.HRef = GetRouteUrl("About", null);
        service_link2.HRef = GetRouteUrl("Service", null);
        service_link.HRef = GetRouteUrl("Service", null);
        contact_link2.HRef = GetRouteUrl("Contact", null);
        contact_link.HRef = GetRouteUrl("Contact", null);
        privacy_link.HRef = GetRouteUrl("privacy-policy", null);
    }
}
