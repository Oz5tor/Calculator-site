<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_SubCalc.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="sub_calc/create_subcac_resuts.js"></script>
    <script src="sub_calc/subnetcalc.js"></script>
    <script src="norm_calc/norm_calc.js"></script>
    <link href="norm_calc/norm_calc_style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Dette er SubCalc</h4>
    <asp:Label ID="Subcalc_Label" runat="server" Text=""></asp:Label>
    <br />
    <center>
    <form style="float:left;" name="SCForm" action="#" id="SCForm">
	<div>
	<table style="float:left;">
	<tbody><tr><td>Class</td><td>
		A<input name="class" value="A" checked="true" onclick="calculateClass('A');" type="radio">
		B<input name="class" value="B" onclick="calculateClass('B');" type="radio">
		C<input name="class" value="C" onclick="calculateClass('C');" type="radio">
	</td></tr>
	<tr><td>Network IP</td><td>
		<input id="network" onchange="calculateIPCIDR(this.value);" type="text">
	</td></tr>
	<tr><td>Subnet Mask</td><td>
		<input id="mask" onchange="calculateSubnet(this.value);" type="text">
		<select id="maskSelect" onchange="calculateSubnet(this.options[this.selectedIndex].value);"><option value="255.0.0.0">255.0.0.0</option><option value="255.128.0.0">255.128.0.0</option><option value="255.192.0.0">255.192.0.0</option><option value="255.224.0.0">255.224.0.0</option><option value="255.240.0.0">255.240.0.0</option><option value="255.248.0.0">255.248.0.0</option><option value="255.252.0.0">255.252.0.0</option><option value="255.254.0.0">255.254.0.0</option><option value="255.255.0.0">255.255.0.0</option><option value="255.255.0.0">255.255.0.0</option><option value="255.255.128.0">255.255.128.0</option><option value="255.255.192.0">255.255.192.0</option><option value="255.255.224.0">255.255.224.0</option><option value="255.255.240.0">255.255.240.0</option><option value="255.255.248.0">255.255.248.0</option><option value="255.255.252.0">255.255.252.0</option><option value="255.255.254.0">255.255.254.0</option><option value="255.255.255.0">255.255.255.0</option><option value="255.255.255.0">255.255.255.0</option><option value="255.255.255.128">255.255.255.128</option><option value="255.255.255.192">255.255.255.192</option><option value="255.255.255.224">255.255.255.224</option><option value="255.255.255.240">255.255.255.240</option><option value="255.255.255.248">255.255.255.248</option><option value="255.255.255.252">255.255.255.252</option></select>
	</td></tr>
	<tr><td>Wildcard Mask</td><td>
		<input id="wildcard" readonly="readonly" type="text">
	</td></tr>
	<tr><td>Mask Bits</td><td>
		<input id="maskbits" readonly="readonly" type="text">
	</td></tr>
	<tr><td>Hosts</td><td>
		<input id="hosts" readonly="readonly" type="text">
		<select id="hostsSelect" onchange="calculateHosts(this.options[this.selectedIndex].value);"><option value="8">16777214</option><option value="9">8388606</option><option value="10">4194302</option><option value="11">2097150</option><option value="12">1048574</option><option value="13">524286</option><option value="14">262142</option><option value="15">131070</option><option value="16">65534</option><option value="17">32766</option><option value="18">16382</option><option value="19">8190</option><option value="20">4094</option><option value="21">2046</option><option value="22">1022</option><option value="23">510</option><option value="24">254</option><option value="25">126</option><option value="26">62</option><option value="27">30</option><option value="28">14</option><option value="29">6</option><option value="30">2</option></select>
	</td></tr>
	<tr><td>Subnet ID</td><td>
		<input id="subnetID" readonly="readonly" type="text">
	</td></tr>
	<tr><td>Start</td><td>
		<input id="startIP" readonly="readonly" type="text">
	</td></tr>
	<tr><td>End</td><td>
		<input id="endIP" readonly="readonly" type="text">
	</td></tr>
	<tr><td>Broadcast</td><td>
		<input id="broadcast" readonly="readonly" type="text">
	</td></tr>
	<tr><td>Bitmap</td><td>
		<input id="bitmap" size="35" disabled="disabled" type="text">
	</td></tr>
	</tbody></table>
</form>
    </center>   
    <form style="float:right;" action="">
    <table class="calculator" id="calc">
            <tr>
                <td colspan="4" class="calc_td_result">
                    <input type="text" readonly="readonly" name="calc_result" id="calc_result" class="calc_result" onkeydown="javascript:key_detect_calc('calc',event);" />
                </td>
            </tr>
            <tr>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="CE" onclick="javascript: f_calc('calc', 'ce');" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="&larr;" onclick="javascript: f_calc('calc', 'nbs');" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="%" onclick="javascript: f_calc('calc', '%');" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="+" onclick="javascript: f_calc('calc', '+');" />
                </td>
            </tr>
            <tr>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="7" onclick="javascript: add_calc('calc', 7);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="8" onclick="javascript: add_calc('calc', 8);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="9" onclick="javascript: add_calc('calc', 9);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="-" onclick="javascript: f_calc('calc', '-');" />
                </td>
            </tr>
                        <tr>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="4" onclick="javascript: add_calc('calc', 4);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="5" onclick="javascript: add_calc('calc', 5);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="6" onclick="javascript: add_calc('calc', 6);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="x" onclick="javascript: f_calc('calc', '*');" />
                </td>
            </tr>
            <tr>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="1" onclick="javascript: add_calc('calc', 1);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="2" onclick="javascript: add_calc('calc', 2);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="3" onclick="javascript: add_calc('calc', 3);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="&divide;" onclick="javascript: f_calc('calc', '');" />
                </td>
            </tr>
            <tr>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="0" onclick="javascript: add_calc('calc', 0);" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="&plusmn;" onclick="javascript: f_calc('calc', '+-');" />
                </td>
                <td class="calc_td_btn">
                        <input type="button" class="calc_btn" value="," onclick="javascript: add_calc('calc', '.');" />
                </td>
                <td class="calc_td_btn">
                        <input id="calcsum" type="button" class="calc_btn" value="=" onclick="javascript: f_calc('calc', '=');" />
                </td>
            </tr>
        </table>
        <script type="text/javascript">
            document.getElementById('calc').onload = init_calc('calc');
        </script>
        </form>

</div>
    <div style="clear:both;"></div>
    <center>
        <asp:Button CssClass="button" ID="logoff_subcalc" runat="server" Text="Log af" OnClick="logoff_subcalc_Click" />
    </center>
</asp:Content>