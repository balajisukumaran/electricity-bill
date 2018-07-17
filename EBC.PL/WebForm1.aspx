<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EBC.PL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <meta name = "viewport" content = "width = device-width, initial-scale = 1"/>      
      <link rel = "stylesheet"
         href = "https://fonts.googleapis.com/icon?family=Material+Icons"/>
      <link rel = "stylesheet"
         href = "https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.3/css/materialize.min.css"/>
      <script type = "text/javascript"
         src = "https://code.jquery.com/jquery-2.1.1.min.js"></script>    
        
      <script src = "https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.3/js/materialize.min.js">
      </script> 
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.13/css/jquery.dataTables.min.css"/>
  
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.13/js/jquery.dataTables.min.js"></script>

    <script>
        $(function () {
            $("#gvElectricity").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>

    </head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
    <h2>Electricity Bill Details</h2>
    <asp:GridView ID="gvElectricity" CssClass="responsive-table" runat="server" AutoGenerateColumns="False"  DataKeyNames="userId" DataSourceID="Electricity">
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


    </div>
    </form>
</body>
</html>
