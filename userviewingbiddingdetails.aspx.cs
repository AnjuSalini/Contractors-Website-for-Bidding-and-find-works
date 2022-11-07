using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class userviewingbiddingdetails : System.Web.UI.Page
{
    Clscontractor ct = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ct.UserId = Session["uname"].ToString();
            DataTable dt = ct.userviewquote();
            if (dt.Rows.Count == 0)
            {
                //divGrid.Visible = false;
                GridView1.Visible = false;
                Label1.Visible = false;
                Label3.Text = "There have no Contactor Request";
                Label2.Visible = false;
                TextBox1.Visible = false;
                Button1.Visible = false;

            }
            else
            {
                //divGrid.Visible = true;
                Label1.Visible = true;
                GridView1.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ct.ContractorID = TextBox1.Text;

        ct.UserId = Session["uname"].ToString();
        DataTable dt3 = ct.userdetailsfetch();

        ct.Username = dt3.Rows[0][1].ToString();
        ct.Contactno = dt3.Rows[0][4].ToString();
        ct.Email = dt3.Rows[0][3].ToString();


        ct.insertrequestapprovedbyusertable();
        Label1.Visible = true;
        Label1.Text = "Requested";
        DataTable dt = ct.userviewquote();
        if (dt.Rows.Count == 0)
        {
            //divGrid.Visible = false;
            GridView1.Visible = false;
            Label2.Visible = true;
            Label3.Visible = false;
            Label1.Visible = false;
            Label3.Text = "There have no Contactor Request";
            TextBox1.Visible = false;

            Button1.Visible = false;

        }
        else
        {
            //divGrid.Visible = true;
            GridView1.Visible = true;

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        //TextBox1.Text = "";
        Response.Redirect("Useraddingavailabledatespage.aspx?contractorid="+ct.ContractorID+"");
        
    }
}