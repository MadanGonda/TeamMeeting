using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamMeetingBOL.UI;
//using TeamMeetingDAL.UI;
using TeamMeetingDAL.UI;
using System.Data;
using System.Data.Sql;
//using System.Xml;

namespace TeamMeetingBLL.UI
{

    //public class SignUpPage:System.Web.UI.Page
    public class SignUpPageBLL
    {
        //SignUpPage getSignupdata = new SignUpPage();
        //TeamMeeting getSignupdata = new TeamMeeting();
        SignUpPageDAL getSignupdata = new SignUpPageDAL();
        SignUpPageDAL getSignupDataset = new SignUpPageDAL();
        SignUpPageBOL getSignupProperty = new SignUpPageBOL();
        
        #region SignupPageBLLProperty
        private int EmpID;
        private string EmpName;
        private string Password;
        private string EmpEmailID;
        private string ReEnterpassword;
        
        public int EmpIdProperty
        {
            get { return EmpID; }
            set { EmpID = value; }
        }

        public string EmpNameProperty
        {
            get { return EmpName; }
            set { EmpName = value; }
        }

        public string EmpEmailIdProperty
        {
            get { return EmpEmailID; }
            set { EmpEmailID = value; }
        }

        public string Passwordproperty
        {
            get { return Password; }
            set { Password = value; }
        }
        public string ReEnterpasswordproperty
        {
            get { return ReEnterpassword; }
            set { ReEnterpassword = value; }
        }
        #endregion

        public DataSet ds;
        public DataTable dt;

        public void bindDataSet()
        {
            getSignupDataset.SignUpDataCon();
            ds = getSignupDataset.ds;
            dt = getSignupDataset.dt;
        }
        
        public void SubmitSignUppage()
        {
            getSignupdata.SignUpDataCon();
            getSignupdata.mydatarow = getSignupdata.dt.NewRow();

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
            getSignupdata.da.Update(getSignupdata.ds, "TimaeTable_signup_page");
        }
    }
}
