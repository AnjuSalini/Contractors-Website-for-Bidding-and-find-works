using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Contractorsaddbidbasedonprice : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string s = Request.QueryString["userid"].ToString();
            TextBox1.Text = s;


        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ct.UserId = TextBox1.Text;

        ct.ContractorID = Session["cname"].ToString();
        ct.ContractorName = TextBox2.Text;
        ct.Address = TextBox3.Text;
        ct.workname = TextBox4.Text;
        ct.price = TextBox5.Text;
        ct.Description = TextBox6.Text;
        ct.Status = "pending";
        ct.contractorbidinsert();

    }
}