using System;
using System.Collections.Generic;
using Biblioteca;


namespace Clase17_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            try
            {
                listaEmpleados = ConexionEntidades.Leer();

                foreach (Empleado empleado in listaEmpleados)
                {
                    Console.WriteLine(empleado.Mostrar());
                }
                ConexionEntidades.Eliminar(3);

                listaEmpleados = ConexionEntidades.Leer();
                foreach (Empleado empleado in listaEmpleados)
                {
                    Console.WriteLine(empleado.Mostrar());
                }
                Empleado e = new Empleado("Mercedes", "Vera", 45454F);
                ConexionEntidades.Guardar(e);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }

        }
    }
}
