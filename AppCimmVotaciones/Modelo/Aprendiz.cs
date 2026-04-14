using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Modelo
{

   
    public class Aprendiz
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string EmailInstitucional { get; set; } = string.Empty;
        public string EmailPersonal { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public int IdTipodocumento { get; set; }
        public int IdEstado { get; set; }
        public int IdFicha { get; set; }

    }
}