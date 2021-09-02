using System;

namespace Biblioteca
{
    public class Kelvin
    {
        private float grados;

        /// <summary>
        /// Cosntructor de la clase Kelvin
        /// </summary>
        /// <param name="grados">grados</param>
        public Kelvin(float grados)
        {
            this.grados = grados;
        }

        /// <summary>
        /// Conversion explícita de Kelvin a float
        /// </summary>
        /// <param name="f">Grados</param>
        public static explicit operator float(Kelvin k)
        {
            return k.grados;
        }

        /// <summary>
        /// Convierte Kelvin a Celsius
        /// </summary>
        /// <param name="f">Objeto Kelvin a convertir</param>
        /// <returns>Temperatura en Kelvin</returns>
        public static float ConvertirAKelvin(Celsius c)
        {
            return (float)c + 273.15F;
        }

        /// <summary>
        /// Convierte Kelvin a Farenheit
        /// </summary>
        /// <param name="f">Objeto Kelvin a convertir</param>
        /// <returns>Temperatura en Kelvin</returns>
        public static float ConvertirAKelvin(Farenheit f)
        {
            return ((float)f + 459.67F) * 5F / 9F;
        }
    }
}
