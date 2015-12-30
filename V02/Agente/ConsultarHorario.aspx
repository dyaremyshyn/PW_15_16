<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="ConsultarHorario.aspx.cs" Inherits="Agente_ConsultarHorario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Horário:"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Inicio: "></asp:Label>
    <asp:TextBox ID="txtInicio" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Calendar ID="Data" AutoPostBack="true" Visible="false" SelectionMode="Day" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Fim: "></asp:Label>
    <asp:TextBox ID="txtFim" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Calendar ID="Calendar1" AutoPostBack="true" Visible="false" SelectionMode="Day" runat="server"></asp:Calendar>
    <p></p>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <p></p>

    <!-- FALTA  -->

</asp:Content>


