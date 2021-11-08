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
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
