using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeamMeetingBLL.UI;
using TeamMeetingBOL.UI;

namespace TeamMeeting.UI
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        SignUpPageBLL signuppageSubmitData = new SignUpPageBLL();
        SignUpPageBOL signuppageSendData = new SignUpPageBOL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //signuppageSendData.EmpNameProperty = TxtName.Text;
            //signuppageSendData.EmpIdProperty =Convert.ToInt32(TxtId.Text);
            //signuppageSendData.EmpEmailIdProperty = TxtEmailID.Text;
            //signuppageSendData.Passwordproperty = TxtPassWord.Text;
            //signuppageSendData.ReEnterpasswordproperty = TxtReEnterPassword.Text;

            signuppageSubmitData.EmpNameProperty = TxtName.Text;
            signuppageSubmitData.EmpIdProperty = Convert.ToInt32(TxtId.Text);
            signuppageSubmitData.EmpEmailIdProperty = TxtEmailID.Text;
            signuppageSubmitData.Passwordproperty = TxtPassWord.Text;
            signuppageSubmitData.ReEnterpasswordproperty = TxtReEnterPassword.Text;
            
            signuppageSubmitData.SubmitSignUppage();
            Response.Redirect("LastWeekPlan.aspx", false);
        }
    }
}