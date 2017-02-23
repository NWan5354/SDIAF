<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="userID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="1">
            <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Buy" ShowSelectButton="True" />
                <asp:BoundField DataField="userID" HeaderText="userID" ReadOnly="True" SortExpression="userID" />
                <asp:BoundField DataField="userName" HeaderText="userName" SortExpression="userName" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:ImageField DataImageUrlField="imagelink">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString %>" SelectCommand="SELECT * FROM [Users1]"></asp:SqlDataSource>
    
    </div>
        <asp:Label ID="selectLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
