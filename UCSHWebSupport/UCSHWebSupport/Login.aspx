<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UCSHWebSupport.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>UCSH EService[Service LogIn]</title>
</head>
<body runat="server">
    <form runat="server">
        <div>
            <link href="CSS/cssLogin.css" rel='stylesheet' type='text/css' />
            <div class="login">
                <div class="login-header">
                    <h4>Login</h4>
                </div>
                <div class="login-form">
                    <h3>UserID:</h3>
                    <asp:TextBox CssClass="textbox" placeholder="Enter UserID" runat="server" ID="txtUserID" ></asp:TextBox><br />
                    <h3>Password:</h3>
                    <asp:TextBox CssClass="textbox" placeholder="Enter Password" runat="server" ID="txtPassword" TextMode="Password" ></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn"></asp:Button>
                    <br />
                    <h5><a href="#">Sign Up!</a></h5>
                    <h5><a href="#">Do you want to download desktop app?</a></h5>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
