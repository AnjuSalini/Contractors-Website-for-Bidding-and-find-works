using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for Clslogin
/// </summary>
public class Clslogin
{
    string qry = "";
    ClsConnection objCon = new ClsConnection();
    DataTable dt = new DataTable();
    public string Fullname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Mobile { get; set; }
    public string EmailId { get; set; }
    public string Status { get; set; }
    public void insRegister()
    {
     
         objCon.xnon("INSERT INTO tblUser(Name,Username,Password,Address,MobileNo,Email,Status) VALUES('" + Fullname + "' , '" + Username + "' ,'" + Password + "', '" + Address + "' , '" + Mobile + "' , '" + EmailId + "','" + Status + "')");

            

      
    }
    public DataTable selOwnerByUname()
    {
        qry = "SELECT * FROM tblUser WHERE Username = '" + Username + "'";
        dt = objCon.xdata(qry);
        return dt;
    }
}