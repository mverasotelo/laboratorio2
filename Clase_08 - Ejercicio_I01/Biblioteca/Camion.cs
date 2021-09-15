using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadMarchas, int pesoCarga, short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
        public string MostrarCamion()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarVehiculo());
            retorno.AppendLine($"Cantidad peso carga:{pesoCarga}");
            retorno.AppendLine($"Cantidad cantidad marchas:{cantidadMarchas}");

            return retorno.ToString();
        }
    }
}
