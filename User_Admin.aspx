<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_Admin.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        td {
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Dette er Admin</h4>
    <asp:Label ID="Admin_Label" runat="server" Text=""></asp:Label>
    <br />


    

    <asp:DropDownList CssClass="login_input" ID="Dropdown_dropdelete" AutoPostBack="false" style="text-align:center" runat="server" Width="22%">
    </asp:DropDownList>
       <asp:Button CssClass="button" ID="select_user" runat="server" Text="Vælg Bruger" OnClick="select_user_Click" />
<center>
<table>
        <tr>
            <td><asp:Label Visible="false" ID="user_id_lable" runat="server" Text="Bruger ID"></asp:Label></td>
            <td><asp:TextBox Visible="false" ReadOnly="true" Cssclass="login_input" ID="user_id" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label Visible="false" ID="Brugernavn" runat="server" Text="Brugernavn"></asp:Label></td>
            <td><asp:TextBox Visible="false" Cssclass="login_input" ID="Edit_username" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label Visible="false" ID="Kodeord" runat="server" Text="Kodeord"></asp:Label></td>
            <td><asp:TextBox Visible="false" Cssclass="login_input" ID="Edit_pwd" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label Visible="false" ID="Addresse" runat="server" Text="Addresse"></asp:Label></td>
            <td><asp:TextBox Visible="false" Cssclass="login_input" ID="Edit_adress" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label Visible="false" ID="Email" runat="server" Text="Email"></asp:Label></td>
            <td><asp:TextBox Visible="false" Cssclass="login_input" ID="Edit_email" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label Visible="false" ID="Brugertype" runat="server" Text="Brugertype"></asp:Label>  </td>
            <td>
                <asp:DropDownList CssClass="login_input" Visible="false" ID="Edit_usertype" style="text-align:center" runat="server" Width="70%">
                    <asp:ListItem Text="Admin" Value="Admin" />
                    <asp:ListItem Text="Sub" Value="Sub" />
                    <asp:ListItem Text="Calc" Value="Calc" />
                    <asp:ListItem Text="SubCalc" Value="SubCalc" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <%-- Sætte to kolonner sammen --%>
            <td colspan="2">
                <asp:Button Visible="false" CssClass="button" ID="update_user" runat="server" Text="Opdater bruger" OnClick="update_user_Click" />
                <asp:Button Visible="false" CssClass="button" ID="delete_user" runat="server" Text="Slet bruger" OnClick="delete_user_Click" />
                <asp:Button CssClass="button" ID="logoff_admin" runat="server" Text="Log af" OnClick="logoff_admin_Click" />
                <asp:Button CssClass="button" ID="Tilbage_select_user" Visible="false" runat="server" Text="Tilbage" OnClick="Tilbage_select_user_Click" />
            </td>
        </tr>
    </table>
</center>
</asp:Content>

