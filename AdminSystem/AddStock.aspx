<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddStock.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<script runat="server">

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Name" runat="server" Text="Name" width="80px"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Quantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" OnClientClick="onSubmit" Text="Submit" />
        </p>
        <p>
            <asp:Button ID="BackButton" runat="server" OnClick="Button1_Click" Text="Go Back" />
        </p>
    </form>
</body>
</html>
