using System;
using Biblioteca;

/*
 Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/

namespace Clase_02___Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;

            Console.WriteLine("{0,20}\n", "CALCULADORA");

            do
            {
                Console.Write("Ingrese el primer operando: ");
                string primerNumeroIngresado = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Ingrese el segundo operando: ");
                string segundoNumeroIngresado = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Ingrese la operacion ( +, -, * o / ): ");
                char operacion = char.Parse(Console.ReadLine());
                Console.WriteLine("");

                while (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/')
                {
                    Console.Write("Operacion incorrecta. Ingrese +, -, * o / : ");
                    operacion = char.Parse(Console.ReadLine());
                }

                if (float.TryParse(primerNumeroIngresado, out float num1) && float.TryParse(segundoNumeroIngresado, out float num2))
                {
                    if( operacion == '/' && !Calculadora.Validar(num2) )
                    {
                        Console.WriteLine("-- No se puede dividir por 0 --\n");
                    }
                    else
                    {
                        Console.WriteLine($"-- El resultado de {num1}{operacion}{num2} es {Calculadora.Calcular(num1, num2, operacion)} --\n");
                    }
                }

                Console.Write("Desea continuar (S/N)? ");
                continuar = char.ToUpper(char.Parse(Console.ReadLine()));
                Console.WriteLine("");

            } while (continuar == 'S');
        }
    }
}
