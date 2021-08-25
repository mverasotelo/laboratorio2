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
            float num1 = 80F;
            float num2 = 4F;

            Console.WriteLine($"La suma de {num1} + {num2} es {Calculadora.Calcular(num1,num2,'+')}");
            Console.WriteLine($"La resta de {num1} - {num2} es {Calculadora.Calcular(num1, num2, '-')}");
            Console.WriteLine($"La multiplicacion de {num1} * {num2} es {Calculadora.Calcular(num1, num2, '*')}");
            Console.WriteLine($"La division de {num1} / {num2} es {Calculadora.Calcular(num1, num2, '/')}");

        }
    }
}
