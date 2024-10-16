<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/clgmst.Master" CodeBehind="Login.aspx.vb" Inherits="Collage_Management.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 22%;
            height: 122px;
            margin-top: 0px;
        }
        .auto-style11 {
            width: 134px;
            height: 25px;
        }
        .auto-style12 {
            height: 35px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <br />
        <form class="form-control shadow p-3 mb-5 bg-body rounded">
            <center style="height: 206px">
        <table align="center" class="auto-style9">
            <tr>
                <td class="auto-style11"><strong>User Name:</strong></td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBox1" runat="server" Height="28px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Password:</strong></td>
                <td class="auto-style12">
                    <input id="Password1" type="password" /></td>
            </tr>
        </table>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login"  class="btn btn-primary"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Forget Password" Width="164px"  class="btn btn-link"/>
&nbsp;
                <br />
        </center>
        </form>
            
            
   
    
</asp:Content>
