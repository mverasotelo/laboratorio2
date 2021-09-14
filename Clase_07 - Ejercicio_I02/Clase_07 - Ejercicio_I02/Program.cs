using System;
using Biblioteca;

namespace Clase_07___Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[28] = "Hola";
            libro[18] = "Buenos dias";
            libro[3] = "Chau";

            Console.WriteLine(libro[2]);

            libro[2] = "Chau pisado";
            libro[95] = "Hasta mañana";

            Console.WriteLine(libro[2]);

            Console.WriteLine("___________");
            foreach (string s in libro.Paginas)
            {
                Console.WriteLine($"{s}");
            }
        }
    }
}
