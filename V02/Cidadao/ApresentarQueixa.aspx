<%@ Page Title="" Language="C#" MasterPageFile="~/Cidadao/Cidadao.master" AutoEventWireup="true" CodeFile="ApresentarQueixa.aspx.cs" Inherits="Cidadao_ApresentarQueixa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Prestar Queixa:"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="final" Visible="false" BackColor="DarkSeaGreen" runat="server" Text=""></asp:Label>
    <p></p>
    <asp:Label ID="Motivol" runat="server" Text="Motivo:"></asp:Label>
    <asp:TextBox ID="Motivo" runat="server"></asp:TextBox>
    <p></p>
      <asp:Label ID="Queixal" runat="server" Text="Texto:"></asp:Label>
    <asp:TextBox ID="Queixa" TextMode="MultiLine" Rows="15" Columns="60" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Enviar" ForeColor="Green" runat="server" Text="Enviar" OnClick="Enviar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:Button ID="Cancelar" ForeColor="Red" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

