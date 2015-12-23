<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Cidadoes.aspx.cs" Inherits="Comandante_Cidadoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="NomeL" runat="server" Text="Nome:"></asp:Label>
    <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
    <tb>
         <asp:Label ID="Label1" runat="server" Text="Resultado:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    </tb>
    <p></p>
    <asp:Label ID="CidaL" runat="server" Text="Nº Cidadao"></asp:Label>
    <asp:TextBox ID="Ncidadao" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="NIFL" runat="server" Text="NIF:"></asp:Label>
    <asp:TextBox ID="NIF" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="MoradaL" runat="server" Text="Morada:"></asp:Label>
    <asp:TextBox ID="Morada" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="ContactoL" runat="server" Text="Contacto:"></asp:Label>
    <asp:TextBox ID="Contacto" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Localidadel" runat="server" Text="Localidade:"></asp:Label>
    <asp:TextBox ID="Localidade" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Pesquisar" runat="server" Text="Pesquisar" />
</asp:Content>

