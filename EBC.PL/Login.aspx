<%@ Page Title="" Language="C#" MasterPageFile="~/ElectricityMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EBC.PL.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 44%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <center><table style="text-align:left" class="auto-style1">
        <tr>
            <td colspan="2" style="background-color:deepskyblue;color:white;font-weight:bold">
                Login Here...
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblUserName" runat="server" Text="User Name : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="txtUserName" Text="Please provide user name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPassword" runat="server" Text="Password : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPwd" runat="server" ControlToValidate="txtPassword" Text="Please provide password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table></center>
</asp:Content>
