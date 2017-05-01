using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Data;

public partial class Default5 : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    string rate="";
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["aid"].ToString();
        TextBox3.Text=Session["email"].ToString();
        //TextBox1.Text = "A001";
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from app where appid=@appid", con);
        cmd.Parameters.AddWithValue("@appid",TextBox1.Text);
         SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {
            TextBox2.Text = dr[2].ToString();
            Image1.ImageUrl = "~/imghandler.ashx?ImID=" +TextBox1.Text;
        }
        con.Close();
        NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        String sMacAddress = string.Empty;
        foreach (NetworkInterface adapter in nics)
        {
            if (sMacAddress == String.Empty)// only return MAC Address from first card  
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                sMacAddress = adapter.GetPhysicalAddress().ToString();
                Label6.Text = sMacAddress;
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default3.aspx");
    }
    public void yes()
    {
        SqlConnection con1 = new SqlConnection(constr);
        con1.Open();
        SqlCommand cmd1 = new SqlCommand("insert into rate1 values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Label6.Text + "','" + rate + "')", con1);
        cmd1.ExecuteNonQuery();
        con1.Close();
        string message = "Thanks for rating!";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<script type = 'text/javascript'>");
        sb.Append("window.onload=function(){");
        sb.Append("alert('");
        sb.Append(message);
        sb.Append("')};");
        sb.Append("</script>");
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
    }
    public void no()
    {
        string message = "Already rated This app!";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<script type = 'text/javascript'>");
        sb.Append("window.onload=function(){");
        sb.Append("alert('");
        sb.Append(message);
        sb.Append("')};");
        sb.Append("</script>");
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' OR mac='" + Label6.Text + "' AND appid='"+TextBox1.Text+"'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            this.no();
        }
        else
        {
            rate = "1";
            this.yes();
        }
        
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' OR mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            this.no();
        }
        else
        {
            rate = "2";
            this.yes();
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' OR mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            this.no();
        }
        else
        {
            rate = "3";
            this.yes();
        }
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' OR mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            this.no();
        }
        else
        {
            rate = "4";
            this.yes();
        }
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' OR mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            this.no();
        }
        else
        {
            rate = "5";
            this.yes();
        }
    }
}