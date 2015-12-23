<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Queixas.aspx.cs" Inherits="Comandante_Queixas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">

    <asp:Label ID="SituacaoL" runat="server" Text="Situação"></asp:Label>
    <asp:RadioButtonList ID="Situacao"  AutoPostBack="true" runat="server">
        <asp:ListItem>Visto</asp:ListItem>
        <asp:ListItem Value="Nao Visto">N&#227;o Visto</asp:ListItem>
        <asp:ListItem>Atribuida</asp:ListItem>
        <asp:ListItem Value="Nao Atribuida">N&#227;o Atribuida</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="QueixaL" runat="server" Visible="false" Text="Queixa:"></asp:Label>
    <asp:DropDownList ID="QueixaDD"  Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:TextBox ID="TextBox1" TextMode="MultiLine" Visible="false" Columns="60" Rows="15" runat="server"></asp:TextBox>
    <asp:Label ID="EstadoLRB" runat="server" Visible="false" Text="Estado:"></asp:Label>
     <asp:RadioButtonList ID="EsdadoRB" Visible="false" runat="server"></asp:RadioButtonList>
    <p></p>
    <asp:Label ID="Situacaolb" runat="server" Visible="false" Text="Situação:"></asp:Label>
    <asp:RadioButtonList ID="SituacaoRB" Visible="false" runat="server"></asp:RadioButtonList>
    <p></p>
    <asp:Label ID="RESPONSAVELl" Visible="false" runat="server" Text="Agente Responsável:"></asp:Label>
    <asp:TextBox ID="ResponsavelTextBox" Visible="false" runat="server"></asp:TextBox>
    <asp:DropDownList ID="AgenteResponsavelD" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
     <asp:Label ID="NomeProcessoL" runat="server" Visible="false" Text="Nome do Processo:"></asp:Label>
    <asp:DropDownList ID="DDProcesso" Visible="false" runat="server"></asp:DropDownList>
    <asp:TextBox ID="TBProcesso" Visible="false" runat="server"></asp:TextBox>
</asp:Content>

