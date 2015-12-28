using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cidadao_ApresentarPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Enviar_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();

        bd.InserPedido(Membership.GetUser().ProviderUserKey.ToString(), Motivo.Text, Pedido.Text, Convert.ToDateTime(DataIncio.Text), Convert.ToDateTime(Datafim.Text));
        Motivo.Text = "";
        Pedido.Text = "";
        final.Text = "O seu pedido foi enviado com sucesso, tentaremos ser breves a contacta-lo";
        final.Visible = true;
    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        Motivo.Text = "";
        Pedido.Text = "";
        final.Visible = false;
    }
}