﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Informacoes.aspx.cs" Inherits="Comandante_Informacoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <h1> <asp:Label ID="Label2" runat="server" Text="Informações"></asp:Label> </h1>
    <asp:Label ID="TituloL" runat="server" Text="Titulo:"></asp:Label>
    <asp:DropDownList ID="titulo" AutoPostBack="true" runat="server"></asp:DropDownList>
    <asp:TextBox ID="TituloTextBox" Visible="false" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="DataL" Visible="false" runat="server" Text="Data:"></asp:Label>
    <asp:TextBox ID="Data" ReadOnly="true" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <tb>
        <asp:Image ID="Image1" Width="250"  runat="server" ImageAlign="TextTop" />
    </tb>
    
     <asp:Label ID="Horal" Visible="false" runat="server" Text="Hora:"></asp:Label>
    <asp:TextBox ID="Hora" ReadOnly="true" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <p></p>
    <asp:Label ID="Txtol" runat="server" Visible="false" Text="Texto:"></asp:Label>
    <asp:TextBox ID="Texto" ReadOnly="true"  Visible="false" TextMode="MultiLine" Rows="10" Columns="50" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Inserirlu" Visible="false" runat="server" Text="Inserir Imagem?"></asp:Label>

    <asp:FileUpload Visible="false" ID="FileUpload1" runat="server" />
   
    <asp:Button ID="Submeter" Visible="false" runat="server" Text="Submeter" OnClick="Submeter_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White"/>
    <asp:Button ID="Anular" Visible="false" runat="server" Text="Anular" OnClick="Anular_Click" />
    <asp:Button ID="NovaInformação" BackColor="SteelBlue" runat="server" Text="Nova Informação" OnClick="NovaInformação_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:Button ID="Editar" Visible="false" runat="server" BackColor="Green" Text="Editar" OnClick="Editar_Click" />&nbsp;
    <asp:Button ID="Eliminar" Visible="false" runat="server" BackColor="Red" Text="Eliminar" OnClick="Eliminar_Click" />
    <asp:Button ID="update" Visible="false" runat="server" Text="Submeter Edição" OnClick="update_Click" />&nbsp;
    <asp:Button ID="canceleupdate" Visible="false" runat="server" Text="Cancelar Edição" OnClick="canceleupdate_Click" />
</asp:Content>

