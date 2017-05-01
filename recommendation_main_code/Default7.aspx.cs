using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    string rate = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["aid"].ToString();
        TextBox3.Text = Session["email"].ToString();
        //TextBox1.Text = "A001";
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from app where appid=@appid", con);
        cmd.Parameters.AddWithValue("@appid", TextBox1.Text);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {
            TextBox2.Text = dr[2].ToString();
            Image1.ImageUrl = "~/imghandler.ashx?ImID=" + TextBox1.Text;
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(constr);
        con1.Open();
        SqlCommand cmd1 = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' AND mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con1);
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            this.no();
        }
        else
        {
            if (RadioButton1.Checked == true)
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' AND mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
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
            else if (RadioButton2.Checked == true)
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' AND mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
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
            else if (RadioButton2.Checked == true)
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' AND mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
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
            else if (RadioButton2.Checked == true)
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' AND mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
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
            else if (RadioButton5.Checked == true)
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from rate1 where uname='" + TextBox3.Text + "' AND mac='" + Label6.Text + "' AND appid='" + TextBox1.Text + "'", con);
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
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}