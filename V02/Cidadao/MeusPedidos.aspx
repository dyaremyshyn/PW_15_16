<%@ Page Title="" Language="C#" MasterPageFile="~/Cidadao/Cidadao.master" AutoEventWireup="true" CodeFile="MeusPedidos.aspx.cs" Inherits="Cidadao_MeusPedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Meus Pedidos:"></asp:Label> </h1>
        <p></p>
    <asp:Label ID="Pedidol" runat="server" Text="Queixas:"></asp:Label>
    <asp:DropDownList ID="Pedidos" AutoPostBack="true" runat="server"></asp:DropDownList>

    <p></p>
    <asp:TextBox ID="Pedido" Rows="9" Columns="60" TextMode="MultiLine" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Datalabel" runat="server" Text="Data de Início:"></asp:Label>
    <asp:TextBox ID="Data" runat="server" Width="84px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="DataFiml" runat="server" Text="Data de Fim:"></asp:Label>
    <asp:TextBox ID="DataFim" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Estadol" runat="server" Text="Estado:"></asp:Label>
    <asp:RadioButtonList ID="Estado" Enabled="false" RepeatDirection="Horizontal" runat="server">
      <asp:ListItem>Visto</asp:ListItem>
      <asp:ListItem Value="Nao Visto">N&#227;o Visto</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Situacaol" runat="server" Text="Situação:"></asp:Label>
    <asp:RadioButtonList ID="Situacao" RepeatDirection="Horizontal" Enabled="false" runat="server">
        <asp:ListItem>Em Andamento</asp:ListItem>
        <asp:ListItem>Por Começar</asp:ListItem>
        <asp:ListItem>Finalizada</asp:ListItem>
    </asp:RadioButtonList>
 
     <asp:Label ID="Notasl" runat="server" Text="Notas:"></asp:Label>
    <asp:DropDownList ID="Notas" runat="server"></asp:DropDownList>
    <p></p>
    <asp:TextBox ID="Nota" Rows="5" Columns="60" TextMode="MultiLine" ReadOnly="true" runat="server"></asp:TextBox>
</asp:Content>

