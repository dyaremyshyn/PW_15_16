using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Queixas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string s =Situacao.SelectedValue;
            switch (s)
            {
                case "Visto":
                    {
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
                    } break;
                case "Nao Visto":
                    {
                        {
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
                        } 
                    } break;
                case "Atribuida": break;
                case "Nao Atribuida": break;
                   
            }
        }
    }
}