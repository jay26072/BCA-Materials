<%@ Page Title="" Language="VB" MasterPageFile="~/clgmst.Master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <center>
        <h1>Login</h1>
    </center>
    <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
    &nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;
    <asp:TextBox ID="Username" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
    &nbsp;
    :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <br />
</asp:Content>

