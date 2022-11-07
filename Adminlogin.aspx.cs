using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Adminlogin : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ct.Username = TextBox1.Text;
        ct.Password = TextBox2.Text;
        DataTable dt = ct.adminlogin();
        if (dt.Rows.Count > 0)
        {
            Response.Redirect("adminhome.aspx");
        }
    }
}