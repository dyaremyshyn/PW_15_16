using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Pedidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (RadioButtonList1.SelectedValue == "Nao Visto")
            {
                SituacaoVistosL.Visible = false;
                SituacaoVistos.Visible = false;
                Autor.Visible = false;
                AutorP.Visible = false;
                DataInicioVl.Visible = false;
                DataInicioV.Visible = false;
                DataFImV.Visible = false;
                PedidV.Visible = false;
                PedidoVistoD.Visible = false;
                NovoPedido.Visible = false;
                Pesquisar.Visible = false;
                DataFimVl.Visible = false;

                Pedido.Visible = true;
                DropDownList1.Visible = true;
                Pedidol.Visible = true;
                TextBox1.Visible = true;
                DataIniciol.Visible = true;
                DataInicio.Visible = true;
                DataFiml.Visible = true;
                DataFim.Visible = true;
                EstadoNL.Visible = true;
                EstadoNovo.Visible = true;
                SituacaoL.Visible = true;
                RadioButtonList2.Visible = true;
                Aprovar.Visible = true;
            }
            else
            {
                Pedido.Visible = false;
                DropDownList1.Visible = false;
                Pedidol.Visible = false;
                TextBox1.Visible = false;
                DataIniciol.Visible = false;
                DataInicio.Visible = false;
                DataFiml.Visible = false;
                DataFim.Visible = false;
                EstadoNL.Visible = false;
                EstadoNovo.Visible = false;
                SituacaoL.Visible = false;
                RadioButtonList2.Visible = false;
                Aprovar.Visible = false;

                SituacaoVistosL.Visible = true;
                SituacaoVistos.Visible = true;
                Autor.Visible = true;
                AutorP.Visible = true;
                DataInicioVl.Visible = true;
                DataInicioV.Visible = true;
                DataFImV.Visible = true;
                PedidV.Visible = true;
                PedidoVistoD.Visible = true;
                NovoPedido.Visible = true;
                Pesquisar.Visible = true;
                DataFimVl.Visible = true;
            }
        }
    }
}