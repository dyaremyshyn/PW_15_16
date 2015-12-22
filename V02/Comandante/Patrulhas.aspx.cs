using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Patrulhas : System.Web.UI.Page
{
    static DateTime time;
    protected void Page_Load(object sender, EventArgs e)
    {
        int count=0;
        ListItem aux;
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            
            Calendar1.SelectedDate = DateTime.Today;
            HoraDD.DataSource = bd.getHorasEntrada();
            HoraDD.DataTextField = "HORA";
            HoraDD.DataValueField = "Id";
            HoraDD.DataTextFormatString = "{0:HH:mm}";
            HoraDD.DataBind();
            time = Calendar1.SelectedDate;
        }

        if (time != Calendar1.SelectedDate)
        {
            count = 0;
            AgentesRB.Items.Clear();
            time = Calendar1.SelectedDate;
            ViaturasRB.Items.Clear();
        }
        
        DateTime hora = DateTime.ParseExact(HoraDD.SelectedItem.Text + ":00", "HH:mm:ss", null);
        hora = new DateTime(Calendar1.SelectedDate.Year, Calendar1.SelectedDate.Month, Calendar1.SelectedDate.Day, hora.Hour, hora.Minute, 0);

        foreach (ListItem li in AgentesRB.Items)
        {
            if (li.Selected)
            {
                count++;
            }
        }

       
        if (count ==0 )
        {

            AgentesRB.DataSource = bd.getAgentesDisponiveis(Calendar1.SelectedDate, hora);
            AgentesRB.DataTextField = "NOME";
            AgentesRB.DataValueField = "DISTINTIVO";
            AgentesRB.DataBind();
        }
        else
        {
            foreach (ListItem li in AgentesRB.Items)
            {
                if (li.Selected)
                {
                    aux = new ListItem(li.Text, li.Value);
                    aux.Selected = false;
                    Responsavel.Items.Add(aux);
                }
            }
        }
        if (ViaturasRB.Items.Count < 1)
        {
            ViaturasRB.DataSource = bd.getViaturaLivre();
            ViaturasRB.DataTextField = "MATRICULO";
            ViaturasRB.DataValueField = "COD_VEICULO";
            ViaturasRB.DataBind();
            
        }
       
        

        
        
    }
    protected void AgendarPatrulha_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        PatrulhasAgendadas.Visible = false;
        AgendarPatrulha.Visible = false;
        DataPatrulhaLabel.Visible = true;
        Calendar1.Visible = true;
        LabelHoraPatrulha.Visible = true;
        HoraDD.Visible = true;
        AgentesLabel.Visible = true;
        AgentesRB.Visible = true;
        ViaturasRB.Visible = true;
        LabelViaturas.Visible = true;
        Cancelar.Visible = true;
        Submit.Visible = true;
        Label3.Visible = true;
        Label4.Visible =true;
        Descricao.Visible = true;
        Local.Visible = true;
        Responsavel.Visible = true;
        Label5.Visible = true;

    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        PatrulhasAgendadas.Visible = true;
        AgendarPatrulha.Visible = true;
        DataPatrulhaLabel.Visible = false;
        Calendar1.Visible = false;
        LabelHoraPatrulha.Visible = false;
        HoraDD.Visible = false;
        AgentesLabel.Visible = false;
        AgentesRB.Visible = false;
        ViaturasRB.Visible = false;
        LabelViaturas.Visible = false;
        Cancelar.Visible = false;
        Submit.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Descricao.Visible = false;
        Local.Visible = false;
        Responsavel.Visible = false;
        Label5.Visible = false;
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        DateTime hora = DateTime.ParseExact(HoraDD.SelectedItem.Text + ":00", "HH:mm:ss", null);
        hora = new DateTime(Calendar1.SelectedDate.Year, Calendar1.SelectedDate.Month, Calendar1.SelectedDate.Day, hora.Hour, hora.Minute, 0);
       string responsavel = Responsavel.SelectedValue;
        int id = bd.insertPatrulha(responsavel, Descricao.Text, Calendar1.SelectedDate, hora, Local.Text);


        foreach (ListItem li in AgentesRB.Items)
        {
            if (li.Selected)
            {
                bd.inserAgenteOperacao(li.Value, id);
            }
        }

        foreach (ListItem Via in ViaturasRB.Items)
        {
            if(Via.Selected){
                bd.inserViaturaOperacao(Via.Value, id);
            }
        }

        ViaturasRB.Items.Clear();
        AgentesRB.Items.Clear();
        Responsavel.Items.Clear();

        Label1.Visible = true;
        PatrulhasAgendadas.Visible = true;
        AgendarPatrulha.Visible = true;
        DataPatrulhaLabel.Visible = false;
        Calendar1.Visible = false;
        LabelHoraPatrulha.Visible = false;
        HoraDD.Visible = false;
        AgentesLabel.Visible = false;
        AgentesRB.Visible = false;
        ViaturasRB.Visible = false;
        LabelViaturas.Visible = false;
        Cancelar.Visible = false;
        Submit.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Descricao.Visible = false;
        Local.Visible = false;
        Responsavel.Visible = false;
        Label5.Visible = false;
    }
}