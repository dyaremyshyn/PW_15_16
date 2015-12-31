using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comandante_Queixas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        if (!IsPostBack)
        {
            
            Queixas.Text = bd.getNQueixasNaoVistas().ToString();
        }

    }
    protected void QueixasNaoVistas_Click(object sender, EventArgs e)
    {
        Response.Redirect("QueixasNaoVistas.aspx");
    }
    protected void QueixasVistas_Click(object sender, EventArgs e)
    {
        Response.Redirect("QueixasVistas.aspx");
    }
}