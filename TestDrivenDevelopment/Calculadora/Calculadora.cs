using System;
using Excepciones;

namespace Calculadora
{
    public class Calculadora
    {
        public static int Add(string numeros)
        {
            int retorno = 0;
            if (!(numeros == string.Empty))
            {
                char[] delimitadores = new char[] { ',', '\n' };

                if (numeros.Length > 4 && numeros[0] == '/' && numeros[1] == '/' && numeros[3] == '\n')
                {
                    delimitadores = new char[] { numeros[2] };
                }

                foreach (string c in numeros.Split(delimitadores))
                {
                    if (int.TryParse(c, out int aux))
                    {
                        retorno += int.Parse(aux.ToString());
                    }
                }
            }
            return retorno;
        }
    }
}
