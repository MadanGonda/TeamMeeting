<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trail.aspx.cs" Inherits="TeamMeeting.UI.Trail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtFirst" runat="server" Text="4"></asp:TextBox>
        <asp:TextBox ID="txtSecond" runat="server" Text="5"></asp:TextBox>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            onrowdatabound="GridView1_RowDataBound">
        <Columns>
        <asp:TemplateField HeaderText="Column1">
            <ItemTemplate>  
            <asp:Label ID="value1" runat="server" Text="1"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Column2">
            <ItemTemplate>  
            <asp:Label ID="value2" runat="server" Text="3"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
