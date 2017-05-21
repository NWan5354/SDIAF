<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.RecoverPassword" %>

<asp:Content ID="Content1"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Recover Password</title>
    <br />
    <br />
    <h1 style="text-align:center">Password Recovery</h1>
</head>
<body>
    
    <div class="container-fluid">
        <div class="text-center">
            <br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Email Address is required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please pick the security question you registered with and provide an answer" ControlToValidate="selectSecurityQuestion" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please provide an answer for your secrity question" ControlToValidate="txtSecQuesAns" ForeColor="Red"></asp:RequiredFieldValidator>
            <br><br/>
            <asp:Label Text="Email Address: " runat="server"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Label Text="Security Question: " runat="server"></asp:Label>
            <asp:DropDownList ID="selectSecurityQuestion" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>What is your mother maiden name?</asp:ListItem>
                <asp:ListItem>What is your first mobile number?</asp:ListItem>
                <asp:ListItem>What is the name of your first primary school you attended?</asp:ListItem>
            </asp:DropDownList>
            <br><br/>
            <asp:Label Text="Security Question Answer: " runat="server"></asp:Label>
            <asp:TextBox ID="txtSecQuesAns" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Label ID="lblUserMessage" runat="server"></asp:Label>
            <br><br/>
            <asp:Button ID="btnRecoverPassword" Text="Recover" runat="server" OnClick="btnRecoverPassword_Click" />
        </div>
    
    </div>
    
</body>
</html>
</asp:Content>