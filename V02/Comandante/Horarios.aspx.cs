using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Horarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            DataTable agentes = bd.carregaAgentes();
            Agente.DataSource = agentes;
            Agente.DataTextField = "NOME";
            Agente.DataValueField = "DISTINTIVO";
            Agente.DataBind();
            Agente.Items.Insert(0, it);
            Data.Visible = true;
            Data.SelectedDate = DateTime.Today;
            HoraE.DataSource = bd.getHorasEntrada();
            HoraE.DataTextField = "HORA";
            HoraE.DataValueField = "Id";
            HoraE.DataTextFormatString = "{0:HH:mm}";
            HoraE.DataBind();
           
            HoraE.Items.Insert(0, it);
            HoraS.Items.Insert(0, it);

        }
        else
        {
            if (Agente.SelectedIndex != 0)
            {
                infoa.Text = "";
                FotoAgente.Visible = true;
                string dist = Agente.SelectedValue.ToString();
                FotoAgente.ImageUrl = bd.carregaFotoAgente(dist);
                Data.Visible = true;
                DateTime dia = Data.SelectedDate;
                infoa.Text = bd.getHoraioAgenteDia(dia, Agente.SelectedValue);

                

                if ((HoraE.SelectedIndex != 0  && HoraS.SelectedIndex ==0) || HoraS.SelectedIndex < HoraE.SelectedIndex)
                {
                   
                    int i = Convert.ToInt32(HoraE.SelectedValue);
                    HoraS.DataSource = bd.getHorasSaida(i);
                    HoraS.DataTextField = "HORA";
                    HoraS.DataValueField = "Id";
                    HoraS.DataTextFormatString = "{0:HH:mm}";
                    HoraS.DataBind();
                    //HoraS.Items.Insert(0, it);

                   
                }

            }
            else
            {
                FotoAgente.Visible = false;
                Data.Visible = true;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label3.Visible = true;
        Label4.Visible = true;
        HoraE.Visible = true;
        HoraS.Visible = true;
        GravarHorario.Visible = true;
        EditarHorario.Visible = false;
        HorarioCompleto.Visible = false;
        CancelarHorario.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void CancelarHorario_Click(object sender, EventArgs e)
    {
        Label4.Visible = false;
        Label3.Visible = false;
        EditarHorario.Visible = true;
        HorarioCompleto.Visible = true;
        HoraE.Visible = false;
        HoraS.Visible = false;
        GravarHorario.Visible = false;
        CancelarHorario.Visible = false;
        HoraS.Items.Clear();
        ListItem it = new ListItem("Selecione");
        HoraS.Items.Insert(0, it);
        HoraE.SelectedIndex = 0;

    }
    protected void GravarHorario_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        if (Data.SelectedDate > DateTime.Today)
        {
           if (infoa.Text == "Agente Fora de Serviço")
           {
                DateTime dia = Data.SelectedDate;
                DateTime hora = DateTime.ParseExact(HoraE.SelectedItem.Text+":00","HH:mm:ss",null);
                DateTime horas = DateTime.ParseExact(HoraS.SelectedItem.Text+":00", "HH:mm:ss", null);
                hora = new DateTime(dia.Year, dia.Month, dia.Day, hora.Hour, hora.Minute, 0);
                horas = new DateTime(dia.Year, dia.Month, dia.Day, horas.Hour, horas.Minute, 0);
                bd.insertHora(Agente.SelectedValue, dia, hora, horas);
               
           }
            else
            {
                DateTime dia = Data.SelectedDate;
                DateTime hora = DateTime.ParseExact(HoraE.SelectedItem.Text + ":00", "HH:mm:ss", null);
                DateTime horas = DateTime.ParseExact(HoraS.SelectedItem.Text + ":00", "HH:mm:ss", null);
                hora = new DateTime(dia.Year, dia.Month, dia.Day, hora.Hour, hora.Minute, 0);
                horas = new DateTime(dia.Year, dia.Month, dia.Day, horas.Hour, horas.Minute, 0);
                bd.updateHoraTrabalho(Agente.SelectedValue, dia, hora, horas);
            }
        }
    }
}