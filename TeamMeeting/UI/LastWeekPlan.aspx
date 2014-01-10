<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LastWeekPlan.aspx.cs" Inherits="TeamMeeting.UI.LastWeekPlan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <%-- <asp:GridView ID="grdLastWeekPlane" runat="server" AutoGenerateColumns="false" DataKeyNames="Id"
                    OnRowCancelingEdit="grdContact_RowCancelingEdit" OnRowDataBound="grdContact_RowDataBound"
                    OnRowEditing="grdContact_RowEditing" OnRowUpdating="grdContact_RowUpdating" ShowFooter="True"
                    OnRowCommand="grdContact_RowCommand" OnRowDeleting="grdContact_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="ID" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:Label ID="lblID" runat="server" Text='<%=Bind("Id") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblID" runat="server" Text='<%=Bind("Id") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Name" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewName" runat="server"></asp:TextBox>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sex" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddlSex" runat="server" SelectedValue='<%# Eval("Sex") %>'>
                                    <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
                                    <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
                                </asp:DropDownList>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblSex" runat="server" Text='<%# Eval("Sex") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList ID="ddlNewSex" runat="server">
                                    <asp:ListItem Text="Male" Value="Male" Selected="True"></asp:ListItem>
                                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                </asp:DropDownList>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Type" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:DropDownList ID="cmbType" runat="server" DataTextField="Typename" DataValueField="Id">
                                </asp:DropDownList>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblType" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList ID="cmbNewType" runat="server" DataTextField="Typename" DataValueField="Id">
                                </asp:DropDownList>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ative">
                            <EditItemTemplate>
                                <asp:CheckBox ID="chkActive" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblActive" runat="server" Text='<%# Eval("IsActive") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:CheckBox ID="chkNewActive" runat="server" />
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Edit" ShowHeader="False" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:LinkButton ID="lbkUpdate" runat="server" CausesValidation="True" CommandName="Update"
                                    Text="Update"></asp:LinkButton>
                                <asp:LinkButton ID="lnkCancel" runat="server" CausesValidation="False" CommandName="Cancel"
                                    Text="Cancel"></asp:LinkButton>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:LinkButton ID="lnkAdd" runat="server" CausesValidation="False" CommandName="Insert"
                                    Text="Insert"></asp:LinkButton>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="False" CommandName="Edit"
                                    Text="Edit"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
                    </Columns>
                </asp:GridView>--%>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Visible="true"
               DataKeyNames="Owner" OnRowCancelingEdit="grdContact_RowCancelingEdit" OnRowDataBound="grdContact_RowDataBound" 
                OnRowEditing="grdContact_RowEditing" OnRowUpdating="grdContact_RowUpdating" OnRowCommand="grdContact_RowCommand" 
                ShowFooter="True" OnRowDeleting="grdContact_RowDeleting">
                    <Columns>
                       <%-- <asp:BoundField HeaderText="EmpId" DataField="EmpId" />
                        <asp:BoundField />--%>
                        <asp:TemplateField HeaderText="Activity" HeaderStyle-HorizontalAlign="Left" >
                            <EditItemTemplate>
                                <asp:TextBox ID="txtActivity" runat="server" Text='<%# Bind("Activity") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewActivity" runat="server"></asp:TextBox>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblActivity" runat="server" Text='<%# Bind("Activity") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Date" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtDate" runat="server" Text='<%# Bind("Date") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewDate" runat="server"></asp:TextBox>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblDate" runat="server" Text='<%# Bind("Date") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Owner" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <%--<asp:TextBox ID="txtOwner" runat="server" Text='<%# Bind("Owner") %>'></asp:TextBox>--%>
                                <asp:DropDownList ID="drpOwner" runat="server" AutoPostBack="false" DataTextField="Owner" DataValueField="Owner">
                                </asp:DropDownList>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewOwner" runat="server"></asp:TextBox>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblOwner" runat="server" Text='<%# Bind("Owner") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Remark" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtRemark" runat="server" Text='<%# Bind("REMARK") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewRemark" runat="server" ></asp:TextBox>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblRemark" runat="server" Text='<%# Bind("REMARK") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Edit" ShowHeader="False" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:LinkButton ID="lbkUpdate" runat="server" CausesValidation="True" CommandName="Update"
                                    Text="Update"></asp:LinkButton>
                                <asp:LinkButton ID="lnkCancel" runat="server" CausesValidation="False" CommandName="Cancel"
                                    Text="Cancel"></asp:LinkButton>
                                <%--<asp:LinkButton ID="lnkDelete" runat="server" CausesValidation="true" CommandName="Delete" Text="Delete">
                                    </asp:LinkButton>--%>
                                    
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:LinkButton ID="lnkAdd" runat="server" CausesValidation="False" CommandName="Insert"
                                    Text="Insert"></asp:LinkButton>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="False" CommandName="Edit"
                                    Text="Edit"></asp:LinkButton>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" ShowHeader="true" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <div>
    </div>
    </form>
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td rowspan="3">
                &nbsp;</td>
            <td rowspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</body>
</html>
