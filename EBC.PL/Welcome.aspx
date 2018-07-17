<%@ Page Title="" Language="C#" MasterPageFile="~/ElectricityMaster.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="EBC.PL.Welcome" %>
<%@ MasterType VirtualPath="~/ElectricityMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">

    <asp:Label ID="lblWelcome" runat="server"></asp:Label>
    <br /><br />
    <center>
    <h2>Electricity Bill Details</h2>
    <asp:GridView ID="gvElectricity" runat="server" AutoGenerateColumns="False"  DataKeyNames="userId" DataSourceID="Electricity">
        <Columns>
            <asp:BoundField DataField="userId" HeaderText="userId" ReadOnly="True" SortExpression="userId" />
            <asp:BoundField DataField="userName" HeaderText="userName" SortExpression="userName" />
            <asp:BoundField DataField="lastReading" HeaderText="lastReading" SortExpression="lastReading" />
            <asp:BoundField DataField="currentReading" HeaderText="currentReading" SortExpression="currentReading" />
            <asp:BoundField DataField="units" HeaderText="units" SortExpression="units" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Electricity" runat="server" ConnectionString="<%$ ConnectionStrings:ElectricityConnString %>" SelectCommand="SELECT * FROM [ElectricityBill]"></asp:SqlDataSource>
        </center>
  
</asp:Content>
