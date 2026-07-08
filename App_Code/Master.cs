using System;
using System.Activities.Expressions;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public class Master
{
    public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    public Master()
    {
        
    }

    
    public string generateId(string fieldName,string query)
    {
        string generatedId = "";

        SqlDataReader get_data = Select_Operation(query);
        if (get_data.Read())
        {
            if (get_data[fieldName] == DBNull.Value)
            {
                generatedId = "1";
            }
            else
            {
                generatedId = Convert.ToString(Convert.ToInt32(get_data[fieldName].ToString()) + 1);
            }
        }
        else
        {
            generatedId = "1";
        }

        get_data.Close();


        return generatedId;
    }

    public int Update_Change_Password(string backend_password,string id)
    {
        con.Close();
        con.Open();
        int RowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update ecommerce_backend Set backend_password=@backend_password Where id=@id";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@backend_password", SqlDbType.NVarChar).Value = backend_password;
            cmd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = id;

            RowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (RowsAffected);
    }

    public decimal Sum_data(string query)
    {
        con.Close();
        con.Open();
        decimal count_data = 0;
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;

            count_data = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return (count_data);
    }

    public DataTable GetData(string query)
    {
        DataTable dt = new DataTable();
        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand(query))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    cmd.Dispose();
                }
            }
            con.Close();
            return dt;

           
        }
    }

    public SqlDataReader Delete_Operation(string query)
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        try
        {
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (reader);
    }

    public int Count_data(string query)
    {
        con.Close();
        con.Open();
        int data = 0;
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            data = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (data);
    }

    public SqlDataReader Select_Operation(string query)
    {
       
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        try
        {
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (reader);
    }

    public void BindDropDownNone(DropDownList dbl_list, string valueField, string textField, string query)
    {
        dbl_list.Items.Clear();
        dbl_list.Items.Add(new ListItem("None", ""));
        dbl_list.AppendDataBoundItems = true;

        String strConnString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        String strQuery = query;
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strQuery;
        cmd.Connection = con;

        try
        {
            con.Open();

            dbl_list.DataSource = cmd.ExecuteReader();
            dbl_list.DataTextField = textField;
            dbl_list.DataValueField = valueField;
            dbl_list.DataBind();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }

    public void BindDropDown(DropDownList dbl_list, string valueField, string textField, string query)
    {
        dbl_list.Items.Clear();
        dbl_list.Items.Add(new ListItem("Please Select", ""));
        dbl_list.AppendDataBoundItems = true;

        String strConnString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        String strQuery = query;
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strQuery;
        cmd.Connection = con;

        try
        {
            con.Open();

            dbl_list.DataSource = cmd.ExecuteReader();
            dbl_list.DataTextField = textField;
            dbl_list.DataValueField = valueField;
            dbl_list.DataBind();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }

    public void BindDropDownAll(DropDownList dbl_list, string valueField, string textField, string query)
    {
        dbl_list.Items.Clear();
        dbl_list.Items.Add(new ListItem("All", ""));
        dbl_list.AppendDataBoundItems = true;

        String strConnString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        String strQuery = query;
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strQuery;
        cmd.Connection = con;

        try
        {
            con.Open();

            dbl_list.DataSource = cmd.ExecuteReader();
            dbl_list.DataTextField = textField;
            dbl_list.DataValueField = valueField;
            dbl_list.DataBind();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }

    public void PopulateGridview(string query, GridView grd_list)
    {
        DataTable dtbl = new DataTable();
        con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
        //  cmd.Parameters.AddWithValue("@search", txt_search.Text.Trim());
        sqlDa.Fill(dtbl);
        if (dtbl.Rows.Count > 0)
        {
            grd_list.DataSource = dtbl;
            grd_list.DataBind();
        }
        else
        {
            dtbl.Rows.Add(dtbl.NewRow());
            grd_list.DataSource = dtbl;
            grd_list.DataBind();

            grd_list.Rows[0].Cells.Clear();
            grd_list.Rows[0].Cells.Add(new TableCell());
            grd_list.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
            grd_list.Rows[0].Cells[0].Text = "No Data Found ..!";
            grd_list.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
        }

        con.Close();

    }

    public void Bind_Checkbox(CheckBoxList chklist,string valueField, string textField,string query)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(query, con);
        adp.Fill(ds);
        chklist.DataSource = ds;
        chklist.DataTextField = textField;
        chklist.DataValueField = valueField;
        chklist.DataBind();
        con.Close();
    }

    public int Insert_Enquiry(string name,string mobileno,string email,string message,string create_date, string subject,string create_time)
    {
        con.Close();
        con.Open();
        int RowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into enquiry(name,email,mobileno,message,create_date,subject,create_time) values (@name,@email,@mobileno,@message,@create_date,@subject,@create_time) ";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@message", SqlDbType.NVarChar).Value = message;
            cmd.Parameters.AddWithValue("@create_date", create_date);
            cmd.Parameters.AddWithValue("@create_time", create_time);
            cmd.Parameters.AddWithValue("@subject", subject);

            RowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (RowsAffected);
    }

    public int Add_Photo(string url)
    {
        con.Close();
        con.Open();
        int RowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into gallery(url) values (@url) ";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@url", SqlDbType.NVarChar).Value = url;

            RowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (RowsAffected);
    }

    public int Book_Appoinment(string name, string mobile, string address, string problem, string create_date)
    {
        con.Close();
        con.Open();
        int RowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into appoinment(name,mobile,address,create_date,problem) values (@name,@mobile,@address,@create_date,@problem)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            cmd.Parameters.AddWithValue("@problem", SqlDbType.NVarChar).Value = problem;
            cmd.Parameters.AddWithValue("@create_date", create_date);

            RowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (RowsAffected);
    }

    public int Insert_Enquiry(string name, string mobileno, string email, string message, string create_date, string create_time)
    {
        con.Close();
        con.Open();
        int RowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into enquiry(name,mobileno,email,create_date,message,create_time) values (@name,@mobileno,@email,@create_date,@message,@create_time)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@message", SqlDbType.NVarChar).Value = message;
            cmd.Parameters.AddWithValue("@create_date", create_date);
            cmd.Parameters.AddWithValue("@create_time", create_time);

            RowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        return (RowsAffected);
    }


}