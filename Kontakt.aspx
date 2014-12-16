<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kontakt.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <br />
        <asp:TextBox CssClass="login_input" required="required" ID="kontakt_navn" style="text-align:center" value="Navn" onfocus="if (this.value == 'Navn') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Navn';}" runat="server" Width="22%"></asp:TextBox>
        <br />
        <asp:TextBox CssClass="login_input" required="required" TextMode="Email" ID="kontakt_email" style="text-align:center" value="Email" onfocus="if (this.value == 'Email') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Email';}" runat="server" Width="22%"></asp:TextBox>
        <br />
        <asp:TextBox id="kontakt_besked" TextMode="multiline" Columns="28" Rows="5" runat="server" ></asp:TextBox>
        <br />
        <asp:Button CssClass="button" ID="Send_besked" runat="server" Text="Send besked" OnClick="Send_besked_Click" />
        <input class="button" id="Reset1" type="reset" value="Reset" />
        <a class="button" href="Default.aspx">Til forsiden</a>
    <br />
    <asp:Label style="color:red"  ID="besked_send" runat="server" Visible="false" Text="Tak for din besked."></asp:Label>
</asp:Content>

