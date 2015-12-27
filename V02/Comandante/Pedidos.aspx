<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Pedidos.aspx.cs" Inherits="Comandante_Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Pedidos"></asp:Label> </h1>
    <asp:Label ID="PedidoIF" runat="server" Text="Situação:"></asp:Label>
    <asp:RadioButtonList AutoPostBack="true" ID="RadioButtonList1" runat="server">
        <asp:ListItem>Visto</asp:ListItem>
        <asp:ListItem Value="Nao Visto">N&#227;o Visto</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Pedido" Visible="false" runat="server" Text="Pedido:"></asp:Label>
    <asp:DropDownList ID="DropDownList1" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="Pedidol" runat="server" Visible="false" Text="Pedido:"></asp:Label><p></p>
    <asp:TextBox ID="TextBox1" Visible="false" Columns="60" Rows="15" TextMode="MultiLine" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="DataIniciol" runat="server" Visible="false" Text="Data de Inicio:"></asp:Label>
    <asp:TextBox ID="DataInicio" TextMode="Date" Visible="false" runat="server" Width="112px"></asp:TextBox>&nbsp; &nbsp;
    <asp:Label ID="DataFiml" Visible="false" runat="server" Text="Data de Fim:"></asp:Label>
    <asp:TextBox ID="DataFim"  TextMode="Date" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="EstadoNL" Visible="false" runat="server" Text="Label"></asp:Label>
    <asp:RadioButtonList RepeatDirection="Horizontal" Visible="false" ID="EstadoNovo" runat="server">
        <asp:ListItem>Visto</asp:ListItem>
        <asp:ListItem Value="Nao Visto">N&#227;o Visto</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="SituacaoL" Visible="false" runat="server" Text="Situação:"></asp:Label>
    <asp:RadioButtonList RepeatDirection="Horizontal" Visible="false" ID="RadioButtonList2" runat="server">
        <asp:ListItem Value="Por Iniciar">Por &#205;niciar</asp:ListItem>
        <asp:ListItem>Em Andamento</asp:ListItem>
        <asp:ListItem>Finalizada</asp:ListItem>
    </asp:RadioButtonList>
    <p></p>
    <asp:Button ID="Aprovar" Visible="false" runat="server" Text="Aprovar" />

    <%--Pedidos vistos--%>
    <asp:Label ID="SituacaoVistosL" runat="server" Visible="false" Text="Situação:"></asp:Label>
    <asp:RadioButtonList ID="SituacaoVistos" Visible="false" runat="server">
        <asp:ListItem Value="Por Iniciar">Por &#205;niciar</asp:ListItem>
        <asp:ListItem>Em Andamento</asp:ListItem>
        <asp:ListItem>Finalizada</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Autor" runat="server" Visible="false" Text="Autor do Pedido:"></asp:Label>
    <asp:DropDownList ID="AutorP" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="DataInicioVl" Visible="false" runat="server" Text="Data de Início:"></asp:Label>
    <asp:TextBox ID="DataInicioV" TextMode="Date" Visible="false" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="DataFImV" Visible="false" runat="server" Text="Data de Fim:"></asp:Label>
     <asp:TextBox ID="DataFimVl" TextMode="Date" Visible="false" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="PedidV" Visible="false" runat="server" Text="Pedido:"></asp:Label>
    <asp:DropDownList ID="PedidoVistoD" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="NovoPedido" Visible="false" runat="server" Text="Registar Novo Peidido" />
    <asp:Button ID="Pesquisar" runat="server" Visible="false" Text="Pesquisar"/>
</asp:Content>

