<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="DepoimentosRecebidos.aspx.cs" Inherits="Comandante_DepoimentosRecebidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="DepoimL" runat="server" Text="Nº Depoimento"></asp:Label>
    <asp:DropDownList ID="NDepoimento" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="AutorL" runat="server" Text="Autor:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="DepoimentoL" runat="server" Text="Depoimento"></asp:Label>
    <asp:TextBox ID="Depoimento"  TextMode="MultiLine" Visible="false" Columns="60" Rows="15" runat="server"></asp:TextBox>
    <asp:Label ID="AprovarD" runat="server" Text="Aprovar Depoimento?"></asp:Label>
    <asp:CheckBox ID="Aprovar" runat="server" />

    <asp:Label ID="ProcessoA" runat="server" Text="Processo:"></asp:Label>
    <asp:DropDownList ID="Processo" runat="server"></asp:DropDownList>
</asp:Content>

