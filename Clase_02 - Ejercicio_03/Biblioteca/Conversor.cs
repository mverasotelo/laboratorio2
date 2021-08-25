using System;


namespace Biblioteca
{
    public class Conversor
    {

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
