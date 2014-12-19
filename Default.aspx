<%@ Page Title="ÜberCalc Inc" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
    <h4>Velkommen til | Login</h4>
          
  <%-- Dette gør enter gpr til Login_field - istedet for næste boks i teksten. --%>
  <asp:Panel id="pnlDefaultButton" runat="server" DefaultButton="Login_field">


        <asp:TextBox CssClass="login_input" ID="Username_Field" style="text-align:center" value="Brugernavn" onfocus="if (this.value == 'Brugernavn') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Brugernavn';}" runat="server" Width="22%"></asp:TextBox>
            <br />
            <asp:TextBox CssClass="login_input" ID="Password_Field"  style="text-align:center; margin-left:30px;" value="Password" onfocus="if (this.value == 'Password') {this.value = '';this.type='password';}" onblur="if (this.value == '') {this.value = 'Password';this.type='text';}" runat="server" Width="22%"></asp:TextBox>
        <asp:Button CssClass="button" ID="Glemt_field" runat="server" DefaultButton="Login_field" Text="?" OnClick="_field_Click" Height="20px" Width="20px" />
            <br />
        <asp:Button CssClass="button" ID="Login_field" runat="server" Text="Login" OnClick="Login_field_Click" />
        <asp:Button CssClass="button" ID="new_user" runat="server" Text="Ny bruger?" OnClick="new_user_field_Click" />
        <asp:Button CssClass="button" ID="kontakt_field" runat="server" Text="Kontakt os?" OnClick="kontakt_field_Click" />


        </asp:Panel>
</asp:Content>      
