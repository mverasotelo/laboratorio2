using System;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// valida que un numero este adentro de un rango
        /// </summary>
        /// <param name="valor"> valor a validar</param>
        /// <param name="min">minimo del rango</param>
        /// <param name="max">maximo del rango</param>
        /// <returns>devuelve un valor booleano</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;

            if (valor >= min && valor <= max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}