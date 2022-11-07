using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Adminviewingdd : System.Web.UI.Page
{
    clsadmin admin = new clsadmin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = admin.adminviewingdd();
            GridView1.DataBind();

        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        admin.id = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        DataTable dt = admin.downloaddd();
        string dd = dt.Rows[0][7].ToString();
        Response.ContentType = "Application/Octet-Stream";
        Response.AppendHeader("Content-Disposition", "Attachment;Filename=" + dd);
        Server.MapPath("~/DD/" + dd);
        Response.TransmitFile(Server.MapPath(dd));
        Response.End();
    }
}