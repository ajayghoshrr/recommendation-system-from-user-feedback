using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default8 : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox3.Text == "Admin" && TextBox4.Text == "Admin")
        {
            Response.Redirect("Default10.aspx");
        }
        else
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from register where email='" + TextBox3.Text + "' AND pwd='" + TextBox4.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["email"] = TextBox3.Text;
                Response.Redirect("Default2.aspx");
            }

            else
            {
                string message = "Not valid User!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }

        }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox3.Text = "";
        TextBox4.Text = "";

    }
}