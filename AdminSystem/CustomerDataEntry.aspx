<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="CustomerDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 436px;
        }
    </style>
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
            <asp:Label ID="PhoneNumber" runat="server" Text="PhoneNumber"></asp:Label>
            <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="DateAdded" runat="server" Text="DateAdded"></asp:Label>
            <asp:TextBox ID="TextBoxDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="UserId" runat="server" Text="UserId"></asp:Label>
            <asp:TextBox ID="TextBoxUserId" runat="server"></asp:TextBox>
        </p>
            <asp:Button ID="FindButton" runat="server" OnClick="btnFind" Text="Find" />
        <p>
            <asp:Button ID="BackButton" runat="server" OnClick="Back" Text="Back" />
        </p>
            <asp:Button ID="ButtonSubmit" runat="server" OnClick="Submit" Text="Submit" />       
    </form>
</body>
</html>