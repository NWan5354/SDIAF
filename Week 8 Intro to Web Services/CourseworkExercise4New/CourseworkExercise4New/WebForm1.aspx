<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CourseworkExercise4New.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h1>Temperature Conversion</h1>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <asp:Label Text="Celsius: " runat="server"></asp:Label>
        <asp:TextBox ID="txtInputCelsius" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label Text="Farenheit: " runat="server"></asp:Label>
        <asp:TextBox ID="txtOutputFarenheit" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnConvert" Text="Convert (C) to (F)" runat="server" OnClick="btnConvert_Click" />
        <br />
        <br />
        <asp:Button ID="btnFarenheitToCelsius" Text="Convert (F) to (C)" runat="server" OnClick="btnFarenheitToCelsius_Click"  />
    </div>
    </form>
</body>
</html>
