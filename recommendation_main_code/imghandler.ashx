<%@ WebHandler Language="C#" Class="imghandler" %>

using System;
using System.Web;
using System.Data.SqlClient;

public class imghandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=rating;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        string imageid = context.Request.QueryString["ImID"];
        //cmd.CommandText = "select img from imgdet where tag='" + context.Session["search"].ToString() + "' and authen='public'";
        cmd.CommandText = "select * from app where appid='" + imageid + "'";
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.Connection = con;
        con.Open();
        System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        context.Response.BinaryWrite((Byte[])dr[4]);
        con.Close();
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}