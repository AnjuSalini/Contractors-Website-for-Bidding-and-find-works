using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class adddaybydaypage : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Insert(0, "--dd--");
            for (int i = 1; i <= 31; i++)
            {
                DropDownList1.Items.Add(i.ToString());
            }
            DropDownList3.Items.Insert(0, "--yy--");
            for (int j = 2017; j < 2030; j++)
            {
                DropDownList3.Items.Add(j.ToString());
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ct.ContractorID = Session["cname"].ToString();
        DataTable dt = ct.contractordetailsfetch();
        ct.ContractorName = dt.Rows[0][1].ToString();
        ct.date = DropDownList1.SelectedItem.Text + "/" + DropDownList2.SelectedItem.Text + "/" + DropDownList3.SelectedItem.Text;
        ct.fileimage = "~/daybydayworksfiles/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath("~/daybydayworksfiles/" + FileUpload1.FileName));
        ct.insertworkday();
        Label1.Visible = true;
    }
}