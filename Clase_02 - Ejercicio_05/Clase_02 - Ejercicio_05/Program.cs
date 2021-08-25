using System;
using Biblioteca;

namespace Clase_02___Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("");
                Console.WriteLine($"Tabla de multiplicar del numero {numero}:");
                Console.WriteLine($"{CreadorDeTablas.DevolverTabla(numero)}");
            }
        }
    }
}
