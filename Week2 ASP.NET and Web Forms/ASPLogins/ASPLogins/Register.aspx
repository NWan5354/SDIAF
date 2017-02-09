<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASPLogins.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <br />
    <h1 align="center">Register</h1>
    <p align="center">New to the website? Please enter your details to register</p>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        
    <asp:Label Text="Name: " runat="server"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br><br/>
        
    <asp:Label Text="Email: " runat="server"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br><br/>
        
    <asp:Label Text="Username: " runat="server"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <br><br/>
        
    <asp:Label Text="Password: " runat="server"></asp:Label>
    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
    <br><br/>
        
    <asp:Button ID="btnSubmit" Text="Submit" runat="server"/>
    <br><br/>

    </div>
    </form>
</body>
</html>
