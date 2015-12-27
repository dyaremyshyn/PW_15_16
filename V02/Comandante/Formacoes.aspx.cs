using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Formacoes : System.Web.UI.Page
{
    static DateTime time;
    protected void Page_Load(object sender, EventArgs e)
    {
        int count = 0;
        ListItem aux;
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            aux = new ListItem("Selecione");
            FormacoesAgendadas.DataSource = bd.getFormacoes();
            FormacoesAgendadas.DataTextField = "HORA_INICIO_TREINO";
            FormacoesAgendadas.DataValueField = "CODFORMACAO";
            FormacoesAgendadas.DataBind();
            FormacoesAgendadas.Items.Insert(0, aux);

            
            Data.SelectedDate = DateTime.Today;
            Hora.DataSource = bd.getHorasEntrada();
            Hora.DataTextField = "HORA";
            Hora.DataValueField = "Id";
            Hora.DataTextFormatString = "{0:HH:mm}";
            Hora.DataBind();
            time = Data.SelectedDate;
        }

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
        Descricaol.Visible = true;
        Descricao.Visible = true;
        Ambito.Visible = true;
        AMbitol.Visible = true;


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
        Descricaol.Visible = false;
        Descricao.Visible = false;
        Ambito.Visible = false;
        AMbitol.Visible = false;
    }
    protected void Marcar_Click(object sender, EventArgs e)
    {
        DateTime hora = DateTime.ParseExact(Hora.SelectedItem.Text + ":00", "HH:mm:ss", null);
        hora = new DateTime(Data.SelectedDate.Year, Data.SelectedDate.Month, Data.SelectedDate.Day, hora.Hour, hora.Minute, 0);

        BDRegisto bd = new BDRegisto();

        int n;
         n = bd.MarcarFormacao(Data.SelectedDate,hora,Formador.Text,Tema.Text,Descricao.Text,Ambito.Text);
         bd.agentesFormacao(n, Data.SelectedDate);

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
        Descricaol.Visible = false;
        Descricao.Visible = false;
        Ambito.Visible = false;
        AMbitol.Visible = false;
    }
}