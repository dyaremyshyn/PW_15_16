<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="PedidosRecebidosVistosPesquisa.aspx.cs" Inherits="Agente_PedidosRecebidosVistosPesquisa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Pedidos Vistos"></asp:Label> </h1>
    <p></p>
    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" TextMode="MultiLine"></asp:TextBox>
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
    <asp:Button ID="Button1" runat="server" Text="Editar" BackColor="Green" />
</asp:Content>

