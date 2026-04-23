using AppCimmVotaciones.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Datos
{
    public class CandidatoD
    {
        public List<CandidatoVista> MtObtenerCandidatos()
        {
            List<CandidatoVista> lista = new List<CandidatoVista>();

            using (SqlConnection cn = ConexionDB.MtAbrirConexion())
            {
                cn.Open();

                string query = @"
            SELECT 
                cj.Id,
                cj.Foto,
                cj.Eslogan,
                a.Nombre,
                a.Apellido,
                f.Jornada
            FROM CandidatoJornada cj
            INNER JOIN Aprendiz a ON cj.IdCandidato = a.Id
            INNER JOIN Ficha f ON a.IdFicha = f.Id
            INNER JOIN JornadaVotacion jv ON cj.IdJornada = jv.Id
            WHERE jv.Año = YEAR(GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new CandidatoVista
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Foto = dr["Foto"].ToString(),
                            Eslogan = dr["Eslogan"].ToString(),
                            Jornada = dr["Jornada"].ToString()
                        });
                    }
                }
            }

            return lista;
        }


    }
}