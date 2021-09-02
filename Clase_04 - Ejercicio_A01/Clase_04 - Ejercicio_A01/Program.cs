using System;
using Biblioteca;


namespace Clase_04___Ejercicio_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir;
            float grados;

            do
            {
                //Ingresar unidad a convertir
                Console.WriteLine("Ingrese unidad de medida que quiere convertir (C, F o K):");
                string convertirDesde = Console.ReadLine();

                while (convertirDesde.ToUpper() != "F" && convertirDesde.ToUpper() != "C" && convertirDesde.ToUpper() != "K")
                {
                    Console.WriteLine("Error. Ingrese unidad de medida que quiere convertir (C, F o K):");
                    convertirDesde = Console.ReadLine();
                }
              
                //Ingresar grados a convertir
                Console.WriteLine("Ingrese grados a convertir:");

                bool esNumero = float.TryParse(Console.ReadLine(), out grados);
                while(!esNumero)
                {
                    Console.WriteLine("Eso no es un número. Ingrese grados a convertir:");
                    esNumero = float.TryParse(Console.ReadLine(), out grados);
                }

                //Ingresar unidad a la que se desea convertir
                Console.WriteLine("Ingrese unidad de medida a la que quiere convertir (C, F o K):");
                string convertirA = Console.ReadLine();

                while (convertirA.ToUpper() != "F" && convertirA.ToUpper() != "C" && convertirA.ToUpper() != "K")
                {
                    Console.WriteLine("Error. Ingrese unidad de medida a la que quiere convertir (C, F o K):");
                    convertirA = Console.ReadLine();
                }

                if (convertirA.ToUpper() == "F")
                {
                    switch (convertirDesde.ToUpper())
                    {
                        case "K":
                            Kelvin k = new Kelvin(grados);
                            Console.WriteLine($"{(float)k} K equivalen a {Farenheit.ConvertirAFarenheit(k):N2}°F");
                            break;
                        case "C":
                            Celsius c = new Celsius(grados);
                            Console.WriteLine($"{(float)c}°C equivalen a {Farenheit.ConvertirAFarenheit(c):N2}°F");
                            break;
                        case "F":
                            Console.WriteLine($"{grados}°F equivalen a {grados}°F");
                            break;
                    }
                }
                else if (convertirA.ToUpper() == "C") 
                {
                    switch (convertirDesde.ToUpper())
                    {
                        case "K":
                            Kelvin k = new Kelvin(grados);
                            Console.WriteLine($"{(float)k} K equivalen a {Celsius.ConvertirACelsius(k):N2}°F");
                            break;
                        case "F":
                            Farenheit f = new Farenheit(grados);
                            Console.WriteLine($"{(float)f}°C equivalen a {Celsius.ConvertirACelsius(f):N2}°F");
                            break;
                        case "C":
                            Console.WriteLine($"{grados}°C equivalen a {grados}°C");
                            break;
                    }
                }
                else
                {
                    switch (convertirDesde.ToUpper())
                    {
                        case "K":
                            Farenheit f = new Farenheit(grados);
                            Console.WriteLine($"{(float)f}°F equivalen a {Kelvin.ConvertirAKelvin(f):N2} K");
                            break;
                        case "C":
                            Celsius c = new Celsius(grados);
                            Console.WriteLine($"{(float)c}°C equivalen a {Kelvin.ConvertirAKelvin(c):N2} K");
                            break;
                        case "F":
                            Console.WriteLine($"{grados} K equivalen a {grados} K");
                            break;
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Desea salir del conversor?");
                salir = Console.ReadLine();
                Console.WriteLine("");


            } while (salir != "s");

        }
    }
}
