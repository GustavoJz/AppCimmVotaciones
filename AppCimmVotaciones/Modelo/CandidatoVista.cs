using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Modelo
{
    public class CandidatoVista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Foto { get; set; }
        public string Eslogan { get; set; }
        public string Jornada { get; set; }

    }
}