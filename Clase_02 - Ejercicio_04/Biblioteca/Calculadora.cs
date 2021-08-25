using System;

namespace Biblioteca
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza calculos entre 2 operandos
        /// </summary>
        /// <param name="primerOperando"> primer operando</param>
        /// <param name="segundoOperando">segundo operando</param>
        /// <param name="operacion">operacion (suma, resta, multiplicacion o division)</param>
        /// <returns>Resultado de la operacion</returns>
        public static float Calcular(float primerOperando, float segundoOperando, char operacion)
        {
            float resultado;

            switch (operacion)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;

                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;

                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;

                case '/':
                    resultado = primerOperando / segundoOperando;
                    break;

                default:
                    resultado = float.NaN;
                    break;
            }
            return resultado;
        }
    }
}
