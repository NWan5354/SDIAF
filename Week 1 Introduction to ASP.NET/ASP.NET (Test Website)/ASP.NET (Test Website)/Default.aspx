<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET__Test_Website_.Default" MasterPageFile="~/MasterPage.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Default</title>
    <h1>This is the Homepage</h1>

</head>
<body>
    <p>Practice passing data from one page to another using ASP.NET!</p>
    <p>What is your name?</p>

<asp:Label runat="server">
    Name:
</asp:Label>
    <asp:TextBox runat="server" ID="NameField"></asp:TextBox>

    <asp:Button runat="server" ID="Button1" Text="Submit" OnClick="Button1_Click" />
    <br />
    <asp:Label runat="server" ID="TimeLabel">

    </asp:Label>
    
    <br />

    <asp:Button ID="TimeButton" runat="server" OnClick="display_time" Text="Display date & time"/>
</body>
</html>
</asp:Content>
