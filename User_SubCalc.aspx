<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_SubCalc.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Dette er SubCalc</h4>
    <asp:Label ID="Subcalc_Label" runat="server" Text=""></asp:Label>
    <br />
        <asp:Button CssClass="button" ID="logoff_subcalc" runat="server" Text="Log af" OnClick="logoff_subcalc_Click" />
</asp:Content>

