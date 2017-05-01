using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.Text = Session["email"].ToString();
        
    }
    protected void Upload(object sender, EventArgs e)
    {
       string pass=Session["pass"].ToString();
       String pass1=TextBox6.Text;
        if ( pass==pass1)
        {
            Response.Redirect("Default9.aspx");
        }
    }
}