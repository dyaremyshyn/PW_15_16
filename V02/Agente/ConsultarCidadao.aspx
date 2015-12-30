<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="ConsultarCidadao.aspx.cs" Inherits="Agente_ConsultarCidadao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Consultar Cidadão"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label3" runat="server" Text="Nº Cidadão: "></asp:Label>
    <asp:TextBox ID="txtNCidadao" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label4" runat="server" Text="Nº Contribuinte: "></asp:Label>
    <asp:TextBox ID="txtContribuinte" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label5" runat="server" Text="Morada: "></asp:Label>
    <asp:TextBox ID="txtMorada" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label7" runat="server" Text="Localidade: "></asp:Label>
    <asp:TextBox ID="txtLocalidade" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label6" runat="server" Text="Contacto"></asp:Label>
    <asp:TextBox ID="txtContacto" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar"/>
    <br /><br />
    <asp:Label ID="Label8" runat="server" Visible="false" Text="Resultado: "></asp:Label>
    <asp:DropDownList ID="ddlResultado" Visible="false" runat="server"></asp:DropDownList>



</asp:Content>

