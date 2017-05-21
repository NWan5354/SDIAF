<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="CustomerConfirmation.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.CustomerConfimation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Confirmation Page</title>
    <h1 style="font-family: Arial; color: white">Thank you for your order!</h1>
</head>
<body>
    <div class="container-fluid">
        <br />
        <asp:Label Text="Order Reference No: " runat="server" ForeColor="White" Font-Size="Medium"></asp:Label>
        <asp:Label id="lblOrderRef" runat="server" ForeColor="White" Font-Size="Medium"></asp:Label>
        <br />
        <br />
        <h4 style="font-family:Arial; color: white">Your order will be dispatched to you within 3 - 5 working days.</h4>
        <br />
        <h4 style="font-family:Arial; color: white">Thanks,</h4>
        <br />
        <h4 style="font-family:Arial; color: white">Nick Wan (Technical Developer - In-House)</h4>
        <br />
    </div>
</body>
</html>
</asp:Content>