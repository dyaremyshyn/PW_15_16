using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agente_QueixasRecebidasVistas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem aux = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            if (Request.QueryString["ID"] != null)
            {
                QueixaDD.DataSource = bd.getQueixa(Request.QueryString["id"]);
                QueixaDD.DataTextField = "TITULOQUEIXA";
                QueixaDD.DataValueField = "COD_QUEIXA";
                QueixaDD.DataBind();
                DataTable data = bd.getQueixa(QueixaDD.SelectedValue);
                TextBox1.Text = (string)data.Rows[0]["DESCRICAOQUEIXA"];
                Autor.Text = (string)data.Rows[0]["NOME"];
                Autor.NavigateUrl = Autor.NavigateUrl + "?" + "ID=" + ((int)data.Rows[0]["ID"]).ToString();
                string situacao = (string)data.Rows[0]["SITUACAOQUEIXA"];
                if (situacao == "PROCESSO ABERTO")
                {
                    RadioButtonList1.SelectedIndex = 0;
                }
                else
                {
                    RadioButtonList1.SelectedIndex = 1;
                }
                DataTable Processo = bd.getProcessoQueixa(QueixaDD.SelectedValue);
                Agente.Text = bd.getNomeAgente(((decimal)Processo.Rows[0]["AGE_R_P"]).ToString());
                Processot.Text = (string)Processo.Rows[0]["TITULOPROCESSO"];

            }

            else
            {
                QueixaDD.DataSource = bd.getQueixasVistas();
                QueixaDD.DataTextField = "TITULOQUEIXA";
                QueixaDD.DataValueField = "COD_QUEIXA";
                QueixaDD.DataBind();
                QueixaDD.Items.Insert(0, aux);
            }

        }
        else
        {
            if (QueixaDD.SelectedIndex != 0)
            {
                DataTable data = bd.getQueixa(QueixaDD.SelectedValue);
                TextBox1.Text = (string)data.Rows[0]["DESCRICAOQUEIXA"];
                Autor.Text = (string)data.Rows[0]["NOME"];
                Autor.NavigateUrl = Autor.NavigateUrl + "?" + "ID=" + ((int)data.Rows[0]["ID"]).ToString();
                string situacao = (string)data.Rows[0]["SITUACAOQUEIXA"];
                if (situacao == "PROCESSO ABERTO")
                {
                    RadioButtonList1.SelectedIndex = 0;
                }
                else
                {
                    RadioButtonList1.SelectedIndex = 1;
                }
                DataTable Processo = bd.getProcessoQueixa(QueixaDD.SelectedValue);
                Agente.Text = bd.getNomeAgente(((decimal)Processo.Rows[0]["AGE_R_P"]).ToString());
                Processot.Text = (string)Processo.Rows[0]["TITULOPROCESSO"];
            }
        }
    }
    protected void back_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("QueixasRecebidas.aspx");
    }
    protected void Aprovar_Click(object sender, EventArgs e)
    {

    }
}