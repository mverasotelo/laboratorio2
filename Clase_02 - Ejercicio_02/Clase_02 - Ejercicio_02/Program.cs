using System;
using Biblioteca;

/*
 * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */


namespace Clase_02___Ejercicio_02
{
    class Program
    {

        static void Main(string[] args)
        {
            string continuar;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                if(int.TryParse(Console.ReadLine(), out int number))
                {
                    suma += number;
                }

                Console.WriteLine("Desea continuar?(S/N)");
                continuar = Console.ReadLine();

            } while (Validador.ValidarRespuesta(continuar));

            Console.WriteLine("");
            Console.WriteLine($"La suma de los numeros ingresados es {suma}");
        }
    }
}
