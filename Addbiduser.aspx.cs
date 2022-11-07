using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Addbiduser : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList3.DataSource = ct.paintfetch();
            DropDownList3.DataTextField = "paintname";
            DropDownList3.DataValueField = "pid";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, "--select--");
            DropDownList4.DataSource = ct.basementfetch();
            DropDownList4.DataTextField = "basementname";
            DropDownList4.DataValueField = "bid";
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, "--select--");

            DropDownList1.Items.Insert(0, "--select--");
            DropDownList1.DataSource = ct.floorfetch();
            DropDownList1.DataValueField = "fid";
            DropDownList1.DataTextField = "floorname";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select--");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ct.UserId = Session["uname"].ToString();
        DataTable dt = ct.userrdetailsfetch();
        ct.Status = "Pending";
        ct.Username = dt.Rows[0][1].ToString();
        ct.Address = dt.Rows[0][2].ToString();
        ct.Email = dt.Rows[0][3].ToString();
        ct.Contactno = dt.Rows[0][4].ToString();
        ct.type = TextBox1.Text;
        ct.budget = TextBox2.Text;
        ct.daysneeded = TextBox3.Text;
        ct.place = TextBox4.Text;

        ct.floor = DropDownList1.SelectedItem.Text;
        ct.floortype = DropDownList2.SelectedItem.Text;
        ct.basement = DropDownList4.SelectedItem.Text;
        ct.paint = DropDownList3.SelectedItem.Text;
        ct.requirementsuserinsert();

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ct.floor = DropDownList1.SelectedItem.Value.ToString();
        DataTable dt = ct.floortypefetch();
        DropDownList2.DataSource = dt;
        DropDownList2.DataValueField = "tid";
        DropDownList2.DataTextField = "tname";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "--select--");
        
    }
}