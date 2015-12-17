<%@ Page Title="" Language="C#" MasterPageFile="~/Geral/Geral.master" AutoEventWireup="true" CodeFile="InicioG.aspx.cs" Inherits="Geral_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    Por favor, inicie sessão para continuar!<br />
    <br />
   <asp:Login ID="Login1" runat="server" CreateUserUrl="~/Geral/Registo.aspx" CreateUserText="Novo Utilizado" OnLoggedIn="Login1_LoggedIn"></asp:Login>
</asp:Content>

