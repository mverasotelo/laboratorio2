using System;
using Geometria;

namespace Clase_03___Ejercicio_I05
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(new Punto(2,1), new Punto(4, 4));
            Console.WriteLine($"Vertices: \n1) {rectangulo.GetVertice1()} \n2) {rectangulo.GetVertice2()} \n3) {rectangulo.GetVertice3()} \n4) {rectangulo.GetVertice4()} ");
        }
    }
}
