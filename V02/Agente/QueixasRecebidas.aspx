<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="QueixasRecebidas.aspx.cs" Inherits="Agente_QueixasRecebidas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
        <h1> <asp:Label ID="Label2" runat="server" Text="Queixas Recebidas"></asp:Label> </h1>
    <p></p>
    <asp:ImageButton ID="back"  Width="25" ImageUrl="~/images/back.png" runat="server" OnClick="back_Click"/>
     <asp:Label ID="QueixaL" runat="server"  Text="Queixa:"></asp:Label>
    <asp:DropDownList ID="QueixaDD" AutoPostBack="true"   runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="AutorL"  runat="server" Text="Autor:"></asp:Label>
    <asp:HyperLink ID="Autor" Target="_blank" runat="server" NavigateUrl="~/Comandante/CidadaoDados.aspx"></asp:HyperLink>
    <p></p>
    <asp:TextBox ID="TextBox1" TextMode="MultiLine"  Columns="60" Rows="12" runat="server"></asp:TextBox>
    <p></p>
    <asp:RadioButtonList ID="RadioButtonList1" AutoPostBack="true" runat="server">
        <asp:ListItem>Abrir Processo</asp:ListItem>
        <asp:ListItem>Adicionar a Processo</asp:ListItem>
        <asp:ListItem>Aguardar</asp:ListItem>
    </asp:RadioButtonList>
     
    <p></p>
    <asp:Label ID="Nomeprocessol" Visible="false" runat="server" Text="Nome do Processo:"></asp:Label>
    <asp:DropDownList ID="Processo" Visible="false" runat="server"></asp:DropDownList>
    <asp:TextBox ID="Processot" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Agentel" Visible="false" runat="server" Text="Agente Responsavel:"></asp:Label>
    <asp:DropDownList ID="Agente" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="Aprovar"  runat="server" Text="Aprovar" OnClick="Aprovar_Click" />
</asp:Content>

