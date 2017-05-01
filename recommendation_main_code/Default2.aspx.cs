using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox4.Text = Session["email"].ToString();
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        string str;
        SqlCommand com;
        int count;
        str = "select count(*) from app";
        com = new SqlCommand(str, con);

        count = Convert.ToInt16(com.ExecuteScalar()) + 1;
        TextBox1.Text = "A00" + count;
        con.Close();
    }
    protected void Upload(object sender, EventArgs e)
    {
        using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
        {
            byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string s = "null";
                    byte[] s1 = Encoding.ASCII.GetBytes(s);
                    cmd.CommandText = "insert into app(uname,appid,aname,description, img, date1,fname,ctype,data) values (@uname,@appid,@aname,@description,@img,@date1,@fname,@ctype,@data)";
                    cmd.Parameters.AddWithValue("@uname", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@appid", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@aname", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@description", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@date1", System.DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@img", bytes);
                    cmd.Parameters.AddWithValue("@fname", s);
                    cmd.Parameters.AddWithValue("@ctype", s);
                    cmd.Parameters.AddWithValue("@data", s1);

                    //cmd.Parameters.AddWithValue("@Name", Path.GetFileName(FileUpload1.PostedFile.FileName));
                    //cmd.Parameters.AddWithValue("@ContentType", "image/jpg");
                    //cmd.Parameters.AddWithValue("@Data", bytes);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        if ((FileUpload2.PostedFile != null) && (FileUpload2.PostedFile.ContentLength > 0))
        {
            string filename = Path.GetFileName(FileUpload2.PostedFile.FileName);
            string contentType = FileUpload2.PostedFile.ContentType;
            using (Stream fs = FileUpload2.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);

                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        string query = "Update app set fname='" + filename + "', ctype='" + contentType + "', data=@data where appid='" + TextBox1.Text + "'";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            //cmd.Parameters.AddWithValue("@f3", filename);
                            //cmd.Parameters.AddWithValue("@c3", contentType);
                            cmd.Parameters.AddWithValue("@data", bytes);

                            //cmd.Parameters.AddWithValue("@Duration", TextBox2.Text);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Response.Redirect(Request.Url.AbsoluteUri);
                        }
                    }
                }
            }
        }
    }
}