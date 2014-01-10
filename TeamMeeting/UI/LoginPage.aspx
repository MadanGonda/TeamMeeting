<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TeamMeeting.UI.LoginPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="../Styles/LoginPageTransperant.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            width: 175px;
        }
        .style3
        {
            width: 408px;
        }
        .style4
        {
            width: 545px;
        }
        .style5
        {
            width: 156px;
        }
        /* .home{
	    background-color: #333;
        }

        #container {
        width: 400px;
        height: 300px;
        position:absolute;
        left: 50%;
        top: 50%;
        margin-left: -200px;
        margin-top: -150px;*/
        /*background-color: green;
        border: 1px solid red;
        
        }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
     <fieldset>
			<p>
				<label for="login-username">USERID</label>
				<asp:TextBox ID="txtUserID" runat="server" class="round full-width-input"></asp:TextBox>
			</p>
			<p>
				<label for="login-password">PASSWORD</label>
				<asp:TextBox ID="txtUerPassword" runat="server" TextMode="Password" class="round full-width-input"></asp:TextBox>
			</p>
			<br/>
			<div id="footer">

               <%-- <asp:Button ID="btnSubmitClick" runat="server" onclick="Submit_Click" Text="SIGN IN" OnClientClick="return userValidation()" class="btnLogin" />--%>
               <asp:Button ID="btnSubmitClick" runat="server" Text="SIGN IN" class="btnLogin" />
			</div>
            <br/>
				<p/>
            <%--<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" class="sign_up">SIGN UP</asp:LinkButton>--%>
            <asp:LinkButton ID="LinkButton1" runat="server" class="sign_up" 
                        onclick="LinkButton1_Click">SIGN UP</asp:LinkButton>
            <br/>
            <br/> 
                <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red" 
                                    Text="* Please Enter Proper Credentials" Font-Size="Larger"></asp:Label>
		</fieldset>

    </div>
    </div>
    </form>
</body>
</html>
