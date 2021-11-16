using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public static class UsuarioDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static UsuarioDao()
        {
            cadenaConexion = @"Data Source=.; Initial Catalog =EJERCICIOS_UTN ; Integrated Security = true"; ;
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM USUARIOS";
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    usuarios.Add(new Usuario(int.Parse(dataReader["CODIGO_USUARIO"].ToString()), dataReader["USERNAME"].ToString()));
                }
                return usuarios;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
