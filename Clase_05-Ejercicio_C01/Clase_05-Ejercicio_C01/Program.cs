using Biblioteca;
using System;

namespace Clase_05_Ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "UTN");
            Jugador j1 = new Jugador(123456, "Mercedes",4,8);
            Jugador j2 = new Jugador(123456, "Julian",3,5);
            Jugador j3 = new Jugador(123458, "Pedro",9,10);
            Jugador j4 = new Jugador(123459, "Juana",8,20);
            Jugador j5 = new Jugador(123450, "Maria",2,8);

            if(equipo + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se ha podido agregar al jugador:\n{j1.MostrarDatos()}");
            }

            if (equipo + j2)
            {
                Console.WriteLine(j2.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se ha podido agregar al jugador:\n{j2.MostrarDatos()}");
            }

            if (equipo + j3)
            {
                Console.WriteLine(j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se ha podido agregar al jugador:\n{j3.MostrarDatos()}");
            }

            if (equipo + j4)
            {
                Console.WriteLine(j4.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se ha podido agregar al jugador:\n{j4.MostrarDatos()}");
            }

            if (equipo + j5)
            {
                Console.WriteLine(j5.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se ha podido agregar al jugador:\n{j5.MostrarDatos()}");
            }
        }
    }
}
