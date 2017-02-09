<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="myTimeLabel" runat="server"></asp:Label>
    <br/>
    <asp:Button ID="btnSubmit" text="Update Time" runat="server" OnClick="btnSubmit_Click"/>
    </div>
    </form>
</body>
</html>
