using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
    
    DataTable dt, dt1, dt2 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cl.Username = txtUsername.Text;
        cl.Password = txtPassword.Text;

        dt = cl.logincontractor();
        dt1 = cl.loginuser();
        if (dt.Rows.Count > 0)
        {

            Session["cname"] = dt.Rows[0][0].ToString();
            Response.Redirect("ContractorHome.aspx");
        }

        if (dt1.Rows.Count > 0)
        {
            Session["uname"] = dt1.Rows[0][0].ToString();
            Response.Redirect("Userhome.aspx");
        }
        
    }
}