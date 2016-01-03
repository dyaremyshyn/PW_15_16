<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Pedido.aspx.cs" Inherits="Comandante_Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="Autorl" runat="server" Text="Autor:"></asp:Label>
    <asp:HyperLink ID="Autor" runat="server">HyperLink</asp:HyperLink>
    <p></p>
    <asp:TextBox ID="pedidotexto" ReadOnly="true" TextMode="MultiLine" Columns="60" Rows="10" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="Situacaol" runat="server" Text="Situacao:"></asp:Label>
    <asp:RadioButtonList ID="Situacao" runat="server"></asp:RadioButtonList>
    <p></p>
    <asp:Label ID="DataIl" runat="server" Text="Data de Inicio:"></asp:Label>
    <asp:TextBox ID="DataInicio" TextMode="Date" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Datafiml" runat="server" Text="Data de Fim:"></asp:Label>
    <asp:TextBox ID="DataFim" TextMode="Date" runat="server"></asp:TextBox>
    <p></p>
        <asp:Button ID="Gravar" runat="server" Text="Grava" OnClick="Gravar_Click" /> &nbsp;
    <asp:Button ID="EscreverM" runat="server" Text="Escrever Nota" OnClick="EscreverM_Click" />
    <p></p>
    <asp:Label ID="Mensagem" Visivel="false" runat="server" Text="Nota:"></asp:Label>
    <asp:TextBox ID="TextBox1" Visivel="false" Rows="5" Columns="40" TextMode="MultiLine" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Enviar" Visivel="false" runat="server" Text="Enviar" OnClick="Enviar_Click" />&nbsp;<asp:Button ID="Cancelar" Visivel="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

