<%@ Page Language="C#" MasterPageFile="~/Bootstrap.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>Register</title>
    
</head>
<body>
    <div class="container-fluid">
       <div class="row">
           <div class="col-md-6">
               <h2 style="color: white">Let's get registered</h2>
               <br />
           </div>

           <div class="col-md-6">
               <br />
               <asp:Label Text="Name: " runat="server" ForeColor="White"></asp:Label>
               <asp:TextBox id="txtName" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Name"></asp:TextBox>
               <asp:RequiredFieldValidator runat="server" ErrorMessage="Name is required *" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <asp:Label Text="Email: " runat="server" ForeColor="White"></asp:Label>
               <asp:TextBox id="txtEmail" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Email Address"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Email address is required *" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>     
               <br />
               <asp:Label Text="Username: " runat="server" ForeColor="White"></asp:Label>
               <asp:TextBox id="txtUsername" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Username"></asp:TextBox>
               <asp:RequiredFieldValidator runat="server" ErrorMessage="Username is required *" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator> 
               <br/>
               <asp:Label Text="Password: " runat="server" ForeColor="White"></asp:Label>
               <asp:TextBox id="txtPassword" TextMode="Password" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Password"></asp:TextBox>
               <asp:RequiredFieldValidator runat="server" ErrorMessage="Password is required *" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>     
               <br/>
               <asp:Label Text="Confirm Password: " runat="server" ForeColor="White"></asp:Label>
               <asp:TextBox id="txtConfirmPassword" TextMode="Password" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Password Confirmation"></asp:TextBox>
               <asp:RequiredFieldValidator runat="server" ErrorMessage="Please confirm your password *" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator>     
               <br/>
               <asp:Label Text="Security Question: " runat="server" ForeColor="White"></asp:Label>
                    <br />
               <asp:DropDownList id="selectSecurityQuestion" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>What is your mother maiden name?</asp:ListItem>
                    <asp:ListItem>What is your first mobile number?</asp:ListItem>
                    <asp:ListItem>What is the name of your first primary school you attended?</asp:ListItem>
               </asp:DropDownList>
               <asp:RequiredFieldValidator runat="server" ErrorMessage="Please select a security question *" ControlToValidate="selectSecurityQuestion" ForeColor="Red"></asp:RequiredFieldValidator>     
               <br><br/>
                <asp:Label text="Security Question Answer: " runat="server" ForeColor="White"></asp:Label>
                <asp:TextBox id="txtSecQuesAnswer" runat="server" CssClass="form-control input-sm" Width="250px" placeholder="Security Question Answer"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Please provide an answer to your selected security question *" ControlToValidate="txtSecQuesAnswer" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               
                <br/>
                <asp:CompareValidator runat="server" ErrorMessage="Both passwords must be the same *" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ForeColor="Red"
                ></asp:CompareValidator>
               <br />
               <asp:Button ID="btnSubmit" Text="Register" runat="server" OnClick="btnSubmit_Click1" CssClass="btn btn-default btn-success" />           
           </div>
       </div>  
    </div>
</body>
</html>
</asp:Content>