<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_Admin.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="wrapper">
    <h4>Dette er Admin</h4>
        <asp:Button ID="logoff_admin" runat="server" Text="Log af" OnClick="logoff_admin_Click" />
        </div>
</asp:Content>

