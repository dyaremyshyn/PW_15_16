<%@ Page Title="" Language="C#" MasterPageFile="~/Geral/Geral.master" AutoEventWireup="true" CodeFile="Registo.aspx.cs" Inherits="Geral_Registo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
        .auto-style2 {
            width: 95px;
        }
        .auto-style3 {
            width: 95px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style5 {
            width: 95px;
            height: 25px;
        }
        .auto-style6 {
            height: 25px;
        }
        .auto-style7 {
            width: 95px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" LoginCreatedUser="False" ContinueDestinationPageUrl="~/Geral/InicioG.aspx" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" OnCreatedUser="CreateUserWizard1_CreatedUser1">
        <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
        <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
        <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <WizardSteps>
             <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td align="center" colspan="2"><h1>Efetuar Registo</h1></td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style2">
                                <asp:Label runat="server" AssociatedControlID="UserName" ID="UserNameLabel">User Name:</asp:Label>

                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="UserName"></asp:TextBox>
                            
                            </td>
                                <td>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ValidationGroup="CreateUserWizard1" ToolTip="User Name is required." ID="UserNameRequired">*</asp:RequiredFieldValidator>
                                </td>
                        </tr>
                        <tr>
                         <td align="right" class="auto-style2">
                                <asp:Label runat="server" AssociatedControlID="UserName" ID="NomeC">Nome Completo:</asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" ID="Nome"></asp:TextBox>
                            </td>
                            <td>
                                 <asp:RequiredFieldValidator runat="server" ControlToValidate="Nome" ErrorMessage="User Name is required." ValidationGroup="CreateUserWizard1" ToolTip="User Name is required." ID="RequiredFieldValidator3">*</asp:RequiredFieldValidator>
                            </td>
                            </tr>
                            <tr>
                            <td align="right" class="auto-style7">
                                <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName">NºCidadao:</asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:TextBox ID="cidadao_1" runat="server"></asp:TextBox>
                            </td>
                            <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="cidadao_1" Display="Dynamic" ErrorMessage="Preenchimento Obrigatório" ForeColor="#ff0000" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="cidadao_1" ErrorMessage="Número de dígitos inválido! 9 dígitos" ForeColor="#ff0000" ValidationExpression="[0-9]{9}" ValidationGroup="CreateUserWizard1">*</asp:RegularExpressionValidator>
                            </td>
                                </tr>
                            <tr>
                                <td align="right" class="auto-style2">
                                    <asp:Label ID="Label2" runat="server" AssociatedControlID="UserName">NºContribuinte:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="nif_1" runat="server" CssClass="textbox" Width="133px" ></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Preenchimento Obrigatório" ControlToValidate="nif_1" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator> 
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Número de dígitos inválido! 9 dígitos" ControlToValidate="nif_1" ValidationExpression="[0-9]{9}" ForeColor="#ff0000"  ValidationGroup="CreateUserWizard1">*</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style2">
                                    <asp:Label ID="Label3" runat="server" AssociatedControlID="UserName">Morada:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Morada_cliente" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Preenchimento Obrigatório" ForeColor="#ff0000" ControlToValidate="Morada_cliente">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style5">
                                    <asp:Label ID="Label4" runat="server" AssociatedControlID="UserName">Cod Postal:</asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="Codigo_p_cliente" runat="server" CssClass="textbox" Width="67px" ></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Preenchimento Obrigatório" ForeColor="#ff0000" ControlToValidate="Codigo_p_cliente">*</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Código Postal inválido! Formato Correcto: nnnn-nnn" ControlToValidate="Codigo_p_cliente" ValidationExpression="[0-9]{4}-[0-9]{3}" ForeColor="#ff0000">*</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style5">
                                    <asp:Label ID="Label5" runat="server" AssociatedControlID="UserName">Localidade:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="cidade1" runat="server" CssClass="textbox" Width="133px" ></asp:TextBox>
                               
                                </td>
                                <td>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"  ErrorMessage="Preenchimento Obrigatório" ForeColor="#ff0000" ControlToValidate="cidade1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style5">
                                    <asp:Label ID="Label6" runat="server" AssociatedControlID="UserName">Data Nascimento:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="data" runat="server" /> 
                                    
                                </td>
                                <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Preenchimento Obrigatório" ForeColor="#ff0000" ControlToValidate="data">*</asp:RequiredFieldValidator> 
                                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Data inválida! Formato Correcto: dd-mm-aaaa" ForeColor="#ff0000" ValidationExpression="[0-3]{1}[0-9]{1}-[0-1]{1}[0-2]{1}-[0-9]{4}" ControlToValidate="data">*</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style5">
                                <asp:Label ID="Label7" runat="server" AssociatedControlID="UserName">Telefone:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Contato_t_cliente" runat="server" /> 
                         
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatortel" runat="server" ErrorMessage="Preenchimento Obrigatório" ForeColor="#ff0000" ControlToValidate="Contato_t_cliente">*</asp:RequiredFieldValidator> 
                                    <asp:RegularExpressionValidator runat="server"  ErrorMessage="Número inválido! 9 Dígitos" ForeColor="#ff0000" ControlToValidate="Contato_t_cliente"  ValidationGroup="CreateUserWizard1" ValidationExpression="[0-9]{9}">*</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        <tr>
                            <td align="right" class="auto-style5">
                                <asp:Label ID="Label8" runat="server" AssociatedControlID="UserName">Foto:</asp:Label>
                            </td>
                            <td>
                                <asp:FileUpload ID="Imagem" runat="server" />
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorimg" runat="server" ErrorMessage="Preenchimento Obrigatório" ForeColor="#ff0000" ControlToValidate="Imagem">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                            <tr>
                                <td align="right" class="auto-style3">
                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                </td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password obrigatória." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style2">
                                    <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirmar Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style2">
                                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="E-mail is required." ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color: Red;" class="auto-style1">
                                    <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                </td>
                            </tr>
                        

                        
                    </table>
                </ContentTemplate>
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
        <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
        <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
        <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
        <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
        <StepStyle BorderWidth="0px" />
    </asp:CreateUserWizard>
    
</asp:Content>

