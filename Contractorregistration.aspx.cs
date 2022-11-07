using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Contractorregistration : System.Web.UI.Page
{
    Clscontractor contractor = new Clscontractor();
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtUsername_TextChanged(object sender, EventArgs e)
    {
        contractor.Username = txtUsername.Text.Trim();
        dt = contractor.selContractorByUname();
        if (dt.Rows.Count > 0)
        {
            lblUname.Visible = true;
            lblUname.Text = "Username Already Exist. Please Enter New One...";
            txtUsername.Text = "";
            txtUsername.Focus();
        }
        else
        {
            lblUname.Visible = true;
            lblUname.Text = "";
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        contractor.ContractorName = txtFullName.Text;
        contractor.Address = txtAddress.Text;
        contractor.Email = txtEmail.Text;
        contractor.Contactno = txtMobile.Text;
        contractor.Username = txtUsername.Text;
        contractor.Password = txtPassword.Text;
        contractor.Status = "Pending";
        lblMsg.Visible = true;
        contractor.contractorresgister();
        txtFullName.Text = "";
        txtUsername.Text = "";
        txtPassword.Text = "";
        txtConfirmPassword.Text = "";
        txtMobile.Text = "";
        txtEmail.Text = "";
        txtAddress.Text = "";
    }
}