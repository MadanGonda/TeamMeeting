using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamMeetingDAL.UI;
using TeamMeetingBOL.UI;
using System.Data;
using System.Data.SqlClient;

namespace TeamMeetingBLL.UI
{

   public class LastWeekPlanBLL
   {

        #region LastWeekPlanBLLProperty
        private int EmpID;
        private string Activity;
        private string DATE;
        private string REMARK;
        private string Owner;

        public string ActivityProperty
        {
            get { return Activity; }
            set { Activity = value; }
        }

        public string DATEdProperty
        {
            get { return DATE; }
            set { DATE = value; }
        }

        public string REMARKproperty
        {
            get { return REMARK; }
            set { REMARK = value; }
        }
        public string Ownerproperty
        {
            get { return Owner; }
            set { Owner = value; }
        }

        public int EmpIdproperty {

            get { return EmpID; }
            set { EmpID = value; }
        }

        #endregion

        public SqlDataAdapter da;
        public DataSet ds;
        //public string constr = ConfigurationManager.ConnectionStrings["SAAPPConnectionString"].ToString();//System.Configuration.ConfigurationSettings.AppSettings["conectionString"];//"Data Source=V2VAPC0079;Initial Catalog=Madan_DB;Integrated Security=True";
        //public string constr = "Data Source=V2VAPC0079;Initial Catalog=Madan_DB;Integrated Security=True";
        public DataTable dt;

        //LastWeekPlanDAL lp = new LastWeekPlanDAL();
         LastWeekPlanDAL lp = new LastWeekPlanDAL();
        //LastWeekPlanDAL lp = new LasWeekUpdateDataCon();
       
        public void BindGrid()
        {
            lp.LasWeekPlaneDataCon();
            //lp.ds = ds;
            //lp.dt = dt;
            ds = lp.ds;
            dt = lp.dt;
        }

        public void updateTable(string ActivityProperty,string DATEdProperty,string REMARKproperty,int EmpIdproperty,string Ownerproperty)
        {

            lp.LasWeekUpdateDataCon();
            //lp.LasWeekPlaneDataCon();
            //lp.UpdateLastWeekData(ActivityProperty, DATEdProperty, REMARKproperty, EmpIdproperty, Ownerproperty);
            lp.mydatarow = lp.dt.NewRow();
            /*getSignupdata.mydatarow = getSignupdata.dt.NewRow();

            //getSignupdata.mydatarow["EmpId"] = getSignupProperty.EmpIdProperty;
            //getSignupdata.mydatarow["EmpName"] = getSignupProperty.EmpNameProperty;
            //getSignupdata.mydatarow["EmailID"] = getSignupProperty.EmpEmailIdProperty;
            //getSignupdata.mydatarow["Password"] = getSignupProperty.Passwordproperty;
            //getSignupdata.mydatarow["RePassword"] = getSignupProperty.ReEnterpasswordproperty;

            getSignupdata.mydatarow["EmpId"] = EmpIdProperty;
            getSignupdata.mydatarow["EmpName"] = EmpNameProperty;
            getSignupdata.mydatarow["EmailID"] = EmpEmailIdProperty;
            getSignupdata.mydatarow["Password"] = Passwordproperty;
            getSignupdata.mydatarow["RePassword"] = ReEnterpasswordproperty;

            getSignupdata.dt.Rows.Add(getSignupdata.mydatarow);
            getSignupdata.da.Update(getSignupdata.ds, "TimaeTable_signup_page");*/

            //lp.UpdateLastWeekData(ActivityProperty, DATEdProperty, REMARKproperty, EmpIdproperty, Ownerproperty);

            lp.mydatarow["Activity"] = ActivityProperty;
            lp.mydatarow["DATE"] = DATEdProperty;
            lp.mydatarow["REMARK"] = REMARKproperty;
            lp.mydatarow["EmpName"] = Ownerproperty;
            lp.mydatarow["EmpId"] = EmpIdproperty;
            lp.dt.Rows.Add(lp.mydatarow);
            lp.da.Update(lp.ds, "LastWeekPlane");
        }

        public void InsertTable(string ActivityProperty, string DATEdProperty, string REMARKproperty, int EmpIdproperty, string Ownerproperty)
        {
            lp.LasWeekPlaneDataCon();
            lp.mydatarow2 = lp.dt.NewRow();

            lp.mydatarow2["Activity"] = ActivityProperty;
            lp.mydatarow2["DATE"] = DATEdProperty;
            lp.mydatarow2["REMARK"] = REMARKproperty;
            lp.mydatarow2["Owner"] = Ownerproperty;
            lp.mydatarow2["EmpId"] = EmpIdproperty;
            lp.dt.Rows.Add(lp.mydatarow2);
            lp.da.Update(lp.ds, "LastWeekPlane");
        }

    }
}
