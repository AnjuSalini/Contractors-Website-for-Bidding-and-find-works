using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for ClsConnection
/// </summary>
public class ClsConnection
{
    //string strCon;
    //public string stringConnection()
    //{

    //    strCon = "Data Source=LOGIC-PC\\SQLEXPRESS;Initial Catalog=Buildingconstruction;User ID=sa;Password=admin123*";
    //    return strCon;
    //}

    //private SqlConnection conn()
    //{
    //    //Declaration
    //    SqlConnection conSql = new SqlConnection();
    //    string con = null;

    //    //Connection String
    //    con = stringConnection();

    //    //Open Sql Connection
    //    conSql = new SqlConnection(con);
    //    conSql.Open();

    //    return conSql;
    //}

    //public DataTable sel_Qry(string Qry)
    //{
    //    DataTable dt = new DataTable();
    //    string selectQuery = null;
    //    SqlConnection SqlCon = new SqlConnection();

    //    SqlCon = conn();

    //    //Query building
    //    selectQuery = Qry;
    //    SqlDataAdapter adptrSql = new SqlDataAdapter(selectQuery, SqlCon);
    //    adptrSql.Fill(dt);
    //    conn().Close();

    //    return dt;
    //}

    //public void ins_upt_del_Qry(string Qry)
    //{
    //    DataTable dt = new DataTable();
    //    string delQuery = null;
    //    SqlConnection SqlCon = new SqlConnection();

    //    SqlCon = conn();

    //    //Query building
    //    delQuery = Qry;
    //    SqlCommand cmdSql = new SqlCommand(delQuery, SqlCon);
    //    cmdSql.ExecuteNonQuery();
    //    conn().Close();
    //}
    SqlConnection con = new SqlConnection();
    public ClsConnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void getcon()
        {
            con.ConnectionString = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=Buildingconstruction;User ID=sa;Password=admin123*";

            con.Open();
        }
       
        public void xnon(string str)
        {
            getcon();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public DataTable xdata(string str)
        {
            getcon();
            SqlCommand cmd = new SqlCommand(str,con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
            con.Close();
            return dt;

        }
        public object xscalar(string str)
        {
            getcon();
            SqlCommand cmd = new SqlCommand(str, con);
            object x = cmd.ExecuteScalar();
            con.Close();
            return x;
        }


}