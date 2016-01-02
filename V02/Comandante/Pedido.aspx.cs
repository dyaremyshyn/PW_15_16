using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Pedido : System.Web.UI.Page
{
    BDRegisto bd = new BDRegisto();
    static string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            id = Request.QueryString["id"];
            DataTable data=bd.getPedido(Request.QueryString["id"]);
            DataTable cidadao = bd.getCidadaoPorId(((int)data.Rows[0]["IDQUEIXOSO"]).ToString());
            Autor.Text =(string)cidadao.Rows[0]["NOME"];
            Autor.NavigateUrl = Autor.NavigateUrl + "?" + "ID=" + ((int)cidadao.Rows[0]["ID"]).ToString();
            pedidotexto.Text = (string)data.Rows[0]["DESCRISSAOPEDIDO"];
            Situacao.Items.Insert(0, new ListItem("Em Andamento"));
            Situacao.Items.Insert(1, new ListItem("Por Começar"));
            Situacao.Items.Insert(2, new ListItem("Finalizado"));
           
            if (((string)data.Rows[0]["SITUACAOPEDIDO"]) == "POR COMECAR")
            {
                Situacao.SelectedIndex = 1;

            }
            else
            {
                if (((string)data.Rows[0]["SITUACAOPEDIDO"]) == "EM ANDAMENTO")
                {
                    Situacao.SelectedIndex = 0;
                }
                else
                {
                    Situacao.SelectedIndex = 3;
                }
            }

            if (((string)data.Rows[0]["ESTADOPEDIDO"]) == "NAO VISTO")
            {
                
            }
            else
            {
                DataFim.TextMode=TextBoxMode.SingleLine;
                DataInicio.ReadOnly = true;
                DataInicio.TextMode = TextBoxMode.SingleLine;
                DataFim.ReadOnly = true;
                DataFim.Text=((DateTime)data.Rows[0]["DATA_FIM_P"]).ToString("dd/MM/yyyy");
                DataInicio.Text = ((DateTime)data.Rows[0]["DATA_INICIO_P"]).ToString("dd/MM/yyyy");

            }
        }
    }
    protected void Gravar_Click(object sender, EventArgs e)
    {
        bd.updatePedido(id, Situacao.SelectedValue, DataInicio.Text, DataFim.Text);
    }
}