<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UsingWebServices.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <%--<asp:TextBox ID="txtHello" runat="server"></asp:TextBox>--%>
        <br />
        <br />
        <asp:TextBox ID="txtFirstNum" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtSecondNum" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" text="Add" runat="server" OnClick="btnAdd_Click"/>
        <br />
        <br />
        <asp:TextBox ID="txtResultBox" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
