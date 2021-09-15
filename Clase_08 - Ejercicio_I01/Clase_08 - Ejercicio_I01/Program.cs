using System;
using System.Collections.Generic;
using Biblioteca;

namespace Clase_08___Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VehiculoTerrestre> vehiculos = new List<VehiculoTerrestre>();

            VehiculoTerrestre auto = new Automovil(5, 4, 4, 5, VehiculoTerrestre.Colores.Blanco);
            Automovil auto2 = new Automovil(5, 4, 4, 5, VehiculoTerrestre.Colores.Rojo);
            Automovil auto3 = new Automovil(5, 4, 4, 5, VehiculoTerrestre.Colores.Negro);
            VehiculoTerrestre moto = new Moto(35, 2, 0, VehiculoTerrestre.Colores.Azul);

            vehiculos.Add(auto2);
            vehiculos.Add(auto3);
            vehiculos.Add(moto);
            
            foreach(VehiculoTerrestre item in vehiculos)
            {
                if(item is Automovil)
                {
                    Automovil automovil = (Automovil)item;
                    Console.WriteLine(automovil.MostrarAutomovil());
                }
                else
                {
                    Console.WriteLine(item.MostrarVehiculo());
                }
            }
        }
    }
}
