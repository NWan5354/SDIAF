<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="ChangePasswordPart2.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.ChangePasswordPart2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Change Password</title>
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6">
                <h2 style="color: white">Please enter your new password!</h2>
                <br />
            </div>

            <div class="col-md-6">
                <h2 style="color: white">Pick a new password and click change password now.</h2>
                <br />
                <asp:Label Text="New Password" runat="server" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Enter Password"></asp:TextBox>
                <br><br/>
                <asp:Label Text="Confirm Password" runat="server" ForeColor="White"></asp:Label>
                <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Enter Confirmation Password"></asp:TextBox>
                <br><br/>
                <asp:Button ID="btnSubmit" Text="Change Password Now!" runat="server" OnClick="btnSubmit_Click" CssClass="btn btn-default btn-success" />
            </div>
        </div>
    </div>
</body>
</html>
</asp:Content>