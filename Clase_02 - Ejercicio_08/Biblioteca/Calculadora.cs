using System;

namespace Biblioteca
{
    public class Calculadora
    {
        /// <summary>
        ///  Calcula los dias pasados desde una fecha pasada por parametro hasta la fecha actual   
        /// </summary>
        /// <param name="fecha">fecha</param>
        /// <returns>cantidad de dias pasados</returns>
        public static int CalcularDias(DateTime fecha)
        {
            return (DateTime.Now - fecha).Days;
        }
    }
}
