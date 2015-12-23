<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Treinos.aspx.cs" Inherits="Comandante_Treinos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="Treinolabel" runat="server" Text="Formações Agendadas:"></asp:Label>
    <asp:DropDownList ID="TreinosAgendados" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Button ID="NovoTreino" runat="server" Text="Novo Treino" OnClick="NovoTreino_Click" />
    <asp:Label ID="DataL" Visible="false" runat="server" Text="Data:"></asp:Label>
    <asp:Calendar ID="Data" Visible="false" runat="server"></asp:Calendar>
    <p></p>
    <asp:Label ID="HoraL" Visible="false" runat="server" Text="Hora:"></asp:Label>
    <asp:DropDownList ID="Hora" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="Rtreino" runat="server" Visible="false" Text="Treinador:"></asp:Label>
    <asp:DropDownList ID="Treinador" Visible="false" runat="server"></asp:DropDownList>
    <p></p>
    <asp:Label ID="LTema" Visible="false" runat="server" Text="Tema:"></asp:Label>
    <asp:TextBox ID="Tema" Visible="false" runat="server"></asp:TextBox>
    <p></p>
    <asp:Label ID="AgentesL" Visible="false" runat="server" Text="Agentes:"></asp:Label>

    <asp:CheckBoxList ID="Agentes" Visible="false" RepeatColumns="5" runat="server"></asp:CheckBoxList>
    <p></p>
    <asp:Button ID="Marcar" Visible="false" runat="server" Text="Marcar" OnClick="Marcar_Click" />
    <asp:Button ID="Cancelar" Visible="false" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
</asp:Content>

