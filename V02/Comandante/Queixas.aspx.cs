using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Queixas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        if (IsPostBack)
        {
            string s =Situacao.SelectedValue;
            switch (s)
            {
                case "Visto":
                    {

                        QueixaDD.DataSource = bd.getQueixasVistas();
                        QueixaDD.DataTextField = "TITULOQUEIXA";
                        QueixaDD.DataValueField = "COD_QUEIXA";
                        QueixaDD.DataBind();
                        QueixaDD.Items.Insert(0, it);

                        Label2.Text = "Queixas Vistas";
                        back.Visible = true;
                        SituacaoL.Visible = false;
                        Situacao.Visible = false;
                        QueixaL.Visible = true;
                        QueixaDD.Visible = true;
                        TextBox1.Visible = true;
                        EstadoLRB.Visible = true;
                        EsdadoRB.Visible = true;
                        Situacaolb.Visible = true;
                        SituacaoRB.Visible = true;
                        RESPONSAVELl.Visible = true;
                        AgenteResponsavelD.Visible = true;
                        NomeProcessoL.Visible = true;
                        Autor.Visible = true;
                    } break;
                case "Nao Visto":
                    {
                        {

                            QueixaDD.DataSource = bd.getQueixasNaoVistas();
                            QueixaDD.DataTextField = "TITULOQUEIXA";
                            QueixaDD.DataValueField = "COD_QUEIXA";
                            QueixaDD.DataBind();
                            QueixaDD.Items.Insert(0, it);
                            Label2.Text = "Queixas Não Vistas";
                            back.Visible = true;
                            SituacaoL.Visible = false;
                            Situacao.Visible = false;
                            QueixaL.Visible = true;
                            QueixaDD.Visible = true;
                            TextBox1.Visible = true;
                            EstadoLRB.Visible = true;
                            EsdadoRB.Visible = true;
                            Situacaolb.Visible = true;
                            SituacaoRB.Visible = true;
                            RESPONSAVELl.Visible = true;
                            AgenteResponsavelD.Visible = true;
                            NomeProcessoL.Visible = true;
                            Autor.Visible = true;
                        } 
                    } break;
                case "Atribuida":
                    {
                        QueixaDD.DataSource = bd.getQueixasAtribuidas();
                        QueixaDD.DataTextField = "TITULOQUEIXA";
                        QueixaDD.DataValueField = "COD_QUEIXA";
                        QueixaDD.DataBind();
                        QueixaDD.Items.Insert(0, it);
                         Label2.Text="Queixas Atribuidas";
                        back.Visible = true;
                        SituacaoL.Visible = false;
                        Situacao.Visible = false;
                        QueixaL.Visible = true;
                        QueixaDD.Visible = true;
                        TextBox1.Visible = true;
                        EstadoLRB.Visible = true;
                        EsdadoRB.Visible = true;
                        Situacaolb.Visible = true;
                        SituacaoRB.Visible = true;
                        RESPONSAVELl.Visible = true;
                        AgenteResponsavelD.Visible = true;
                        NomeProcessoL.Visible = true;
                        Autor.Visible = true;
                    } break;
                case "Nao Atribuida":
                    {
                        QueixaDD.DataSource = bd.getQueixasNaoAtribuidas();
                        QueixaDD.DataTextField = "TITULOQUEIXA";
                        QueixaDD.DataValueField = "COD_QUEIXA";
                        QueixaDD.DataBind();
                        QueixaDD.Items.Insert(0, it);
                         Label2.Text="Queixas Não Atribuidas";
                        back.Visible = true;
                        SituacaoL.Visible = false;
                        Situacao.Visible = false;
                        QueixaL.Visible = true;
                        QueixaDD.Visible = true;
                        TextBox1.Visible = true;
                        EstadoLRB.Visible = true;
                        EsdadoRB.Visible = true;
                        Situacaolb.Visible = true;
                        SituacaoRB.Visible = true;
                        RESPONSAVELl.Visible = true;
                        AgenteResponsavelD.Visible = true;
                        NomeProcessoL.Visible = true;
                        Autor.Visible = true;
                    } break;
                case "FINALIZADAS":
                    {
                        QueixaDD.Items.Insert(0, it);
                        QueixaDD.DataSource = bd.getQueixasFinalizadas();
                        QueixaDD.DataTextField = "TITULOQUEIXA";
                        QueixaDD.DataValueField = "COD_QUEIXA";
                        QueixaDD.DataBind();

                        Label2.Text = "Queixas Com Processos Finalizados";
                        back.Visible = true;
                        SituacaoL.Visible = false;
                        Situacao.Visible = false;
                        QueixaL.Visible = true;
                        QueixaDD.Visible = true;
                        TextBox1.Visible = true;
                        EstadoLRB.Visible = true;
                        EsdadoRB.Visible = true;
                        Situacaolb.Visible = true;
                        SituacaoRB.Visible = true;
                        RESPONSAVELl.Visible = true;
                        AgenteResponsavelD.Visible = true;
                        NomeProcessoL.Visible = true;
                        Autor.Visible = true;
                    } break;


            }
            if(QueixaDD.SelectedIndex!=0){
            DataTable data = bd.getQueixa(QueixaDD.SelectedValue);
            TextBox1.Text = (string)data.Rows[0]["DESCRICAOQUEIXA"];
            Autor.Text = (string)data.Rows[0]["NOME"];
            Autor.NavigateUrl = Autor.NavigateUrl + "?" + "ID=" + ((int)data.Rows[0]["ID"]).ToString();
            if ((string)data.Rows[0]["ESTADOQUEIXA"] == "VISTO")
            {
                EsdadoRB.SelectedIndex = 0;
            }
            else
            {
                EsdadoRB.SelectedIndex = 1;
            }
            if ((string)data.Rows[0]["SITUACAOQUEIXA"] == "ATRIBUIDA")
            {
                SituacaoRB.SelectedIndex = 0;
            }
            else
            {
                if ((string)data.Rows[0]["SITUACAOQUEIXA"] == "FINALIZADA")
                {
                    SituacaoRB.SelectedIndex = 2;
                }
                else
                {
                    SituacaoRB.SelectedIndex = 1;
                    ResponsavelTextBox.Visible = false;
                    TBProcesso.Visible = true;
                    AgenteResponsavelD.Visible = true;
                    AbrirProcesso.Visible = true;
                    AgenteResponsavelD.DataSource = bd.getAgentes();
                    AgenteResponsavelD.DataTextField = "NOME";
                    AgenteResponsavelD.DataValueField = "DISTINTIVO";
                    AgenteResponsavelD.DataBind();
                    AgenteResponsavelD.Items.Insert(0, it);
                }
            }
            }
        }
    }
    protected void back_Click(object sender, ImageClickEventArgs e)
    {
        Label2.Text = "Queixas";
        back.Visible = false;
        SituacaoL.Visible = true;
        Situacao.Visible = true;
        QueixaL.Visible = false;
        QueixaDD.Visible = false;
        TextBox1.Visible = false;
        EstadoLRB.Visible = false;
        EsdadoRB.Visible = false;
        Situacaolb.Visible = false;
        SituacaoRB.Visible = false;
        RESPONSAVELl.Visible = false;
        AgenteResponsavelD.Visible = false;
        NomeProcessoL.Visible = false;
        Autor.Visible = false;
    }
    protected void AbrirProcesso_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        bd.abrirProcesso(AgenteResponsavelD.SelectedValue, "", TBProcesso.Text);
    }
}