<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="AdicionarAgente.aspx.cs" Inherits="Comandante_AdicionarAgente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
     <h1> <asp:Label ID="Label2" runat="server" Text="Adicionar Agente"></asp:Label> </h1>
    <asp:Label ID="Label1" runat="server" Text="Numero de Cidadão:"></asp:Label>
    <asp:TextBox ID="Cidadao" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="PesquisaCidadao" runat="server" Text="Pesquisa" OnClick="PesquisaCidadao_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
    <p></p>
    Resultado:<asp:Label ID="Info" runat="server" ForeColor="Red"  Text=""></asp:Label>
    <p></p>
    <asp:Label ID="LabelNome" runat="server" Visible="false" Text="Nome:"></asp:Label>
    <asp:TextBox ID="Nome" Visible="false" ReadOnly="true" runat="server"></asp:TextBox>
    <asp:Image ID="Foto" runat="server" />
    <p></p>
    <asp:Label ID="LabelContr" runat="server" Visible="false" Text="Nº Contribuinte:"></asp:Label>
    <asp:TextBox ID="Contribuinte" Visible="false" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="LabelIda" runat="server" Visible="false" Text="Idade:"></asp:Label>
    <asp:TextBox ID="Idade1" ReadOnly="true" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="LabelDn" runat="server" Visible="false" Text="Data de Nascimento:"></asp:Label>
    <asp:TextBox ID="DataNascimento" Visible="false"  ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="DadosAgentes" ForeColor="Green" Visible="false" runat="server" Text="Complete os dados do agente:"></asp:Label>
    <p></p>
    <asp:Label ID="NumeroSerieA" Visible="false" runat="server" Text="Numero de Destintivo:"></asp:Label>
    <asp:TextBox ID="NumeroSerie" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Funcao2" Visible="false" runat="server" Text="Funcao:"></asp:Label>
    <asp:TextBox ID="funcao" Visible="false" runat="server"></asp:TextBox>
     <p></p>
    <asp:Label ID="ArmaLab" ForeColor="Green" Visible="false" runat="server" Text="Arma Principal:"></asp:Label>
    <p></p>
    <asp:Label ID="Nseriel" Visible="false" runat="server" Text="Nº de Serie:"></asp:Label>
    <asp:TextBox ID="NSerie" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Fabricantel" Visible="false" runat="server" Text="Fabricante:"></asp:Label>
    <asp:TextBox ID="Fabrincante" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Modelol" Visible="false" runat="server" Text="Modelo:"></asp:Label>
    <asp:TextBox ID="Modelo" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="balal" Visible="false" runat="server" Text="Calibre de bala:"></asp:Label>
    <asp:DropDownList visible="false" ID="DropDownList1" runat="server">
        <asp:ListItem Enabled="true">Selecione</asp:ListItem>
        <asp:ListItem Value="5.56">5,56</asp:ListItem>
        <asp:ListItem Value="6.35">6,35</asp:ListItem>
        <asp:ListItem Value="7.62">7,62</asp:ListItem>
        <asp:ListItem Value="7.65">7,65</asp:ListItem>
        <asp:ListItem Value="7.8">7,8</asp:ListItem>
        <asp:ListItem Value="7.92">7,92</asp:ListItem>
        <asp:ListItem Value="8.9">8,9</asp:ListItem>
        <asp:ListItem Value="9">9</asp:ListItem>
        <asp:ListItem Value="9.5">9,5</asp:ListItem>
        <asp:ListItem Value="10">10</asp:ListItem>
        <asp:ListItem Value="11.25">11,25</asp:ListItem>
        <asp:ListItem Value="11.87">11,87</asp:ListItem>
        <asp:ListItem Value="12.49">12,49</asp:ListItem>
        <asp:ListItem Value="14.5">14,5</asp:ListItem>
        <asp:ListItem Value="15.6">15,6</asp:ListItem>
        <asp:ListItem Value="18.5">18,5</asp:ListItem>
        <asp:ListItem Value="19,7">19,7</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="id" Visible="false" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    
    <asp:Button ID="InserirAgente" Visible="false" runat="server" Text="Inserir Agente" OnClick="InserirAgente_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
    <p></p>
    <asp:Label ID="reslabel" Visible="false" runat="server" Text="Resultado:"></asp:Label><asp:Label ID="Resultado" Visible="false" runat="server" Text=""></asp:Label>

</asp:Content>

