using AppCimmVotaciones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppCimmVotaciones.Logica;

namespace AppCimmVotaciones.Vista.Auth
{
    public partial class Login : System.Web.UI.Page
    {
        string tipoUsuario = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMensaje.Text = "Faltan datos";
                return;
            }

            UsuarioLogin oDatosUsuario = new UsuarioLogin()
            {
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            string tipoUsuario = chkTipo.Checked ? "Funcionario" : "Candidato";

            LoginL oLogin = new LoginL();
            UsuarioLogin oDatosSesion = oLogin.MtLogin(oDatosUsuario, tipoUsuario);

            if (oDatosSesion != null)
            {
                lblMensaje.Text = "Bienvenido " + oDatosSesion.NombreCompleto + " " + oDatosSesion.TipoUsuario;

                Session["Usuario"] = oDatosSesion.Email;
                Session["Nombre"] = oDatosSesion.NombreCompleto;
                Session["Rol"] = oDatosSesion.Rol;
                //Session["TipoUsuario"]=oDatosSesion.TipoUsuario;

                if (tipoUsuario == "Funcionario")
                {
                    Response.Redirect("../Funcionarios/IndexFuncionarios.aspx");
                }
                else if (tipoUsuario == "Candidato")
                {
                    Response.Redirect("../Candidatos/PerfilCandidato.aspx");
                }

            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos";
            }
        }

        protected void chkTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTipo.Checked)
            {
                chkTipo.Text = "Funcionario";
            }
            else
            {
                chkTipo.Text = "Candidato";
            }
        }
    }
}