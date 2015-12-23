using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Treinos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void NovoTreino_Click(object sender, EventArgs e)
    {
        TreinosAgendados.Visible = false;
        Treinolabel.Visible = false;
        NovoTreino.Visible = false;
        DataL.Visible = true;
        Data.Visible = true;
        Hora.Visible = true;
        HoraL.Visible = true;
        Treinador.Visible = true;
        Rtreino.Visible = true;
        LTema.Visible = true;
        Tema.Visible = true;
        Marcar.Visible = true;
        Cancelar.Visible = true;
        AgentesL.Visible = true;
        Agentes.Visible = true;
    }
    protected void Marcar_Click(object sender, EventArgs e)
    {

    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        TreinosAgendados.Visible = true;
        Treinolabel.Visible = true;
        NovoTreino.Visible = true;
        DataL.Visible = false;
        Data.Visible = false;
        Hora.Visible = false;
        HoraL.Visible = false;
        Treinador.Visible = false;
        Rtreino.Visible = false;
        LTema.Visible = false;
        Tema.Visible = false;
        Marcar.Visible = false;
        Cancelar.Visible = false;
        AgentesL.Visible = false;
        Agentes.Visible = false;
    }
}