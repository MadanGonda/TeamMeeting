<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="TeamMeeting.UI.SignUpPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="fieldset" class="boxBody trans_back">
		<fieldset>
			<p>
				<label for="login-username">USERNAME</label>
				<!--input type="text" id="login-username" class="round full-width-input" autofocus /-->
                <asp:TextBox ID="TxtName" runat="server" class="round full-width-input"></asp:TextBox>
			</p>
			<p>
				<label for="login-password">USERID</label>
				<!--input type="password" id="login-password" class="round full-width-input" /-->
                <asp:TextBox ID="TxtId"  runat="server" class="round full-width-input"></asp:TextBox>
			</p>

            <p>
				<label for="login-password">EMAILID</label>
				<!--input type="password" id="login-password" class="round full-width-input" /-->
                <asp:TextBox ID="TxtEmailID" runat="server" class="round full-width-input"></asp:TextBox>
			</p>
            <p>
				<label for="login-password">PASSWORD</label>
				<!--input type="password" id="login-password" class="round full-width-input" /-->
                <asp:TextBox ID="TxtPassWord" runat="server" TextMode="Password" class="round full-width-input"></asp:TextBox>
			</p>
            <p>
				<label for="login-password">CONFIRM PASSWORD</label>
				<!--input type="password" id="login-password" class="round full-width-input" /-->
                <asp:TextBox ID="TxtReEnterPassword" runat="server" TextMode="Password" class="round full-width-input"></asp:TextBox>
			</p>
			<br/>
			
             <%--<asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="SUBMIT" OnClientClick="return SigbUpvalidation();"  class="btnLogin"/>--%>
			<asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="SUBMIT" class="btnLogin"/>
		</fieldset>
	</div>
    </form>
</body>
</html>
