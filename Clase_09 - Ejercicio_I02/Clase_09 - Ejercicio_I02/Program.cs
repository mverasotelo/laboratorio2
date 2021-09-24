using System;
using System.Text;
using Bibilioteca;
using System.Collections.Generic;

namespace Clase_09___Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            Figura circulo = new Circulo(2);
            Figura rectangulo = new Rectangulo(4, 8);
            Figura cuadrado = new Cuadrado(3);

            figuras.Add(circulo);
            figuras.Add(rectangulo);
            figuras.Add(cuadrado);

            foreach (Figura figura in figuras)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"=============== FIGURA {(figuras.IndexOf(figura)+1):D2} ==================");
                sb.AppendLine($"Tipo: {figura.GetType()}");
                sb.AppendLine($"{figura.Dibujar()}");
                sb.AppendLine($"Área: {figura.CalcularSuperficie():N2}");
                sb.AppendLine($"Perímetro: {figura.CalcularPerimetro():N2}");
                sb.AppendLine("============================================");
                Console.WriteLine(sb);
            }
        }
        //¿Por qué la clase Cuadrado no está obligada a implementar el método Dibujar? ¿Las otras clases están obligadas a hacerlo?
        //Ninguna de las tres esta obligada a implementar el método Dibujar porque no es un metodo abstracto en sus clases bases.

        //¿Por qué la clase Cuadrado no está obligada a implementar el método CalcularSuperficie? ¿Las otras clases están obligadas a hacerlo?
        //La clase Cuadrado está obligada a implementar el método CalcularSuperficie porque ya lo implementa su clase base (Rectangulo). Las otras clases estan obligadas porque son metodos abstractos en su clase base (Figura)

        //¿A qué implementación del método CalcularPerimetro llaman los objetos de tipo Cuadrado?
        //A la implmentación de Rectangulo que es la clase mas cercana en la jerarquia de herencia
    }
}
