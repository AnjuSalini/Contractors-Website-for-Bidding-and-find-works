using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class contractordetails : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           cl.ContractorID = Request.QueryString["contractorid"].ToString();
           GridView1.DataSource = cl.contractordetailsforuser();
           GridView1.DataBind();
        }
    }
}