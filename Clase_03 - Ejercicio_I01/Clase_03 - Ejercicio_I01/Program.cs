using System;
using Biblioteca;

namespace Clase_03___Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo!";
            Cuenta cuenta1 = new Cuenta("Mercedes", 3500);
            Console.WriteLine($"{cuenta1.Mostrar()}");

            cuenta1.Retirar(100.5F);
            Console.WriteLine($"{cuenta1.Mostrar()}");
                    
            cuenta1.Ingresar(500);
            Console.WriteLine($"{cuenta1.Mostrar()}");

            Console.ReadKey();
        }
    }
}
