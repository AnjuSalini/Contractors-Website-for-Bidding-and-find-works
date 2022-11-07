using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Useraddingavailabledatespage : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox6.Text = Request.QueryString["contractorid"].ToString();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        ct.contractorid = TextBox6.Text;
        ct.UserId = Session["uname"].ToString();
        ct.Address = TextBox1.Text;
        ct.Contactno = TextBox2.Text;
        ct.landmark = TextBox3.Text;
        ct.from = TextBox4.Text;
        ct.to = TextBox5.Text;
        ct.additionalinfo();

    }
}