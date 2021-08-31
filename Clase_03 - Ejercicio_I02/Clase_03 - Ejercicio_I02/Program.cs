using System;
using Biblioteca;

namespace Clase_03___Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            personas[0] = new Persona("Mercedes", new DateTime(1989, 06, 02), 34398757);
            personas[1] = new Persona("Pedro", new DateTime(2005, 08, 05), 45254356);
            personas[2] = new Persona("Julian", new DateTime(1986, 09, 02), 32568645);

            /*foreach(Persona in personas)
            {
                if (persona != null)
                {
                    persona.Mostra
                }
            }
            Console.WriteLine($"{persona1.Mostrar()}");
            Console.WriteLine($"{persona1.EsMayorDeEdad()}");*/
        }
    }
}
