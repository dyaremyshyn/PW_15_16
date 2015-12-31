using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_DepoimentosRecebidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            if (Request.QueryString["ID"] != null)
            {

                NDepoimento.DataSource = bd.getDepoimento(Request.QueryString["id"]);
                NDepoimento.DataTextField = "COD_DEPOIMENTO";
                NDepoimento.DataValueField = "COD_DEPOIMENTO";
                NDepoimento.DataBind();
                TextBox1.Visible = true;
                AutorL.Visible = true;
                DepoimentoL.Visible = true;
                Depoimento.Visible = true;
                Confirmar.Visible = false;
                DataTable data = bd.getDepoimento(NDepoimento.SelectedValue);
                TextBox1.Text = (string)data.Rows[0]["NOME"];
                Depoimento.Text = (string)data.Rows[0]["TITULODEPOIMENTO"] + "\n\n" + (string)data.Rows[0]["TEXTODEPOIMENTO"] + "\n" + "Data: " + ((DateTime)data.Rows[0]["DATADEP"]).ToString("dd/MM/yyyy");
                TextBox1.NavigateUrl = TextBox1.NavigateUrl + "?" + "ID=" + ((int)data.Rows[0]["ID"]).ToString();

            }
            else
            {
                NDepoimento.DataSource = bd.getDepoimentosPorAprovar();
                NDepoimento.DataTextField = "COD_DEPOIMENTO";
                NDepoimento.DataValueField = "COD_DEPOIMENTO";
                NDepoimento.DataBind();
                NDepoimento.Items.Insert(0, it);
            }
        }
        else
        {
            TextBox1.Visible = true;
            AutorL.Visible = true;
            DepoimentoL.Visible = true;
            Depoimento.Visible = true;
            AprovarD.Visible = true;
            Aprovar.Visible = true;
            DataTable data = bd.getDepoimento(NDepoimento.SelectedValue);
            TextBox1.Text = (string)data.Rows[0]["NOME"];
            Depoimento.Text = (string)data.Rows[0]["TITULODEPOIMENTO"] + "\n\n" + (string)data.Rows[0]["TEXTODEPOIMENTO"] + "\n" + "Data: " + ((DateTime)data.Rows[0]["DATADEP"]).ToString("dd/MM/yyyy");
            TextBox1.NavigateUrl = TextBox1.NavigateUrl + "?" + "ID=" + ((int)data.Rows[0]["ID"]).ToString();
            if (Aprovar.Checked == true)
            {
              
                ProcessoA.Visible = true;
                Processo.Visible = true;
                if (Processo.Items.Count < 1)
                {
                    Processo.DataSource = bd.getProcessos();
                    Processo.DataTextField = "TITULOPROCESSO";
                    Processo.DataValueField = "IDPROCESSO";
                    Processo.DataBind();
                    Processo.Items.Insert(0, it);
                }
            }
        }
    }
    protected void Confirmar_Click(object sender, EventArgs e)
    {
        BDRegisto bd= new BDRegisto();
        bd.updateDepoimento(Processo.SelectedValue, NDepoimento.SelectedValue);
    }
}