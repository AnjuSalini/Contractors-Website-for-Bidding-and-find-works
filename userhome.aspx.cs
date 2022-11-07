using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class userhome : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Response.Write("Welcome" + Session["uname"].ToString());
            cl.UserId = Session["uname"].ToString();
           DataList1.DataSource= cl.userdetailsfetch();
           DataList1.DataBind();
            
        }
    }
    //protected void LinkButton2_Click(object sender, EventArgs e)
    //{

    //}
   
}