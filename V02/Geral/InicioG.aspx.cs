using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Geral_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
        string nome = Login1.UserName.ToString();
        if (Roles.IsUserInRole(nome, "Comandante"))
        {
            //Login1.DestinationPageUrl = "~/Administrador/InicioAdm.aspx";
            Response.Redirect("~/Comandante/Inicio.aspx");
        }
        else
        {
            if (Roles.IsUserInRole(nome, "Agente"))
                Response.Redirect("~/Agente/Inicio.aspx");
            else
             Response.Redirect("~/Cidadao/InicioCidadao.aspx");
          
        }
    }
}