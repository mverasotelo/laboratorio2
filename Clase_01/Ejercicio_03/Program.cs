using System;

/*
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
*/

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroIngresado;
            bool continuar = false;

            do
            {
                Console.Write("Ingrese un numero: ");
                numeroIngresado = Console.ReadLine();
                Console.Write("\n");

                if (int.TryParse(numeroIngresado, out numero)) //Validar que el dato ingresado por el usuario sea un número.
                {
                    continuar = false;
                    Console.WriteLine("Numeros primos hasta el {0}:", numero); // * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
                    for (int i = 1; i < numero; i++)
                    {
                        bool esPrimo = true;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }
                        if (esPrimo)
                        {
                            Console.Write("{0} ", i);
                        }
                    }

                    //Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.             
                    Console.WriteLine("\n");
                    Console.WriteLine("Desea continuar (s/n)?"); 
                    if (Console.ReadLine().ToLower() == "s") 
                    {
                        continuar = true;
                        Console.WriteLine("");
                    }

                }
            } while ((numeroIngresado != "salir" && !int.TryParse(numeroIngresado, out numero)) || (continuar == true)); //Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

        }
    }
}