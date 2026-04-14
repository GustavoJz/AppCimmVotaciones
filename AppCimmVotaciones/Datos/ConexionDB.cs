using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace AppCimmVotaciones.Datos
{
    public static class ConexionDB
    {


        private static readonly string cadena= System.Configuration.ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;

        public static SqlConnection MtAbrirConexion()
        {
            if (string.IsNullOrEmpty(cadena)) {
                throw new Exception("La cadena de conexión no se ha configurado correctamente.");
            }

            return new SqlConnection(cadena);
        }

       

    }
}