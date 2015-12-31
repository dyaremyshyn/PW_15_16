using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agente_QueixasRecebidas : System.Web.UI.Page
{
    static string ultimaqueixa;
    static int index;
    protected void Page_Load(object sender, EventArgs e)
    {
        

         ListItem aux = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            QueixaDD.DataSource = bd.getQueixasNaoVistas();
            QueixaDD.DataTextField = "TITULOQUEIXA";
            QueixaDD.DataValueField = "COD_QUEIXA";
            QueixaDD.DataBind();
            QueixaDD.Items.Insert(0, aux);
            ultimaqueixa = QueixaDD.SelectedValue;
            Agente.DataSource = bd.getAgentes();
            Agente.DataTextField = "NOME";
            Agente.DataValueField = "DISTINTIVO";
            Agente.DataBind();
            Agente.Items.Insert(0, aux);
            Processo.DataSource = bd.getProcessos();
            Processo.DataTextField = "TITULOPROCESSO";
            Processo.DataValueField = "IDPROCESSO";
            Processo.DataBind();
            Processo.Items.Insert(0, aux);
            index = RadioButtonList1.SelectedIndex;
        }
        else
        {
            
            if (QueixaDD.SelectedIndex != 0)
            {
                if (QueixaDD.SelectedValue != ultimaqueixa)
                {
                    DataTable data = bd.getQueixa(QueixaDD.SelectedValue);
                    TextBox1.Text = (string)data.Rows[0]["DESCRICAOQUEIXA"];
                    Autor.Text = (string)data.Rows[0]["NOME"];
                    Autor.NavigateUrl = Autor.NavigateUrl + "?" + "ID=" + ((int)data.Rows[0]["ID"]).ToString();
                    ultimaqueixa = QueixaDD.SelectedValue;


                   
                }
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    Nomeprocessol.Visible = true;
                    Processot.Visible = true;
                    Processo.Visible = false;
                    Agentel.Visible = true;
                    Agente.Visible = true;
                }
                else
                {
                    if (RadioButtonList1.SelectedIndex == 1)
                    {
                        Nomeprocessol.Visible = true;
                        Processot.Visible = false;
                        Processo.Visible = true;
                        Agentel.Visible = false;
                        Agente.Visible = false;
                    }
                    else
                    {
                        Nomeprocessol.Visible = true;
                        Processot.Visible = false;
                        Processo.Visible = false;
                        Agentel.Visible = false;
                        Agente.Visible = false;
                    }
                }
               
            }
            else
            {
                RadioButtonList1.SelectedIndex = -1;
                ultimaqueixa = QueixaDD.SelectedValue;
                TextBox1.Text = "";
                Autor.Visible = false;
                Nomeprocessol.Visible = false;
                Processot.Visible = false;
                Processo.Visible = false;
                Agentel.Visible = false;
                Agente.Visible = false;
            }

           
            
        }
    }
    protected void back_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Queixas.aspx");
    }

    protected void Aprovar_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        if (RadioButtonList1.SelectedIndex == 0)
        {
            if (Agente.SelectedIndex != 0)
            {
                int processo;
                processo = bd.abrirProcesso(Agente.SelectedValue, "", Processot.Text);
                bd.updateQueixaParaVista(QueixaDD.SelectedValue);
                bd.addQueixaProcesso(QueixaDD.SelectedValue, processo.ToString());
            }
        }
        else
        {
            if (RadioButtonList1.SelectedIndex == 1)
            {
                bd.updateQueixaParaVista(QueixaDD.SelectedValue);
                bd.addQueixaProcesso(QueixaDD.SelectedValue, Processo.SelectedValue);
            }
            else
            {
                Agente.SelectedIndex = 0;
                Processo.SelectedIndex = 0;
                RadioButtonList1.SelectedIndex = -1;
                QueixaDD.SelectedIndex = 0;
                Nomeprocessol.Visible = false;
                TextBox1.Text = "";
            }
        }
    }
}