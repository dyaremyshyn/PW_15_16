using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Geral_Registo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void CreateUserWizard1_CreatedUser1(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        string idRegistado;
        string nome = CreateUserWizard1.UserName;
        if (!Roles.IsUserInRole(nome, "Cidadao"))
        {
            TextBox Nome = null;
            Nome = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Nome");
            TextBox ncidadao = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("cidadao_1");
            TextBox contribuinte = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("nif_1");
            TextBox Moradac = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Morada_cliente");
            TextBox codP = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Codigo_p_cliente");
            TextBox loc = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("cidade1");
            TextBox dataN = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("data");
            TextBox telefone = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Contato_t_cliente");
            FileUpload img = (FileUpload)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Imagem");
            RadioButtonList rd = (RadioButtonList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("SEXO");
            Roles.AddUserToRole(nome, "Cidadao");
            idRegistado = Membership.GetUser(nome).ProviderUserKey.ToString();
            Stream fs = img.PostedFile.InputStream;
            Byte[] bytes = bd.carregaImagem(fs);
            bd.criaDono(Nome.Text, ncidadao.Text, contribuinte.Text, Moradac.Text, codP.Text, loc.Text, dataN.Text, telefone.Text,idRegistado,bytes,rd.SelectedValue);
           
        }

    }
}