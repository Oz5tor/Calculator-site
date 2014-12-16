<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_Admin.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Dette er Admin</h4>
    <asp:Label ID="Admin_Label" runat="server" Text=""></asp:Label>
    <br />
    <asp:DropDownList CssClass="login_input" ID="Dropdown_dropdelete" style="text-align:center" runat="server" Width="22%">
    </asp:DropDownList>
    <br />
        <asp:Button CssClass="button" ID="delete_user" runat="server" Text="Slet bruger" OnClick="delete_user_Click" />
        <asp:Button CssClass="button" ID="logoff_admin" runat="server" Text="Log af" OnClick="logoff_admin_Click" />
</asp:Content>

