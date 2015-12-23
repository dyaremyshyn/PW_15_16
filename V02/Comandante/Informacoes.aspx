<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Informacoes.aspx.cs" Inherits="Comandante_Informacoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="TituloL" runat="server" Text="Titulo:"></asp:Label>
    <asp:DropDownList ID="titulo" runat="server"></asp:DropDownList>
    <asp:TextBox ID="TituloTextBox" Visible="false" runat="server"></asp:TextBox>
    <tr>
        <asp:Image ID="Image1" runat="server" />
    </tr>
    <p></p>
    <asp:Label ID="Txtol" runat="server" Text="Texto:"></asp:Label>
    <textarea id="TextArea1" cols="20" rows="2"></textarea>
    <p></p>
    <asp:Label ID="Inserirlu" Visible="false" runat="server" Text="Inserir Imagem?"></asp:Label>

    <asp:CheckBox ID="InserirI" Visible="false" runat="server" />
    <asp:FileUpload Visible="false" ID="FileUpload1" runat="server" />
    <asp:Label ID="DataL" runat="server" Text="Data"></asp:Label>
    <asp:TextBox ID="Data" runat="server"></asp:TextBox>
    <p></p>
     <asp:Label ID="Horal" runat="server" Text="Hora"></asp:Label>
    <asp:TextBox ID="Hora" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="Submeter" Visible="false" runat="server" Text="Submeter" />
    <asp:Button ID="Anular" Visible="false" runat="server" Text="Anular" />
    <asp:Button ID="NovaInformação" BackColor="SteelBlue" runat="server" Text="Nova Informação" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:Button ID="Editar" runat="server" BackColor="Green" Text="Editar" />&nbsp;
    <asp:Button ID="Eliminar" runat="server" BackColor="Red" Text="Eliminar" />
</asp:Content>

