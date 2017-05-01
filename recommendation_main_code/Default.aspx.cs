using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        string str;
        SqlCommand com;
        int count;
        str = "select count(*) from register";
        com = new SqlCommand(str, con);

        count = Convert.ToInt16(com.ExecuteScalar()) + 1;
        TextBox1.Text = "U00" + count;
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into register values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.SelectedItem.Value.ToString() + "','" + TextBox8.Text + "','" + TextBox9.Text + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        string message = "Successfully Register!";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<script type = 'text/javascript'>");
        sb.Append("window.onload=function(){");
        sb.Append("alert('");
        sb.Append(message);
        sb.Append("')};");
        sb.Append("</script>");
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        Response.Redirect(Request.Url.AbsoluteUri);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox9.Text = "";
        TextBox8.Text = "";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default8.aspx");
    }
}