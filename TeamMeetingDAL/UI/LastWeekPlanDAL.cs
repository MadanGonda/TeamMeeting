using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace TeamMeetingDAL.UI
{
    public class LastWeekPlanDAL
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataSet ds;
        //public string constr = ConfigurationManager.ConnectionStrings["SAAPPConnectionString"].ToString();//System.Configuration.ConfigurationSettings.AppSettings["conectionString"];//"Data Source=V2VAPC0079;Initial Catalog=Madan_DB;Integrated Security=True";
        public string constr = "Data Source=V2VAPC0079;Initial Catalog=Madan_DB;Integrated Security=True";
        public DataTable dt;
        public SqlDataReader dr;
        public DataRow mydatarow;
        public DataRow mydatarow2;
        public DataSet Ds = new DataSet();

        public void LasWeekPlaneDataCon()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("SelectLastWeekPlane", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "LastWeekPlane");
            dt = ds.Tables["LastWeekPlane"];
            con.Close();
        }

        //public void bindDropDown()
        //{
        //    con = new SqlConnection();
        //    con.ConnectionString = constr;
        //    con.Open();
        //    cmd = new SqlCommand("SelectLastWeekPlane", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    da = new SqlDataAdapter(cmd);
        //    SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
        //    ds = new DataSet();
        //    da.Fill(ds, "LastWeekPlane");
        //    dt = ds.Tables["LastWeekPlane"];
        //    con.Close();
        //}

        public void LasWeekUpdateDataCon()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("TotalDataOfLastWeek", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "LastWeekPlane");
            dt = ds.Tables["LastWeekPlane"];
            con.Close();
        }

        public void DeleteLastWeekData(int empID)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("DeleteEmpIDLastWeekPlane", con);
            cmd.Parameters.AddWithValue("@empid", empID);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "LastWeekPlane");
            dt = ds.Tables["LastWeekPlane"];
            con.Close();
        }

        public void UpdateLastWeekData(string Activity,string DATE,string REMARK, int empId,string EmpName)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("UpdateEmpIDLastWeekPlane", con);
            cmd.Parameters.AddWithValue("@Activity", Activity);
            cmd.Parameters.AddWithValue("@Date", DATE);
            cmd.Parameters.AddWithValue("@REMARK",REMARK);
            cmd.Parameters.AddWithValue("@EmpId", empId);
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "LastWeekPlane");
            dt = ds.Tables["LastWeekPlane"];
            con.Close();
        }

        public void InsertData(string Activity, string DATE, string REMARK, int empId, string EmpName)
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("InsertData", con);
            cmd.Parameters.AddWithValue("@Activity", Activity);
            cmd.Parameters.AddWithValue("@Date", DATE);
            cmd.Parameters.AddWithValue("@REMARK", REMARK);
            cmd.Parameters.AddWithValue("@EmpId", empId);
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "LastWeekPlane");
            dt = ds.Tables["LastWeekPlane"];
            con.Close();
        }

    }
}
