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
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        resultado = float.NaN;
                    }
                    break;

                default:
                    resultado = float.NaN;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el segundo operando sea distinto de 0 (para division)
        /// </summary>
        /// <param name="segundoOperando"></param>
        /// <returns>devuelve un booleano true si es distinto de cero y false si es cero</returns>
        public static bool Validar(float segundoOperando)
        {
            return segundoOperando != 0;
        }

    }
}
