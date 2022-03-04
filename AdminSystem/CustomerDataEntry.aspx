<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_Default" %>

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
        <asp:Label ID="UserName" runat="server" Text="UserName" ></asp:Label>
        <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="PassWord" runat="server" Text="PassWord"></asp:Label>
            <asp:TextBox ID="TextBoxPassWord" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonSubmit" runat="server" OnClick="Submit" OnClientClick="onSubmit" Text="Submit" />
        </p>
        <p>
            <asp:Button ID="BackButton" runat="server" OnClick="Back" Text="Back" />
        </p>
    </form>
</body>
</html>