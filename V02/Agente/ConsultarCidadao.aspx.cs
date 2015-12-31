using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agente_ConsultarCidadao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListItem it = new ListItem("Selecione");
            resultado.Items.Insert(0, it);
        }
        else
        {

        }
    }
    protected void Pesquisar_Click(object sender, EventArgs e)
    {
        if (resultado.SelectedIndex != 0)
        {
            Response.Redirect("CidadaoDados.aspx?" + "id=" + resultado.SelectedValue);
        }
    }

    protected void Pesqnome_Click(object sender, ImageClickEventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        resultado.DataSource = bd.pesquisaCidadaoPorNome(Nome.Text);
        resultado.DataTextField = "NOME";
        resultado.DataValueField = "ID";
        resultado.DataBind();
        resultado.Items.Insert(0, it);
    }
    protected void PesqCidadao_Click(object sender, ImageClickEventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        resultado.DataSource = bd.pesquisaCidadaoPorNCIDADAO(Ncidadao.Text);
        resultado.DataTextField = "NOME";
        resultado.DataValueField = "ID";
        resultado.DataBind();
        resultado.Items.Insert(0, it);
    }
    protected void PesqMorada_Click(object sender, ImageClickEventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        resultado.DataSource = bd.pesquisaCidadaoPorMorada(Morada.Text);
        resultado.DataTextField = "NOME";
        resultado.DataValueField = "ID";
        resultado.DataBind();
        resultado.Items.Insert(0, it);
    }
    protected void pesqNIF_Click(object sender, ImageClickEventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        resultado.DataSource = bd.pesquisaCidadaoPorNIF(NIF.Text);
        resultado.DataTextField = "NOME";
        resultado.DataValueField = "ID";
        resultado.DataBind();
        resultado.Items.Insert(0, it);
    }
    protected void PesqContacto_Click(object sender, ImageClickEventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        resultado.DataSource = bd.pesquisaCidadaoPorContato(Contacto.Text);
        resultado.DataTextField = "NOME";
        resultado.DataValueField = "ID";
        resultado.DataBind();
        resultado.Items.Insert(0, it);
    }
    protected void PesqLocalidade_Click(object sender, ImageClickEventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        resultado.DataSource = bd.pesquisaCidadaoPorLocalidade(Localidade.Text);
        resultado.DataTextField = "NOME";
        resultado.DataValueField = "ID";
        resultado.DataBind();
        resultado.Items.Insert(0, it);
    }
    protected void pesqcodP_Click(object sender, ImageClickEventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        resultado.DataSource = bd.pesquisaCidadaoPorCP(CodigoPostal.Text);
        resultado.DataTextField = "NOME";
        resultado.DataValueField = "ID";
        resultado.DataBind();
        resultado.Items.Insert(0, it);
    }
}