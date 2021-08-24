using System;

//Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese numero:");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}", numero, Math.Pow(numero, 2), Math.Pow(numero, 3));
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
            else
            {
                Console.WriteLine("ERROR. ¡Eso no es un número!");
            }
        }
    }
}