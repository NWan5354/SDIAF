<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComputerConvert.aspx.cs" Inherits="CourseworkExcersise4PartA.ComputerConvert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Computer Convert</title>
    <h1 style="font-family:Arial">Computer Convert</h1>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label Text="Computer Value: " runat="server" Font-Names="Arial" />
        <asp:TextBox ID="txtUserSpecifiedValue" runat="server" Font-Names="Arial" />  
        <br />
        <br />
        <asp:Label Text="From Computer Unit: " runat="server" Font-Names="Arial" />

        <asp:DropDownList ID="dropDownFrom" runat="server" Font-Names="Arial">
            <asp:ListItem>Bit</asp:ListItem>
            <asp:ListItem>Byte</asp:ListItem>
            <asp:ListItem>Kilobyte</asp:ListItem>
            <asp:ListItem>Megabyte</asp:ListItem>
            <asp:ListItem>Gigabyte</asp:ListItem>
            <asp:ListItem>Terabyte</asp:ListItem>
            <asp:ListItem>Petabyte</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label Text="To Computer Unit: " runat="server" Font-Names="Arial" />
        <asp:DropDownList ID="dropDownTo" runat="server">
            <asp:ListItem>Bit</asp:ListItem>
            <asp:ListItem>Byte</asp:ListItem>
            <asp:ListItem>Kilobyte</asp:ListItem>
            <asp:ListItem>Megabyte</asp:ListItem>
            <asp:ListItem>Gigabyte</asp:ListItem>
            <asp:ListItem>Terabyte</asp:ListItem>
            <asp:ListItem>Petabyte</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnConvert" Text="Convert" runat="server" Font-Names="Arial" OnClick="btnConvert_Click" />
        <br />
        <br />
        <asp:Label Text="Result: " runat="server" Font-Names="Arial"></asp:Label>
        <asp:Label ID="lblConvertedValue" runat="server" Font-Names="Arial" />
    </div>
    </form>
</body>
</html>
