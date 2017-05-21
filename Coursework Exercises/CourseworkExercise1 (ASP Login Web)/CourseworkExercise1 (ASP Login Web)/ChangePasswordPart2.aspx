<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="ChangePasswordPart2.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.ChangePasswordPart2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Change Password</title>
</head>
<body>
    
    <div class="container">

        <div class="text-center">
            <p>Please enter your new password and click submit</p>
            <br><br/>
            <asp:Label Text="New Password" runat="server"></asp:Label>
            <asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Label Text="Confirm Password" runat="server"></asp:Label>
            <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br><br/>
            <asp:Button ID="btnSubmit" Text="Change Password Now!" runat="server" OnClick="btnSubmit_Click" />

        </div>
    
    </div>
    
</body>
</html>
</asp:Content>