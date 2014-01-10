using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeamMeetingBLL.UI;
using System.Data;

namespace TeamMeeting.UI
{
    public partial class LastWeekPlan : System.Web.UI.Page
    {
        public int empID;

        public int EmpIdProperty
        {
            get { return empID; }
            set { ViewState["empID"] = value; }
        }

        //int empId;
        //Session["empId"] = empId;

        LastWeekPlanBLL lp = new LastWeekPlanBLL();
        SignUpPageBLL drpLink = new SignUpPageBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource=
            //if (!IsPostBack) {
            //lp.BindGrid();
            //    GridView1.DataSource = lp.dt;
            //    GridView1.DataBind();
            if (!IsPostBack)
            {
                gridBind();
                GridView1.Visible = true;
            }
            //}

        }

        public void gridBind()
        {
            lp.BindGrid();
            GridView1.DataSource = lp.dt;
            GridView1.DataBind();
        }
        public void BindDropDown()
        {
            EditCommandColumn gridItem = new EditCommandColumn();

            //DropDownList drpOwner = .
        }

        protected void grdContact_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //ContactTypeTableAdapter contactType = new ContactTypeTableAdapter();
            //DataTable contactTypes = contactType.GetData();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                /*  Label lblType = (Label)e.Row.FindControl("lblType");
                  if (lblType != null)
                  {
                      int typeId = Convert.ToInt32(lblType.Text);
                      lblType.Text = (string)contactType.GetTypeById(typeId);
                  }
                  DropDownList cmbType = (DropDownList)e.Row.FindControl("cmbType");
                  if (cmbType != null)
                  {   
                      cmbType.DataSource = contactTypes;
                      cmbType.DataTextField = "TypeName";
                      cmbType.DataValueField = "Id";
                      cmbType.DataBind();
                      cmbType.SelectedValue = grdContact.DataKeys[e.Row.RowIndex].Values[1].ToString();
                  }*/
                Label lblOwner = (Label)e.Row.FindControl("lblOwner");
                if (lblOwner != null)
                {
                    //int typeId = Convert.ToInt32(lblOwner.Text);
                    //lblOwner.Text = (string)contactType.GetTypeById(typeId);
                    //lblOwner.Text = GridView1.DataKeys[e.Row.RowIndex].Values[1].ToString();
                }
                DropDownList drpOwner = (DropDownList)e.Row.FindControl("drpOwner");
                if (drpOwner != null)
                {
                    drpLink.bindDataSet();
                    drpOwner.DataSource = drpLink.dt;
                    drpOwner.DataTextField = "EmpName";
                    drpOwner.DataValueField = "EmpName";
                    drpOwner.DataBind();
                    drpOwner.SelectedValue = GridView1.DataKeys[e.Row.RowIndex].Values[0].ToString();
                }
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    DropDownList drownerfooter = (DropDownList)e.Row.FindControl("drpOwner");
                    drpOwner.DataSource = lp.dt;
                    drpOwner.DataBind();
                }
            }
            /*if (e.Row.RowType == DataControlRowType.Footer)
            {
                DropDownList cmbNewType = (DropDownList)e.Row.FindControl("cmbNewType");
                cmbNewType.DataSource = contactTypes;
                cmbNewType.DataBind();
            }*/
        }

        protected void grdContact_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void grdContact_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridBind();
        }

        protected void grdContact_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //ContactTableAdapter contact = new ContactTableAdapter();
            //bool flag = false;
            int empIDvalue;

            TextBox txtActivity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtActivity");
            lp.ActivityProperty = txtActivity.Text;

            TextBox txtDate = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDate");
            lp.DATEdProperty = txtDate.Text;

            //TextBox txtNewOwner = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNewOwner");
            //DropDownList drpOwner = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("drpNewOwner");
            //lp.Ownerproperty = txtNewOwner.Text;

            TextBox remarks;
            TextBox txtRemark = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtRemark");
            TextBox txtNewRemark = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNewRemark");
            if (txtRemark != txtNewRemark)
                remarks = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNewRemark");
            else
                remarks = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtRemark");
            lp.REMARKproperty = txtRemark.Text;

            DropDownList drpOwner = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("drpOwner");
            lp.Ownerproperty = drpOwner.SelectedItem.Text;
            lp.Ownerproperty = "jak5";
            //lp.EmpIdproperty = EmpIdProperty;
            lp.EmpIdproperty = 20;
            //empIDvalue=EmpIdProperty;

            lp.updateTable(lp.ActivityProperty, lp.DATEdProperty, lp.REMARKproperty, lp.EmpIdproperty, lp.Ownerproperty);

            /*TextBox txtName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName");
            CheckBox chkActive = (CheckBox)GridView1.Rows[e.RowIndex].FindControl("chkActive");
            DropDownList cmbType = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("cmbType");
            DropDownList ddlSex = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddlSex");*/

            //if (chkActive.Checked) flag = true; else flag = false;
            //contact.Update(txtName.Text, ddlSex.SelectedValue, cmbType.SelectedValue, flag,Convert.ToInt32(lblId.Text));
            //grdContact.EditIndex = -1;
            // gridBind();

        }

        protected void grdContact_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Insert")
            {
                TextBox txtActivity = (TextBox)GridView1.FooterRow.FindControl("txtNewActivity");
                lp.ActivityProperty = txtActivity.Text;

                TextBox txtDate = (TextBox)GridView1.FooterRow.FindControl("txtNewDate");
                lp.DATEdProperty = txtDate.Text;

                //TextBox txtNewOwner = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNewOwner");
                //DropDownList drpOwner = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("drpNewOwner");
                //lp.Ownerproperty = txtNewOwner.Text;

                //TextBox remarks;
                //TextBox txtRemark = (TextBox)GridView1.FooterRow.FindControl("txtRemark");
                TextBox txtNewRemark = (TextBox)GridView1.FooterRow.FindControl("txtNewRemark");
                /*if (txtRemark!=txtNewRemark)
                    remarks = (TextBox)GridView1.FooterRow.FindControl("txtNewRemark");
                else
                    remarks = (TextBox)GridView1.FooterRow.FindControl("txtRemark");*/
                lp.REMARKproperty = txtNewRemark.Text;

                //DropDownList drpOwner = (DropDownList)GridView1.FooterRow.FindControl("drpOwner");
                //lp.Ownerproperty = drpOwner.SelectedItem.Text;
                lp.Ownerproperty = "jak5";
                //lp.EmpIdproperty = EmpIdProperty;
                lp.EmpIdproperty = 20;
                lp.InsertTable(lp.ActivityProperty, lp.DATEdProperty, lp.REMARKproperty, lp.EmpIdproperty, lp.Ownerproperty);
                gridBind();
            }

        }

        protected void grdContact_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //int ID = (int)GridView1.DataKeys[e.RowIndex].Value;
            string Owners = (string)GridView1.DataKeys[e.RowIndex].Value;

            //Label x.TextBox="Delete Record"+ID.ToString();
            GridView1.DataBind();
        }
    }
}