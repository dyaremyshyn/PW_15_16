<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="DadosPessoais.aspx.cs" Inherits="Agente_DadosPessoais" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Consultar Agente"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Nome:  "></asp:Label>
    <asp:TextBox ID="txtNomeAgente" ReadOnly="true" visible="true" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label3" runat="server" Text="ID:  "></asp:Label>
    <asp:TextBox ID="txtIDAgente" ReadOnly="true" runat="server"></asp:TextBox>
    <asp:Image ID="Foto"  Width="150px" Height="120" runat="server" />
    <p></p>
     <asp:Label ID="lblFoto" Visible="false"  runat="server" Text="Foto:"></asp:Label>
    <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" />
    <p></p>
    <asp:Label ID="Label4" runat="server" Text="Data Nascimento: "></asp:Label>
    <asp:TextBox ID="txtDataNascimento" ReadOnly="true" runat="server"></asp:TextBox>
    <asp:Calendar ID="CalendarDataNascimento" Width="25px" Height="25px" AutoPostBack="true" Visible="False" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
        <NextPrevStyle VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#808080" />
        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" />
        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
        <WeekendDayStyle BackColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Label ID="Label5" runat="server" Text="Idade: "></asp:Label>
    <asp:TextBox ID="txtIdade" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label6" runat="server" Text="Contribuinte: "></asp:Label>
    <asp:TextBox ID="txtContribuinte" ReadOnly="true" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label7" runat="server" Text="Morada: "></asp:Label>
    <asp:TextBox ID="txtMorada" ReadOnly="true" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label8" runat="server" Text="Sexo: "></asp:Label>
    <asp:TextBox ID="txtSexo" ReadOnly="true" runat="server"></asp:TextBox>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
        <asp:ListItem Selected="True">Masculino</asp:ListItem>
        <asp:ListItem>Feminino</asp:ListItem>
    </asp:RadioButtonList>
    <p></p>
    <asp:Label ID="Label9" runat="server" Text="Cód. Postal: "></asp:Label>
    <asp:TextBox ID="txtCodPostal" ReadOnly="true" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label10" runat="server" Text="NºArma: "></asp:Label>
    <asp:DropDownList ID="ddlNArma" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="Label11" runat="server" Text="Contacto: "></asp:Label>
    <asp:TextBox ID="txtContacto" ReadOnly="true" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label12" runat="server" Text="Localidade: "></asp:Label>
    <asp:TextBox ID="txtLocalidade" ReadOnly="true" runat="server"></asp:TextBox>    
    <p></p>
    <asp:Button ID="EditarDados" runat="server" Text="Editar" OnClick="EditarDados_Click"/>
    <asp:Button ID="Atualizar" Visible="false" runat="server" Text="Atualizar" OnClick="Atualizar_Click" />&nbsp;
    <asp:Button ID="Cancelar" Visible="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
    
</asp:Content>

