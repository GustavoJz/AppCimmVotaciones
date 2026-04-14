using AppCimmVotaciones.Datos;
using AppCimmVotaciones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Logica
{
    public class LoginL
    {

        public UsuarioLogin MtLogin(UsuarioLogin oDatos, string tipoUsuario)
        {
            LoginD oLoginD = new LoginD();
            UsuarioLogin oDatosSesion = oLoginD.MtLogin(oDatos, tipoUsuario);
            return oDatosSesion;
        }
    }
}