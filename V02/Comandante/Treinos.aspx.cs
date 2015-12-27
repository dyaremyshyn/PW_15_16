using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Treinos : System.Web.UI.Page
{
    static DateTime time;
    static string Treinadoractual;
    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem aux;
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            aux = new ListItem("Selecione");
            TreinosAgendados.DataSource = bd.getTreinos();
            TreinosAgendados.DataTextField = "HORA_INICIO_TREINO";
            TreinosAgendados.DataValueField = "COD_TREINO";
            TreinosAgendados.DataBind();
            TreinosAgendados.Items.Insert(0, aux);


            Data.SelectedDate = DateTime.Today;
            Hora.DataSource = bd.getHorasEntrada();
            Hora.DataTextField = "HORA";
            Hora.DataValueField = "Id";
            Hora.DataTextFormatString = "{0:HH:mm}";
            Hora.DataBind();
            time = Data.SelectedDate;

            Hora.Items.Insert(0, aux);
            horafim.Items.Insert(0, aux);

            Treinador.DataSource = bd.getAgentesFolga(Data.SelectedDate);
            Treinador.DataTextField = "Nome";
            Treinador.DataValueField = "Distintivo";
            Treinador.DataBind();
            Treinador.Items.Insert(0, aux);
            Treinadoractual = Treinador.SelectedValue;
        }
        else
        {
            if (time != Data.SelectedDate)
            {
                aux = new ListItem("Selecione");
                Treinador.DataSource = bd.getAgentesFolga(Data.SelectedDate);
                Treinador.DataTextField = "Nome";
                Treinador.DataValueField = "Distintivo";
                Treinador.DataBind();
                Treinador.Items.Insert(0, aux);
                time = Data.SelectedDate;
            }
            if ((Hora.SelectedIndex != 0 && horafim.SelectedIndex == 0))
            {
                aux = new ListItem("Selecione");
                int i = Convert.ToInt32(Hora.SelectedValue);
                horafim.DataSource = bd.getHorasSaida(i);
                horafim.DataTextField = "HORA";
                horafim.DataValueField = "Id";
                horafim.DataTextFormatString = "{0:HH:mm}";
                horafim.DataBind();
                //
                horafim.Items.Insert(0, aux);
            }

            if (Treinadoractual != Treinador.SelectedValue && Treinador.SelectedIndex !=0)
            {
                Agentes.DataSource=bd.getAgentesFolga(Data.SelectedDate, Treinador.SelectedValue);
                Agentes.DataTextField = "Nome";
                Agentes.DataValueField = "Distintivo";
                Agentes.DataBind();
                Treinadoractual = Treinador.SelectedValue;

            }

        }
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
        horafim.Visible = true;
        Horaf.Visible = true;
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

        BDRegisto bd = new BDRegisto();
        DateTime hora = DateTime.ParseExact(Hora.SelectedItem.Text + ":00", "HH:mm:ss", null);
        hora = new DateTime(Data.SelectedDate.Year, Data.SelectedDate.Month, Data.SelectedDate.Day, hora.Hour, hora.Minute, 0);
        DateTime horas = DateTime.ParseExact(horafim.SelectedItem.Text + ":00", "HH:mm:ss", null);
        horas =new DateTime(Data.SelectedDate.Year, Data.SelectedDate.Month, Data.SelectedDate.Day, horas.Hour, horas.Minute, 0);
        string responsavel = Treinador.SelectedValue;
        int id = bd.marcarTreino(Data.SelectedDate, hora,horas,responsavel, Tema.Text);


        foreach (ListItem li in Agentes.Items)
        {
            if (li.Selected)
            {
                bd.inserAgenteTreino(li.Value, id);
            }
        }


        TreinosAgendados.Visible = true;
        Treinolabel.Visible = true;
        NovoTreino.Visible = true;
        DataL.Visible = false;
        Data.Visible = false;
        Hora.Visible = false;
        HoraL.Visible = false;
        horafim.Visible = false;
        Horaf.Visible = false;
        Treinador.Visible = false;
        Rtreino.Visible = false;
        LTema.Visible = false;
        Tema.Visible = false;
        Marcar.Visible = false;
        Cancelar.Visible = false;
        AgentesL.Visible = false;
        Agentes.Visible = false;
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
        horafim.Visible = false;
        Horaf.Visible = false;
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