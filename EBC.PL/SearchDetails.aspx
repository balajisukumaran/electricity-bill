<%@ Page Title="" Language="C#" MasterPageFile="~/ElectricityMaster.Master" AutoEventWireup="true" CodeBehind="SearchDetails.aspx.cs" Inherits="EBC.PL.SearchDetails" %>
<%@ MasterType VirtualPath="~/ElectricityMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">

     <table>
        <tr>
            <td colspan="2">
                <h3>Insert Bill Details Here</h3>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblId" runat="server" Text="User Id : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtuserId" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search Details" OnClick="btnSearch_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblName" runat="server" Text="User Name : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbllast" runat="server" Text="Last Month Reading: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtlast" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCurrent" runat="server" Text="Current Month Reading: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcurrent" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>       
        
        <tr>
            <td>
                <asp:Label ID="lblunits" runat="server" Text="Units Consumed"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtunits" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblprice" runat="server" Text="Price: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtprice" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
    </table>

</asp:Content>
