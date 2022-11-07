using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for businesslogic
/// </summary>
public class businesslogic
{
    ClsConnection obj = new ClsConnection();
    DataTable dt = new DataTable();
    public string Username;
    public string Userpassword;
    string qry = "";
  
	public businesslogic()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable selUserLogin()
    {
        dt = obj.xdata("SELECT *  FROM tblUser WHERE Username = '" + Username + "' AND Password = '" + Userpassword + "' AND Status='Aprroved'");
       
        return dt;
    }
    public DataTable Selcontractor()
    {
        dt = obj.xdata("select * from tblContractor where Username='" + Username + "' and Password='" + Userpassword + "' and Status='Approved'");
        return dt;
    }
    public DataTable selClients()
    {
        qry = "SELECT id,Name FROM tblUser";
        dt = obj.xdata(qry);
        return dt;

    }
    
}