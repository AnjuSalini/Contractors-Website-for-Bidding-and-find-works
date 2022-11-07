using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class ViewAgreement : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ct.UserId = Session["uname"].ToString();

            DataTable dt = ct.userviewagreement();
            GridView1.DataSource = dt;
            GridView1.DataBind();
            if (dt.Rows.Count == 0)
            {
                GridView1.Visible = false;
                Label1.Visible = true;
            }
            else
            {
                GridView1.Visible = true;

            }
        }
    }
}