using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Formacoes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void NovaFormacao_Click(object sender, EventArgs e)
    {
        FormacoesAgendadas.Visible = false;
        FormAgendlabel.Visible = false;
        NovaFormacao.Visible = false;
        DataL.Visible = true;
        Data.Visible = true;
        Hora.Visible = true;
        HoraL.Visible = true;
        Formador.Visible = true;
        LForm.Visible = true;
        LTema.Visible = true;
        Tema.Visible = true;
        Marcar.Visible = true;
        Cancelar.Visible = true;


    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        FormacoesAgendadas.Visible = true;
        FormAgendlabel.Visible = true;
        NovaFormacao.Visible = true;
        DataL.Visible = false;
        Data.Visible = false;
        Hora.Visible = false;
        HoraL.Visible = false;
        Formador.Visible = false;
        LForm.Visible = false;
        LTema.Visible = false;
        Tema.Visible = false;
        Marcar.Visible = false;
        Cancelar.Visible = false;
    }
    protected void Marcar_Click(object sender, EventArgs e)
    {

    }
}