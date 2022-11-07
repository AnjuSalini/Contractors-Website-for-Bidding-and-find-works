using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Ownerregistration : System.Web.UI.Page
{
    Clscontractor user = new Clscontractor();
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        user.ContractorName = txtFullName.Text;
        user.Address = txtAddress.Text;
        user.Email = txtEmail.Text;
        user.Contactno = txtMobile.Text;
        user.Username = txtUsername.Text;
        user.Password = txtPassword.Text;
        user.Status = "Pending";
        lblMsg.Visible = true;
        user.userresgister();
        txtFullName.Text = "";
        txtUsername.Text = "";
        txtPassword.Text = "";
        txtConfirmPassword.Text = "";
        txtMobile.Text = "";
        txtEmail.Text = "";
        txtAddress.Text = "";

    }
    protected void txtUsername_TextChanged(object sender, EventArgs e)
    {
        user.Username = txtUsername.Text.Trim();
        dt = user.selOwnerByUname();
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
}