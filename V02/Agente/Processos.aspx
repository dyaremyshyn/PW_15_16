<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="Processos.aspx.cs" Inherits="Agente_Processos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Processos"></asp:Label> </h1>
    <p></p>
    <asp:CheckBox ID="MeusProcessos" AutoPostBack="true" Text="Meus Processos" runat="server" />
    <p></p>
    <asp:Label ID="ProcessoL" runat="server" Text="Processo:"></asp:Label>
    <asp:DropDownList ID="Processo" AutoPostBack="true" runat="server"></asp:DropDownList>
    <asp:Label ID="Respl" runat="server" Text="Responsavel:"></asp:Label>
    <asp:TextBox ID="Res" runat="server"></asp:TextBox>
    
    <p></p>
    <asp:Label ID="QueixaL" runat="server" Text="Queixa:"></asp:Label>
    <asp:DropDownList ID="Queixa" AutoPostBack="true" runat="server" ></asp:DropDownList>  <asp:HyperLink ID="verQueixa" Target="_blank" NavigateUrl="~/Comandante/QueixasVistas.aspx" runat="server"></asp:HyperLink> 
    <p></p>
    <asp:Label ID="DepoimentosL" runat="server" Text="Depoimentos"></asp:Label>
    <asp:DropDownList ID="Depoimentos" AutoPostBack="true" runat="server"></asp:DropDownList>  <asp:HyperLink ID="VerDep" Target="_blank"  runat="server"></asp:HyperLink> 
    <p></p>
    <asp:Label ID="DescricaoP" runat="server" Text="Descrição do Processo:"></asp:Label><p></p>
    <asp:TextBox ID="Descp" ReadOnly="true"  TextMode="MultiLine"  Columns="60" Rows="5" runat="server"></asp:TextBox>
    <asp:CheckBox ID="EditarInfo" Visible="false" AutoPostBack="true" Text="Editar Informação" runat="server" />
     <p></p>
    <asp:Label ID="DatIl" runat="server" Text="Data de Inicio:"></asp:Label>
    <asp:TextBox ID="data" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:CheckBox ID="Encerrar" Visible="false" runat="server" Text="Encerrar Processo" />
    <p>
        <asp:Button ID="ActualizarProcesso" Visible="false" runat="server" Text="Actualizar" />
    </p>
 
</asp:Content>

