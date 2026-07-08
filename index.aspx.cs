using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class index : System.Web.UI.Page
{
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowToastMessage(string Message, MessageType type)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowToastMessage('" + Message + "','" + type + "');", true);
    }

    Master mst = new Master();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            homelink.HRef= GetRouteUrl("About", null);
            homelink2.HRef= GetRouteUrl("About", null);
            homelink3.HRef= GetRouteUrl("About", null);
            homelink4.HRef= GetRouteUrl("About", null);
            servicelink.HRef= GetRouteUrl("Service", null);
        }
    }
    

    protected void btnsend_ServerClick(object sender, EventArgs e)
    {
        if (name.Text.Length > 0 && mobile.Text.Length > 0 && msg.Text.Length > 0)
        {
            //SendMail();
            int saveData = mst.Insert_Enquiry(name.Text, mobile.Text, email.Text, msg.Text, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("hh:mm:ss"));

            if (saveData > 0)
            {
                string script = "<script type=\"text/javascript\">alert('Enquiry Sent...');</script>";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);

                ShowToastMessage("Data has been saved.", MessageType.Error);

                name.Text = String.Empty;
                mobile.Text = String.Empty;
                msg.Text = String.Empty;
                email.Text = String.Empty;

            }

        }
        else
        {

        }
    }


}