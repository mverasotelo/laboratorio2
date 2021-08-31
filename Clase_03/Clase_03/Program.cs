using System;
using Biblioteca;

namespace Clase_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mascota[] mascotas = new Mascota[3];

            Mascota felix = new Mascota("Felix", new DateTime(2018,05,10), "gato");
            felix.SetNombre("Garfield");

            mascotas[0] = felix;
            mascotas[1] = new Mascota("Fatiga", new DateTime(2018, 05, 10), "perro");
            mascotas[2] = new Mascota("Kimi", new DateTime(2010, 04, 29), "gato");

            foreach(Mascota mascota in mascotas)
            {
                if (mascota != null)
                // if(!(mascota is null))
                {
                    Console.WriteLine($"{mascota.GetNombre()} es un {mascota.GetEspecie()}");
                }
            }
        }
    }
}