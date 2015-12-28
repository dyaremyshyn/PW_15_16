using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Pedidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd=new BDRegisto();
        ListItem it=new ListItem("Selecione");
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
                DropDownList1.Visible = true;
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

                if(DropDownList1.Items.Count<1){
                DropDownList1.DataSource=bd.getPedidosNaoVisto();
                DropDownList1.DataTextField = "TITULOPEDIDO";
                DropDownList1.DataValueField = "COD_PEDIDO";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0,it);
                }
                if (DropDownList1.SelectedIndex != 0)
                {
                    DataTable data = bd.getPedido(DropDownList1.SelectedValue);
                    TextBox1.Text = (string)data.Rows[0]["DESCRISSAOPEDIDO"];
                    DataInicio.Text = ((DateTime)data.Rows[0]["DATA_INICIO_P"]).ToString("dd/MM/yyyy");
                    DataFim.Text = ((DateTime)data.Rows[0]["DATA_FIM_P"]).ToString("dd/MM/yyyy");
                }
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

                if (DropDownList1.Items.Count < 1)
                {
                    DropDownList1.DataSource = bd.getPedidosVisto();
                    DropDownList1.DataTextField = "TITULOPEDIDO";
                    DropDownList1.DataValueField = "COD_PEDIDO";
                    DropDownList1.DataBind();
                    DropDownList1.Items.Insert(0, it);
                }

                if (DropDownList1.SelectedIndex != 0)
                {
                    DataTable data = bd.getPedido(DropDownList1.SelectedValue);
                    TextBox1.Text = (string)data.Rows[0]["DESCRISSAOPEDIDO"];
                    DataInicio.Text = ((DateTime)data.Rows[0]["DATA_INICIO_P"]).ToString("dd/MM/yyyy");
                    DataFim.Text = ((DateTime)data.Rows[0]["DATA_FIM_P"]).ToString("dd/MM/yyyy");
                }

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