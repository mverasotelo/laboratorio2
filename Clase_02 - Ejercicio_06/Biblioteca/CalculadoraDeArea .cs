using System;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        /// <summary>
        /// Calcula el area de un cuadrado
        /// </summary>
        /// <param name="longitudLado">longitud lado en cm</param>
        /// <returns>Devuelve al area en cm2</returns>
        public static double CalcularAreaCuadrado(double longitudLado) {
            return Math.Pow(longitudLado,2);
        }

        /// <summary>
        /// Calcula el area de un triangulo
        /// </summary>
        /// <param name="baseTriangulo">base del triangulo</param>
        /// <param name="alturaTriangulo">altura del triangulo</param>
        /// <returns>Devuelve al area en cm2</returns>
        public static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo) {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        /// <summary>
        /// Calcula el area de un circulo
        /// </summary>
        /// <param name="radio">radio del circulo</param>
        /// <returns>Devuelve al area en cm2</returns>
        public double CalcularAreaCirculo(double radio) {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
