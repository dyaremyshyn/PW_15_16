<%@ Page Title="" Language="C#" MasterPageFile="~/Cidadao/Cidadao.master" AutoEventWireup="true" CodeFile="MinhasQueixas.aspx.cs" Inherits="Cidadao_MinhasQueixas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Minhas Queixas:"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Queixasl" runat="server" Text="Queixas:"></asp:Label>
    <asp:DropDownList ID="Queixas" AutoPostBack="true" runat="server"></asp:DropDownList>

    <p></p>
    <asp:TextBox ID="Queixa" ReadOnly="true" Rows="9" Columns="60" TextMode="MultiLine" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Datalabel" runat="server" Text="Data da Queixa:"></asp:Label>
    <asp:TextBox ID="Data" ReadOnly="true" runat="server" Width="84px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="AgenteRL" runat="server" Text="Agente Responsável:"></asp:Label>
    <asp:TextBox ID="AgenteResponsavel" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Estadol" runat="server" Text="Estado:"></asp:Label>
    <asp:RadioButtonList ID="Estado" Enabled="false" RepeatDirection="Horizontal" runat="server">
      <asp:ListItem>Visto</asp:ListItem>
      <asp:ListItem Value="Nao Visto">N&#227;o Visto</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Situacaol" runat="server" Text="Situação:"></asp:Label>
    <asp:RadioButtonList ID="Situacao" RepeatDirection="Horizontal" Enabled="false" runat="server">
        <asp:ListItem>Processo Aberto</asp:ListItem>
        <asp:ListItem>Parado</asp:ListItem>
        <asp:ListItem>Finalizada</asp:ListItem>
    </asp:RadioButtonList>
 
     <asp:Label ID="Mensagnl" runat="server" Text="Mensagens:"></asp:Label>
    <asp:DropDownList ID="Mensagens" runat="server"></asp:DropDownList>
    <p></p>
    <asp:TextBox ID="Mensagem" Rows="5" Columns="60" TextMode="MultiLine" ReadOnly="true" runat="server"></asp:TextBox>


</asp:Content>

