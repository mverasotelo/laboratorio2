using System;
using System.Collections.Generic;
using Biblioteca;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(5,4, Competencia.TipoCompetencia.F1);
            Competencia cm = new Competencia(4, 3, Competencia.TipoCompetencia.MotoCross);
            VehiculoDeCarrera a1 = new AutoF1("Toyota", 25);
            VehiculoDeCarrera a2 = new AutoF1("Mercedes", 20);
            VehiculoDeCarrera a3 = new AutoF1("Ferrari", 22);
            VehiculoDeCarrera a4 = new AutoF1("Honda", 26);

            List<MotoCross> motos = new List<MotoCross>()
            {
                new MotoCross("Honda", 18, 150),
                new MotoCross("Toyota", 19, 170),
                new MotoCross("Honda", 17, 200)
            };


            try
            {
                if (cm + a1 == true)
                {
                    Console.WriteLine($"Se agrego {a1.MostrarDatos()}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }

            try
            {
                if (cm == a1)
                {
                    Console.WriteLine($"INCLUIDO: {a1.MostrarDatos()}");
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {

                Console.WriteLine($"{e}");
            }

            if (c + a2 == true)
            {
                Console.WriteLine($"Se agrego {a2.MostrarDatos()}");
            }

            if(cm + motos[0] == true)
            {
                Console.WriteLine($"Se agrego {motos[0].MostrarDatos()}");
            }
            else
            {
                Console.WriteLine("Imposible");
            }

        }
    }
}
