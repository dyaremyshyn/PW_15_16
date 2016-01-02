<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="PedidosRecebidosVistosRegistar.aspx.cs" Inherits="Agente_PedidosRecebidosVistosRegistar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Registar Pedido: "></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Label1" runat="server" Visible="true" Text="Nº Cidadão: "></asp:Label>
    <asp:TextBox ID="txtNCidadao" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" />
    <p></p>
    <div visible="false"> 
        <asp:Label ID="Label3" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="txtNome" runat="server" ReadOnly="true"></asp:TextBox>
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="Label4" runat="server" Text="NIF: "></asp:Label>
        <asp:TextBox ID="txtNIF" runat="server" ReadOnly="true"></asp:TextBox>
        <p></p>
        <asp:Label ID="Label5" runat="server" Text="Morada: "></asp:Label>
        <asp:TextBox ID="txtMorada" runat="server" ReadOnly="true"></asp:TextBox>
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="Label6" runat="server" Text="Cód.Postal: "></asp:Label>
        <asp:TextBox ID="txtCodPostal" runat="server" ReadOnly="true"></asp:TextBox>
        <p></p>
        <asp:Label ID="Label7" runat="server" Text="Localidade: "></asp:Label>
        <asp:TextBox ID="txtLocalidade" runat="server" ReadOnly="true"></asp:TextBox>
        <p></p>
        <asp:Label ID="Label8" runat="server" Text="Tipo de Pedido: "></asp:Label>
        <asp:DropDownList ID="ddlTipoPedido" runat="server"></asp:DropDownList>
        <p></p>
        <asp:Label ID="Label9" runat="server" Text="Data Início: "></asp:Label>
        <asp:TextBox ID="txtDataInicio" runat="server"></asp:TextBox>
        &nbsp&nbsp&nbsp<asp:Calendar ID="cDataInicio" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Data Fim: "></asp:Label>
        <asp:TextBox ID="txtDataFim" runat="server"></asp:TextBox>
        &nbsp&nbsp&nbsp<asp:Calendar ID="cDataFim" runat="server"></asp:Calendar>
        <p></p>
        <br />
        <h3><asp:Label ID="Label11" runat="server" Text="Pedido"></asp:Label></h3>
        <asp:TextBox ID="txtPedido" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
        <p></p>
        <asp:Label ID="Label12" runat="server" Text="Situação: "></asp:Label>
        <asp:CheckBoxList ID="cblSituacao" runat="server">
            <asp:ListItem>Em andamento</asp:ListItem>
            <asp:ListItem>Por começar</asp:ListItem>
        </asp:CheckBoxList>
        <p></p>
        <asp:Button ID="btnRegistar" runat="server" Text="Registar" />
    </div>
</asp:Content>

