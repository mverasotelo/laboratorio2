using System;

//Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.


namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            float suma = 0;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero:");
                if (int.TryParse(Console.ReadLine(), out numero))
                {

                    suma += numero;

                    if(numero < minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
            }
            Console.WriteLine("El numero minimo es {0}, el numero maximo es {1} y el promedio es {2}", minimo, maximo, suma/5);
        }
    }
}
