using System;
using Biblioteca;

namespace Clase13_Cartuchera
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();
            CartucheraSimple cartucheraSimple = new CartucheraSimple();


            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = ((IAcciones)miLapiz).Color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            Console.WriteLine();


            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            Console.WriteLine();


            cartucheraMultiuso.acciones.Add((IAcciones)miLapiz);

            while (cartucheraMultiuso.RecorrerElementos())
            {
                Console.WriteLine(cartucheraMultiuso.RecorrerElementos());
            }



           Console.ReadKey();
        }
    }
}
