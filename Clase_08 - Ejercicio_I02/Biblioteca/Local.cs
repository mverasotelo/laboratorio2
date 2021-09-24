using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada { get => CalcularCosto(); }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
            ;
        }

        public Local(string origen, float duracion, string destino, float costo):this(new Llamada(duracion, destino, origen), costo) 
        {
        }


        public new string Mostrar() 
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"{base.Mostrar()} - Costo: ${CostoLlamada:N2}");

            return retorno.ToString();
        }

        protected float CalcularCosto()
        {
            return duracion * costo;
        }
    }
}
