using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_manage_department : System.Web.UI.Page
{
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowMessage(string Message, MessageType type)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }

    Master mst = new Master();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        lblquery.Text = "Select * from enquiry Order by id desc ";
        mst.PopulateGridview(lblquery.Text, grdproducts);
    }

    protected void grdproducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdproducts.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void lnkdel_Click(object sender, EventArgs e)
    {
        LinkButton lnkdel = (LinkButton)sender;  // get the link button which trigger the event
        lbldeleteRowId.Text = lnkdel.CommandArgument;

        ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "$('#Del').modal()", true);//show the modal
    }

    protected void lnkdelete_ServerClick(object sender, EventArgs e)
    {
        SqlDataReader deleteData = mst.Delete_Operation("delete from enquiry where id='" + lbldeleteRowId.Text + "'");
        deleteData.Close();
        ShowMessage("Delete operation success.", MessageType.Success);

        BindData();
    }

    protected void grdproducts_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            
        }
    }


}