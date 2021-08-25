using System;
using Biblioteca;

/*
 * Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}
El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}
 */

namespace Clase_02___Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEnDecimal = 35;
            int numeroEnBinario = 11101;

            Console.WriteLine($"El numero {numeroEnDecimal} en binario es: {Conversor.ConvertirDecimalABinario(numeroEnDecimal)}");
            Console.WriteLine($"El numero {numeroEnBinario} en decimal es: {Conversor.ConvertirBinarioADecimal(numeroEnBinario)}");

        }
    }
}