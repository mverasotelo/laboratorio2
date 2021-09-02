using System;

namespace Biblioteca
{
    public class Farenheit
    {
        private float grados;

        /// <summary>
        /// Constructor de la clase Farenheit
        /// </summary>
        /// <param name="grados">grados</param>
        public Farenheit(float grados)
        {
            this.grados = grados;
        }

        /// <summary>
        /// Conversion explícita de Farenheit a float
        /// </summary>
        /// <param name="f">Grados</param>
        public static explicit operator float(Farenheit f)
        {
            return f.grados;

        }

        /// <summary>
        /// Convierte Celsius a Farenheit
        /// </summary>
        /// <param name="c">Objeto Celsius a convertir</param>
        /// <returns>Temperatura en Farenheit</returns>
        public static float ConvertirAFarenheit(Celsius c)
        {
            return (float) c * (9F /5F) + 32;
        }

        /// <summary>
        /// Convierte Celsius a Kelvin
        /// </summary>
        /// <param name="k">Objeto Kelvin a convertir</param>
        /// <returns>Temperatura en Kelvin</returns>
        public static float ConvertirAFarenheit(Kelvin k)
        {
            return (float) k * (9F / 5F) - 459.67F;
        }
    }
}