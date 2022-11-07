using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class ContractorViewRequest : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            Response.Write("Welcome" + Session["cname"].ToString());
            DataTable dt = ct.biddatafetch();
            if (dt.Rows.Count == 0)
            {
                //divGrid.Visible = false;
                GridView1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "There have no Request for you";


            }
            else
            {
                //divGrid.Visible = true;

                GridView1.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
    }
}