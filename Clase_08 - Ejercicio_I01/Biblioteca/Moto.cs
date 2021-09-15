using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cilindrada, short cantidadRuedas, short cantidadPuertas, Colores color):base(cantidadRuedas,cantidadPuertas, color) //para heredar atributos
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarVehiculo());
            retorno.AppendLine($"Cantidad cilindrada:{cilindrada}");

            return retorno.ToString();
        }
    }
}
