<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Agentes.aspx.cs" Inherits="Comandante_Agentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="NomeL" runat="server" Text="Nome:"></asp:Label>
    <asp:DropDownList ID="Nome" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Image ID="Image1" runat="server" />
    <p></p>
    <asp:Label ID="DistintivoL" runat="server" Text="Distintivo:"></asp:Label>
    <asp:TextBox ID="Distintivo" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="NIFL" runat="server" Text="NIF:"></asp:Label>
    <asp:TextBox ID="NIF" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="CCL" runat="server" Text="Nº Cidadão:"></asp:Label>
    <asp:TextBox ID="CC" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="DNL" runat="server" Text="Data de Nascimento:"></asp:Label>
    <asp:TextBox ID="DataNascimento" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Idade:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="MoradaL" runat="server" Text="Morada:"></asp:Label>
    <asp:TextBox ID="Morada" runat="server"></asp:TextBox>
     <p></p>
    <asp:Label ID="ContactoL" runat="server" Text="Contacto:"></asp:Label>
    <asp:TextBox ID="Contacto" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="ArmasL" runat="server" Text="Armas:"></asp:Label>
    <asp:DropDownList ID="Armas" runat="server"></asp:DropDownList>
</asp:Content>

