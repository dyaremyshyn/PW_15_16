<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Queixas.aspx.cs" Inherits="Comandante_Queixas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
      <h1> <asp:Label ID="Label2" runat="server" Text="Queixas"></asp:Label> </h1>

    <asp:Label ID="Queixasl" runat="server" Text="Queixas Não Vistas:"></asp:Label>
    <asp:TextBox ID="Queixas" ReadOnly="true" runat="server" Width="16px"></asp:TextBox>
    <p></p>
    <asp:Button ID="QueixasVistas" runat="server" Text="Queixas Vistas" OnClick="QueixasVistas_Click" style="height: 26px" />
    <p></p>
    <p></p>
    <p></p>
    <asp:Button ID="QueixasNaoVistas" runat="server" Text="Queixas Não Vistas" OnClick="QueixasNaoVistas_Click" />
  
</asp:Content>

