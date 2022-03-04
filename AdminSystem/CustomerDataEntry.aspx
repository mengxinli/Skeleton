<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

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
            <td><asp:Button ID="Button2" runat="server" Text="login" onclick="Button2_Click" /> </td>
            <td> <asp:Button ID="Button1" runat="server" Text="register" onclick="Button1_Click" /></td>
        </tr>
       </table>
    </div>
    </form>
</body>
</html>