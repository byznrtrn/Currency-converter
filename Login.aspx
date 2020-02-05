<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <br />
      Name:
      <asp:TextBox ID="txtName" runat="server" Width="178px"></asp:TextBox>
      <asp:Button ID="cmdStore" runat="server" OnClick="cmdStore_Click" Text="Login" />
    </div>
    </form>
</body>
</html>
