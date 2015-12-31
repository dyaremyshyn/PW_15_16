<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="DadosPessoais.aspx.cs" Inherits="Agente_DadosPessoais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <h1> <asp:Label ID="Label2" runat="server" Text="Dados Pessoais:"></asp:Label> </h1>
      
    <asp:Label ID="NomeL" runat="server" Text="Nome:"></asp:Label>
    <asp:TextBox ID="Nome" ReadOnly="true" runat="server" Width="233px"></asp:TextBox> 
    <asp:Image ID="Foto"  Width="150px" Height="120" runat="server" />
    <p></p>
     <asp:Label ID="Fotol" Visible="false"  runat="server" Text="Foto:"></asp:Label>
    <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" />
    <p></p>
    <asp:Label ID="CidaL" runat="server" Text="Nº Cidadao"></asp:Label>
    <asp:TextBox ID="Ncidadao" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="NIFL" runat="server" Text="NIF:"></asp:Label>
    <asp:TextBox ID="NIF" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="Datal" runat="server" Text="Data de Nascimento:"></asp:Label>
    <asp:TextBox ID="Data" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="MoradaL" runat="server" Text="Morada:"></asp:Label>
    <asp:TextBox ID="Morada" ReadOnly="true" runat="server" Width="224px"></asp:TextBox>
    <p></p>
    <asp:Label ID="ContactoL" runat="server" Text="Contacto:"></asp:Label>
    <asp:TextBox ID="Contacto" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Localidadel" runat="server" Text="Localidade:"></asp:Label>
    <asp:TextBox ID="Localidade" ReadOnly="true" runat="server" Width="205px"></asp:TextBox>
    <p></p>
     <asp:Label ID="Label1" runat="server" Text="Codigo Postal:"></asp:Label>
    <asp:TextBox ID="CodigoPostal" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Sexol" runat="server" Text="Sexo:"></asp:Label>
    <asp:TextBox ID="Sexo" ReadOnly="true" runat="server"></asp:TextBox>
    <asp:RadioButtonList ID="Sexorb" Visible="false" runat="server">
        <asp:ListItem Value="MASCULINO">Masculino</asp:ListItem>
        <asp:ListItem Value="FEMININO">Feminino</asp:ListItem>
    </asp:RadioButtonList>
    <p></p>
    <asp:Button ID="EditarDados" runat="server" Text="Editar Dados:" OnClick="EditarDados_Click" />
    <asp:Button ID="Atualizar" Visible="false" runat="server" Text="Atualizar" OnClick="Atualizar_Click" />&nbsp;
    <asp:Button ID="Cancelar" Visible="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
    
</asp:Content>

