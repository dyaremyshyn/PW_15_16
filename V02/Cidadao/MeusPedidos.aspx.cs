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
    static string pedidoatual,notaactual="";
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
            pedidoatual = Pedidos.SelectedValue;
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

                if (pedidoatual != Pedidos.SelectedValue)
                {
                    Notas.DataSource = bd.getMeusPedidosNotas(Pedidos.SelectedValue);
                    Notas.DataTextField = "DATA";
                    Notas.DataValueField = "IDNOTA";
                    Notas.DataBind();
                    Notas.Items.Insert(0, aux);
                    pedidoatual = Pedidos.SelectedValue;
                    notaactual = Notas.SelectedValue;
                }

                if (notaactual != Notas.SelectedValue)
                {
                    DataTable nota = bd.getNota(Notas.SelectedValue);
                    string mensagem;
                    mensagem = (string)nota.Rows[0]["MENSAGEM"];
                    mensagem=mensagem+"/n"+"/n"+"Agente: "+bd.getNomeAgente(((decimal)nota.Rows[0]["MENSAGEM"]).ToString());

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