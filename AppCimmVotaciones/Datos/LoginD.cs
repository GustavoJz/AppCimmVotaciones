using AppCimmVotaciones.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppCimmVotaciones.Datos
{
    public class LoginD
    {

        public UsuarioLogin MtLogin(UsuarioLogin oDatos, string tipoUsuario)
        {
            UsuarioLogin oUsuario = null;

            using (SqlConnection cn = ConexionDB.MtAbrirConexion())
            {
                cn.Open();
                string consulta = "";
                if (tipoUsuario == "Funcionario")
                {
                    consulta = @"select Funcionario.*, Rol.Rol from Funcionario 
                inner join Rol on Funcionario.IdRol= Rol.Id 
                where Funcionario.Email= @Email and Funcionario.Clave=@Clave ";
                }
                else if (tipoUsuario == "Candidato")
                {
                    consulta = @"select a.* from Aprendiz a
                inner join CandidatoJornada cj on a.Id= cj.IdCandidato 
                where a.EmailInstitucional= @Email and cj.Clave=@Clave ";
                }


                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Email", oDatos.Email);
                    cmd.Parameters.AddWithValue("@Clave", oDatos.Password);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            oUsuario = new UsuarioLogin()
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                NombreCompleto = dr["Nombre"].ToString() + " " + dr["Apellido"].ToString(),
                                Email = tipoUsuario == "Funcionario" ? dr["Email"].ToString() : dr["EmailInstitucional"].ToString(),
                                Rol = tipoUsuario == "Funcionario" ? dr["Rol"].ToString() : "Candidato",
                                TipoUsuario = tipoUsuario
                            };
                        }

                    }
                }
            }
            return oUsuario;
        }
    }
}