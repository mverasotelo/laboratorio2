using System;
using static Biblioteca.ConversorDeTemperatura;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperaturaCelsius = 30;
            Console.WriteLine("{0}", Biblioteca.ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius));
        }
    }
} 
