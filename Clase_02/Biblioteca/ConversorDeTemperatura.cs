using System;

namespace Biblioteca
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F
;       
        /// <summary>
        /// Convierte grados celsius a Kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">tempertura en grados Celsius</param>
        /// <returns>temperatura convertida</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;
            return temperaturaKelvin;
        }
    }
}
