using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Userviewworkdetails : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            ct.UserId = Session["uname"].ToString();
            GridView1.DataSource = ct.workfetch();
            GridView1.DataBind();
        }
    }
}