<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_Calc.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Dette er calc</h4>
    <asp:Label ID="Calc_Label" runat="server" Text=""></asp:Label>
    <br />
        <asp:Button CssClass="button" ID="logoff_calc" runat="server" Text="Log af" OnClick="logoff_calc_Click" />
</asp:Content>

