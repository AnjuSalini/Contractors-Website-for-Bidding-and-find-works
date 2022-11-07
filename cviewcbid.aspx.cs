using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class cviewcbid : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ct.contractorbidtablefetch();
        if (!IsPostBack)
        {
            if (dt.Rows.Count == 0)
            {
                Label1.Visible = true;
            }
            else
            {
                GridView1.DataSource = ct.contractorbidtablefetch();
                GridView1.DataBind();
            }
        }
    }
}