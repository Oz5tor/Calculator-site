<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_new.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h3>Opret bruger</h3>

        <asp:TextBox CssClass="login_input" required="required" ID="new_username" style="text-align:center" value="Brugernavn" onfocus="if (this.value == 'Brugernavn') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Brugernavn';}" runat="server" Width="22%"></asp:TextBox>
        <br />
        <asp:TextBox CssClass="login_input" required="required" ID="new_password" style="text-align:center" value="Password" onfocus="if (this.value == 'Password') {this.value = '';this.type='password';}" onblur="if (this.value == '') {this.value = 'Password';this.type='text';}" runat="server" Width="22%"></asp:TextBox>
        <br /> 
        <asp:TextBox CssClass="login_input" required="required" ID="conf_new_password" style="text-align:center" value="Bekræft Password" onfocus="if (this.value == 'Bekræft Password') {this.value = '';this.type='Password';}" onblur="if (this.value == '') {this.value = 'Bekræft Password';this.type='text';}" runat="server" Width="22%"></asp:TextBox>
        <br />
        <asp:TextBox CssClass="login_input" required="required" ID="new_address" style="text-align:center" value="Adresse" onfocus="if (this.value == 'Adresse') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Adresse';}" runat="server" Width="22%"></asp:TextBox>
        <br />
        <asp:TextBox CssClass="login_input" required="required" TextMode="Email" ID="new_email" style="text-align:center" value="Email" onfocus="if (this.value == 'Email') {this.value = '';}" onblur="if (this.value == '') {this.value = 'Email';}" runat="server" Width="22%"></asp:TextBox>
        <br />


        
        <asp:DropDownList CssClass="login_input" ID="Usertype_drop" style="text-align:center" runat="server" Width="22%">
            <asp:ListItem Text="Vælg brugertype" Value="" />
             <asp:ListItem Text="Admin" Value="Admin" />
            <asp:ListItem Text="Sub" Value="Sub" />
            <asp:ListItem Text="Calc" Value="Calc" />
            <asp:ListItem Text="SubCalc" Value="SubCalc" />
        </asp:DropDownList>
         
    <br />

        <asp:Button CssClass="button" ID="create_user" runat="server" Text="Opret bruger" OnClick="create_user_Click" />
        <a class="button" href="Default.aspx">Til forsiden</a>
    <br />
    <asp:Label ID="label_brugerfindes" style="color:red" runat="server" Text="" Visible ="false"></asp:Label>
    <asp:Label ID="label_brugeropret" style="color:red" runat="server" Text="" Visible ="false"></asp:Label>
</asp:Content>

