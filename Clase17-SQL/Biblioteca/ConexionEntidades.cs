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
                    listaEmpleados.Add(new Empleado(int.Parse(dataReader["ID_EMPLEADO"].ToString()), dataReader["NOMBRE"].ToString()
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
    }
}
