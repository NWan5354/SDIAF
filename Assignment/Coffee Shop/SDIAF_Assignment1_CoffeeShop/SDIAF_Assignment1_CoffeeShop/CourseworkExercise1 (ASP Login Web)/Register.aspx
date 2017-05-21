<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>Register</title>
    <br />
    <br />
    <h1 style="text-align:center">Register Page</h1>
    <h2 style="text-align:center">New to the website, please get registered!</h2>
    <br><br/>
</head>
<body>
    
    <div class="container-fluid">
        <div class="text-center">

        <asp:RequiredFieldValidator runat="server" ErrorMessage="Name is required" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Email address is required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Username is required" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Password is required" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Please confirm your password" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator>

        <br><br/>
        <asp:Label Text="Name: " runat="server"></asp:Label>
        <asp:TextBox id="txtName" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Email: " runat="server"></asp:Label>
        <asp:TextBox id="txtEmail" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Username: " runat="server"></asp:Label>
        <asp:TextBox id="txtUsername" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Password: " runat="server"></asp:Label>
        <asp:TextBox id="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Confirm Password: " runat="server"></asp:Label>
        <asp:TextBox id="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br><br/>

        <asp:Button ID="btnSubmit" Text="Get Registered" runat="server"/>
        <br><br/>
        </div>
    </div>
    
</body>
</html>
</asp:Content>