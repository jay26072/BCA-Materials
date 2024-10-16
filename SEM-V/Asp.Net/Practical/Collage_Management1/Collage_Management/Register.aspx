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
        .auto-style14 {
            width: 165px;
            height: 40px;
        text-align: center;
    }
        .auto-style15 {
            height: 40px;
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
            height: 61px;
        text-align: center;
    }
        .auto-style18 {
            height: 61px;
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
            <td class="auto-style12">Frist Name:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Last Name:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox2" runat="server"> </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Username:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Password:</td>
            <td class="auto-style13">
                <input id="Password1" type="password" /></td>
        </tr>
        <tr>
            <td class="auto-style12">Confirm Password:</td>
            <td class="auto-style13">
                <input id="Password2" type="password"/></td>
        </tr>
        <tr>
            <td class="auto-style12">Date Of Birth:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Gender:</td>
            <td class="auto-style13">
                <asp:RadioButton ID="Male" runat="server" Text="Male" name="gender" GroupName="gender" />
&nbsp;&nbsp;
                <asp:RadioButton ID="Femaile" runat="server" Text="Female" GroupName="gender" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Department:</td>
            <td class="auto-style13">
                <select id="Select2" name="D2" >
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>Select Your Department</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>BCA</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>BBA</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>MCA</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>MBA</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </select></td>
        </tr>
        <tr>
            <td class="auto-style12">Address:</td>
            <td class="auto-style13">
                <textarea id="TextArea1" name="S1" ></textarea></td>
        </tr>
        <tr>
            <td class="auto-style12">E-Mail:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Mobile No:</td>
            <td class="auto-style15">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Role:</td>
            <td class="auto-style18">
                <select id="Select1" name="D1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>Select Your Role</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>Staff</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <option>Student</option>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </select></td>
        </tr>
    </table>
        <b>
        <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </b>
        </b>&nbsp;</form>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input id="Button1" type="button" value="Submit" class="auto-style16 btn btn-success"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input id="Button2" type="button" value="Reset" class="auto-style16 btn btn-danger" /></b><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
