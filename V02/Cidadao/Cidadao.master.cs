using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cidadao_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BDRegisto br = new BDRegisto();
            string currentUser = Membership.GetUser().ProviderUserKey.ToString();
            fotolog.ImageUrl = br.MostraImagem(currentUser);
        }

    }
}
