using System;
using Biblioteca;

namespace Clase_04___EjercicioI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(5);

            Console.WriteLine($"Cantidad de sumas sumador (constructor inicializado en 0): {sumador.GetCantidadSumas()}\n");
            Console.WriteLine($"Cantidad de sumas sumador2 (constructor inicializado segun valor recibido por parametro): {sumador2.GetCantidadSumas()}\n");

            string concatenacion = sumador.Sumar("Hola", " mundo!");
            long suma = sumador2.Sumar(10, 5);

            Console.WriteLine($"Resultado de la operacion del sumador: {concatenacion}\n");
            Console.WriteLine($"Resultado de la operacion del sumador2: {suma}\n");

            Console.WriteLine($"Nueva cantidad de sumas sumador: {sumador.GetCantidadSumas()}\n");
            Console.WriteLine($"Nueva cantidad de sumas sumador2: {sumador2.GetCantidadSumas()}\n");

            int cantidadSumasSumador2 = (int) sumador2;
            Console.WriteLine($"sumador2 casteado a int: {cantidadSumasSumador2}\n");

            Console.WriteLine($"Resultado de sumar sumador y sumador2: {sumador+sumador2}\n");
            Console.WriteLine($"Resultado de comparar sumador y sumador2: {sumador | sumador2}\n");

        }
    }
}
