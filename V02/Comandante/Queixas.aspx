<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Queixas.aspx.cs" Inherits="Comandante_Queixas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Queixas"></asp:Label> </h1>
    <asp:ImageButton ID="back" Visible="false" Width="25" ImageUrl="~/images/back.png" runat="server" OnClick="back_Click" />
    <asp:Label ID="SituacaoL" runat="server" Text="Situação"></asp:Label>
    <asp:RadioButtonList ID="Situacao"    AutoPostBack="true" runat="server">
        <asp:ListItem>Visto</asp:ListItem>
        <asp:ListItem Value="Nao Visto">N&#227;o Visto</asp:ListItem>
        <asp:ListItem>Atribuida</asp:ListItem>
        <asp:ListItem Value="Nao Atribuida">N&#227;o Atribuida</asp:ListItem>
        <asp:ListItem Value="FINALIZADA">Finalizada</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="QueixaL" runat="server" Visible="false" Text="Queixa:"></asp:Label>
    <asp:DropDownList ID="QueixaDD" AutoPostBack="true"  Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="AutorL" Visible="false" runat="server" Text="Autor:"></asp:Label>
    <asp:HyperLink ID="Autor" Target="_blank" runat="server" NavigateUrl="~/Comandante/CidadaoDados.aspx"></asp:HyperLink>
    <p></p>
    <asp:TextBox ID="TextBox1" TextMode="MultiLine" Visible="false" Columns="60" Rows="12" runat="server"></asp:TextBox>
    <asp:Label ID="EstadoLRB" runat="server" Visible="false" Text="Estado:"></asp:Label>
     <asp:RadioButtonList ID="EsdadoRB" RepeatDirection="Horizontal" Visible="false" runat="server">
         <asp:ListItem>Visto</asp:ListItem>
         <asp:ListItem Value="NAO VISTO">N&#227;o Visto</asp:ListItem>
     </asp:RadioButtonList>
    <p></p>
    <asp:Label ID="Situacaolb" runat="server" Visible="false" Text="Situação:"></asp:Label>
    <asp:RadioButtonList ID="SituacaoRB" RepeatDirection="Horizontal" Visible="false" runat="server">
        <asp:ListItem>Atribuida</asp:ListItem>
        <asp:ListItem>Nao Atribuida</asp:ListItem>
        <asp:ListItem Value="FINALIZADA">Finalizada</asp:ListItem>
    </asp:RadioButtonList>
    <p></p>
    <asp:Label ID="RESPONSAVELl" Visible="false" runat="server" Text="Agente Responsável:"></asp:Label>
    <asp:TextBox ID="ResponsavelTextBox" Visible="false" runat="server"></asp:TextBox>
    <asp:DropDownList ID="AgenteResponsavelD" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
     <asp:Label ID="NomeProcessoL" runat="server" Visible="false" Text="Nome do Processo:"></asp:Label>
    <asp:DropDownList ID="DDProcesso" Visible="false" runat="server"></asp:DropDownList>
    <asp:TextBox ID="TBProcesso" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="AbrirProcesso" Visible="false" runat="server" Text="Abrir Processo" OnClick="AbrirProcesso_Click" />
</asp:Content>

