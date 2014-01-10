using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using System.Xml;

namespace TeamMeetingDAL.UI
{

    public class SignUpPageDAL
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

        public void SignUpDataCon()
        {
            con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            cmd = new SqlCommand("pr_TimaeTable_signup_page", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "TimaeTable_signup_page");
            dt = ds.Tables["TimaeTable_signup_page"];
            con.Close();
        }

    }
}
