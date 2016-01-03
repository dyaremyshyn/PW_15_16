<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="RemoverAgente.aspx.cs" Inherits="Comandante_RemoverAgente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Remover Agente"></asp:Label> </h1>
    <asp:Label ID="Label1" runat="server" Text="Numero de Distintivo:"></asp:Label>
    <asp:TextBox ID="txtDistintivo" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="PesquisaAgente" runat="server" Text="Pesquisa" OnClick="PesquisaAgente_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
    <p></p>
    Resultado:<asp:HyperLink ID="Autor" Target="_blank" runat="server" NavigateUrl="~/Comandante/Agentes.aspx"></asp:HyperLink>
    <asp:Label ID="Info" runat="server" ForeColor="Red"  Text=""></asp:Label>
    <p></p>

    <asp:Button ID="EliminarAgente" Visible="false" runat="server" Text="Eliminar Agente" OnClick="EliminarAgente_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
    <p></p>
    <h4><asp:Label ID="reslabel" Visible="false" runat="server" Text="Resultado:"></asp:Label></h4>
    <asp:Label ID="Resultado" Visible="false" runat="server" Text=""></asp:Label>

</asp:Content>

