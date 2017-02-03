<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_Experimenting.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h1>Encryption ASP.NET Web Page</h1>

    <script runat="server">


    </script>

</head>
<body>

    <p><asp:Label runat="server" id="NameLabel"></asp:Label></p>

    <form runat="server" id="NameField">
    

        <p><asp:TextBox runat="server" id="NameBox" /><input type="submit" value="Encrypt" /></p>

        

    </form>
</body>
</html>
