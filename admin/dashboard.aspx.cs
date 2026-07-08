using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class auth_dashboard : System.Web.UI.Page
{
    Master mst = new Master();
    public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowMessage(string Message, MessageType type)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
        }
    }

    

    private void GetData()
    {
        //lblappoinment.Text = Convert.ToString(mst.Count_data("select isnull(count(*),0) from appoinment"));

        lbltotalenquiry.Text = Convert.ToString(mst.Count_data("select isnull(count(*),0) from enquiry"));

        //lblphotos.Text = Convert.ToString(mst.Count_data("select isnull(count(*),0) from gallery"));

    }

}