using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Adminviewamountrequest : System.Web.UI.Page
{
    clsadmin admin = new clsadmin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = admin.amountrequesttabledatafetch();
            GridView1.DataBind();
        }
    }
}