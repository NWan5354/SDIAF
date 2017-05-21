<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Login</title>
    
    
</head>
<body>
<div class="container-fluid">
    <div class="row">
        <div class="col-md-6">
            <h2 style="color: white">Not yet registered as a member?</h2>
            <br />
            <h3 style="color: white">Are you a New Customer?</h3>
            <br />
            <a href="Register.aspx"><div class="btn btn-default btn-primary">Get Registered</div></a>
            <br />
            <h3 style="color: white;">Forgotten your password?</h3>
            <br />
            <a href="RecoverPassword.aspx"><div class="btn btn-default btn-primary">Reset Password</div></a>
        </div>

        <div class="col-md-6">
            <h2 style="color: white">Log in (Existing Customer?)</h2>
            <br />
            <asp:TextBox id="txtUsername" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Username"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br/> 
            <asp:TextBox id="txtPassword" TextMode="Password" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Password"></asp:TextBox>
             <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>    
                <br />
            <asp:Button id="btnLogin" Text="Log in" runat="server" OnClick="btnLogin_Click" CssClass="btn btn-default btn-success"/>
                <br><br />
            <asp:Label ID="lblUserMessage" runat="server" ForeColor="Red"></asp:Label>
                <br />
        </div>
    </div>
</div>
</body>
</html>
</asp:Content>
