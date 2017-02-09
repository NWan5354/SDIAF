<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPLogins.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <h1 align="center">Login Page</h1>
    <br />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Label text="Username: " runat="server"></asp:Label>
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username is required" ControlToValidate="txtUserName" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/><br/>
    <asp:Label Text="Password: " runat="server"></asp:Label>
    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is required" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/><br/>
    <asp:Label ID="lblUserValidation" runat="server"></asp:Label>
    <br><br/>
        
    <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click"/>
        <br><br/>
    

    </div>
    </form>
</body>
</html>
