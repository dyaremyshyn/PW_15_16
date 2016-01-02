<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="PedidosRecebidosVistos.aspx.cs" Inherits="Agente_PedidosRecebidosVistos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Pedidos Vistos"></asp:Label> </h1>
    <p></p>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Situação: "></asp:Label>
        <asp:CheckBoxList ID="cbSituacao" runat="server">
            <asp:ListItem Selected="True">Em andamento</asp:ListItem>
            <asp:ListItem>Por começar</asp:ListItem>
            <asp:ListItem>Finalizado</asp:ListItem>
        </asp:CheckBoxList>
    </div>
    <asp:Label ID="Label3" runat="server" Text="Autor do Pedido: "></asp:Label>
    <asp:DropDownList ID="ddlAutorPedido" runat="server"></asp:DropDownList>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label4" runat="server" Text="Assunto: "></asp:Label>
    <asp:DropDownList ID="ddlAssunto" runat="server"></asp:DropDownList>

    <p></p>
     <asp:Label ID="Label6" runat="server" Text="Data Início: "></asp:Label>
    <asp:TextBox ID="txtDataInicio" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp<asp:Calendar ID="cDataInicio" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Data Fim: "></asp:Label>
    <asp:TextBox ID="txtDataFim" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp<asp:Calendar ID="cDataFim" runat="server"></asp:Calendar>
    <p></p>
    <asp:Button ID="btnRegistarNovoPedido" runat="server" Text="Registar Novo Pedido"/>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" BackColor="green" />
</asp:Content>

