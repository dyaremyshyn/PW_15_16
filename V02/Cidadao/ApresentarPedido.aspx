<%@ Page Title="" Language="C#" MasterPageFile="~/Cidadao/Cidadao.master" AutoEventWireup="true" CodeFile="ApresentarPedido.aspx.cs" Inherits="Cidadao_ApresentarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Fazer Pedido:"></asp:Label> </h1>
     <p></p>
    <asp:Label ID="final" Visible="false" BackColor="DarkSeaGreen" runat="server" Text=""></asp:Label>
    <p></p>
    <asp:Label ID="Motivol" runat="server" Text="Motivo:"></asp:Label>
    <asp:TextBox ID="Motivo" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Pedidol" runat="server" Text="Pedido:"></asp:Label>
    <asp:TextBox ID="Pedido" TextMode="MultiLine" Rows="15" Columns="60" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="DataIniciol" runat="server" Text="Data de Início:"></asp:Label>
    <asp:TextBox ID="DataIncio" TextMode="Date" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Datafiml" runat="server" Text="Data de Fim:"></asp:Label>
    <asp:TextBox ID="Datafim" TextMode="Date" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:Button ID="Cancelar" ForeColor="Red" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

