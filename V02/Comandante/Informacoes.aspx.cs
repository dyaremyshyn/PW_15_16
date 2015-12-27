using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Informacoes : System.Web.UI.Page
{
    static string noticia;
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        ListItem it = new ListItem("Selecione");
        if (!IsPostBack)
        {
            titulo.DataSource = bd.getInfos();
            titulo.DataTextField = "TITULONOTICIA";
            titulo.DataValueField = "COD_NOTICIA";
            titulo.DataBind();
            titulo.Items.Insert(0, it);
            noticia=titulo.SelectedValue;
        }
        else
        {
            if(titulo.SelectedValue!=noticia && titulo.SelectedIndex!=0){
                Image1.ImageUrl = bd.getFotoNocia(titulo.SelectedValue);
                Texto.Text = (string)bd.getTextNocia(titulo.SelectedValue).Rows[0]["NOTICIA"];
                Data.Text = ((DateTime)bd.getTextNocia(titulo.SelectedValue).Rows[0]["DATANOTICIA"]).ToString("dd/MM/yyyy");

                Hora.Text = ((DateTime)bd.getTextNocia(titulo.SelectedValue).Rows[0]["HORA"]).ToString("hh:mm");
                Txtol.Visible = true;
                Texto.Visible = true;
                Horal.Visible = true;
                DataL.Visible = true;
                Data.Visible = true;
                Hora.Visible = true;
                noticia = titulo.SelectedValue;
                Editar.Visible = true;
                Eliminar.Visible = true;
            }
            if (titulo.SelectedIndex == 0)
            {
                Txtol.Visible = false;
                Data.Text = "";
                Hora.Text = "";
                Editar.Visible = false;
                Texto.Visible = false;
                Horal.Visible = false;
                DataL.Visible = false;
                Data.Visible = false;
                Hora.Visible = false;
                Eliminar.Visible = false;
                noticia = titulo.SelectedValue;
                Image1.ImageUrl = "";
            }
            

        }
    }
    protected void Submeter_Click(object sender, EventArgs e)
    {
        string currentUser = Membership.GetUser().ProviderUserKey.ToString();
        BDRegisto bd = new BDRegisto();
         Stream fs =  FileUpload1.PostedFile.InputStream;
         Byte[] bytes = bd.carregaImagem(fs);
         ListItem it = new ListItem("Selecione");
         bd.inserNoticia(TituloTextBox.Text, Texto.Text, bytes, currentUser);
         TituloTextBox.Text = "";
         TituloTextBox.Visible = false;
         titulo.Visible = true;
         titulo.DataSource = bd.getInfos();
         titulo.DataTextField = "TITULONOTICIA";
         titulo.DataValueField = "COD_NOTICIA";
         titulo.DataBind();
         titulo.Items.Insert(0, it);
         update.Visible = false;
         canceleupdate.Visible = false;
         Txtol.Visible = false;
         Data.Text = "";
         Hora.Text = "";
         Editar.Visible = false;
         Texto.Visible = false;
         Horal.Visible = false;
         DataL.Visible = false;
         Data.Visible = false;
         Hora.Visible = false;
         Eliminar.Visible = false;
         noticia = titulo.SelectedValue;
         Image1.ImageUrl = "";
         Data.ReadOnly = true;
         Hora.ReadOnly = true;
         Texto.ReadOnly = true;

    }
    protected void Anular_Click(object sender, EventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        TituloTextBox.Text = "";
        TituloTextBox.Visible = false;
        titulo.Visible = true;
        titulo.DataSource = bd.getInfos();
        titulo.DataTextField = "TITULONOTICIA";
        titulo.DataValueField = "COD_NOTICIA";
        titulo.DataBind();
        titulo.Items.Insert(0, it);
        update.Visible = false;
        canceleupdate.Visible = false;
        Txtol.Visible = false;
        Data.Text = "";
        Hora.Text = "";
        Editar.Visible = false;
        Texto.Visible = false;
        Horal.Visible = false;
        DataL.Visible = false;
        Data.Visible = false;
        Hora.Visible = false;
        Eliminar.Visible = false;
        noticia = titulo.SelectedValue;
        Image1.ImageUrl = "";
        Data.ReadOnly = true;
        Hora.ReadOnly = true;
        Texto.ReadOnly = true;
    }
    protected void NovaInformação_Click(object sender, EventArgs e)
    {
        
        Submeter.Visible = true;
        Anular.Visible = true;
        titulo.Visible = false;
        TituloTextBox.Visible = true;
        Texto.Text = "";
        Texto.Visible = true;
        Texto.ReadOnly = false;
        Data.Visible = false;
        Hora.Visible=false;
        FileUpload1.Visible = true;
        NovaInformação.Visible = false;
        Eliminar.Visible = false;
    }
    protected void Editar_Click(object sender, EventArgs e)
    {
        Texto.ReadOnly = false;
        titulo.Visible = false;
        TituloTextBox.Visible = true;
        TituloTextBox.Text = titulo.SelectedItem.Text;
        TituloTextBox.ReadOnly = false;
        Data.ReadOnly = false;
        Hora.ReadOnly = false;
        NovaInformação.Visible = false;
        update.Visible = true;
        Editar.Visible = false;
        Eliminar.Visible = false;
        canceleupdate.Visible = true;

    }
    protected void Eliminar_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        ListItem it = new ListItem("Selecione");
        bd.DeleteNocia(titulo.SelectedValue);
        TituloTextBox.Text = "";
        TituloTextBox.Visible = false;
        titulo.Visible = true;
        titulo.DataSource = bd.getInfos();
        titulo.DataTextField = "TITULONOTICIA";
        titulo.DataValueField = "COD_NOTICIA";
        titulo.DataBind();
        titulo.Items.Insert(0, it);
        update.Visible = false;
        canceleupdate.Visible = false;
        Txtol.Visible = false;
        Data.Text = "";
        Hora.Text = "";
        Editar.Visible = false;
        Texto.Visible = false;
        Horal.Visible = false;
        DataL.Visible = false;
        Data.Visible = false;
        Hora.Visible = false;
        Eliminar.Visible = false;
        noticia = titulo.SelectedValue;
        Image1.ImageUrl = "";
        Data.ReadOnly = true;
        Hora.ReadOnly = true;
        Texto.ReadOnly = true;
    }
    protected void update_Click(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        ListItem it = new ListItem("Selecione");
        bd.upateNoticia(titulo.SelectedValue, Membership.GetUser().ProviderUserKey.ToString(), titulo.Text, Texto.Text);
        TituloTextBox.Text = "";
        TituloTextBox.Visible = false;
        titulo.Visible = true;
        titulo.DataSource = bd.getInfos();
        titulo.DataTextField = "TITULONOTICIA";
        titulo.DataValueField = "COD_NOTICIA";
        titulo.DataBind();
        titulo.Items.Insert(0, it);
        update.Visible = false;
        canceleupdate.Visible = false;
        Txtol.Visible = false;
        Data.Text = "";
        Hora.Text = "";
        Editar.Visible = false;
        Texto.Visible = false;
        Horal.Visible = false;
        DataL.Visible = false;
        Data.Visible = false;
        Hora.Visible = false;
        Eliminar.Visible = false;
        noticia = titulo.SelectedValue;
        Image1.ImageUrl = "";
        Data.ReadOnly = true;
        Hora.ReadOnly = true;
        Texto.ReadOnly = true;


    }
    protected void canceleupdate_Click(object sender, EventArgs e)
    {
        ListItem it = new ListItem("Selecione");
        BDRegisto bd = new BDRegisto();
        TituloTextBox.Text = "";
        TituloTextBox.Visible = false;
        titulo.Visible = true;
        titulo.DataSource = bd.getInfos();
        titulo.DataTextField = "TITULONOTICIA";
        titulo.DataValueField = "COD_NOTICIA";
        titulo.DataBind();
        titulo.Items.Insert(0, it);
        update.Visible = false;
        canceleupdate.Visible = false;
        Txtol.Visible = false;
        Data.Text = "";
        Hora.Text = "";
        Editar.Visible = false;
        Texto.Visible = false;
        Horal.Visible = false;
        DataL.Visible = false;
        Data.Visible = false;
        Hora.Visible = false;
        Eliminar.Visible = false;
        noticia = titulo.SelectedValue;
        Image1.ImageUrl = "";
        Data.ReadOnly = true;
        Hora.ReadOnly = true;
        Texto.ReadOnly = true;
    }
}