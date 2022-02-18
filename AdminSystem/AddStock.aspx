<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Quantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" />
        </p>
    </form>
</body>
</html>
