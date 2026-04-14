using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Modelo
{
    public class UsuarioLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Rol { get; set; }
        public string TipoUsuario { get; set; }

    }
}