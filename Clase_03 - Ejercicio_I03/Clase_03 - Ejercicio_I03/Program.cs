using System;
using Biblioteca;

namespace Clase_03___Ejercicio_I03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "El ejemplo universal";

            Estudiante[] estudiantes = new Estudiante[3];
            estudiantes[0] = new Estudiante("Vera", "1543", "Mercedes");
            estudiantes[1] = new Estudiante("Perez", "1545", "Julian");
            estudiantes[2] = new Estudiante("Garcia", "1548", "Maria");

            estudiantes[0].SetNotaPrimerParcial(8);
            estudiantes[1].SetNotaPrimerParcial(5);
            estudiantes[2].SetNotaPrimerParcial(2);
            estudiantes[0].SetNotaSegundoParcial(6);
            estudiantes[1].SetNotaSegundoParcial(6);
            estudiantes[2].SetNotaSegundoParcial(1);

            foreach( Estudiante estudiante in estudiantes)
            {
                if (estudiante != null)
                {
                    Console.WriteLine($"{estudiante.Mostrar()}");
                }
            }

            Console.ReadKey();
        }
    }
}
