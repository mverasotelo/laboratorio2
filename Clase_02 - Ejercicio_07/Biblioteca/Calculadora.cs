using System;

namespace Biblioteca
{
    public class Calculadora
    {
        /// <summary>
        /// Calcula la hipotenusa de un triangulo rectangulo, siguiendo el teorema de Pitagoras
        /// </summary>
        /// <param name="baseTriangulo">Base del triangulo en centimetros</param>
        /// <param name="alturaTriangulo">Altura del triangulo en centimetros</param>
        /// <returns>Hipotenusa en centimetros</returns>
        public static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        }
    }
}
