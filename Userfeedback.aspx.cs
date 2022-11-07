using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Userfeedback : System.Web.UI.Page
{
    Clscontractor cl = new Clscontractor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Insert(0, "--select--");
            DropDownList1.DataSource = cl.contractornamefordropdown();
            DropDownList1.DataTextField = "fullname";
            DropDownList1.DataBind();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cl.UserId = Session["uname"].ToString();
        cl.Username = TextBox1.Text;
        DataTable dt = cl.contractorfetch();
        cl.ContractorID = dt.Rows[0][0].ToString();
        cl.ContractorName = DropDownList1.SelectedItem.Text;
        cl.Feedback = TextBox3.Text;
        cl.Rating = ImageButton1.AlternateText + ImageButton2.AlternateText + ImageButton3.AlternateText + ImageButton4.AlternateText + ImageButton5.AlternateText;
        cl.usergalleryimagetable();
        TextBox1.Text = "";
        //DropDownList1.ClearSelection();
        TextBox3.Text = "";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton1.AlternateText = "1";
        Label1.Visible = true;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton2.AlternateText = "2";
        Label1.Visible = true;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton3.AlternateText = "3";
        Label1.Visible = true;
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton4.AlternateText = "4";
        Label1.Visible = true;
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton5.AlternateText = "5";
        Label1.Visible = true;
    }
}