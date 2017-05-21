<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.RecoverPassword" %>

<asp:Content ID="Content1"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Recover Password</title>
    <br />
    <br />
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6">
                <h1 style="color: white">Password Recovery</h1>
            </div>
            <div class="col-md-6">
                
                
                
                
                <asp:Label Text="Email Address: " ForeColor="White" runat="server"></asp:Label>
                <asp:TextBox ID="txtEmail" CssClass="form-control input-sm" Width="250px" placeholder="coffee@example.co.uk" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Email Address is required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                <br/>
                <asp:Label Text="Security Question: " ForeColor="White" runat="server"></asp:Label>
                <asp:DropDownList ID="selectSecurityQuestion" CssClass="form-control" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>What is your mother maiden name?</asp:ListItem>
                    <asp:ListItem>What is your first mobile number?</asp:ListItem>
                    <asp:ListItem>What is the name of your first primary school you attended?</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Please pick the security question you registered with and provide an answer" ControlToValidate="selectSecurityQuestion" ForeColor="Red"></asp:RequiredFieldValidator>
                <br/>
                <asp:Label Text="Security Question Answer: " ForeColor="White" runat="server"></asp:Label>
                <asp:TextBox ID="txtSecQuesAns" CssClass="form-control input-sm" Width="250px" placeholder="Type in security question here" runat="server"></asp:TextBox>
                <br/>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Please provide an answer for your secrity question" ControlToValidate="txtSecQuesAns" ForeColor="Red"></asp:RequiredFieldValidator>
                <br/>
                <asp:Label ID="lblUserMessage" ForeColor="White" runat="server"></asp:Label>
                <br/>
                <asp:Button ID="btnRecoverPassword" Text="Recover" CssClass="btn btn-success" runat="server" OnClick="btnRecoverPassword_Click" />
            </div>
        </div>
    </div>
</body>
</html>
</asp:Content>