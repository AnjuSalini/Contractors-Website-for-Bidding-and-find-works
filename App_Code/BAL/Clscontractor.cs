using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Clscontractor
/// </summary>
public class Clscontractor
{
    string qry = "";
    ClsConnection objCon = new ClsConnection();
    
    DataTable dt = new DataTable();
    public int Id { get; set; }
    public int WorkID { get; set; }
    public string UserId { get; set; }
    public string workname { get; set; }
    public string daysneeded{get;set;}
    public string price { get; set; }
    public string ContractorName { get; set; }
    public string Address { get; set; }
    public string Contactno { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Feedback { get; set; }
    public string Password { get; set; }
    public string Status { get; set; }
    public string Description { get; set; }
    public string WorkImage { get; set; }
    public string imageformat { get; set; }
    public string contractorid { get; set; }
    public string fileimage { get; set; }
    public string ContractorID { get; set; }
    public string type { get; set; }
    public string budget { get; set; }
    public string date { get; set; }
    public string floor { get; set; }
    public string floortype{ get; set; }
    public string paint { get; set; }
    public string painttype { get; set; }
    public string basement { get; set; }
    public string place { get; set; }
    public string landmark { get; set; }
    public string star1 { get; set; }
    public string star2 { get; set; }
    public string star3 { get; set; }
    public string star4 { get; set; }
    public string star5 { get; set; }
    public string Rating { get; set; }
    public string cement { get; set; }
    public string steel { get; set; }
    public string bricks { get; set; }
    public string sand { get; set; }
    public string from{ get; set; }
    public string to { get; set; }
    public string stone { get; set; }
    public string Agreement { get; set; }
    public string RequirementId{ get; set; }
	public Clscontractor()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void insContractorinfo()
    {

        objCon.xnon("INSERT INTO tblContractor(Contractorname,Address,ContactNo,Email,Username,Password,Status) VALUES('" + ContractorName + "' , '" + Address + "' , '" + Contactno + "' , '" + Email + "' ,'" + Username + "' ,'" + Password + "','" + Status + "')");

    }
    public DataTable selContractorByUname()
    {
        
        qry = "SELECT * FROM contractorlogintable WHERE Username = '" + Username + "'";
        dt = objCon.xdata(qry);
        return dt;
    }
    public DataTable selContractor()
    {
        qry = "SELECT fullname,address,email,mobileno FROM contractorregistertable WHERE fullname = '" + ContractorName + "' ";
        dt = objCon.xdata(qry);
        return dt;
    }
    public void insWorkImageInfo()
    {
       // objCon.ins_upt_del_Qry("INSERT INTO tblContractor(Contractorname,Address,ContactNo,Email,Username,Password,Status) VALUES('" + ContractorName + "' , '" + Address + "' , '" + Contactno + "' , '" + Email + "' ,'" + Username + "' ,'" + Password + "','" + Status + "')");

        objCon.xnon("INSERT INTO tblcontractorwork(Description,Workimage,cid,Contractorname,Address,ContactNo) VALUES('" + Description + "' , '" + WorkImage + "' , " + ContractorID + " , '" + ContractorName + "' , '" + Address + "', '" + Contactno + "')");
 
    }

    public DataSet selContractorImages()
    {
        SqlConnection con = new SqlConnection(@"Data Source=SP-PC\SQLEXPRESS;Initial Catalog=Buildingconstruction;User ID=sa;Password=admin123*");
        SqlDataAdapter da = new SqlDataAdapter("select * from tblcontractorwork", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataTable selWorkInfo()
    {
        qry = "SELECT * FROM tblcontractorwork WHERE id = "+ WorkID  + " ";
        dt = objCon.xdata(qry);
        return dt;
    }
    public void inReqImageInfo()
    {
        // objCon.ins_upt_del_Qry("INSERT INTO tblContractor(Contractorname,Address,ContactNo,Email,Username,Password,Status) VALUES('" + ContractorName + "' , '" + Address + "' , '" + Contactno + "' , '" + Email + "' ,'" + Username + "' ,'" + Password + "','" + Status + "')");

        objCon.xnon("INSERT INTO tblcontractorwork(Description,Workimage,ContractorID,Contractorname,Address,ContactNo) VALUES('" + Description + "' , '" + WorkImage + "' , " + ContractorID + " , '" + ContractorName + "' , '" + Address + "', '" + Contactno + "')");

    }
    public DataTable logincontractor()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select * from contractorlogintable where username='" + Username + "'and password='" + Password + "'");

        return dt;
        
    }
    //public DataTable logincontractor1()
    //{
    //    DataTable dt1 = new DataTable();
    //    dt1 = objCon.xdata("select * from contractorregistertable where status='Approved'");
    //    return dt1;
    //}
    public void contractorresgister()
    {
        object x = objCon.xscalar("insert into contractorlogintable values('" + Username + "' ,'" + Password + "')select @@identity");
        objCon.xnon("insert into contractorregistertable values('" + ContractorName + "','" + Address + "','" + Email + "','" + Contactno + "','" + Status + "','" + Convert.ToInt32(x).ToString() + "')");
    }
    public DataTable selOwnerByUname()
    {
        qry = "SELECT * FROM userlogintable WHERE Username = '" + Username + "'";
        dt = objCon.xdata(qry);
        return dt;
    }
    public void userresgister()
    {
        object x = objCon.xscalar("insert into userlogintable values('" + Username + "' ,'" + Password + "')select @@identity");
        objCon.xnon("insert into userregistertable values('" + ContractorName + "','" + Address + "','" + Email + "','" + Contactno + "','" + Status + "','" + Convert.ToInt32(x).ToString() + "')");
    }
    public DataTable loginuser()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select * from userlogintable where username='" + Username + "' and password='" + Password + "' ");
        return dt;
    }
    public void insertworkdetails()
    {
        objCon.xnon("insert into tblcontractorwork values('"+Description+"','"+WorkImage+"','"+ContractorName+"','"+ContractorID+"')");
    }
    public DataTable fetchcontractordetails()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select * from contractorregistertable where email='"+Email+"'");
        return dt;
    }
    public DataTable workfetch()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select * from daybydaytable where Id='"+UserId+"'");
        return dt;
    }
    public DataTable contractorfetch()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select * from contractorregistertable");
        return dt;
    }
    public void insertworkday()
    {
        objCon.xnon("insert into daybydaytable values('"+ContractorName+"','"+date+"','"+fileimage+"','"+ContractorID+"')");
    }
    public void ongoingwork()
    {
        objCon.xnon("insert into ongoingworktable values('"+workname+"','"+date+"','"+daysneeded+"','"+ContractorName+"','"+ContractorID+"')");
    }
    public DataTable contractordetailsfetch()
    {
       DataTable dt=objCon.xdata("select * from contractorregistertable where contractorlid='" +contractorid+ "'");
       return dt;
    }
    public void insertcompletedworks()
    {
        objCon.xnon("insert into completedworkstable values('"+ContractorName+"','"+workname+"','"+price+"','"+daysneeded+"','"+ContractorID+"')");
    }
    public void requirementsuserinsert()
    {
        objCon.xnon("insert into userrequirementstable values('"+type+"','"+budget+"','"+daysneeded+"','"+place+"','"+Username+"','"+Address+"','"+Email+"','"+Contactno+"','"+floor+"','"+floortype+"','"+paint+"','"+basement+"','"+Status+"','"+UserId+"')");
    }
    public DataTable userrdetailsfetch()
    {
        DataTable dt = objCon.xdata("select * from userregistertable where userlid='" + UserId + "'");
        return dt;
    }
    public void insertgalleryuser()
    {
        objCon.xnon("insert into usergalleryimagetable values('"+WorkImage+"')");
    }
    public DataTable adminlogin()
    {
        DataTable dt=objCon.xdata("select * from adminlogintable where username='"+Username+"'and password='"+Password+"'");
        return dt;
    }
    public DataTable userrequirementfetch()
    {
        DataTable dt = objCon.xdata("select * from userrequirementstable");
        return dt;
    }
    public void requestbid()
    {
        qry = " UPDATE userrequirementstable SET status='Requested' WHERE Id=" + UserId + "";
       
        objCon.xnon(qry);
      
    }
//    public void insertbid()
//    {
//objCon.xnon("
//    }
    public DataTable biddatafetch()
    {
        qry = "SELECT * FROM userrequirementstable WHERE newstatus = 'Pending'";
        dt = objCon.xdata(qry);
        return dt;
    }
    public void insertrequestquotetable()
    {
        objCon.xnon( "insert into requestquotetable values('" + contractorid+ "','" + UserId + "','" + ContractorName + "','" + Contactno + "','" + Email + "','Requested')");
    }
    public void approvebid()
    {
        objCon.xnon( " UPDATE requestquotetable SET status='Requested' WHERE Id='" + UserId + "'");
    }
    public DataTable userdetailsfetch()
    {
        DataTable dt = objCon.xdata("select * from userregistertable where userlid='" + UserId + "'");
        return dt;
    }
    public void insertrequestapprovedbyusertable()
    {
        objCon.xnon("insert into useracceptedrequesttable values('" + ContractorID+ "','" + UserId + "','" + Username + "','" + Contactno + "','" + Email + "','Accepted')");
        objCon.xnon("update userrequirementstable set newstatus='Approved' where userid='"+UserId+"'");
        objCon.xnon("update contractorsbidtable set status='Approved' where userid='" + UserId + "'");
    }
    public DataTable userviewquote()
    {
        DataTable dt = objCon.xdata("select * from contractorsbidtable where userid='"+UserId+"' and status='pending'");
        return dt;
    }
    public DataTable contractorviewquote()
    {
        DataTable dt = objCon.xdata("select * from useracceptedrequesttable where contractorid='" + contractorid + "'");
        return dt;
    }
    public void agreementuploadtableinsert()
    {

        objCon.xnon("insert into agreementtable values('" + contractorid + "','" + ContractorName + "','" + UserId + "','" + Username + "','" + Email + "','"+Contactno+"','"+Agreement+"')");
    }
    public DataTable userviewagreement()
    {
        DataTable dt = objCon.xdata("select * from agreementtable where userid='" + UserId + "'");
        return dt;
    }
    public DataTable usergalleryimagetablefetch()
    {
        DataTable dt = objCon.xdata("select * from usergalleryimagetable");
        return dt;
    }
    public DataTable usergalleryimagetable()
    {
        DataTable dt = objCon.xdata("insert into userfeedbacktable values('"+Username+"','"+ContractorName+"','"+ContractorID+"','"+Feedback+"','"+UserId+"','"+Rating+"')");
        return dt;
    }
    public void requestamountbycontractor()
    {
        objCon.xnon("insert into amountrequesttable values('" + UserId + "','" + ContractorID + "','" + ContractorName + "','" + date + "','" + price + "','pending')");
    }
    public DataTable selectuserfromquoterequesttable()
    {
        DataTable dt = objCon.xdata("select * from useracceptedrequesttable where contractorid= '"+ContractorID+"'");
        return dt;
    }
    public DataTable userdatafetchforpayment()
    {
        DataTable dt = objCon.xdata("select * from userregistertable");
        return dt;
    }
    public DataTable contractorrequestamountfetch()
    {
        DataTable dt = objCon.xdata("select * from amountrequesttable where userid='"+UserId+"' and status='pending'");
        return dt;
    }
    public void insertddtable()
    {
        objCon.xnon("insert into ddtable values('" + UserId + "','"+Username+"','" + ContractorID + "','" + ContractorName + "','" + date + "','" + price + "','"+WorkImage+"')");
        objCon.xnon("update amountrequesttable set status='approved' where userid='" + UserId + "'");
    }
    public void insertratingtable()
    {
        objCon.xnon("insert into ratingtable values('" + ContractorID + "','" + ContractorName + "','" + Username + "','"+Rating+"','" + UserId + "')");
    }
    public DataTable floorfetch()
    {
        DataTable dt = objCon.xdata("select * from floortable");
        return dt;
    }
    public DataTable floortypefetch()
    {
        DataTable dt = objCon.xdata("select tid,tname from typetable where fid='"+floor+"'");
        return dt;
    }
    public DataTable paintfetch()
    {
        DataTable dt = objCon.xdata("select * from painttable");
        return dt;
    }
    public DataTable basementfetch()
    {
        DataTable dt = objCon.xdata("select * from basementtable");
        return dt;
    }
    public void adminmarketinsert()
    {
        objCon.xnon("insert into markettable values('" + cement + "','" + sand+ "','" + bricks + "','" + stone + "','" + steel + "','" + date + "')");
    }
    public DataTable feedbacktablefetch()
    {
        DataTable dt = objCon.xdata("select * from userfeedbacktable where rating='"+Rating+"'");
        return dt;
    }
    public void contractorbidinsert()
    {
        objCon.xnon("insert into contractorsbidtable values('" + UserId + "','" + ContractorID+ "','" + ContractorName + "','" +  Address+ "','" + workname + "','" + price + "','"+Description+"','pending')");
    }
    public DataTable contractorbidtablefetch()
    {
        DataTable dt = objCon.xdata("select * from contractorsbidtable where status='pending'");
        return dt;
    }
    public DataTable contractordetailsforuser()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select * from contractorregistertable where contractorrid='"+ContractorID+"'");
        return dt;
    }
    public DataTable contractornamefordropdown()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select fullname from contractorregistertable");
        return dt;
    }
    public void changeusername()
    {
        objCon.xnon("update userregistertable set fullname='"+Username+"' where userlid='"+UserId+"'");
    }
    public void changeaddress()
    {
        objCon.xnon("update userregistertable set address='" + Address + "' where userlid='" + UserId + "'");
    }
    public void changeemail()
    {
        objCon.xnon("update userregistertable set email='" + Email + "' where userlid='" + UserId + "'");
    }
    public void changemobilenumber()
    {
        objCon.xnon("update userregistertable set mobileno='" + Contactno + "' where userlid='" + UserId + "'");
    }
    public void additionalinfo()
    {
        objCon.xnon("insert into additionalinfotable values('"+Address+"','"+Contactno+"','"+landmark+"','"+from+"','"+to+"','"+UserId+"','"+contractorid+"')");
    }
    public DataTable additionalinfofetchtocontractor()
    {
        DataTable dt = new DataTable();
        dt = objCon.xdata("select * from additionalinfotable where contractorid='"+contractorid+"'");
        return dt;
    }
}