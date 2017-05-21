<%@ Page Language="C#" MasterPageFile="Bootstrap.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CourseworkExercise1__ASP_Login_Web_.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Default</title>
    
    
</head>
<body>
    
    <div>
    <p><%Response.Write(Session["userName"]); %></p>
    </div>
    
</body>
</html>
</asp:Content>