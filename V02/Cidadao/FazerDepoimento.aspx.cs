using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cidadao_FazerDepoimento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Enviar_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        bd.InserDepoimento(Membership.GetUser().ProviderUserKey.ToString(), Caso.Text, Depoimento.Text);
        Caso.Text = "";
        Depoimento.Text = "";
        final.Text = "O seu depoimento foi enviado com sucesso, obrigado pela sua participação  no combate ao crime";
        final.Visible = true;
    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        Caso.Text = "";
        Depoimento.Text = "";
        final.Visible = false;
    }
}