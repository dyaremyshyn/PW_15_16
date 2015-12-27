<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="CidadaoDados.aspx.cs" Inherits="Comandante_CidadaoDados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
       <h1> <asp:Label ID="Label1" runat="server" Text="Cidadão"></asp:Label> </h1>
   <asp:ImageButton ID="VoltarAtras" title="Voltar atrás" Width="50px" Height="50" ImageUrl="~/images/back.png" runat="server" OnClick="VoltarAtras_Click" />
   <p></p>
    <asp:Label ID="NomeL" runat="server" Text="Nome:"></asp:Label>
    <asp:TextBox ID="Nome" runat="server" Width="233px"></asp:TextBox> 
    <asp:Image ID="Foto"  Width="150px" Height="120" runat="server" />
    <p></p>
    <asp:Label ID="CidaL" runat="server" Text="Nº Cidadao"></asp:Label>
    <asp:TextBox ID="Ncidadao" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="NIFL" runat="server" Text="NIF:"></asp:Label>
    <asp:TextBox ID="NIF" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="MoradaL" runat="server" Text="Morada:"></asp:Label>
    <asp:TextBox ID="Morada" runat="server" Width="224px"></asp:TextBox>
    <p></p>
    <asp:Label ID="ContactoL" runat="server" Text="Contacto:"></asp:Label>
    <asp:TextBox ID="Contacto" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Localidadel" runat="server" Text="Localidade:"></asp:Label>
    <asp:TextBox ID="Localidade" runat="server" Width="205px"></asp:TextBox>
    <p></p>
     <asp:Label ID="Label2" runat="server" Text="Codigo Postal:"></asp:Label>
    <asp:TextBox ID="CodigoPostal" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Sexol" runat="server" Text="Sexo:"></asp:Label>
    <asp:TextBox ID="Sexo" runat="server"></asp:TextBox>

    <p></p>
      <asp:Label ID="Pedidol" runat="server" Text="Pedidos:"></asp:Label>
    <asp:DropDownList ID="Pedidos" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="Queixasl" runat="server" Text="Queixas:"></asp:Label>
    <asp:DropDownList ID="Queixas" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="Depoimentosl" runat="server" Text="Depoimentos:"></asp:Label>
    <asp:DropDownList ID="Depoimentos" runat="server"></asp:DropDownList>
</asp:Content>

