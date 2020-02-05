<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Panel ID="pnlNotLoggedIn" runat="server">
            You are not logged in.<br /> Please
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">login</asp:HyperLink>
            &nbsp;here.</asp:Panel>
    </form>
</body>
</html>
