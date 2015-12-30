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

            txtIDAgente.Text = Convert.ToString(((decimal)dados.Rows[0]["NCIDADAO"]));
            txtContribuinte.Text = Convert.ToString(((decimal)dados.Rows[0]["NCONTRIBUINTE"]));
            txtMorada.Text = (string)dados.Rows[0]["MORADA"];
            txtContacto.Text = (string)dados.Rows[0]["NTELEFONE"];
            txtLocalidade.Text = (string)dados.Rows[0]["LOCALIDADE"];
            txtCodPostal.Text = (string)dados.Rows[0]["COD_POSTAL"];
            txtDataNascimento.Text = ((DateTime)dados.Rows[0]["DATANASCIMENTO"]).ToString("dd/MM/yyyy");
            txtSexo.Text = (string)dados.Rows[0]["SEXO"];
            Foto.ImageUrl = bd.carregaFotoUser(Membership.GetUser().ProviderUserKey.ToString());
        }


    
    }

    // evento ao clicar para editar
    // as caixas de texto passam de readonly="true" para "false" 


    protected void EditarDados_Click(object sender, EventArgs e)
    {
        txtNomeAgente.ReadOnly = false;
        txtIDAgente.ReadOnly = false;
        txtContribuinte.ReadOnly = false;
        txtMorada.ReadOnly = false;
        txtContacto.ReadOnly = false;
        txtLocalidade.ReadOnly = false;
        txtCodPostal.ReadOnly = false;
        txtSexo.ReadOnly = false;

        rbSexo.Visible = true;

        if (txtSexo.Text.ToCharArray()[0] == 'M')
        {
            rbSexo.SelectedIndex = 0;
        }
        else
        {
            rbSexo.SelectedIndex = 1;
        }

        Atualizar.Visible = true;
        Cancelar.Visible = true;
        EditarDados.Visible = false;
        FileUpload1.Visible = true;
        lblFoto.Visible = true;

    }
    protected void Atualizar_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        Stream fs = FileUpload1.PostedFile.InputStream;
        Byte[] bytes = bd.carregaImagem(fs);
        if (FileUpload1.FileBytes.Length > 0)
        {
            bd.updateUserWithFoto(Membership.GetUser().ProviderUserKey.ToString(), txtNomeAgente.Text, txtIDAgente.Text, txtContribuinte.Text, txtMorada.Text, txtLocalidade.Text, txtCodPostal.Text, txtContacto.Text, rbSexo.SelectedValue, Convert.ToDateTime(txtDataNascimento.Text), bytes);
        }
        else
        {
            bd.updateUserNofoto(Membership.GetUser().ProviderUserKey.ToString(), txtNomeAgente.Text, txtIDAgente.Text, txtContribuinte.Text, txtMorada.Text, txtLocalidade.Text, txtCodPostal.Text, txtContacto.Text, rbSexo.SelectedValue, Convert.ToDateTime(txtDataNascimento.Text));
        }


        DataTable dados = bd.getUser(Membership.GetUser().ProviderUserKey.ToString());
        txtNomeAgente.Text = (string)dados.Rows[0]["NOME"];
        txtIDAgente.Text = Convert.ToString(((decimal)dados.Rows[0]["NCIDADAO"]));
        txtContribuinte.Text = Convert.ToString(((decimal)dados.Rows[0]["NCONTRIBUINTE"]));
        txtMorada.Text = (string)dados.Rows[0]["MORADA"];
        txtContacto.Text = (string)dados.Rows[0]["NTELEFONE"];
        txtLocalidade.Text = (string)dados.Rows[0]["LOCALIDADE"];
        txtCodPostal.Text = (string)dados.Rows[0]["COD_POSTAL"];
        txtDataNascimento.Text = ((DateTime)dados.Rows[0]["DATANASCIMENTO"]).ToString("dd/MM/yyyy");
        txtSexo.Text = (string)dados.Rows[0]["SEXO"];
        Foto.ImageUrl = bd.carregaFotoUser(Membership.GetUser().ProviderUserKey.ToString());

        txtNomeAgente.ReadOnly = true;
        txtIDAgente.ReadOnly = true;
        txtContribuinte.ReadOnly = true;
        txtMorada.ReadOnly = true;
        txtContacto.ReadOnly = true;
        txtLocalidade.ReadOnly = true;
        txtCodPostal.ReadOnly = true;
        txtSexo.Visible = true;
        rbSexo.Visible = false;

        Atualizar.Visible = false;
        Cancelar.Visible = false;
        EditarDados.Visible = true;
        FileUpload1.Visible = false;
        lblFoto.Visible = false;
    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        txtNomeAgente.ReadOnly = true;
        txtIDAgente.ReadOnly = true;
        txtContribuinte.ReadOnly = true;
        txtMorada.ReadOnly = true;
        txtContacto.ReadOnly = true;
        txtLocalidade.ReadOnly = true;
        txtCodPostal.ReadOnly = true;
        txtSexo.Visible = true;
        rbSexo.Visible = false;

        Atualizar.Visible = false;
        Cancelar.Visible = false;
        EditarDados.Visible = true;
        FileUpload1.Visible = false;
        lblFoto.Visible = false;
    }
}