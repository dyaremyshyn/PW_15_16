using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cidadao_MeusDepoimentos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BDRegisto bd = new BDRegisto();
        ListItem aux = new ListItem("Selecione");
        if (!IsPostBack)
        {

            Depoimentos.DataSource = bd.getDepoimentos(Membership.GetUser().ProviderUserKey.ToString());
            Depoimentos.DataTextField = "TITULODEPOIMENTO";
            Depoimentos.DataValueField = "COD_DEPOIMENTO";
            Depoimentos.DataBind();
            Depoimentos.Items.Insert(0, aux);

        }
        else
        {
            if (Depoimentos.SelectedIndex != 0)
            {
                Depoimento.Text = (string)bd.getDepoimento(Depoimentos.SelectedValue).Rows[0]["TEXTODEPOIMENTO"];
                if ((string)bd.getDepoimento(Depoimentos.SelectedValue).Rows[0]["SITUACAODEP"] == "APROVADO")
                {
                    Situação.Checked = true;
                }
            }
            else
            {
                Depoimento.Text = "";
                Situação.Checked = false;
            }
        }
    }
}