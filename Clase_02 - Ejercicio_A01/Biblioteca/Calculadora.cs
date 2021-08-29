using System;

namespace Biblioteca
{
    public class Calculadora
    {

        /// <summary>
        /// Calcula el factorial de un numero entero positivo
        /// </summary>
        /// <param name="operando"></param>
        /// <returns>Devuelve factorial si el operando es positivo y 0 si el operando es negativo</returns>
        public static long CalcularFactorial(int operando)
        {
            long factorial = 1;
            if (operando > 1)
            {
                factorial = operando * CalcularFactorial(operando - 1);
            }
            else if (operando < 0)
            {
                factorial = 0;
            }
            return factorial;
        }   
    }
}
