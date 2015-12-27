using System;
using System.Collections.Generic;
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
            if(titulo.SelectedValue!=noticia){
                Image1.ImageUrl = bd.getFotoNocia(titulo.SelectedValue);
                Texto.Text = (string)bd.getTextNocia(titulo.SelectedValue).Rows[0]["NOTICIA"];
                Data.Text = ((DateTime)bd.getTextNocia(titulo.SelectedValue).Rows[0]["DATANOTICIA"]).ToString("dd/MM/yyyy");

                Hora.Text = ((DateTime)bd.getTextNocia(titulo.SelectedValue).Rows[0]["HORA"]).ToString("hh:mm");

                Texto.Visible = true;
                Data.Visible = true;
                Hora.Visible = true;
                noticia = titulo.SelectedValue;
                Editar.Visible = true;
                Eliminar.Visible = true;
            }
            if (titulo.SelectedIndex == 0)
            {
                Editar.Visible = false;
                Texto.Visible = false;
                Data.Visible = false;
                Hora.Visible = false;
                Eliminar.Visible = false;
                noticia = titulo.SelectedValue;
            }
            

        }
    }
    protected void Submeter_Click(object sender, EventArgs e)
    {
        string user = System.Security.Principal.WindowsIdentity.GetCurrent().User.ToString();
    }
    protected void Anular_Click(object sender, EventArgs e)
    {
        Submeter.Visible = false;
        Anular.Visible = false;
        titulo.Visible = true;
        TituloTextBox.Visible = false;
        Texto.Text = "";
        Texto.Visible = false;
        Texto.ReadOnly = true;
        Data.Visible = true;
        Hora.Visible = true;
        FileUpload1.Visible = false;
        NovaInformação.Visible = true;
        Eliminar.Visible = false;
        titulo.SelectedIndex = 0;
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

    }
    protected void Eliminar_Click(object sender, EventArgs e)
    {

    }
}