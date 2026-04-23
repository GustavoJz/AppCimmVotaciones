using AppCimmVotaciones.Datos;
using AppCimmVotaciones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Logica
{
    public class CandidatoL
    {
        private CandidatoD candidatoD = new CandidatoD();

        public Dictionary<string, List<CandidatoVista>> MtObtenerCandidatosJornada()
        {
            var lista = candidatoD.MtObtenerCandidatos();

            var CandidatosAgrupado = lista
                .GroupBy(c => c.Jornada)
                .ToDictionary(g => g.Key, g => g.ToList());

            return CandidatosAgrupado;
        }
    }
}