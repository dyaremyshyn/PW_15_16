<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Operacoes.aspx.cs" Inherits="Comandante_Operacoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Operações Agendadas:"></asp:Label>
    <asp:DropDownList ID="OperacoesAgendadas" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="NovaOperacao" runat="server" Text="NovaOperacao" OnClick="NovaOperacao_Click" />
    <asp:Label ID="NomeL" visible="false" runat="server" Text="Nome Da Operação:"></asp:Label>
    <asp:TextBox ID="NomeDaOperacao" visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="TipL" visible="false" runat="server" Text="Tipo Operação:"></asp:Label>
    <asp:DropDownList ID="Tipo" visible="false" runat="server"></asp:DropDownList>&nbsp; &nbsp; 
    <asp:Label ID="LocalL" visible="false" runat="server" Text="Local:"></asp:Label>
    <asp:TextBox ID="Local" visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Calendar ID="Data" visible="false" runat="server"></asp:Calendar>
    <asp:Label ID="Lhora" visible="false" runat="server" Text="Hora:"></asp:Label>
    <asp:DropDownList ID="Hora" visible="false" runat="server"></asp:DropDownList>
    <asp:CheckBoxList ID="Agentes" AutoPostBack="true" visible="false" RepeatColumns="5" runat="server"></asp:CheckBoxList>
    <asp:CheckBoxList ID="Viaturas" visible="false" RepeatColumns="5" runat="server"></asp:CheckBoxList><p></p>
    <asp:DropDownList ID="Responsavel" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="Inserir" Visible="false" runat="server" Text="Inserir" />
    <asp:Button ID="Cancelar" Visible="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

