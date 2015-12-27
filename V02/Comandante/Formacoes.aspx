<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Formacoes.aspx.cs" Inherits="Comandante_Formacoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <h1> <asp:Label ID="Label2" runat="server" Text="Formações"></asp:Label> </h1>
    <asp:Label ID="FormAgendlabel" runat="server" Text="Formações Agendadas:"></asp:Label>
    <asp:DropDownList ID="FormacoesAgendadas" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="NovaFormacao" runat="server" Text="Nova Formação" OnClick="NovaFormacao_Click" />
    <asp:Label ID="DataL" Visible="false" runat="server" Text="Data:"></asp:Label>
    <asp:Calendar ID="Data" Visible="false" runat="server"></asp:Calendar>
    <p></p>
    <asp:Label ID="HoraL" Visible="false" runat="server" Text="Hora:"></asp:Label>
    <asp:DropDownList ID="Hora" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="LForm" runat="server" Visible="false" Text="Formador:"></asp:Label>
    <asp:TextBox ID="Formador" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="LTema" Visible="false" runat="server" Text="Tema:"></asp:Label>
    <asp:TextBox ID="Tema" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="AMbitol" Visible="false" runat="server" Text="Âmbito:"></asp:Label>
    <asp:TextBox ID="Ambito" Visible="false" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="Descricaol" Visible="false" runat="server" Text="Descrição:"></asp:Label>
    <asp:TextBox ID="Descricao" TextMode="MultiLine" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Marcar" Visible="false" runat="server" Text="Marcar" OnClick="Marcar_Click" />
    <asp:Button ID="Cancelar" Visible="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

