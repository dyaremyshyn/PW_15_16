using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_CidadaoDados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        ListItem it = new ListItem("Selecione");
        if (!IsPostBack)
        {
            DataTable dados = bd.getCidadaoPorId(Request.QueryString["id"]);
            Nome.Text =(string)dados.Rows[0]["NOME"];
            Ncidadao.Text = Convert.ToString(((decimal)dados.Rows[0]["NCIDADAO"]));
            NIF.Text = Convert.ToString(((decimal)dados.Rows[0]["NCONTRIBUINTE"]));
            Morada.Text = (string)dados.Rows[0]["MORADA"];
            Contacto.Text = (string)dados.Rows[0]["NTELEFONE"];
            Localidade.Text = (string)dados.Rows[0]["LOCALIDADE"];
            CodigoPostal.Text = (string)dados.Rows[0]["COD_POSTAL"];
            Sexo.Text = (string)dados.Rows[0]["SEXO"];
            Foto.ImageUrl = bd.carregaFotoCidadao(Request.QueryString["id"]);
            Pedidos.Items.Insert(0, it);
            Queixas.Items.Insert(0, it);
            Depoimentos.Items.Insert(0, it);
        }
    }

    protected void VoltarAtras_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Cidadoes.aspx");
    }
}