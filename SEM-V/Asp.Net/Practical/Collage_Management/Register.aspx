<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/clgmst.Master" CodeBehind="Register.aspx.vb" Inherits="Collage_Management.Register" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 37%;
            height: 370px;
            font-weight: 700;
        }
        #TextArea1 {
            height: 26px;
            width: 208px;
        }
        #Select1 {
            width: 196px;
        }
        .auto-style12 {
        width: 165px;
        height: 39px;
        text-align: center;
    }
        .auto-style13 {
        height: 39px;
        text-align: center;
    }
        #Select2 {
            width: 208px;
        }
        #Button1 {
            height: 32px;
            width: 96px;
        }
        #Button2 {
            height: 32px;
            width: 96px;
        }
    .auto-style16 {
        font-weight: bold;
    }
        .auto-style17 {
            width: 165px;
            height: 73px;
            text-align: center;
        }
        .auto-style18 {
            height: 73px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<center><h1 style="color:white"><strong><em>Registration</em></strong></h1></center><br />
    <br />
    <form class="form-control shadow p-3 mb-5 bg-body rounded">
        <table align="center" class="auto-style8" border="3">
        <br />
        <tr>
            <td class="auto-style12">Username:</td>
            <td class="auto-style13">
                <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Password:</td>
            <td class="auto-style13">
                <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Confirm Password:</td>
            <td class="auto-style18">
                <asp:TextBox ID="Cpass" runat="server"></asp:TextBox>
&nbsp;<br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Password" ControlToValidate="TextBox4" ErrorMessage="Password Not Match"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Date Of Birth:</td>
            <td class="auto-style13">
                &nbsp;<asp:TextBox ID="Dob" runat="server" ></asp:TextBox>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Gender:</td>
            <td class="auto-style13">
                <asp:DropDownList ID="Gender" runat="server" Width="107px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Department:</td>
            <td class="auto-style13">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>BCA</asp:ListItem>
                    <asp:ListItem>BBA</asp:ListItem>
                    <asp:ListItem>MCA</asp:ListItem>
                    <asp:ListItem>MBA</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
        <b>
        <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </b>
        </b>&nbsp;</form>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Button" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input id="Button2" type="button" value="Reset" class="auto-style16 btn btn-danger" /></b><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
