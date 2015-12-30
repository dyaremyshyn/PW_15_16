<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="DadosPessoais.aspx.cs" Inherits="Agente_DadosPessoais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Consultar Agente"></asp:Label> </h1>
    <asp:Label ID="Label1" runat="server" Text="Nome:  "></asp:Label>
    <asp:TextBox ID="txtNomeAgente" ReadOnly="true" visible="true" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label3" runat="server" Text="ID:  "></asp:Label>
    <asp:TextBox ID="txtIDAgente" ReadOnly="true" runat="server"></asp:TextBox>

    <p></p>
    &nbsp
</asp:Content>

