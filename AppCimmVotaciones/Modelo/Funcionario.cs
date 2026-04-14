using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Modelo
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public Rol Rol { get; set; }
    }
}