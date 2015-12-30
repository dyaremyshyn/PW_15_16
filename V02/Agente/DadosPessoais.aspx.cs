using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agente_DadosPessoais : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            DataTable dados = bd.getUser(Membership.GetUser().ProviderUserKey.ToString());
            txtNomeAgente.Text = (string)dados.Rows[0]["NOME"];

            Ncidadao.Text = Convert.ToString(((decimal)dados.Rows[0]["NCIDADAO"]));
            txtContribuinte.Text = Convert.ToString(((decimal)dados.Rows[0]["NCONTRIBUINTE"]));
            txtMorada.Text = (string)dados.Rows[0]["MORADA"];
            txtContacto.Text = (string)dados.Rows[0]["NTELEFONE"];
            txtLocalidade.Text = (string)dados.Rows[0]["LOCALIDADE"];
            txtCodPostal.Text = (string)dados.Rows[0]["COD_POSTAL"];
            Data.Text = ((DateTime)dados.Rows[0]["DATANASCIMENTO"]).ToString("dd/MM/yyyy");
            Sexo.Text = (string)dados.Rows[0]["SEXO"];
            Foto.ImageUrl = bd.carregaFotoUser(Membership.GetUser().ProviderUserKey.ToString());
        }
    
    }

    // evento ao clicar para editar
    // as caixas de texto passam de readonly="true" para "false" 


    protected void EditarDados_Click(object sender, EventArgs e)
    {

    }
    protected void Atualizar_Click(object sender, EventArgs e)
    {

    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {

    }
}