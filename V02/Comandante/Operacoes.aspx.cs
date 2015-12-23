using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Operacoes : System.Web.UI.Page
{
    static DateTime time;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        int count = 0;
        ListItem aux;
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
             
            



            Data.SelectedDate = DateTime.Today;
            Hora.DataSource = bd.getHorasEntrada();
            Hora.DataTextField = "HORA";
            Hora.DataValueField = "Id";
            Hora.DataTextFormatString = "{0:HH:mm}";
            Hora.DataBind();
            time = Data.SelectedDate;
        }


        if (time != Data.SelectedDate)
        {
            count = 0;
            Agentes.Items.Clear();
            time = Data.SelectedDate;
            Viaturas.Items.Clear();
        }



        DateTime hora = DateTime.ParseExact(Hora.SelectedItem.Text + ":00", "HH:mm:ss", null);
        hora = new DateTime(Data.SelectedDate.Year, Data.SelectedDate.Month, Data.SelectedDate.Day, hora.Hour, hora.Minute, 0);

        foreach (ListItem li in Agentes.Items)
        {
            if (li.Selected)
            {
                count++;
            }
        }


        if (count == 0)
        {

            Agentes.DataSource = bd.getAgentesDisponiveis(Data.SelectedDate, hora);
            Agentes.DataTextField = "NOME";
            Agentes.DataValueField = "DISTINTIVO";
            Agentes.DataBind();
        }
        else
        {
            foreach (ListItem li in Agentes.Items)
            {
                if (li.Selected)
                {
                    aux = new ListItem(li.Text, li.Value);
                    aux.Selected = false;
                    Responsavel.Items.Add(aux);
                }
            }
        }
        if (Viaturas.Items.Count < 1)
        {
            Viaturas.DataSource = bd.getViaturaLivre();
            Viaturas.DataTextField = "MATRICULO";
            Viaturas.DataValueField = "COD_VEICULO";
            Viaturas.DataBind();

        }
       
    }
    protected void NovaOperacao_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        OperacoesAgendadas.Visible = false;
        NovaOperacao.Visible = false;
        NomeL.Visible = true;
        NomeDaOperacao.Visible = true;
        TipL.Visible = true;
        Tipo.Visible = true;
        LocalL.Visible = true;
        Local.Visible = true;
        Data.Visible = true;
        Lhora.Visible = true;
        Hora.Visible = true;
        Agentes.Visible = true;
        Viaturas.Visible = true;
        Inserir.Visible = true;
        Cancelar.Visible = true;
        Responsavel.Visible = true;
    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        OperacoesAgendadas.Visible = true;
        NovaOperacao.Visible = true;
        NomeL.Visible =false;
        NomeDaOperacao.Visible = false;
        TipL.Visible = false;
        Tipo.Visible = false;
        LocalL.Visible = false;
        Local.Visible = false;
        Data.Visible = false;
        Lhora.Visible = false;
        Hora.Visible = false;
        Agentes.Visible = false;
        Viaturas.Visible = false;
        Inserir.Visible = false;
        Cancelar.Visible = false;
        Responsavel.Visible = false;
    }
}