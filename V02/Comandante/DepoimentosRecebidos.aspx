<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="DepoimentosRecebidos.aspx.cs" Inherits="Comandante_DepoimentosRecebidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <h1> <asp:Label ID="Label2" runat="server" Text="Depoimentos"></asp:Label> </h1>
    <asp:Label ID="DepoimL" runat="server" Text="Nº Depoimento"></asp:Label>
    <asp:DropDownList ID="NDepoimento" AutoPostBack="true" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="AutorL" Visible="false" runat="server" Text="Autor:"></asp:Label>
    <asp:HyperLink ID="TextBox1" Target="_blank" runat="server" NavigateUrl="~/Comandante/CidadaoDados.aspx"></asp:HyperLink>
    <p></p>
    <asp:Label ID="DepoimentoL" Visible="false" runat="server" Text="Depoimento"></asp:Label>
    <asp:TextBox ID="Depoimento"  TextMode="MultiLine" Visible="false" Columns="60" Rows="15" runat="server"></asp:TextBox>
    <asp:Label ID="AprovarD" Visible="false" runat="server" Text="Aprovar Depoimento?"></asp:Label>
    <asp:CheckBox ID="Aprovar" AutoPostBack="true" Visible="false" runat="server" />

    <asp:Label ID="ProcessoA" Visible="false" runat="server" Text="Processo:"></asp:Label>
    <asp:DropDownList ID="Processo" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="Confirmar" runat="server" Text="Confirmar" />
</asp:Content>

