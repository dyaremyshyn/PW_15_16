using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Pedidos : System.Web.UI.Page
{
    static string pedActual;
    static int index=-1;
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd=new BDRegisto();
        ListItem it=new ListItem("Selecione");
        if (IsPostBack)
        {
            if (Pedido.Items.Count < 1|| index!=RadioButtonList1.SelectedIndex)
            {
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    Pedido.DataSource = bd.getPedidosVisto();
                    Pedido.DataTextField = "TITULOPEDIDO";
                    Pedido.DataValueField = "COD_PEDIDO";
                    Pedido.DataBind();
                    Pedido.Items.Insert(0, it);
                    pedActual = Pedido.SelectedValue;
                    index = RadioButtonList1.SelectedIndex;
                }
                else
                {
                    Pedido.DataSource = bd.getPedidosNaoVisto();
                    Pedido.DataTextField = "TITULOPEDIDO";
                    Pedido.DataValueField = "COD_PEDIDO";
                    Pedido.DataBind();
                    Pedido.Items.Insert(0, it);
                    pedActual = Pedido.SelectedValue;
                    index = RadioButtonList1.SelectedIndex;
                }
            }
            else
            {

                if (Pedido.SelectedIndex != 0)
                {
                    Response.Redirect("Pedido.aspx?" + "id=" + Pedido.SelectedValue);
                }
            }
        }
        
    }
}