<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CourseworkExcersise4PartA.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Convert Area</title>
    <h1 style="font-family: Arial">Convert Area</h1>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label Text="Area Value: " runat="server" Font-Names="Arial" />
        <asp:TextBox ID="txtUserAreaValue" runat="server" Font-Names="Arial" />  
        <br />
        <br />
        <asp:Label Text="From Area Unit: " runat="server" Font-Names="Arial" />
        
        <asp:DropDownList ID="dropDownFrom" runat="server">
            <asp:ListItem>acre</asp:ListItem>
            <asp:ListItem>acrecommercial</asp:ListItem>
            <asp:ListItem>acreIreland</asp:ListItem>
            <asp:ListItem>acresurvey</asp:ListItem>
            <asp:ListItem>are</asp:ListItem>
            <asp:ListItem>boxtinplatedsteel</asp:ListItem>
            <asp:ListItem>binTaiwan</asp:ListItem>
            <asp:ListItem>buJapan</asp:ListItem>
            <asp:ListItem>canteroEcuador</asp:ListItem>
            <asp:ListItem>caoVietnam</asp:ListItem>
            <asp:ListItem>centaire</asp:ListItem>
            <asp:ListItem>circularfootinternational</asp:ListItem>
            <asp:ListItem>circularfootUSsurvey</asp:ListItem>
            <asp:ListItem>circularinchinternational</asp:ListItem>
            <asp:ListItem>circularinchUSsurvey</asp:ListItem>
            <asp:ListItem>hectare</asp:ListItem>
            <asp:ListItem>laborCanada</asp:ListItem>
            <asp:ListItem>laborUSsurvey</asp:ListItem>
            <asp:ListItem>manzanaCostaRican</asp:ListItem>
            <asp:ListItem>manzanaArgentina</asp:ListItem>
            <asp:ListItem>rood</asp:ListItem>
            <asp:ListItem>saoVietnam</asp:ListItem>
            <asp:ListItem>scrupleancientRome</asp:ListItem>
            <asp:ListItem>sectionUSsurvey</asp:ListItem>
            <asp:ListItem>square</asp:ListItem>
            <asp:ListItem>squareSriLanka</asp:ListItem>
            <asp:ListItem>squareangstrom</asp:ListItem>
            <asp:ListItem>squareeastronomicalunit</asp:ListItem>
            <asp:ListItem>squarecablelengthUSsurvey</asp:ListItem>
            <asp:ListItem>squarecaliber</asp:ListItem>
            <asp:ListItem>squarecentimeter</asp:ListItem>
            <asp:ListItem>squarechainGunterUSsurvey</asp:ListItem>
            <asp:ListItem>squarechainRamdenEngineer</asp:ListItem>
            <asp:ListItem>squarecubit</asp:ListItem>
            <asp:ListItem>squarecubitancientEgypt</asp:ListItem>
            <asp:ListItem>squaredigit</asp:ListItem>
            <asp:ListItem>squarefathom</asp:ListItem>
            <asp:ListItem>squarefootinternational</asp:ListItem>
            <asp:ListItem>squarefootUSsurvey</asp:ListItem>
            <asp:ListItem>squarefurlongUSsurvey</asp:ListItem>
            <asp:ListItem>squaregigameter</asp:ListItem>
            <asp:ListItem>squarehectometer</asp:ListItem>
            <asp:ListItem>squareinchinternational</asp:ListItem>
            <asp:ListItem>squareinchUSsurvey</asp:ListItem>
            <asp:ListItem>squarekilometer</asp:ListItem>
            <asp:ListItem>squareleaguenautical</asp:ListItem>
            <asp:ListItem>squareleagueUSstatute</asp:ListItem>
            <asp:ListItem>squarelightyear</asp:ListItem>
            <asp:ListItem>squarelinkGunterUSsurvey</asp:ListItem>
            <asp:ListItem>squarelinkRamdenEngineer</asp:ListItem>
            <asp:ListItem>squaremegameter</asp:ListItem>
        </asp:DropDownList>
        
        <br />
        <br />
        <asp:Label Text="To Area Unit: " runat="server" Font-Names="Arial" />
        
        <asp:DropDownList ID="dropDownTo" runat="server">
            <asp:ListItem>acre</asp:ListItem>
            <asp:ListItem>acrecommercial</asp:ListItem>
            <asp:ListItem>acreIreland</asp:ListItem>
            <asp:ListItem>acresurvey</asp:ListItem>
            <asp:ListItem>are</asp:ListItem>
            <asp:ListItem>boxtinplatedsteel</asp:ListItem>
            <asp:ListItem>binTaiwan</asp:ListItem>
            <asp:ListItem>buJapan</asp:ListItem>
            <asp:ListItem>canteroEcuador</asp:ListItem>
            <asp:ListItem>caoVietnam</asp:ListItem>
            <asp:ListItem>centaire</asp:ListItem>
            <asp:ListItem>circularfootinternational</asp:ListItem>
            <asp:ListItem>circularfootUSsurvey</asp:ListItem>
            <asp:ListItem>circularinchinternational</asp:ListItem>
            <asp:ListItem>circularinchUSsurvey</asp:ListItem>
            <asp:ListItem>hectare</asp:ListItem>
            <asp:ListItem>laborCanada</asp:ListItem>
            <asp:ListItem>laborUSsurvey</asp:ListItem>
            <asp:ListItem>manzanaCostaRican</asp:ListItem>
            <asp:ListItem>manzanaArgentina</asp:ListItem>
            <asp:ListItem>rood</asp:ListItem>
            <asp:ListItem>saoVietnam</asp:ListItem>
            <asp:ListItem>scrupleancientRome</asp:ListItem>
            <asp:ListItem>sectionUSsurvey</asp:ListItem>
            <asp:ListItem>square</asp:ListItem>
            <asp:ListItem>squareSriLanka</asp:ListItem>
            <asp:ListItem>squareangstrom</asp:ListItem>
            <asp:ListItem>squareeastronomicalunit</asp:ListItem>
            <asp:ListItem>squarecablelengthUSsurvey</asp:ListItem>
            <asp:ListItem>squarecaliber</asp:ListItem>
            <asp:ListItem>squarecentimeter</asp:ListItem>
            <asp:ListItem>squarechainGunterUSsurvey</asp:ListItem>
            <asp:ListItem>squarechainRamdenEngineer</asp:ListItem>
            <asp:ListItem>squarecubit</asp:ListItem>
            <asp:ListItem>squarecubitancientEgypt</asp:ListItem>
            <asp:ListItem>squaredigit</asp:ListItem>
            <asp:ListItem>squarefathom</asp:ListItem>
            <asp:ListItem>squarefootinternational</asp:ListItem>
            <asp:ListItem>squarefootUSsurvey</asp:ListItem>
            <asp:ListItem>squarefurlongUSsurvey</asp:ListItem>
            <asp:ListItem>squaregigameter</asp:ListItem>
            <asp:ListItem>squarehectometer</asp:ListItem>
            <asp:ListItem>squareinchinternational</asp:ListItem>
            <asp:ListItem>squareinchUSsurvey</asp:ListItem>
            <asp:ListItem>squarekilometer</asp:ListItem>
            <asp:ListItem>squareleaguenautical</asp:ListItem>
            <asp:ListItem>squareleagueUSstatute</asp:ListItem>
            <asp:ListItem>squarelightyear</asp:ListItem>
            <asp:ListItem>squarelinkGunterUSsurvey</asp:ListItem>
            <asp:ListItem>squarelinkRamdenEngineer</asp:ListItem>
            <asp:ListItem>squaremegameter</asp:ListItem>
        </asp:DropDownList>
        
        <br />
        <br />
        <asp:Button ID="btnConvertValue" Text="Convert" runat="server" OnClick="btnConvertValue_Click" Font-Names="Arial" />
        <br />
        <br />
        <asp:Label Text="Result: " runat="server" Font-Names="Arial"></asp:Label>
        <asp:Label ID="lblConversionResult" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
