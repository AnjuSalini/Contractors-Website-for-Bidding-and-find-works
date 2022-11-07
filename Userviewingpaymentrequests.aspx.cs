using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Userviewingpaymentrequests : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cl.UserId = Session["uname"].ToString();
            DataTable dt = cl.contractorrequestamountfetch();
            if (dt.Rows.Count == 0)
            {
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                FileUpload1.Visible = false;
                Label1.Visible = true;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Button1.Visible = false;
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
        TextBox3.Text = GridView1.SelectedRow.Cells[2].Text;
        TextBox4.Text = GridView1.SelectedRow.Cells[3].Text;
        TextBox5.Text = GridView1.SelectedRow.Cells[4].Text;
        TextBox6.Text = GridView1.SelectedRow.Cells[5].Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cl.UserId = Session["uname"].ToString();
        cl.Username = TextBox2.Text;
        cl.ContractorID = TextBox3.Text;
        cl.ContractorName = TextBox4.Text;
        cl.date = TextBox5.Text;
        cl.price = TextBox6.Text;
        cl.WorkImage = "~/DD/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath("~/DD/" + FileUpload1.FileName));
        cl.insertddtable();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
}