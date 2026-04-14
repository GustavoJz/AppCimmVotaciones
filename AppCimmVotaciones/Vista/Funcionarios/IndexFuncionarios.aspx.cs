using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppCimmVotaciones.Vista.Funcionarios
{
    public partial class IndexFuncionarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session["Error"] = "Debe iniciar sesión para acceder a esta página.";
                Response.Redirect("~/Vista/Error.aspx");
            }
        }
    }
}