using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public static class JuegoDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static JuegoDao()
        {
            cadenaConexion = @"Data Source=.; Initial Catalog =EJERCICIOS_UTN ; Integrated Security = true";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                comando.Parameters.Clear(); //HAY QUE LIMPIAR LOS PARAMETROS CUANDO TRABAJAMOS CON MIEMBROS ESTATICOS
                conexion.Open();
                comando.Parameters.AddWithValue("@id", codigoJuego);
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO=@id";

                comando.ExecuteNonQuery();
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

        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear(); //HAY QUE LIMPIAR LOS PARAMETROS CUANDO TRABAJAMOS CON MIEMBROS ESTATICOS
                conexion.Open();
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@codigoUsuario", juego.CodigoUsuario);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);

                comando.CommandText = $"INSERT INTO JUEGOS (NOMBRE, CODIGO_USUARIO, PRECIO, GENERO) VALUES (@nombre, @codigoUsuario, @precio, @genero)";

                comando.ExecuteNonQuery();
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

        public static List<Biblioteca> Leer()
        {
            List <Biblioteca> bibliotecas = new List<Biblioteca>();

            try
            {
                comando.Parameters.Clear(); //HAY QUE LIMPIAR LOS PARAMETROS CUANDO TRABAJAMOS CON MIEMBROS ESTATICOS
                conexion.Open();
                comando.CommandText = "SELECT j.CODIGO_JUEGO, j.GENERO, j.NOMBRE, u.USERNAME FROM JUEGOS j INNER JOIN USUARIOS u ON j.CODIGO_USUARIO = u.CODIGO_USUARIO;";
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    bibliotecas.Add(new Biblioteca(int.Parse(dataReader["CODIGO_JUEGO"].ToString()), dataReader["NOMBRE"].ToString(), dataReader["GENERO"].ToString(), dataReader["USERNAME"].ToString()));
                }
                return bibliotecas;
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

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juego = null;
            try
            {
                comando.Parameters.Clear(); //HAY QUE LIMPIAR LOS PARAMETROS CUANDO TRABAJAMOS CON MIEMBROS ESTATICOS
                conexion.Open();
                comando.CommandText = "SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigoJuego);
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    juego = new Juego(Convert.ToInt32(dataReader["CODIGO_JUEGO"].ToString()),
                        Convert.ToInt32(dataReader["CODIGO_USUARIO"].ToString()), dataReader["GENERO"].ToString(),
                        dataReader["NOMBRE"].ToString(), Convert.ToDouble(dataReader["PRECIO"].ToString()));
                }
                return juego;
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

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear(); //HAY QUE LIMPIAR LOS PARAMETROS CUANDO TRABAJAMOS CON MIEMBROS ESTATICOS
                conexion.Open();
                comando.Parameters.AddWithValue("@codigo", juego.CodigoJuego);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@genero", juego.Genero);

                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero WHERE CODIGO_JUEGO = @codigo";

                comando.ExecuteNonQuery();
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
