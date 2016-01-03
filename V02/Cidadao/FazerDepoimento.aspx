<%@ Page Title="" Language="C#" MasterPageFile="~/Cidadao/Cidadao.master" AutoEventWireup="true" CodeFile="FazerDepoimento.aspx.cs" Inherits="Cidadao_FazerDepoimento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Prestar Declarações:"></asp:Label> </h1>
    <p></p>
      <asp:Label ID="final" Visible="false" BackColor="DarkSeaGreen" runat="server" Text=""></asp:Label>
    <p></p>
    <asp:Label ID="Casol" runat="server" Text="Caso:"></asp:Label>
    <asp:TextBox ID="Caso" runat="server"></asp:TextBox>
    <p></p>
  <asp:Label ID="Depoimentol" runat="server" Text="Depoimento:"></asp:Label>
    <asp:TextBox ID="Depoimento" TextMode="MultiLine" Rows="15" Columns="60" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />&nbsp; 
    <asp:Button ID="Cancelar" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

