using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_AdicionarAgente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void PesquisaCidadao_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();

        if (bd.procuraAgentePorNCidadao(Cidadao.Text))
        {
            if (bd.verificaSeNaoExisteAgente(Cidadao.Text))
            {

                Info.Text = "Encontrado";
                LabelNome.Visible = true;
                Nome.Visible = true;
                LabelContr.Visible = true;
                Contribuinte.Visible = true;
                LabelIda.Visible = true;
                Idade1.Visible = true;
                LabelDn.Visible = true;
                DataNascimento.Visible = true;
                DadosAgentes.Visible = true;
                NumeroSerieA.Visible = true;
                NumeroSerie.Visible = true;
                Funcao2.Visible = true;
                funcao.Visible = true;
                ArmaLab.Visible = true;
                NSerie.Visible = true;
                Nseriel.Visible = true;
                Fabricantel.Visible = true;
                Fabrincante.Visible = true;
                Modelo.Visible = true;
                Modelol.Visible = true;
                DropDownList1.Visible = true;
                balal.Visible = true;
                InserirAgente.Visible = true;
                DataTable agente = bd.retornaPessoa(Cidadao.Text);
                Nome.Text = (String)agente.Rows[0]["NOME"];
                Contribuinte.Text = Convert.ToString(agente.Rows[0]["NCONTRIBUINTE"]);
                DateTime dt = (DateTime)agente.Rows[0]["DATANASCIMENTO"];
                DateTime today = DateTime.Today;
                DataNascimento.Text = String.Format("{0:MM/dd/yyyy}", dt);
                int idade = today.Year - dt.Year;
                Idade1.Text = Convert.ToString(idade);
                id.Text = Convert.ToString(agente.Rows[0]["ID"]);
            }
            else
            {
                Info.Text = "Agente Já Foi Registado";

                LabelNome.Visible = false;
                Nome.Visible = false;
                LabelContr.Visible = false;
                Contribuinte.Visible = false;
                LabelIda.Visible = false;
                Idade1.Visible = false;
                LabelDn.Visible = false;
                DataNascimento.Visible = false;
                NumeroSerieA.Visible = false;
                NumeroSerie.Visible = false;
                Funcao2.Visible = false;
                funcao.Visible = false;
                DadosAgentes.Visible = false;
                NumeroSerieA.Visible = false;
                NumeroSerie.Visible = false;
                Funcao2.Visible = false;
                funcao.Visible = false;
                ArmaLab.Visible = false;
                NSerie.Visible = false;
                Nseriel.Visible = false;
                Fabricantel.Visible = false;
                Fabrincante.Visible = false;
                Modelo.Visible = false;
                Modelol.Visible = false;
                DropDownList1.Visible = false;
                balal.Visible = false;
                InserirAgente.Visible = false;
                Resultado.Visible = false;
                reslabel.Visible = false;
            }
        }

        else
        {
            Info.Text = "Nao Encontrado";
           
            LabelNome.Visible = false;
            Nome.Visible = false;
            LabelContr.Visible = false;
            Contribuinte.Visible = false;
            LabelIda.Visible = false;
            Idade1.Visible = false;
            LabelDn.Visible = false;
            DataNascimento.Visible = false;
            NumeroSerieA.Visible = false;
            NumeroSerie.Visible = false;
            Funcao2.Visible = false;
            funcao.Visible = false;
            DadosAgentes.Visible = false;
            NumeroSerieA.Visible = false;
            NumeroSerie.Visible = false;
            Funcao2.Visible = false;
            funcao.Visible = false;
            ArmaLab.Visible = false;
            NSerie.Visible = false;
            Nseriel.Visible = false;
            Fabricantel.Visible = false;
            Fabrincante.Visible = false;
            Modelo.Visible = false;
            Modelol.Visible = false;
            DropDownList1.Visible = false;
            balal.Visible = false;
            InserirAgente.Visible = false;
            Resultado.Visible = false;
            reslabel.Visible = false;
        }
    }
    protected void InserirAgente_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        if (bd.verificaSeNaoExisteDestintivo(NumeroSerie.Text))
        {
            bd.InserAgente(id.Text, NumeroSerie.Text, funcao.Text);
            if (bd.verificaSeNãoExisiteArma(NSerie.Text))
            {
                bd.InserArma(NumeroSerie.Text, Modelo.Text, NSerie.Text, Fabrincante.Text, DropDownList1.SelectedValue);
                bd.MudaRoleParaAgente(Cidadao.Text);
                Resultado.Text = "Agente Registado Com Sucesso";
                Resultado.Visible = true;
                reslabel.Visible = true;
            }
            else
            {
                Resultado.Text = "Arma Já Existente";
                Resultado.Visible = true;
                reslabel.Visible = true;
            }

        }
        else
        {
            Resultado.Text = "Numero de Serie Já Existente";
            Resultado.Visible = true;
            reslabel.Visible = true;
        }
    }
}