<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="CoffeeProducts.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.CoffeeProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Coffee Products</title>
</head>
<body>
    <div class="container-fluid">
        <div class="text-center">

            <h2 style="font-family:Arial; color:white">Please select a coffee below and scroll down to continue making the purchase</h2>
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Coffee Products List</h3>
                </div>
                <div class="panel-body">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeShopConnectionString %>" SelectCommand="SELECT * FROM [coffeeDetails] WHERE ([stockQuantity] &gt;= @stockQuantity)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="1" Name="stockQuantity" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="table table-hover" DataKeyNames="coffeeID" DataSourceID="SqlDataSource1" PageSize="5" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                                    <asp:BoundField DataField="coffeeID" HeaderText="" InsertVisible="False" ReadOnly="True" SortExpression="coffeeID" />
                                    <asp:BoundField DataField="coffeeName" HeaderText="" SortExpression="coffeeName" />
                                    <asp:BoundField DataField="coffeeStrength" HeaderText="" SortExpression="coffeeStrength" />
                                    <asp:BoundField DataField="coffeeGrind" HeaderText="" SortExpression="coffeeGrind" />
                                    <asp:BoundField DataField="origin" HeaderText="" SortExpression="origin" />
                                    <asp:BoundField DataField="price" DataFormatString="{0:c}" HeaderText="" SortExpression="price" />
                                    <asp:BoundField DataField="stockQuantity" HeaderText="" SortExpression="stockQuantity" />
                                    <asp:ImageField DataImageUrlField="imageLink" HeaderText="">
                                        <ControlStyle Height="110" Width="180px" />
                                    </asp:ImageField>
                                </Columns>
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                <SortedDescendingHeaderStyle BackColor="#820000" />
                            </asp:GridView>

                            <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                            <br />
                            <asp:Label ID="lblSelectedCoffee" runat="server" Text="No Coffee Selected"></asp:Label>
                            <br />
                            <asp:Label ID="lblCoffeeStrength" runat="server" Text=""></asp:Label>
                            <br />
                            <asp:Label ID="lblGrind" runat="server" Text=""></asp:Label>
                            <br />
                            <asp:Label ID="lblOrigin" runat="server" Text=""></asp:Label>
                            <br />
                            <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>

                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                        </Triggers>
                    </asp:UpdatePanel>
                    <br />
                </div>
            </div>

            <br />
            <asp:Button ID="btnBuyCoffee" Text="Purchase" CssClass="btn btn-success" runat="server" OnClick="btnBuyCoffee_Click" />
            <br />

        </div>
    </div>
</body>
</html>
</asp:Content>