using System;
using System.Web.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Configuration;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Xml.Linq;
public partial class contact : System.Web.UI.Page
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