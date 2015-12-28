<%@ Page Title="" Language="C#" MasterPageFile="~/Cidadao/Cidadao.master" AutoEventWireup="true" CodeFile="MeusDepoimentos.aspx.cs" Inherits="Cidadao_MeusDepoimentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Meus Depoimentos:"></asp:Label> </h1>
      <asp:Label ID="Depoimentol" runat="server" Text="Depoimentos:"></asp:Label>
    <asp:DropDownList ID="Depoimentos" AutoPostBack="true" runat="server"></asp:DropDownList>
    <p></p>
    <asp:TextBox ID="Depoimento" Rows="20" Columns="60" TextMode="MultiLine" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Sitaucaol" runat="server" Text="Situação"></asp:Label>
    <asp:RadioButton ID="Situação" Enabled="false" Text="Depoimento Aprovado" runat="server" />
</asp:Content>

