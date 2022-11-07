using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Adminaddmarketdetails : System.Web.UI.Page
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
        ct.cement = TextBox1.Text;
        ct.sand = TextBox2.Text;
        ct.bricks = TextBox3.Text;
        ct.stone = TextBox4.Text;
        ct.steel = TextBox5.Text;
        ct.date = DropDownList1.SelectedItem.Text + "/" + DropDownList2.SelectedItem.Text + "/" + DropDownList3.SelectedItem.Text;
        ct.adminmarketinsert();
    }
}