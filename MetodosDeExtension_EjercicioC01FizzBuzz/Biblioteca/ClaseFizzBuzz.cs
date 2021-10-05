using System;

namespace Biblioteca
{
    public static class ClaseFizzBuzz
    {

        public static string FizzBuzz(this int entero)
        {
            string retorno = entero.ToString();

            if(entero % 3 == 0 && entero % 5 == 0)
            {
                retorno = "FizzBuzz";
            }
            else if(entero % 3 == 0)
            {
                retorno = "Fizz";
            }
            else if (entero % 5 == 0)
            {
                retorno = "Buzz";
            }
            return retorno;
        }
    }
}
