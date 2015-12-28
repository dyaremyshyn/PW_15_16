using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cidadao_MinhasQueixas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        ListItem aux = new ListItem("Selecione");
        if (!IsPostBack)
        {

            Queixas.DataSource = bd.getQueixas(Membership.GetUser().ProviderUserKey.ToString());
            Queixas.DataTextField = "TITULOQUEIXA";
            Queixas.DataValueField = "COD_QUEIXA";
            Queixas.DataBind();
            Queixas.Items.Insert(0, aux);

        }
        else
        {
            if (Queixas.SelectedIndex != 0)
            {
                DataTable dados = bd.getQueixa(Queixas.SelectedValue);
                Data.Text = ((DateTime)dados.Rows[0]["DATAQUEIXA"]).ToString("dd/MM/yyyy");
                AgenteResponsavel.Text = "";
                Queixa.Text = (string)dados.Rows[0]["DESCRICAOQUEIXA"];
                if ((string)dados.Rows[0]["ESTADOQUEIXA"] == "Aberto")
                {
                    Estado.SelectedIndex = 0;
                }
                else
                {
                    Estado.SelectedIndex = 1;
                }
                if ((string)dados.Rows[0]["SITUACAOQUEIXA"] == "Por Atribuir")
                {
                    Situacao.SelectedIndex = 0;
                }
                else
                {
                    if ((string)dados.Rows[0]["SITUACAOQUEIXA"] == "Finalizado")
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
                Queixa.Text = "";
                Data.Text = "";
                AgenteResponsavel.Text = "";
                Situacao.SelectedIndex = -1;
                Estado.SelectedIndex = -1;
            }
        }
    }
}