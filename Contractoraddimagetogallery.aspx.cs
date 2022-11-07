using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Contractoraddimagetogallery : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ct.WorkImage = "~/Contractorworkpic/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath("~/Contractorworkpic/" + FileUpload1.FileName));
        ct.insertgalleryuser();
    }
}