<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Agentes.aspx.cs" Inherits="Comandante_Agentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <h1> <asp:Label ID="Label2" runat="server" Text="Agentes"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="NomeL" runat="server" Text="Nome:"></asp:Label>
    <asp:DropDownList ID="Nome" AutoPostBack="true" runat="server"></asp:DropDownList> &nbsp; 
    <asp:ImageButton ID="back"  Width="25" ImageUrl="~/images/delete.jpg" runat="server" OnClick="back_Click"/>
    <p></p>
    <asp:Image ID="Image1" Width="150px" Height="120" runat="server" />
    <p></p>
    <asp:Label ID="DistintivoL" runat="server" Text="Distintivo:"></asp:Label>
    <asp:TextBox ID="Distintivo" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="NIFL"  runat="server" Text="NIF:"></asp:Label>
    <asp:TextBox ID="NIF" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="CCL" runat="server" Text="Nº Cidadão:"></asp:Label>
    <asp:TextBox ID="CC" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="DNL" runat="server" Text="Data de Nascimento:"></asp:Label>
    <asp:TextBox ID="DataNascimento" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Idade:"></asp:Label>
    <asp:TextBox ID="Idade" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="MoradaL" runat="server" Text="Morada:"></asp:Label>
    <asp:TextBox ID="Morada" ReadOnly="true" runat="server"></asp:TextBox>
     <p></p>
    <asp:Label ID="codPostall" runat="server" Text="CodPostal:"></asp:Label>
    <asp:TextBox ID="CodPosta" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="ContactoL" runat="server" Text="Contacto:"></asp:Label>
    <asp:TextBox ID="Contacto" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Funcaol" runat="server" Text="Função:"></asp:Label>
    <asp:TextBox ID="Funcao" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="ArmasL" runat="server" Text="Armas:"></asp:Label>
    <asp:DropDownList ID="Armas" AutoPostBack="true" runat="server"></asp:DropDownList>
    <p></p>
     <asp:Label ID="DescricaoArma" runat="server" Text="DescricaoArma:"></asp:Label><p></p>
    <asp:TextBox ID="DescArma" TextMode="MultiLine" Rows="4" Columns="50" ReadOnly="true" runat="server"></asp:TextBox>
</asp:Content>

