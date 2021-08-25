using System;
using Biblioteca;

namespace Clase_02___Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese longitud del lado en cm.: ");
            if (int.TryParse(Console.ReadLine(), out int longitudLado))
            {
                Console.WriteLine($"\nEl area del cuadrado es {CalculadoraDeArea.CalcularAreaCuadrado(longitudLado)} cm2.");
            }
            else
            {
                Console.WriteLine("Eso no es un número");
            }
        }
    }
}
