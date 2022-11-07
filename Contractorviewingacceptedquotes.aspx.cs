using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Contractorviewingacceptedquotes : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cl.contractorid = Session["cname"].ToString();
            GridView2.DataSource = cl.additionalinfofetchtocontractor();
            GridView2.DataBind();
           
            DataTable dt = cl.contractorviewquote();
            if (dt.Rows.Count == 0)
            {
                Label3.Visible = false;
                Label4.Visible = false;
                
                
                GridView1.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                FileUpload1.Visible = false;
                Button1.Visible = false;
                Label1.Visible = true;
                Label2.Visible = false;
                Label5.Visible = false;
                
            }
            else
            {
               
                Label3.Visible = true;
                Label4.Visible = true;
                
                Label1.Visible = false;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                FileUpload1.Visible = true;
                Button1.Visible = true;
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
        cl.UserId = TextBox1.Text;
        cl.Username = TextBox2.Text;
        cl.contractorid = Session["cname"].ToString();
        DataTable dt3 = cl.contractordetailsfetch();

        cl.ContractorName = dt3.Rows[0][1].ToString();
        cl.Contactno = dt3.Rows[0][4].ToString();
        cl.Email = dt3.Rows[0][3].ToString();

        cl.Agreement = "~/Agreementimage/" + FileUpload1.FileName;
        FileUpload1.SaveAs(Server.MapPath("~/Agreementimage/" + FileUpload1.FileName));
        cl.agreementuploadtableinsert();

        DataTable dt = cl.contractorviewquote();
        if (dt.Rows.Count == 0)
        {
           
            GridView1.Visible = false;


            TextBox1.Visible = false;

            Button1.Visible = false;

        }
        else
        {
           
            GridView1.Visible = true;

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
}