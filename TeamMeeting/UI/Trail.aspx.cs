using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamMeeting.UI
{
    public partial class Trail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //TextBox txtActivity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtActivity");
            Label value1 = (Label)e.Row.FindControl("value1");
            value1.Text = txtFirst.Text;

            Label value2 = (Label)e.Row.FindControl("value2");
            value2.Text = txtSecond.Text;
        }
    }
}