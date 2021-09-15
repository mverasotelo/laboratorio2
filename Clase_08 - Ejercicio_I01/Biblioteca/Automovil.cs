using System;
using System.Text;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadMarchas, int cantidadPasajeros, short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string MostrarAutomovil()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarVehiculo());
            retorno.AppendLine($"Cantidad pasajeros:{cantidadPasajeros}");
            retorno.AppendLine($"Cantidad marchas:{cantidadMarchas}");

            return retorno.ToString();
        }
    }
}
