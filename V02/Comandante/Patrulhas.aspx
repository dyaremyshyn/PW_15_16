<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Patrulhas.aspx.cs" Inherits="Comandante_Patrulhas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Patrulhas Agendadas:"></asp:Label>
    <asp:DropDownList ID="PatrulhasAgendadas" AutoPostBack="true" runat="server"></asp:DropDownList>
    <p></p>
    <asp:GridView ID="GridView1" Width="50" runat="server"></asp:GridView>
    <asp:DropDownList ID="AgentesPa" AutoPostBack="true" Visible="false" runat="server"></asp:DropDownList>
    <asp:DropDownList ID="ViaturasPa" AutoPostBack="true" Visible="false" runat="server"></asp:DropDownList><p></p>
    <asp:GridView ID="Viaturas" Visible="false" runat="server"></asp:GridView>
    <asp:Label ID="NovaP" runat="server" ForeColor="GreenYellow" Text="Nova Patrulha Marcada Com Sucesso"></asp:Label>
    <asp:Label ID="DataPatrulhaLabel"  Visible="false" runat="server" Text="Data:"></asp:Label>
    <asp:Calendar ID="Calendar1" Width="50px" Height="50" AutoPostBack="true" Visible="false" runat="server"></asp:Calendar>

    <asp:Label ID="LabelHoraPatrulha" Visible="false"  runat="server" Text="Hora"></asp:Label>
    <asp:DropDownList ID="HoraDD" AutoPostBack="true"  Visible="false" runat="server"></asp:DropDownList>
    
    <asp:Label ID="AgentesLabel" Visible="false" runat="server" Text="Agentes:"></asp:Label>
    <asp:CheckBoxList ID="AgentesRB" AutoPostBack="true" RepeatColumns="5" runat="server"></asp:CheckBoxList>
    <p></p>
      <asp:Label ID="LabelViaturas" Visible="false" runat="server" Text="Viaturas:"></asp:Label>
    <asp:CheckBoxList ID="ViaturasRB" Visible="false" RepeatColumns="5"  runat="server"></asp:CheckBoxList>
    <p></p>
    <asp:Label ID="Label5" runat="server" Visible="false" Text="Responsavel:"></asp:Label>
    <asp:DropDownList ID="Responsavel" Visible="false" runat="server"></asp:DropDownList>
    <asp:Label ID="Label3" Visible="false" runat="server" Text="Local"></asp:Label>
    <asp:TextBox ID="Local" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="Label4" Visible="false" runat="server" Text="Descrição:"></asp:Label>
    <asp:TextBox ID="Descricao" TextMode="MultiLine" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button ID="AgendarPatrulha"  BackColor="Green" runat="server" Text="Agendar Patrulha" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" OnClick="AgendarPatrulha_Click" />
    <asp:Button ID="Submit" Visible="false" runat="server" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" Text="Submeter" OnClick="Submit_Click" />
    <asp:Button ID="Cancelar" Visible="false" runat="server" Text="Cancelar" BackColor="Red" BorderColor="Black" Font-Bold="True" ForeColor="White" OnClick="Cancelar_Click" />
    
</asp:Content>

