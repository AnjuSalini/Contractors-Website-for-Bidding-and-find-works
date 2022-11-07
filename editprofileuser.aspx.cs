using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class editprofileuser : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cl.UserId = Session["uname"].ToString();
        cl.Username = TextBox1.Text;
        cl.changeusername();
        TextBox1.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        cl.UserId = Session["uname"].ToString();
        cl.Address = TextBox2.Text;
        cl.changeaddress();
        TextBox2.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        cl.UserId = Session["uname"].ToString();
        cl.Email = TextBox3.Text;
        cl.changeemail();
        TextBox3.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        cl.UserId = Session["uname"].ToString();
        cl.Contactno = TextBox4.Text;
        cl.changemobilenumber();
        TextBox4.Text = "";
    }
}