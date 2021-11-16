using System;
using System.Collections.Generic;
using System.Data.SqlClient; //Instalar paquete Nuget


namespace Biblioteca
{
    public static class ConexionEntidades
    {
        static string connectionStr;
        static SqlConnection conexion;
        static SqlCommand comando;

        static ConexionEntidades()
        {
            connectionStr = @"Data Source=.; Initial Catalog =EMPRESA_DB; Integrated Security = true";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Empleado> Leer()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM EMPLEADOS";
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    listaEmpleados.Add(new Empleado(dataReader["NOMBRE"].ToString()
                    ,dataReader["APELLIDO"].ToString(), float.Parse(dataReader["SALARIO"].ToString())));
                }
                return listaEmpleados;
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

        public static void Eliminar(int id)
        {
            try
            {
                comando.Parameters.Clear(); //HAY QUE LIMPIAR LOS PARAMETROS CUANDO TRABAJAMOS CON MIEMBROS ESTATICOS
                conexion.Open();
                comando.Parameters.AddWithValue("@id", id);
                comando.CommandText = $"DELETE FROM EMPLEADOS WHERE ID_EMPLEADO=@id";

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

        public static void Guardar(Empleado empleado)
        {
            try
            {
                comando.Parameters.Clear(); //HAY QUE LIMPIAR LOS PARAMETROS CUANDO TRABAJAMOS CON MIEMBROS ESTATICOS
                conexion.Open();
                comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@salario", empleado.Salario);

                comando.CommandText = $"INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, SALARIO) VALUES (@nombre, @apellido, @salario)";

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
