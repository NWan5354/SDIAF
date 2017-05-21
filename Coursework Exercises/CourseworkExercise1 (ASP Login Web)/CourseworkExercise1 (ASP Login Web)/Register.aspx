<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>Register</title>
    
</head>
<body>
    
    <div class="container-fluid">
        <div class="text-center">

        <h2>New to the website, lets get registered! Please fill in the fields and click "Register"</h2>

        <asp:RequiredFieldValidator runat="server" ErrorMessage="Name is required" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Email address is required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Username is required" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Password is required" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Please confirm your password" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:CompareValidator runat="server" ErrorMessage="Both passwords must be the same" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ForeColor="Red"
        ></asp:CompareValidator>  
        <br />
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Please select a security question" ControlToValidate="selectSecurityQuestion" ForeColor="Red"></asp:RequiredFieldValidator>    
              
        <br><br/>
        <asp:Label Text="Name: " runat="server"></asp:Label>
        <asp:TextBox id="txtName" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Email: " runat="server"></asp:Label>
        <asp:TextBox id="txtEmail" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Username: " runat="server"></asp:Label>
        <asp:TextBox id="txtUsername" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Password: " runat="server"></asp:Label>
        <asp:TextBox id="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Confirm Password: " runat="server"></asp:Label>
        <asp:TextBox id="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br><br/>
        <asp:Label Text="Security Question: " runat="server"></asp:Label>
        <asp:DropDownList id="selectSecurityQuestion" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>What is your mother maiden name?</asp:ListItem>
            <asp:ListItem>What is your first mobile number?</asp:ListItem>
            <asp:ListItem>What is the name of your first primary school you attended?</asp:ListItem>
            </asp:DropDownList>
        <br><br/>

        <asp:Label text="Security Question Answer: " runat="server"></asp:Label>
        <asp:TextBox id="txtSecQuesAnswer" runat="server"></asp:TextBox>
        <br><br />
        <asp:Button ID="btnSubmit" Text="Register" runat="server" OnClick="btnSubmit_Click1" />
        
       
        </div>
    </div>
    
</body>
</html>
</asp:Content>