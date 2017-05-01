using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default10 : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        //string str = Session["email"].ToString();
        if (!this.IsPostBack)
        {
            this.BindGrid();
        }
        int a = 0, b = 0, c = 0;

        //for (int i = 0; i < (GridView1.Rows.Count); i++)
        //{
        //    a = Convert.ToInt32(GridView1.Rows[i].Cells[4].Text.ToString());
        //    c = c + a; //storing total qty into variable 
        //}
        //Label1.Text = c.ToString();
        

    }
    private void BindGrid()
    {
        //string str = Session["email"].ToString();
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM rate1"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM rate1 where appid='" + DropDownList1.SelectedItem.Value.ToString() + "'"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                    int a = 0, b = 0, c = 0;
                    for (int i = 0; i < (GridView1.Rows.Count); i++)
                    {
                        a = Convert.ToInt32(GridView1.Rows[i].Cells[3].Text.ToString());
                        c = c + a; //storing total qty into variable 
                    }
                  int cc = GridView1.Rows.Count;
                  int z = c;
                  int x = c / cc;
                  Label1.Text = x.ToString();


                }
            }
        }
    }
}