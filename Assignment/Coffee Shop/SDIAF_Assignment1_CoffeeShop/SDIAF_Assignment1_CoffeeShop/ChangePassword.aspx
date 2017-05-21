<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Change Password</title>

   
</head>
<body>
    
<div class="container-fluid">
    <div class="row">
           <div class="col-md-6">
               <h2 style="color:white">Reset your password</h2>
                    <br />
           </div>

           <div class="col-md-6">
               <h3 style="color:white">Please enter your current password to proceed</h3>
               <br />
               <asp:Label Text="Password" runat="server" ForeColor="White"></asp:Label>
               <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control input-sm" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <asp:Label Text="Confirm Password" runat="server" ForeColor="White"></asp:Label>
               <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" CssClass="form-control input-sm" Width="250px"></asp:TextBox>
               <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Confirm Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
               <br><br />
               <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="btnSubmit_Click" CssClass="btn btn-default btn-success" />
               <br><br />
               <asp:CompareValidator runat="server" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ErrorMessage="Both passwords must match" ForeColor="Red"></asp:CompareValidator> 
           </div>
    </div>             
</div>
</body>
</html>
</asp:Content>
