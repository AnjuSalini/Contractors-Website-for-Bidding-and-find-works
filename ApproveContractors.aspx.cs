using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class ApproveContractors : System.Web.UI.Page
{
    clsadmin admin = new clsadmin();
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        dt = admin.selContractorApproval();
        if (dt.Rows.Count == 0)
        {
           
            gvData.Visible = false;
            lblApprvd.Visible = true;
            lblApprvd.Text = "There have no Contactor Request";
            TextBox1.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            txtId.Visible = false;
            btnApprove.Visible = false;
            lblApprvd.Visible = true;
        }
        else
        {
           
            gvData.Visible = true;
            gvData.DataSource = dt;
            gvData.DataBind();
        }

    }
    protected void gvData_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtId.Text = gvData.SelectedRow.Cells[1].Text;
       TextBox1.Text=gvData.SelectedRow.Cells[5].Text;
    }
    protected void btnApprove_Click(object sender, EventArgs e)
    {
        admin.ContractorID = Convert.ToInt16(txtId.Text);
        admin.ApproveContactor();
        lblApprvd.Visible = true;
        lblApprvd.Text = "Approved";
        dt = admin.selContractorApproval();
        if (dt.Rows.Count == 0)
        {
           
            gvData.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            lblmsg.Visible = true;
            lblApprvd.Visible = false;
            lblmsg.Text = "There have no Contactor Request";
            TextBox1.Visible = false;
            txtId.Visible = false;
            btnApprove.Visible = false;

        }
        else
        {
           
            gvData.Visible = true;
            gvData.DataSource = dt;
            gvData.DataBind();
        }
        //txtId.Text = "";
    //    string toAddress = TextBox1.Text;
    //    string fromAddress = "sample@gmail.com";//give a created gmail address 
    //    const string fromPassword = "4email";//give password
    //    string subj = "Hi, Your account is approved";
    //    string body = "";
    //    Label1.Text = "User is Approved";
    //    var smtp = new System.Net.Mail.SmtpClient();
    //    {
    //        smtp.Host = "smtp.gmail.com";
    //        smtp.Port = 587;
    //        smtp.EnableSsl = true;
    //        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
    //        smtp.Credentials = new System.Net.NetworkCredential(fromAddress, fromPassword);
    //        smtp.Timeout = 20000;
    //}
    //    smtp.Send(fromAddress, toAddress, subj, body);
    }
    
  
}