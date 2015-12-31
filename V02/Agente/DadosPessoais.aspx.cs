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
            
            if (!IsPostBack)
            {
                DataTable dados = bd.getUser(Membership.GetUser().ProviderUserKey.ToString());
                Nome.Text = (string)dados.Rows[0]["NOME"];
                Ncidadao.Text = Convert.ToString(((decimal)dados.Rows[0]["NCIDADAO"]));
                NIF.Text = Convert.ToString(((decimal)dados.Rows[0]["NCONTRIBUINTE"]));
                Morada.Text = (string)dados.Rows[0]["MORADA"];
                Contacto.Text = (string)dados.Rows[0]["NTELEFONE"];
                Localidade.Text = (string)dados.Rows[0]["LOCALIDADE"];
                CodigoPostal.Text = (string)dados.Rows[0]["COD_POSTAL"];
                Data.Text = ((DateTime)dados.Rows[0]["DATANASCIMENTO"]).ToString("dd/MM/yyyy");
                Sexo.Text = (string)dados.Rows[0]["SEXO"];
                Foto.ImageUrl = bd.carregaFotoUser(Membership.GetUser().ProviderUserKey.ToString());
            }
        }


    
    }

    // evento ao clicar para editar
    // as caixas de texto passam de readonly="true" para "false" 


    protected void EditarDados_Click(object sender, EventArgs e)
    {
        Nome.ReadOnly = false;
        Ncidadao.ReadOnly = false;
        NIF.ReadOnly = false;
        Morada.ReadOnly = false;
        Contacto.ReadOnly = false;
        Localidade.ReadOnly = false;
        CodigoPostal.ReadOnly = false;
        Sexo.Visible = false;
        Sexorb.Visible = true;
        if (Sexo.Text.ToCharArray()[0] == 'M')
        {
            Sexorb.SelectedIndex = 0;
        }
        else
        {
            Sexorb.SelectedIndex = 1;
        }
        Atualizar.Visible = true;
        Cancelar.Visible = true;
        EditarDados.Visible = false;
        FileUpload1.Visible = true;
        Fotol.Visible = true;
    }
    protected void Atualizar_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        Stream fs = FileUpload1.PostedFile.InputStream;
        Byte[] bytes = bd.carregaImagem(fs);
        if (FileUpload1.FileBytes.Length > 0)
        {
            bd.updateUserWithFoto(Membership.GetUser().ProviderUserKey.ToString(), Nome.Text, Ncidadao.Text, NIF.Text, Morada.Text, Localidade.Text, CodigoPostal.Text, Contacto.Text, Sexorb.SelectedValue, Convert.ToDateTime(Data.Text), bytes);
        }
        else
        {
            bd.updateUserNofoto(Membership.GetUser().ProviderUserKey.ToString(), Nome.Text, Ncidadao.Text, NIF.Text, Morada.Text, Localidade.Text, CodigoPostal.Text, Contacto.Text, Sexorb.SelectedValue, Convert.ToDateTime(Data.Text));
        }


        DataTable dados = bd.getUser(Membership.GetUser().ProviderUserKey.ToString());
        Nome.Text = (string)dados.Rows[0]["NOME"];
        Ncidadao.Text = Convert.ToString(((decimal)dados.Rows[0]["NCIDADAO"]));
        NIF.Text = Convert.ToString(((decimal)dados.Rows[0]["NCONTRIBUINTE"]));
        Morada.Text = (string)dados.Rows[0]["MORADA"];
        Contacto.Text = (string)dados.Rows[0]["NTELEFONE"];
        Localidade.Text = (string)dados.Rows[0]["LOCALIDADE"];
        CodigoPostal.Text = (string)dados.Rows[0]["COD_POSTAL"];
        Data.Text = ((DateTime)dados.Rows[0]["DATANASCIMENTO"]).ToString("dd/MM/yyyy");
        Sexo.Text = (string)dados.Rows[0]["SEXO"];
        Foto.ImageUrl = bd.carregaFotoUser(Membership.GetUser().ProviderUserKey.ToString());

        Nome.ReadOnly = true;
        Ncidadao.ReadOnly = true;
        NIF.ReadOnly = true;
        Morada.ReadOnly = true;
        Contacto.ReadOnly = true;
        Localidade.ReadOnly = true;
        CodigoPostal.ReadOnly = true;
        Sexo.Visible = true;
        Sexorb.Visible = false;

        Atualizar.Visible = false;
        Cancelar.Visible = false;
        EditarDados.Visible = true;
        FileUpload1.Visible = false;
        Fotol.Visible = false;


    }
    protected void Cancelar_Click(object sender, EventArgs e)
    {
        Nome.ReadOnly = true;
        Ncidadao.ReadOnly = true;
        NIF.ReadOnly = true;
        Morada.ReadOnly = true;
        Contacto.ReadOnly = true;
        Localidade.ReadOnly = true;
        CodigoPostal.ReadOnly = true;
        Sexo.Visible = true;
        Sexorb.Visible = false;

        Atualizar.Visible = false;
        Cancelar.Visible = false;
        EditarDados.Visible = true;
        FileUpload1.Visible = false;
        Fotol.Visible = false;
    }
}