using System;
using Biblioteca;

namespace Clase_02___Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();

            Console.Write("Ingrese la fecha de su cumpleaños (dd/mm/aaaa): ");

            while (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.Write("Esa no es una fecha. Ingrese la fecha de su cumpleaños (dd/mm/aaaa): ");
            }

            Console.WriteLine("");
            Console.WriteLine($"Usted ha vivido {Calculadora.CalcularDias(fecha)} dias");
        }
    }
}