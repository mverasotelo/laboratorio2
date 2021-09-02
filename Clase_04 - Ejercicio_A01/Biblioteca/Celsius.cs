using System;

namespace Biblioteca
{
    public class Celsius
    {

        private float grados;

        /// <summary>
        /// Cosntructor de la clase Celsius
        /// </summary>
        /// <param name="grados">grados</param>
        public Celsius(float grados)
        {
            this.grados = grados;
        }

        /// <summary>
        /// Conversion explícita de Celsius a float
        /// </summary>
        /// <param name="f">Grados</param>
        public static explicit operator float(Celsius c)
        {
            return c.grados;
        }

        /// <summary>
        /// Convierte Farenheit a Celsius
        /// </summary>
        /// <param name="f">Objeto Farenheit a convertir</param>
        /// <returns>Temperatura en Farenheit</returns>
        public static float ConvertirACelsius(Farenheit f)
        {
            return ((float)f - 32) * (5F / 9F);
        }

        /// <summary>
        /// Convierte Farenheit a Kelvin
        /// </summary>
        /// <param name="f">Objeto Kelvin a convertir</param>
        /// <returns>Temperatura en Kelvin</returns>
        public static float ConvertirACelsius(Kelvin k)
        {
            return (float)k - 273.15F;
        }

    }
}
