<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Login</title>
    <br />
    <br />
    <h1 style="text-align:center">Login Page</h1>
</head>
<body>
    <div class="container-fluid">
        <div class="text-center">
    <br />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
    <br><br/>

    <asp:Label text="Username" runat="server"></asp:Label>
    <asp:TextBox id="txtUsername" runat="server"></asp:TextBox>
    
    <br><br/>

    <asp:Label text="Password" runat="server"></asp:Label>
    <asp:TextBox id="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
    
    <br><br/>

    <asp:Label ID="lblUserMessage" runat="server"></asp:Label>

    <br><br/>

    <asp:Button id="btnLogin" Text="Log in" runat="server" OnClick="btnLogin_Click" />
    <br/>
    </div>
    </div>
</body>
</html>
</asp:Content>
