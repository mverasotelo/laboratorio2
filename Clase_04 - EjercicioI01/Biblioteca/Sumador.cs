using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        /// <summary>
        /// Getter de cantidad de sumas
        /// </summary>
        /// <returns>cantidad de sumas</returns>
        public int GetCantidadSumas()
        {
            return cantidadSumas;
        }

        /// <summary>
        /// Constructor de la clase Sumador asignando a cantidadSumas el valor pasado por parametro
        /// </summary>
        /// <param name="cantidadSumas">cantidad de sumas pasado por parametro</param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga del Constructor de la clase Sumador asignando a cantidadSumas el valor 0
        /// </summary>
        /// <param name="cantidadSumas">0</param>

        public Sumador() : this(0) { }

        /// <summary>
        /// Suma 2 operandos pasado por parametro e incrementa cantidadSumas en 1
        /// </summary>
        /// <param name="a">operando 1</param>
        /// <param name="b">operando 2</param>
        /// <returns>resultado de la suma</returns>
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// Concatena 2 string pasados por parametro
        /// </summary>
        /// <param name="a">string 1</param>
        /// <param name="b">string 2</param>
        /// <returns>string concatenado</returns>
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// Conversión explícita que retorna cantidadSumas.
        /// </summary>
        /// <param name="s">Sumador a convertir a int</param>
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga del operador + que suma cantidadSumas de los Sumadores pasados por parametros
        /// </summary>
        /// <param name="s1">Sumador 1</param>
        /// <param name="s2">Sumador 1</param>
        /// <returnsr>resultado</returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga del operador | que compara cantidadSumas de los Sumadores pasados por parametros
        /// </summary>
        /// <param name="s1">Sumador 1</param>
        /// <param name="s2">Sumador 1</param>
        /// <returnsr>booleano</returns>
        public static bool  operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

    }


}
