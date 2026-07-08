using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class auth_login : System.Web.UI.Page
{
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowMessage(string Message, MessageType type)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }

    Master mst = new Master();

    string id,admin_name, admin_email, admin_mobileno, admin_password, admin_role;

    protected void Page_Load(object sender, EventArgs e)
    {
//txtemail.Text=enc.Decrypted("LBz9Ve+n73PTwEkRML4d0hT6T/rN+gnZiqKmw5HiAEU=");
    }

    protected void btnlogin_ServerClick(object sender, EventArgs e)
    {
        // string pass = enc.Decrypted(txtpassword.Text);

        try
        {
            if (txtemail.Text.Length > 0 && txtpassword.Text.Length > 0)
            {

                SqlDataReader get_data = mst.Select_Operation("Select * from admin_login where admin_email='" + txtemail.Text+"' ");
                if(get_data.Read())
                {
                    id = get_data["id"].ToString();
                    admin_email = get_data["admin_email"].ToString();
                    admin_mobileno = get_data["admin_mobileno"].ToString();
                    admin_name = get_data["admin_name"].ToString();
                    admin_password = get_data["admin_password"].ToString();
                    admin_role = get_data["admin_role"].ToString();

                    if(txtemail.Text==admin_email && txtpassword.Text== admin_password)
                    {
                        Session["id"] = id;
                        Session["admin_email"] = admin_email;
                        Session["admin_mobileno"] = admin_mobileno;
                        Session["admin_name"] = admin_name;
                        Session["admin_role"] = admin_role;

                        Response.Redirect("dashboard.aspx");
                    }
                    else
                    {
                        ShowMessage("Invaild Email & Password.",MessageType.Error);
                    }
                }

                get_data.Close();

            }
            else
            {
                ShowMessage("Please enter Email and Password.", MessageType.Error);
            }
        }
        catch (SqlException ex)
        {
            ShowMessage(ex.Message, MessageType.Error);
        }
    }
}