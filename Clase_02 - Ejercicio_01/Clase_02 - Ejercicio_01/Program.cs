using System;
using Biblioteca;

namespace Clase_02___Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
            float suma = 0;
            int contNumeros = 0;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int valorMaximo = 100;
            int valorMinimo = -100;


            while(contNumeros < 10)
            {
                Console.WriteLine("Ingrese numero:");
                numeroIngresado = Console.ReadLine();

                if (int.TryParse(numeroIngresado, out numero))
                {
                    if (Biblioteca.Validador.Validar(numero, valorMinimo, valorMaximo))
                    {
                        suma += numero;

                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        if (numero > maximo)
                        {
                            maximo = numero;
                        }
                        contNumeros++;
                    }
                    else
                    {
                        Console.WriteLine("El valor debe ser entre -100 y 100. Ingrese nuevamente:");
                    }
                }
            }
            Console.WriteLine("El numero minimo es {0}, el numero maximo es {1} y el promedio es {2}", minimo, maximo, suma / contNumeros);
        }
    }
}
