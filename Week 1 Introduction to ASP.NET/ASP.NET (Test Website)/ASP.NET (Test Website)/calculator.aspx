<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="ASP.NET__Test_Website_.calculator"  MasterPageFile="~/MasterPage.Master"%>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <h1>ASP.NET Calculator</h1>
</head>
<body>
    <p>Please type in the two numbers and click submit</p>
 
    <asp:Label runat="server" Text="First Number" />
    <asp:TextBox runat="server" ID="FirstNumber"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Second Number" />
    <asp:TextBox runat="server" ID="SecondNumber"></asp:TextBox>

    <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click" />

    <br />
    <p>Answer: <asp:Label runat="server" ID="Answer"></asp:Label></p>

    
</body>
</html>
</asp:Content>