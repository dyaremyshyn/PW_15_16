<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="PedidosRecebidos.aspx.cs" Inherits="Agente_PedidosRecebidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Pedidos Recebidos"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Estado: "></asp:Label>
    <div>
        <asp:CheckBox ID="cbVisto" runat="server" /><asp:Label ID="Label3" runat="server" Text="Visto"></asp:Label> <br />
        <asp:CheckBox ID="cbNVisto" runat="server" /><asp:Label ID="Label4" runat="server" Text="Não Visto"></asp:Label>
    </div>
</asp:Content>

