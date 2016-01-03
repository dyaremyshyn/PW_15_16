<%@ Page Title="" Language="C#" MasterPageFile="~/Comandante/Comandante.master" AutoEventWireup="true" CodeFile="Horarios.aspx.cs" Inherits="Comandante_Horarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
   <h1> <asp:Label ID="Label1" runat="server" Text="Defenir Horários"></asp:Label> </h1>
    <asp:DropDownList ID="Agente" AutoPostBack="true" runat="server"></asp:DropDownList>
    
    <asp:Image ID="FotoAgente" Visible="false" Width="150px" Height="120" runat="server" />
    <p></p>
    <asp:Label ID="infoa" runat="server" Text="Label"></asp:Label>
    <p></p>
    <asp:Label ID="Label2" runat="server" Text="Data:"></asp:Label>
    <asp:Calendar ID="Data" AutoPostBack="true" Visible="false" SelectionMode="Day" runat="server"></asp:Calendar>
    <p></p>
     <asp:Label ID="Label3" runat="server" Visible="false" Text="Hora de Entrada"></asp:Label>
    <asp:DropDownList Visible="false" ID="HoraE" AutoPostBack="true" runat="server">    
    </asp:DropDownList>
    <p></p>
    <asp:Label ID="Label4" runat="server" Visible="false" Text="Hora de Saida"></asp:Label>
    <asp:DropDownList ID="HoraS" Visible="false" AutoPostBack="true" runat="server"></asp:DropDownList>
    <asp:Button ID="EditarHorario" runat="server" Text="Editar Horario" OnClick="Button1_Click" BackColor="Green" BorderStyle="Groove" BorderColor="Black" Font-Bold="True" ForeColor="White" />
    <asp:Button ID="GravarHorario" Visible="false" runat="server" Text="Gravar" OnClick="GravarHorario_Click" />
    <asp:Button ID="CancelarHorario" Visible="false" runat="server" Text="Cancelar" OnClick="CancelarHorario_Click" />
    


    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

    <asp:Button ID="HorarioCompleto" runat="server" Text="Horario Completo" OnClick="Button2_Click" />
   
    
</asp:Content>

