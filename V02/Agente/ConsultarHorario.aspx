<%@ Page Title="" Language="C#" MasterPageFile="~/Agente/Policia.master" AutoEventWireup="true" CodeFile="ConsultarHorario.aspx.cs" Inherits="Agente_ConsultarHorario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <h1> <asp:Label ID="Label2" runat="server" Text="Horário:"></asp:Label> </h1>
    <p></p>
    <asp:Label ID="Label1" runat="server" Text="Data de Inicio: "></asp:Label>
    <asp:TextBox ID="txtInicio" TextMode="Date" runat="server" ></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Calendar ID="Data" AutoPostBack="true" Visible="false" SelectionMode="Day" runat="server"></asp:Calendar>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Data de Fim: "></asp:Label>
    <asp:TextBox ID="txtFim" TextMode="Date" runat="server"></asp:TextBox>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Calendar ID="Calendar1" AutoPostBack="true" Visible="false" SelectionMode="Day" runat="server"></asp:Calendar>
    <p></p>
    <asp:Button ID="btnPesquisaHorario" runat="server" Text="Ver Horario" OnClick="btnPesquisaHorario_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
    <div runat="server" id="myDiv" visible="false" >
        <h3>Horário</h3>
        <asp:GridView ID="gvHorario" runat="server"></asp:GridView>
        <p></p>
        <h3>Operações</h3>
        <asp:GridView ID="gvOperacoes" runat="server"></asp:GridView>
        <p></p>
        <h3>Treinos</h3>
        <asp:GridView ID="gvTreinos" runat="server"></asp:GridView>
        <p></p>
        <h3>Formações</h3>
        <asp:GridView ID="gvFormacoes" runat="server"></asp:GridView>
        <p></p> 
        <asp:Label ID="Label4" runat="server" Text="Info Extra: "></asp:Label>
        <asp:TextBox ID="txtInfoExtra" runat="server" ReadOnly="true" TextMode="MultiLine" placeholder="Sem Informações Extra"></asp:TextBox>
    </div>

</asp:Content>


