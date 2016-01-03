using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_RemoverAgente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void PesquisaAgente_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        DataTable data = new DataTable();
        if (bd.verificaSeNaoExisteAgente(txtDistintivo.Text))
        {
            Autor.Text = (string)data.Rows[0]["NOME"];
            Autor.NavigateUrl = Autor.NavigateUrl + "?" + "ID=" + ((int)data.Rows[0]["ID"]).ToString();
            Info.Text = "Encontrado";
            EliminarAgente.Visible = true;
        }
        else
        {
            Info.Text = "Nao Encontrado";

            
            Resultado.Visible = false;
            reslabel.Visible = false;
        }
    }
    
    protected void EliminarAgente_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        DataTable data = new DataTable();

        bd.elimindaAgente(txtDistintivo.Text);
        Resultado.Text = "Agente eliminado com sucesso!";
        Resultado.Visible = true;
    }
}