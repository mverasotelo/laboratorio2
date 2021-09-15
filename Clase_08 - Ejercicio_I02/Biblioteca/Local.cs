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

        public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }


        public new string Mostrar() 
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append($"{base.Mostrar()} - Costo: ${CostoLlamada}");

            return retorno.ToString();
        }

        private float CalcularCosto()
        {
            return duracion * costo;
        }
    }
}
