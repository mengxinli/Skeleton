﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1WebForm2.aspx.cs" Inherits="WebApplication1.1WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label> </td>
            <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label> </td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td> <asp:Button ID="Button1" runat="server" Text="Register" onclick="Button1_Click" /> </td>
            <td> <asp:Button ID="Button2" runat="server" Text="Back" onclick="Button2_Click" /> </td>
        </tr>
    </table> 
    </div>
    </form>
</body>
</html>