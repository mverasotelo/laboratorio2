using System;
using Biblioteca;

namespace ClaseGenerics_EjercicioI01_Torneo
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo de futbol");

            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Chicago Bulls", new DateTime(1980,06,10));
            EquipoBasquet equipoBasquet2 = new EquipoBasquet("Los Angeles Lakers", new DateTime(1956, 06, 2));
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("San Antonio Spurs", new DateTime(1965, 02, 3));

            EquipoFutbol equipoFutbol1= new EquipoFutbol("River Plate", new DateTime(1905, 06, 05));
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("Boca Juniors", new DateTime(1903, 08, 12));
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("Independiente", new DateTime(1908, 11, 19));

            if(equipoBasquet1 + torneoBasquet)
            {
                Console.WriteLine($"Se agrego el equipo {equipoBasquet1.Ficha()}");
            }
            if (equipoBasquet2 + torneoBasquet)
            {
                Console.WriteLine($"Se agrego el equipo {equipoBasquet2.Ficha()}");
            }
            if (equipoBasquet3 + torneoBasquet)
            {
                Console.WriteLine($"Se agrego el equipo {equipoBasquet3.Ficha()}");
            }

            _ = equipoFutbol1 + torneoFutbol;
            _ = equipoFutbol2 + torneoFutbol;
            _ = equipoFutbol3 + torneoFutbol;

            Console.WriteLine();
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.WriteLine();
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
        }
    }
}
