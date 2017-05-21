<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="SearchCoffee.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.SearchCoffee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Search Coffee</title>
</head>
<body>
    <div class="container-fluid">
            <div class="col-md-6">
                <h1 style="color: white">Search for Coffee Products</h1>
                <br />
            </div>
            <div class="col-md-6">
                <h1 style="color: white">Please use the following dropdown to find a coffee</h1>
                <br />
                <p style="color: white">As you search the results will appear automatically, else it will be empty</p>
                <br />            
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeShopConnectionString %>" SelectCommand="SELECT [coffeeName] FROM [coffeeDetails]"></asp:SqlDataSource>
                <br />
                <asp:Label Text="Coffee Name: " ForeColor="White" runat="server"></asp:Label>
                <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="coffeeName" DataValueField="coffeeName">
                <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeShopConnectionString %>" SelectCommand="SELECT DISTINCT [coffeeStrength] FROM [coffeeDetails]">
                </asp:SqlDataSource>
                <br />
                <asp:Label runat="server" ForeColor="White" Text="Strength: "></asp:Label>
                <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="coffeeStrength" DataValueField="coffeeStrength">
                </asp:DropDownList>
                <br />
                <asp:Label Text="Grind: " ForeColor="White" runat="server"></asp:Label>
                <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server" DataSourceID="SqlDataSource3" DataTextField="coffeeGrind" DataValueField="coffeeGrind">
                </asp:DropDownList>
                <br />
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeShopConnectionString %>" SelectCommand="SELECT DISTINCT [coffeeGrind] FROM [coffeeDetails]">
                </asp:SqlDataSource>
                <br />
            </div>
            
            <div class="col-md-12">
                <div class="text-center">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Search Results Found</h3>
                        </div>
                        <div class="panel-body">
                            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                            </asp:Timer>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="coffeeID" DataSourceID="SqlDataSource7" CssClass="table table-hover" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                                            <asp:BoundField DataField="coffeeID" HeaderText="" InsertVisible="False" ReadOnly="True" SortExpression="coffeeID" />
                                            <asp:BoundField DataField="coffeeName" HeaderText="" SortExpression="coffeeName" />
                                            <asp:BoundField DataField="coffeeStrength" HeaderText="" SortExpression="coffeeStrength" />
                                            <asp:BoundField DataField="coffeeGrind" HeaderText="" SortExpression="coffeeGrind" />
                                            <asp:BoundField DataField="origin" HeaderText="" SortExpression="origin" />
                                            <asp:BoundField DataField="price" HeaderText="" SortExpression="price" />
                                            <asp:BoundField DataField="stockQuantity" HeaderText="" SortExpression="stockQuantity" />
                                            <asp:ImageField DataAlternateTextField="imageLink" DataImageUrlField="imageLink">
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
                                    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeShopConnectionString %>" SelectCommand="SELECT * FROM [coffeeDetails] WHERE (([stockQuantity] &gt;= @stockQuantity) AND ([coffeeName] LIKE '%' + @coffeeName + '%') AND ([coffeeStrength] = @coffeeStrength) AND ([coffeeGrind] LIKE '%' + @coffeeGrind + '%'))">
                                        <SelectParameters>
                                            <asp:Parameter DefaultValue="1" Name="stockQuantity" Type="Int32" />
                                            <asp:ControlParameter ControlID="DropDownList1" Name="coffeeName" PropertyName="SelectedValue" Type="String" />
                                            <asp:ControlParameter ControlID="DropDownList2" Name="coffeeStrength" PropertyName="SelectedValue" Type="Int32" />
                                            <asp:ControlParameter ControlID="DropDownList3" Name="coffeeGrind" PropertyName="SelectedValue" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                    <asp:Label ID="lblID" runat="server" Visible="False"></asp:Label>
                                    <br />
                                    <asp:Label ID="lblSelectedCoffee" runat="server" Text="No Coffee Selected"></asp:Label>
                                    <br />
                                    <asp:Label ID="lblCoffeeStrength" runat="server"></asp:Label>
                                    <br />
                                    <asp:Label ID="lblGrind" runat="server"></asp:Label>
                                    <br />
                                    <asp:Label ID="lblOrigin" runat="server"></asp:Label>
                                    <br />
                                    <asp:Label ID="lblPrice" runat="server"></asp:Label>
                                    <br />
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick">
                                    </asp:AsyncPostBackTrigger>
                                </Triggers>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                <br />
                <asp:Button ID="btnBuyCoffee" Text="Purchase" CssClass="btn btn-success" runat="server" OnClick="btnBuyCoffee_Click" />
                <br />
            </div>
        </div>
    </div>
</body>
</html>
</asp:Content>