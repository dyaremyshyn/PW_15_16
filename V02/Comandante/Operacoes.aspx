<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Operacoes.aspx.cs" Inherits="Comandante_Operacoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <h1> <asp:Label ID="Label2" runat="server" Text="Operações"></asp:Label> </h1>
    <asp:Label ID="Label1" runat="server" Text="Operações Agendadas:"></asp:Label>
    <asp:DropDownList ID="OperacoesAgendadas" AutoPostBack="true" runat="server"></asp:DropDownList>&nbsp;
    <asp:ImageButton ID="back"  Width="25" ImageUrl="~/images/delete.jpg" runat="server" OnClick="back_Click"/>
    <p></p>
    <asp:GridView ID="op" runat="server"></asp:GridView>
    <p></p>
    <asp:Button ID="NovaOperacao" runat="server" Text="NovaOperacao" OnClick="NovaOperacao_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White"/>
    <asp:Label ID="NomeL" visible="false" runat="server" Text="Nome Da Operação:"></asp:Label>
    <asp:TextBox ID="NomeDaOperacao" visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="TipL" visible="false" runat="server" Text="Tipo Operação:"></asp:Label>
    <asp:DropDownList ID="Tipo" visible="false" runat="server">
        <asp:ListItem>Selecione</asp:ListItem>
        <asp:ListItem Value="TRANSITO">Transito</asp:ListItem>
        <asp:ListItem Value="Drogas">Controlo Drogas</asp:ListItem>
        <asp:ListItem Value="CORRIDAS ILEGAIS">Corridas Ilegais</asp:ListItem>
        <asp:ListItem Value="SEGURANCA">Seguran&#231;a</asp:ListItem>
        <asp:ListItem Value="PROTECAO">Prote&#231;&#227;o</asp:ListItem>
        <asp:ListItem Value="MIGRACAO">Controlo Migracao</asp:ListItem>
        <asp:ListItem Value="CRIMINALIDADE">Combate &#224; criminalidade</asp:ListItem>
        <asp:ListItem Value="FISCALIZACAO">Fiscaliza&#231;&#227;o</asp:ListItem>
        <asp:ListItem Value="HUMANITARIA">Humanit&#225;ria</asp:ListItem>
    </asp:DropDownList>
    <p></p>
    <asp:Label ID="LocalL" visible="false" runat="server" Text="Local:"></asp:Label>
    <asp:TextBox ID="Local" visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Calendar ID="Data" visible="false" runat="server"></asp:Calendar>
    <asp:Label ID="Lhora" visible="false" runat="server" Text="Hora:"></asp:Label>
    <asp:DropDownList ID="Hora" AutoPostBack="true" visible="false" runat="server"></asp:DropDownList>
    <asp:CheckBoxList ID="Agentes" AutoPostBack="true" visible="false" RepeatColumns="5" runat="server"></asp:CheckBoxList>
    <asp:CheckBoxList ID="Viaturas" visible="false" RepeatColumns="5" runat="server"></asp:CheckBoxList><p></p>
     <asp:Label ID="Responsavell" visible="false" runat="server" Text="Responsavel:"></asp:Label>
    <asp:DropDownList ID="Responsavel" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="Inserir" Visible="false" runat="server" Text="Inserir" OnClick="Inserir_Click" />
    <asp:Button ID="Cancelar" Visible="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

