﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Glemt_kode.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Her kan du få resat dit password!</h3>
    <asp:Label ID="Resat_label" runat="server" Visible="false" Text="Test1"></asp:Label>
    <br />
    <asp:TextBox CssClass="login_input" required="required" ID="res_Username" style="text-align:center" value="Indtast Brugernavn" onfocus="if (this.value == 'Indtast Brugernavn') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Indtast Brugernavn';}" runat="server" Width="22%"></asp:TextBox>
    <br />
    <asp:TextBox CssClass="login_input" required="required" TextMode="Email" ID="res_email" style="text-align:center" value="Email" onfocus="if (this.value == 'Email') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Email';}" runat="server" Width="22%"></asp:TextBox>
    <br />
    <asp:TextBox CssClass="login_input" required="required" ID="res_password" style="text-align:center" value="Nyt Password" onfocus="if (this.value == 'Nyt Password') {this.value = '';this.type='password';}" onblur="if (this.value == '') {this.value = 'Nyt Password';this.type='text';}" runat="server" Width="22%"></asp:TextBox>
    <br /> 
    <asp:TextBox CssClass="login_input" required="required" ID="conf_res_password" style="text-align:center" value="Bekræft Nyt Password" onfocus="if (this.value == 'Bekræft Nyt Password') {this.value = '';this.type='Password';}" onblur="if (this.value == '') {this.value = 'Bekræft Nyt Password';this.type='text';}" runat="server" Width="22%"></asp:TextBox>
    <br />

    <asp:Button CssClass="button" ID="Ress_password" runat="server" Text="Reset Password" OnClick="Ress_password_Click" />
    <asp:Button CssClass="button" ID="forside_glemt" runat="server" Text="Log af" OnClick="forside_glemt_Click" />


</asp:Content>

