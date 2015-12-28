using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cidadao_MeusPedidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        ListItem aux = new ListItem("Selecione");
        if (!IsPostBack)
        {

            Pedidos.DataSource = bd.getPedidos(Membership.GetUser().ProviderUserKey.ToString());
            Pedidos.DataTextField = "TITULOPEDIDO";
            Pedidos.DataValueField = "COD_PEDIDO";
            Pedidos.DataBind();
            Pedidos.Items.Insert(0, aux);

        }
        else
        {
            if (Pedidos.SelectedIndex != 0)
            {
                DataTable dados = bd.getPedido(Pedidos.SelectedValue);
                Data.Text = ((DateTime)dados.Rows[0]["DATA_INICIO_P"]).ToString("dd/MM/yyyy");
                DataFim.Text = ((DateTime)dados.Rows[0]["DATA_FIM_P"]).ToString("dd/MM/yyyy");
                Pedido.Text = (string)dados.Rows[0]["DESCRISSAOPEDIDO"];
                if ((string)dados.Rows[0]["ESTADOPEDIDO"] == "VISTO")
                {
                    Estado.SelectedIndex=0;
                }
                else
                {
                    Estado.SelectedIndex=1;
                }
                if ((string)dados.Rows[0]["SITUACAOPEDIDO"] == "EM ANDAMENTO")
                {
                    Situacao.SelectedIndex = 0;
                }
                else
                {
                    if ((string)dados.Rows[0]["SITUACAOPEDIDO"] == "POR COMECAR")
                    {
                        Situacao.SelectedIndex = 1;
                    }
                    else
                    {
                        Situacao.SelectedIndex = 2;
                    }
                }
            }
            else
            {
                Pedido.Text = "";
                Data.Text = "";
                DataFim.Text = "";
                Situacao.SelectedIndex = -1;

                Estado.SelectedIndex = -1;
            }
        }
    }
}