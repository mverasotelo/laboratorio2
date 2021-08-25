using System;


namespace Biblioteca
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un numero entero decimal al sistema binario
        /// </summary>
        /// <param name="numero">numero entero decimal a convertir</param>
        /// <returns>devuelve el numero en binario</returns>
        public static string ConvertirDecimalABinario(int numero)
        {
            long digito;
            long binario = 0;

            for (int i = numero % 2, j = 0; numero > 0; numero /= 2, i = numero % 2, j++)
            {
                digito = i % 2;
                binario += digito * (long)Math.Pow(10, j);
            }

            return binario.ToString();
        }

        /// <summary>
        /// Convierte un numero entero binario al sistema decimal
        /// </summary>
        /// <param name="binario">numero entero binario a convertir</param>
        /// <returns>devuelve el numero en decimal</returns>
        public static int ConvertirBinarioADecimal(int binario) 
        {
            int numero = 0;
            int digito;

            for (long i = binario, j = 0; i > 0; i /= 10, j++)
            {
                digito = (int)i % 10;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }

            return numero;
        }
    }
}
