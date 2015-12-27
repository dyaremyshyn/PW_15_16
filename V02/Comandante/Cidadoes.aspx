<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Cidadoes.aspx.cs" Inherits="Comandante_Cidadoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label3" runat="server" Text="Pesquisa Cidadão"></asp:Label> </h1>
    <asp:Label ID="NomeL" runat="server" Text="Nome:"></asp:Label>
    <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
    <asp:ImageButton ID="Pesqnome" title="Pesquisar" Height="25" Width="25" ImageUrl="~/images/shearch.ico" runat="server" OnClick="Pesqnome_Click" />
   
      
    <p></p>
    <asp:Label ID="CidaL" runat="server" Text="Nº Cidadao"></asp:Label>
    <asp:TextBox ID="Ncidadao" runat="server"></asp:TextBox>
     <asp:ImageButton ID="PesqCidadao" title="Pesquisar" Height="25" Width="25" ImageUrl="~/images/shearch.ico" runat="server" OnClick="PesqCidadao_Click" />
    <p></p>
    <asp:Label ID="NIFL" runat="server" Text="NIF:"></asp:Label>
    <asp:TextBox ID="NIF" runat="server"></asp:TextBox>
     <asp:ImageButton ID="pesqNIF" title="Pesquisar" Height="25" Width="25" ImageUrl="~/images/shearch.ico" runat="server" OnClick="pesqNIF_Click" />
    <p></p>
    <asp:Label ID="MoradaL" runat="server" Text="Morada:"></asp:Label>
    <asp:TextBox ID="Morada" runat="server"></asp:TextBox>
       <asp:ImageButton ID="PesqMorada" title="Pesquisar" Height="25" Width="25" ImageUrl="~/images/shearch.ico" runat="server" OnClick="PesqMorada_Click" />
    <p></p>
    <asp:Label ID="ContactoL" runat="server" Text="Contacto:"></asp:Label>
    <asp:TextBox ID="Contacto" runat="server"></asp:TextBox>
    <asp:ImageButton ID="PesqContacto" title="Pesquisar" Height="25" Width="25" ImageUrl="~/images/shearch.ico" runat="server" OnClick="PesqContacto_Click" />
    <p></p>
    <asp:Label ID="Localidadel" runat="server" Text="Localidade:"></asp:Label>
    <asp:TextBox ID="Localidade" runat="server"></asp:TextBox>
       <asp:ImageButton ID="PesqLocalidade" title="Pesquisar" Height="25" Width="25" ImageUrl="~/images/shearch.ico" runat="server" OnClick="PesqLocalidade_Click" />
    <p></p>
     <asp:Label ID="Label2" runat="server" Text="Codigo Postal:"></asp:Label>
    <asp:TextBox ID="CodigoPostal" runat="server"></asp:TextBox>
       <asp:ImageButton ID="pesqcodP" title="Pesquisar" Height="25" Width="25" ImageUrl="~/images/shearch.ico" runat="server" OnClick="pesqcodP_Click"  />
    <p></p>
       <asp:Label ID="Label1" runat="server" Text="Resultado:"></asp:Label>
        <asp:DropDownList ID="resultado" runat="server"></asp:DropDownList>
   
    <asp:Button ID="Ver" runat="server" Text="Pesquisar" OnClick="Pesquisar_Click" />
</asp:Content>

