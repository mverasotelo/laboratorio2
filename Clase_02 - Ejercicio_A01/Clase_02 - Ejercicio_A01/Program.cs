using System;
using Biblioteca;

namespace Clase_02___Ejercicio_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            long resultado;

            Console.Write("Ingrese operando: ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Eso no es un numero. Ingrese operando: ");
            }

            resultado = Calculadora.CalcularFactorial(numero);

            if (resultado == 0)
            {
                Console.WriteLine("No se puede calcular el factorial de un numero negativo");
            }
            else
            {
                Console.WriteLine($"El factorial de {numero} es {resultado}");
            }
        }
    }
}
