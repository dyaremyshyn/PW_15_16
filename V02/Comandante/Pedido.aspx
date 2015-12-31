<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Pedido.aspx.cs" Inherits="Comandante_Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="Autorl" runat="server" Text="Autor:"></asp:Label>
    <asp:HyperLink ID="Autor" runat="server">HyperLink</asp:HyperLink>
    <p></p>
    <asp:TextBox ID="pedidotexto" TextMode="MultiLine" Columns="60" Rows="10" runat="server"></asp:TextBox>
    <p></p>
    <asp:RadioButtonList ID="Situacao" runat="server"></asp:RadioButtonList>
    <p></p>
    <asp:Button ID="Gravar" runat="server" Text="Button" OnClick="Gravar_Click" />
</asp:Content>

