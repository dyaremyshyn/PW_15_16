<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="PedidosRecebidosNaoVistos.aspx.cs" Inherits="Agente_PedidosRecebidosNaoVistos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Pedidos Não Vistos"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Pedido: "></asp:Label>
    <asp:DropDownList ID="ddlPedido" runat="server"></asp:DropDownList>
    <p></p>
    <h3><asp:Label ID="Label3" runat="server" Text="Pedido: "></asp:Label></h3>
    <asp:TextBox ID="txtPedido" TextMode="MultiLine" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    
    <div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Mensagem: "></asp:Label>
            <asp:CheckBoxList ID="cbMensagem" runat="server" Width="128px">
                <asp:ListItem>Visto</asp:ListItem>
                <asp:ListItem Selected="True">Não Visto</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div style="width: 449px">
            <asp:Label ID="Label5" runat="server" Text="Situação: "></asp:Label>
            <asp:CheckBoxList ID="cbSituacao" runat="server" Width="127px">
                <asp:ListItem>Em andamento</asp:ListItem>
                <asp:ListItem>Por começar</asp:ListItem>
                <asp:ListItem>Finalizado</asp:ListItem>
            </asp:CheckBoxList>
        </div>
    </div>
    <p></p>
    <asp:Label ID="Label6" runat="server" Text="Data Início: "></asp:Label>
    <asp:TextBox ID="txtDataInicio" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp<asp:Calendar ID="cDataInicio" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Data Fim: "></asp:Label>
    <asp:TextBox ID="txtDataFim" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp<asp:Calendar ID="cDataFim" runat="server"></asp:Calendar>
    <p></p>
    <asp:Button ID="btnAprovar" runat="server" Text="Aprovar"/>
</asp:Content>

