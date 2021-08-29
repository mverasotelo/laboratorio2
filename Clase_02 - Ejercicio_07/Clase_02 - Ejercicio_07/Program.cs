using System;
using Biblioteca;

namespace Clase_02___Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            float baseTriangulo;
            float alturaTriangulo;

            Console.Write("Ingrese la base del triangulo en cm.: ");

            while (!float.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.Write("Eso no es un numero. Ingrese la base del triangulo en cm.: ");
            }

            Console.Write("Ingrese la altura del triangulo en cm.: ");

            while (!float.TryParse(Console.ReadLine(), out alturaTriangulo))
            {
                Console.Write("Eso no es un numero. Ingrese la altura del triangulo en cm.: ");
            }

            Console.WriteLine("La hipotenusa del triangulo ingresado es: {0:N2} cm",Calculadora.CalcularHipotenusa(baseTriangulo, alturaTriangulo));
        }
    }
}
