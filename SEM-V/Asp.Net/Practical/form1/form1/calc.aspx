<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="calc.aspx.vb" Inherits="form1.calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 153px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table dir="ltr" style="width: 26%; height: 130px;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Enter Value of A:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="30px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Enter Value Of B:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="34px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Answer"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="+" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="-" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="*" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" style="height: 29px" Text="/" />
    </form>
</body>
</html>
