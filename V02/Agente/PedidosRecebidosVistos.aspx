<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="PedidosRecebidosVistos.aspx.cs" Inherits="Agente_PedidosRecebidosVistos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Pedidos Vistos"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Autorl" runat="server" Text="Autor:"></asp:Label>
    <asp:HyperLink ID="Autor" runat="server">HyperLink</asp:HyperLink>
    <p></p>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Situação: "></asp:Label>
        <asp:DropDownList ID="Situacao" runat="server"></asp:DropDownList>
    </div>
    <asp:Label ID="Label3" runat="server" Text="Autor do Pedido: "></asp:Label>
    <asp:DropDownList ID="ddlAutorPedido" runat="server"></asp:DropDownList>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label4" runat="server" Text="Assunto: "></asp:Label>
    <asp:DropDownList ID="ddlAssunto" runat="server"></asp:DropDownList>

    <p></p>
     <asp:Label ID="Label6" runat="server" Text="Data Início: "></asp:Label>
    <asp:TextBox ID="txtDataInicio" runat="server" TextMode="Date"></asp:TextBox>
    &nbsp&nbsp&nbsp<asp:Calendar ID="cDataInicio" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Data Fim: "></asp:Label>
    <asp:TextBox ID="txtDataFim" runat="server" TextMode="Date"></asp:TextBox>
    &nbsp&nbsp&nbsp<asp:Calendar ID="cDataFim" runat="server"></asp:Calendar>
    <p></p>
    <asp:Button ID="btnRegistarNovoPedido" runat="server" Text="Registar Novo Pedido" OnClick="btnRegistarNovoPedido_Click"/>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
    <asp:Button ID="EscreverM" runat="server" Text="Escrever Nota" OnClick="EscreverM_Click" />
    <p></p>
    <asp:Label ID="Mensagem" Visivel="false" runat="server" Text="Nota:"></asp:Label>
    <asp:TextBox ID="txtNota" Visivel="false" Rows="5" Columns="40" TextMode="MultiLine" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Enviar" Visivel="false" runat="server" Text="Enviar" OnClick="Enviar_Click" />&nbsp;<asp:Button ID="Cancelar" Visivel="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

