using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Processos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            Processo.DataSource = bd.getProcessos();
            Processo.DataTextField = "TITULOPROCESSO";
            Processo.DataValueField = "IDPROCESSO";
            Processo.DataBind();
            Processo.Items.Insert(0, it);
        }
        else
        {
            if (Processo.SelectedIndex != 0)
            {
                DataTable Data = bd.getProcesso(Processo.SelectedValue);
                Res.Text = bd.getNomeAgente(((decimal)Data.Rows[0]["AGE_R_P"]).ToString());
                Descp.Text = (string)Data.Rows[0]["DESCRICAOPROCESSO"];
                data.Text = ((DateTime)Data.Rows[0]["DataAbertura"]).ToString("dd/MM/yyyy");
                if (Queixa.Items.Count < 1)
                {
                    Queixa.DataSource = bd.getQueixaProcesso(Processo.SelectedValue);
                    Queixa.DataTextField = "TITULOQUEIXA";
                    Queixa.DataValueField = "COD_QUEIXA";
                    Queixa.DataBind();
                    Queixa.Items.Insert(0, it);
                }

                if (Depoimentos.Items.Count < 1)
                {
                    Depoimentos.DataSource = bd.getDepoimentoProcesso(Processo.SelectedValue);
                    Depoimentos.DataTextField = "COD_DEPOIMENTO";
                    Depoimentos.DataValueField = "COD_DEPOIMENTO";
                    Depoimentos.DataBind();
                    Depoimentos.Items.Insert(0, it);
                }
                verQueixa.Text = "Ver Queixa " + Queixa.SelectedItem.Text;
                string n = "~/Comandante/QueixasVistas.aspx";
                verQueixa.NavigateUrl = n + "?" + "ID=" + Queixa.SelectedValue;
                VerDep.Text = "Ver Depoimento" + Depoimentos.SelectedItem.Text;
                VerDep.NavigateUrl = "~/Comandante/DepoimentosRecebidos.aspx" + "?" + "ID=" + Depoimentos.SelectedValue;


            }
        }
    }
}
   
  
  