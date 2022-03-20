<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1WebForm1.aspx.cs" Inherits="WebApplication1.1WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="css/LoginStyle.css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 147px;
        }
        .style2
        {
            width: 595px;
        }
        .style3
        {
            width: 595px;
            height: 46px;
        }
        .style4
        {
            height: 46px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table>
        <tr>
            <td> <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label> </td>
            <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
            <td> <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label> </td>
            <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Button ID="Button2" runat="server" Text="login" onclick="Button2_Click" /> </asp:Label> </td>
            <td> <asp:Button ID="Button1" runat="server" Text="Register" onclick="Button1_Click" /> </asp:TextBox></td>
        </tr>
       </table>
    </div>
    </form>
</body>
</html>