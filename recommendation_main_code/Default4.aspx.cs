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
using System.Xml;

public partial class Default4 : System.Web.UI.Page
{
    String constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    string rate = "";
    int violence_count = 0;
    int vulgar_count = 0;
    int hate_count = 0;
    int sex_count = 0;
    int others_count = 0;
    int offensive_count = 0;
    int vicount = 0, vucount = 0, hcount = 0, scount = 0, otcount = 0, offcount = 0;

    string[] violence=new string[100];
    string[] vulgar=new string[100];
    string[] hate=new string[100];
    string[] sexual=new string[100];
    string[] offensive=new string[100];
    string[] others=new string[100];
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
    protected void Button1_Click(object sender, EventArgs e)
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
            XmlDocument doc = new XmlDocument();
            XmlDocument vuldoc1 = new XmlDocument();
            XmlDocument hatedoc2 = new XmlDocument();
            XmlDocument sexdoc3 = new XmlDocument();
            XmlDocument offdoc4 = new XmlDocument();
            //XmlDocument otherdoc5 = new XmlDocument();

            doc.Load(Server.MapPath(@"~/xmldoc/good.xml"));
            vuldoc1.Load(Server.MapPath(@"~/xmldoc/exc.xml"));
            hatedoc2.Load(Server.MapPath(@"~/xmldoc/bad.xml"));
            sexdoc3.Load(Server.MapPath(@"~/xmldoc/avg.xml"));
            offdoc4.Load(Server.MapPath(@"~/xmldoc/poor.xml"));
            //otherdoc5.Load(Server.MapPath(@"~/xmldoc/others.xml"));

            try
            {
                XmlNodeList xmlNL = doc.GetElementsByTagName("words");
                XmlNodeList xmlvul = vuldoc1.GetElementsByTagName("words");
                XmlNodeList xmlhate = hatedoc2.GetElementsByTagName("words");
                XmlNodeList xmlsex = sexdoc3.GetElementsByTagName("words");
                XmlNodeList xmloff = offdoc4.GetElementsByTagName("words");
                //XmlNodeList xmlother = otherdoc5.GetElementsByTagName("words");

                vicount = Convert.ToInt32(xmlNL.Count);
                vucount = Convert.ToInt32(xmlvul.Count);
                hcount = Convert.ToInt32(xmlhate.Count);
                scount = Convert.ToInt32(xmlsex.Count);
                //otcount = Convert.ToInt32(xmlother.Count);
                offcount = Convert.ToInt32(xmloff.Count);

                for (int a = 0; a < vicount; a++)
                {
                    XmlNode dele = doc.SelectSingleNode("/good/words[@id='" + a + "']");
                    violence[a] = dele.Attributes["word"].Value;
                }

                for (int a = 0; a < vucount; a++)
                {
                    XmlNode dele = vuldoc1.SelectSingleNode("/exc/words[@id='" + a + "']");
                    vulgar[a] = dele.Attributes["word"].Value;
                }

                for (int a = 0; a < hcount; a++)
                {
                    XmlNode dele = hatedoc2.SelectSingleNode("/bad/words[@id='" + a + "']");
                    hate[a] = dele.Attributes["word"].Value;
                }

                for (int a = 0; a < scount; a++)
                {
                    XmlNode dele = sexdoc3.SelectSingleNode("/avg/words[@id='" + a + "']");
                    sexual[a] = dele.Attributes["word"].Value;
                }

                for (int a = 0; a < offcount; a++)
                {
                    XmlNode dele = offdoc4.SelectSingleNode("/poor/words[@id='" + a + "']");
                    offensive[a] = dele.Attributes["word"].Value;
                }
            }
            catch (Exception ex)
            {

            }

            string originalstr = TextBox6.Text.ToString();
            string[] words = originalstr.Split(' ');
            foreach (string word1 in words)
            {
                string word = word1.ToUpper().ToString();
                for (int i = 0; i < vicount; i++)
                {
                    string str1 = violence[i].ToUpper().ToString();
                    if (word.Equals(violence[i].ToUpper().ToString()))
                    {
                        violence_count++;
                    }

                }

                for (int i = 0; i < vucount; i++)
                {
                    if (word.Equals(vulgar[i].ToUpper().ToString()))
                    {
                        vulgar_count++;
                    }

                }

                for (int i = 0; i < hcount; i++)
                {
                    if (word.Equals(hate[i].ToUpper().ToString()))
                    {
                        hate_count++;
                    }

                }

                for (int i = 0; i < scount; i++)
                {
                    if (word.Equals(sexual[i].ToUpper().ToString()))
                    {
                        sex_count++;
                    }

                }

                for (int i = 0; i < otcount; i++)
                {
                    if (word.Equals(others[i].ToUpper().ToString()))
                    {
                        others_count++;
                    }

                }
                for (int i = 0; i < offcount; i++)
                {
                    if (word.Equals(offensive[i].ToUpper().ToString()))
                    {
                        offensive_count++;
                    }

                }

            }
            if (violence_count == 0 && vulgar_count == 0 && hate_count == 0 && sex_count == 0 && others_count == 0 && offensive_count == 0)
            {
                string message = "Chage your Sentance!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

            }
            else if (violence_count > 0)
            {
                rate = "4";
                this.yes();
            }
            else if (vulgar_count > 0)
            {
                rate = "5";
                this.yes();
            }
            else if (hate_count > 0)
            {
                rate = "1";
                this.yes();
            }
            else if (sex_count > 0)
            {
                rate = "3";
                this.yes();
            }
            else if (offensive_count > 0)
            {
                rate = "2";
                this.yes();
            }

        }
    }
        


    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}