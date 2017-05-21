<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Change Password</title>
    <br />
    <br />

    <h1 style="text-align:center">Change Password</h1>
</head>
<body>
    
    <div class="container-fluid">
    
        <div class="text-center">
            <p>Please enter your current password to continue</p>
            <br />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br><br/>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Confirm Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br><br/>
            <asp:CompareValidator runat="server" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ErrorMessage="Both passwords must match" ForeColor="Red"></asp:CompareValidator>

            <br />
            <asp:Label Text="Password" runat="server"></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Label Text="Confirm Password" runat="server"></asp:Label>
            <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br><br/>
            <br><br/>
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />

        </div>

    </div>
    
</body>
</html>
</asp:Content>
