<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CourseworkEx4_PartB_Section3_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Exchange</title>
    <h1 style="font-family:Arial">Currency Exchange</h1>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label Font-Names="Arial" Text="GBP (British Pound £): " runat="server"></asp:Label>
        <asp:TextBox ID="txtBritishPound" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label Font-Names="Arial" Text="Select Country: " runat="server"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>No Country Selected</asp:ListItem>
            <asp:ListItem>United States</asp:ListItem>
            <asp:ListItem>South Africa</asp:ListItem>
            <asp:ListItem>Singapore</asp:ListItem>
            <asp:ListItem>Hong Kong</asp:ListItem>
            <asp:ListItem>France</asp:ListItem>
            <asp:ListItem>Germany</asp:ListItem>
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>Denmark</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnConvertCurrency" Text="Convert" runat="server" OnClick="btnConvertCurrency_Click" />
        <br />
        <br />
        <asp:Label Font-Names="Arial" Text="Currency Exchange Returned: " runat="server"></asp:Label>
        <asp:Label Font-Names="Arial" ID="lblCurrencyResultReturned" runat="server"></asp:Label>
        <br />
        <br />
    </div>
    </form>
</body>
</html>
