<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Pedidos.aspx.cs" Inherits="Comandante_Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Pedidos"></asp:Label> </h1>
    <asp:RadioButtonList AutoPostBack="true" ID="RadioButtonList1" runat="server">
        <asp:ListItem Value="VISTO">Visto</asp:ListItem>
        <asp:ListItem Value="NAO VISTO">N&#227;o Visto</asp:ListItem>
    </asp:RadioButtonList>
    <p></p>
    <asp:Label ID="Pedidol" runat="server" Text="Pedido:"></asp:Label>
    <asp:DropDownList ID="Pedido" AutoPostBack="true" runat="server"></asp:DropDownList>
    
</asp:Content>

