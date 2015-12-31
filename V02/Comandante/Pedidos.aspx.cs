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
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Pedido.DataSource = bd.getPedidosVisto();
                Pedido.DataTextField = "TITULOPEDIDO";
                Pedido.DataValueField = "COD_PEDIDO";
                Pedido.DataBind();
                Pedido.Items.Insert(0, it);

            }
            else
            {
                Pedido.DataSource = bd.getPedidosNaoVisto();
                Pedido.DataTextField = "TITULOPEDIDO";
                Pedido.DataValueField = "COD_PEDIDO";
                Pedido.DataBind();
                Pedido.Items.Insert(0, it);
            }

            if (Pedido.Items.Count > 1)
            {
                if (Pedido.SelectedIndex != 0)
                {
                    
                }
            }
        }
        
    }
}