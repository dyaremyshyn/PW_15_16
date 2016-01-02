﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Agente_ConsultarHorario : System.Web.UI.Page
{
    BDRegisto bd = new BDRegisto();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnPesquisaHorario_Click(object sender, EventArgs e)
    {

        gvHorario.DataSource = bd.getHorarioLaboral(txtInicio.Text, txtFim.Text, Membership.GetUser().ProviderUserKey.ToString());
        myDiv.Visible = true;

        gvHorario.DataBind();
    }
}