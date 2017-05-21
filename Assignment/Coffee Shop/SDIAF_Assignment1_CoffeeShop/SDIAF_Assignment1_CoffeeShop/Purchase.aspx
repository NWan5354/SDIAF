<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.Purchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Purchase</title>
    <h1 style="font-family: Arial; color: white">Purchasing Coffee</h1>
</head>
<body>
    <br />
    <h3 style="font-family: Arial; color: white">You are just a click away from purchasing your coffee</h3>
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="jumbotron">
                    <h3 style="font-family: Arial">Step 1:</h3>
                    <br />
                    <h3 style="font-family: Arial">Ordering the following item:</h3>
                    <br />
                    <asp:Label ID="lblCoffeeName" runat="server" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label text="£" runat="server" Font-Size="Large"></asp:Label>
                    <asp:Label ID="lblCoffeePrice" runat="server" Font-Size="Large"></asp:Label>
                    <asp:Label Text=" (Price Per Unit)" runat="server" Font-Size="Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Label Text="Set Quantity" runat="server" Font-Size="Large"></asp:Label>
                    <asp:TextBox ID="txtSetQuantity" Text="1" runat="server" Font-Size="Large" CssClass="form-control" Width="60px"></asp:TextBox>
                    <asp:Button ID="btndeincrementQuantity" Text="-" runat="server" Font-Size="Small" CssClass="btn btn-default" OnClick="btndeincrementQuantity_Click" />
                    <asp:Button ID="btnincrementQuantity" Text="+" runat="server" Font-Size="Small" CssClass="btn btn-default" OnClick="btnincrementQuantity_Click" />
                    <br />
                    <br />
                    
                    </div>
                </div>
            <div class="col-md-4">
                <div class="jumbotron">
                    <h3 style="font-family: Arial">Step 2:</h3>
                    <br />
                    <h3 style="font-family: Arial">Total to pay:</h3>
                    <br />
                    <br />
                    <br />
                    <asp:Label Text="Total Amount: £" runat="server" Font-Size="Large"></asp:Label>
                    <asp:Label ID="lblTotalAmount" runat="server" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label Text="Quantity being ordered:" runat="server" Font-Size="Large"></asp:Label>
                    <asp:Label ID="lblQuantity" Text="1" runat="server" Font-Size="Large"></asp:Label>
                    <br />
                    <h4 style="font-family: Arial; color: red">Please fill out <strong>all</strong> fields in <strong>Step 3</strong> and click on Check Out</h4>
                    <br />
                </div>
            </div>
            <div class="col-md-4">
                <div class="jumbotron">
                    <h3 style="font-family: Arial">Step 3:</h3>
                    <br />
                    <h3 style="font-family: Arial">Deliver to the following:</h3>
                    <br />
                    <asp:Label id="lblinStock" runat="server" visible="false"></asp:Label>
                    <br />
                    <asp:Label text="Name: " runat="server" Font-Size="Medium"></asp:Label>
                    <asp:TextBox id="txtName" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Name"></asp:TextBox>
                    <br />
                    <asp:Label text="Want us to find your address?" runat="server" Font-Size="Medium"></asp:Label>
                    <asp:TextBox id="textboxHouseNo" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="House No"></asp:TextBox>
                    <br />
                    <asp:TextBox id="textboxPostcode" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Postcode"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnFindAddress" Text="Auto Complete" runat="server" OnClick="btnFindAddress_Click" />
                    <br />
                    <br />
                    <asp:Label text="House No / Street: " runat="server" Font-Size="Medium"></asp:Label>
                    <asp:TextBox id="txtStreetName" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Address Line 1"></asp:TextBox>
                    <br />
                    <asp:Label text="Town: " runat="server" Font-Size="Medium"></asp:Label>
                    <asp:TextBox id="txtTown" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Town"></asp:TextBox>
                    <br />
                    <asp:Label text="Postcode: " runat="server" Font-Size="Medium"></asp:Label>
                    <asp:TextBox id="txtPostcode" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Postcode"></asp:TextBox>
                    <br />
                    <asp:Label text="Contact No: " runat="server" Font-Size="Medium"></asp:Label>
                    <asp:TextBox id="txtContactNo" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="0123456789"></asp:TextBox>
                    <br />
                    <asp:Label text="Email: " runat="server" Font-Size="Medium" ID="Label1"></asp:Label>
                    <asp:TextBox id="txtEmail" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Name@example.co.uk"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnCheckout" Text="Check Out" runat="server" CssClass="btn btn-success" OnClick="btnCheckout_Click" />
                    <br />
                    <br />
                    <asp:Label runat="server" Font-Size="Medium" ID="lblInvalidQuantity" ForeColor="Red" Visible="False"></asp:Label>
                    <br />
                </div>
            </div>
        </div>
    </div>
</body>
</html>
</asp:Content>