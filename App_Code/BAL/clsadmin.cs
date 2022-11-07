using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for clsadmin
/// </summary>
public class clsadmin
{
    string qry = "";
    ClsConnection objCon = new ClsConnection();
    DataTable dt = new DataTable();
    public int ContractorID{get;set;}
    public int UserID{get;set;}
    public string ContractorName { get; set; }
    public string Address { get; set; }
    public string Contactno { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Status { get; set; }
    public string date { get; set; }
    public string price { get; set; }
    public string dd { get; set; }
    public string id { get; set; }

	public clsadmin()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable selContractorApproval()
    {
        qry = "SELECT * FROM contractorregistertable WHERE status = 'Pending'";
        dt = objCon.xdata(qry);
        return dt;
    }
    public void ApproveContactor()
    {
        qry = " UPDATE contractorregistertable SET status='Approved' WHERE contractorrid=" + ContractorID + "";
        objCon.xnon(qry);
    }
    public DataTable selUserApproval()
    {
        qry = "SELECT * FROM userregistertable WHERE status = 'Pending'";
        dt = objCon.xdata(qry);
        return dt;
    }
    public void ApproveUser()
    {
        qry = " UPDATE userregistertable SET status='Approved' WHERE userrid=" + UserID + "";
        objCon.xnon(qry);
    }
    public DataTable amountrequesttabledatafetch()
    {
        DataTable dt = objCon.xdata("select * from amountrequesttable ");
        return dt;
    }
    public DataTable adminviewingdd()
    {
        DataTable dt = objCon.xdata("select * from ddtable ");
        return dt;
    }
    public DataTable downloaddd()
    {
        DataTable dt = objCon.xdata("select * from ddtable where id='"+id+"' ");
        return dt;
    }
    public DataTable userfeedbackfetch()
    {
        DataTable dt = objCon.xdata("select * from userfeedbacktable ");
        return dt;
    }
  
}