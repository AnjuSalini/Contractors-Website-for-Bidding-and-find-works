using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class viewcontractorsbyuser : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    GridView1.DataSource = ct.contractorfetch(); ;
        //    GridView1.DataBind();
        //}
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ct.Rating = TextBox1.Text;
        GridView1.DataSource = ct.feedbacktablefetch();
        GridView1.DataBind();
    }
}