using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Agentes : System.Web.UI.Page
{
    static string agente;
    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            Nome.DataSource = bd.carregaAgentes();
            Nome.DataTextField = "NOME";
            Nome.DataValueField = "DISTINTIVO";
            Nome.DataBind();
            Nome.Items.Insert(0, it);
            agente= Nome.SelectedValue;
        }
        else
        {
            Distintivo.Text = Nome.SelectedValue;
            NIF.Text = Convert.ToString((decimal)bd.getAgentedadosNaoPolicias(Nome.SelectedValue).Rows[0]["NCONTRIBUINTE"]);
            CC.Text = Convert.ToString((decimal)bd.getAgentedadosNaoPolicias(Nome.SelectedValue).Rows[0]["NCIDADAO"]);
            DataNascimento.Text = ((DateTime)bd.getAgentedadosNaoPolicias(Nome.SelectedValue).Rows[0]["DATANASCIMENTO"]).ToString("dd/MM/yyyy");
            Idade.Text = Convert.ToString(bd.calculaIdade((DateTime)bd.getAgentedadosNaoPolicias(Nome.SelectedValue).Rows[0]["DATANASCIMENTO"]));
            Morada.Text = ((string)bd.getAgentedadosNaoPolicias(Nome.SelectedValue).Rows[0]["MORADA"]);
            Contacto.Text = ((string)bd.getAgentedadosNaoPolicias(Nome.SelectedValue).Rows[0]["NTELEFONE"]);
            Image1.ImageUrl = bd.carregaFotoAgente(Nome.SelectedValue);
            CodPosta.Text = ((string)bd.getAgentedadosNaoPolicias(Nome.SelectedValue).Rows[0]["COD_POSTAL"]);
            Funcao.Text = bd.getFuncao(Nome.SelectedValue);
            if (agente != Nome.SelectedValue)
            {
                Armas.DataSource = bd.getArmasAgente(Nome.SelectedValue);
                Armas.DataTextField = "MODELO";
                Armas.DataValueField = "NARMA";
                Armas.DataBind();
                Armas.Items.Insert(0, it);
                agente = Nome.SelectedValue;
            }
            if (Armas.SelectedIndex != 0)
            {
                DescArma.Text = bd.getDescricaoArma(Armas.SelectedValue);
            }
        }
    }
    protected void back_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("RemoverAgente.aspx");
    }
}