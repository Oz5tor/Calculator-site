<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_Sub.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Dette er Sub</h4>
        <asp:Button ID="logoff_sub" runat="server" Text="Log af" OnClick="logoff_sub_Click" />
</asp:Content>

