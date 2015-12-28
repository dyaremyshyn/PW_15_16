using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cidadao_ApresentarQueixa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Enviar_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        bd.InserQUeixa(Membership.GetUser().ProviderUserKey.ToString(), Motivo.Text, Queixa.Text);
        Motivo.Text = "";
        Queixa.Text = "";
        final.Text = "A sua queixa foi enviada com sucesso, tentaremos ser breves a contacta-lo";
        final.Visible = true;
    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        Motivo.Text = "";
        Queixa.Text = "";
        final.Visible = false;
    }
}