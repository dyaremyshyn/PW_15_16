<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Processos.aspx.cs" Inherits="Comandante_Processos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="ProcessoL" runat="server" Text="Processo:"></asp:Label>
    <asp:DropDownList ID="Processo" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="QueixaL" runat="server" Text="Queixa:"></asp:Label>
    <asp:DropDownList ID="Queixa" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="DepoimentosL" runat="server" Text="Depoimentos"></asp:Label>
    <asp:DropDownList ID="Depoimentos" runat="server"></asp:DropDownList>
    

    <asp:TextBox ID="TextBox1"  TextMode="MultiLine" Visible="false" Columns="60" Rows="15" runat="server"></asp:TextBox>
</asp:Content>

