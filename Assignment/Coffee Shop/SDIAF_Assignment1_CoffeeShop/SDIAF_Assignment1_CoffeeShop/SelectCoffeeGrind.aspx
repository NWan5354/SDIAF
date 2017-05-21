<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="SelectCoffeeGrind.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.SelectCoffeeGrind" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Select Coffee Grind</title>
    <h2 style="color: white">Coffee Grind</h2>
</head>
<body>
    <div class="container-fluid">
        
        <div class="row">
            <div class="col-md-6">
                <h3 style="color: white">Select your Coffee Grind type</h3>
                <br />
            </div>
            <div class="col-md-6">
                <h3 style="color: white">Do you prefer a coffee grind type?</h3>
                <br />
                <asp:Label Text="Select Coffee Grind" runat="server" ForeColor="White"></asp:Label>
                <asp:DropDownList ID="selectedCoffeeGrind" runat="server" CssClass="form-control" DataSourceID="SqlDataSource2" DataTextField="coffeeGrind" DataValueField="coffeeGrind">
                </asp:DropDownList>
                <br/>
                <br/>
            </div>
            <div class="text-center">
            <div class="col-md-12">
                <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Selected by Coffee Grind type</h3>
                </div>

                <div class="panel-body">
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeShopConnectionString %>" SelectCommand="SELECT DISTINCT [coffeeGrind] FROM [coffeeDetails]"></asp:SqlDataSource>
                <br />
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="table table-hover table-responsive" DataKeyNames="coffeeID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                                    <asp:BoundField DataField="coffeeID" HeaderText="" InsertVisible="False" ReadOnly="True" SortExpression="coffeeID" />
                                    <asp:BoundField DataField="coffeeName" HeaderText="" SortExpression="coffeeName" />
                                    <asp:BoundField DataField="coffeeStrength" HeaderText="" SortExpression="coffeeStrength" />
                                    <asp:BoundField DataField="coffeeGrind" HeaderText="" SortExpression="coffeeGrind" />
                                    <asp:BoundField DataField="origin" HeaderText="" SortExpression="origin" />
                                    <asp:BoundField DataField="price" HeaderText="" SortExpression="price" DataFormatString="{0:c}" />
                                    <asp:BoundField DataField="stockQuantity" HeaderText="" SortExpression="stockQuantity" />
                                    <asp:ImageField DataAlternateTextField="imageLink" HeaderText="" DataImageUrlField="imageLink">
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
                            <asp:Label ID="lblID" runat="server" Visible="False"></asp:Label>
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
                            

                            <br />
                            <br />
                            
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                        </Triggers>
                    </asp:UpdatePanel>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeShopConnectionString %>" SelectCommand="SELECT * FROM [coffeeDetails] WHERE (([stockQuantity] &gt;= @stockQuantity) AND ([coffeeGrind] LIKE '%' + @coffeeGrind + '%'))">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="1" Name="stockQuantity" Type="Int32" />
                        <asp:ControlParameter ControlID="selectedCoffeeGrind" Name="coffeeGrind" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                    </div>
                   </div>
                <br />
                <br />
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