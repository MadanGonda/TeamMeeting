using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Runtime.Serialization;

namespace TeamMeetingBOL.UI
{
    [Serializable]
   public class SignUpPageBOL
    {
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
        
    }
}
