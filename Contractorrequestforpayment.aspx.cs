using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Contractorrequestforpayment : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
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
        cl.ContractorID = Session["cname"].ToString();
        DataTable dt = cl.selectuserfromquoterequesttable();
        cl.UserId = dt.Rows[0][2].ToString();
        cl.Username = dt.Rows[0][3].ToString();
      
        cl.ContractorName = TextBox1.Text;
        cl.date = DropDownList1.SelectedItem.Text + "/" + DropDownList2.SelectedItem.Text + "/" + DropDownList3.SelectedItem.Text;
        cl.price = TextBox2.Text;
        cl.requestamountbycontractor();
    }
}