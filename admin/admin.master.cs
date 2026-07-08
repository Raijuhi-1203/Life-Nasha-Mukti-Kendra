using System;
using System.Web;

public partial class auth_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();

        if (!IsPostBack)
        {
            if (Session["admin_name"] != null)
            {

            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}
