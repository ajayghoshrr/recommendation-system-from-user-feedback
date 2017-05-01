using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["email"].ToString();
        DataTable dt = new DataTable();
        //String strConnString = System.Configuration.ConfigurationManager.
        //    ConnectionStrings["conString"].ConnectionString;
        string strQuery = "select * from app order by appid";
        SqlCommand cmd = new SqlCommand(strQuery);
        SqlConnection con = new SqlConnection(constr);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            //GridView2.DataSource = dt;
            //GridView2.DataBind();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            con.Close();
            sda.Dispose();
            con.Dispose();
            dt.Dispose();
        }
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string id = GridView1.SelectedRow.Cells[3].Text;
        Session["aid"] = id;
        //int id = int.Parse((sender as LinkButton).CommandArgument);
        string contentType, fileName;
        byte[] bytes;
        //string fileName = GridView1.SelectedRow.Cells[4].ToString();
        //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select * from app where appid=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    bytes = (byte[])sdr["data"];
                    contentType = sdr["ctype"].ToString();
                    fileName = sdr["fname"].ToString();
                }
                con.Close();
            }
        }
        Response.Clear();
        Response.Buffer = true;
        Response.Charset = "";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = contentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
        Response.BinaryWrite(bytes);
        Response.Flush();
        Response.End();
    }
    protected void status(object sender, EventArgs e)
    {
        string numbers = "1234567890";

        string characters = numbers;
       
        string otp = string.Empty;
        for (int i = 0; i < 6; i++)
        {
            string character = string.Empty;
            do
            {
                int index = new Random().Next(0, characters.Length);
                character = characters.ToCharArray()[index].ToString();
            } while (otp.IndexOf(character) != -1);
               otp += character;
        }
        string pass= otp;
        Session["pass"] = pass;
        //Session["id"] = GridView1.SelectedRow.Cells[3].ToString();
        //Session["name"] = GridView1.SelectedRow.Cells[4].ToString();
        using (MailMessage mm = new MailMessage("rajvenkatesan1993@gmail.com", Label1.Text))
        {
            mm.Subject = "Your Security Key";
            mm.Body = pass;
           
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential("rajvenkatesan1993@gmail.com", "rajpraba123");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);
            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
        }
        Response.Redirect("Default6.aspx");
    }
}