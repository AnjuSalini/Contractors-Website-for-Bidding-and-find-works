using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Adminviewcomplaints : System.Web.UI.Page
{
    clsadmin admin = new clsadmin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = admin.userfeedbackfetch();
            GridView1.DataBind();
        }
    }
}