<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="QueixasRecebidasVistas.aspx.cs" Inherits="Agente_QueixasRecebidasVistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Queixas Recebidas Vistas"></asp:Label> </h1>
    <p></p>
    <asp:ImageButton ID="back"  Width="25" ImageUrl="~/images/back.png" runat="server" OnClick="back_Click"/>
     <asp:Label ID="QueixaL" runat="server"  Text="Queixa:"></asp:Label>
    <asp:DropDownList ID="QueixaDD" AutoPostBack="true"   runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="AutorL"  runat="server" Text="Autor:"></asp:Label>
    <asp:HyperLink ID="Autor" Target="_blank" runat="server" NavigateUrl="~/Comandante/CidadaoDados.aspx"></asp:HyperLink>
    <p></p>
    <asp:TextBox ID="TextBox1" ReadOnly="true" TextMode="MultiLine"  Columns="60" Rows="12" runat="server"></asp:TextBox>
    <p></p>
    <asp:RadioButtonList ID="RadioButtonList1" Enabled="false" runat="server">
        <asp:ListItem Value="PROCESSO ABERTO">Caso Aberto</asp:ListItem>
        <asp:ListItem Value="FINALIZADA">Finalizada</asp:ListItem>
    </asp:RadioButtonList>
    <p></p>
    <asp:Label ID="Nomeprocessol" runat="server" Text="Nome do Processo:"></asp:Label>
   
    <asp:TextBox ID="Processot" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Agentel" runat="server" Text="Agente Responsavel:"></asp:Label>
     <asp:TextBox ID="Agente" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Aprovar" runat="server" Text="Aprovar" OnClick="Aprovar_Click" />&nbsp;
    <asp:Button ID="Encrever" runat="server" Text="Escrever Mensagem" OnClick="Encrever_Click" />
     <p></p>
    <asp:Label ID="Mensagem" Visivel="false" runat="server" Text="Mensagem:"></asp:Label>
    <asp:TextBox ID="TextBox2" Visivel="false" Rows="5" Columns="40" TextMode="MultiLine" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Enviar" Visivel="false" runat="server" Text="Enviar" OnClick="Enviar_Click"  />&nbsp;<asp:Button ID="Cancelar" Visivel="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click"  />

</asp:Content>

