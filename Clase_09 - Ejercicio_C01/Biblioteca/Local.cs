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


        public Local(string nroDestino, float duracion, string nroOrigen, float costo) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada { get => CalcularCosto(); }

        /// <summary>
        /// Calcula el costo de una llamada segun su duracion y el valor del minuto
        /// </summary>
        /// <returns></returns>
        protected float CalcularCosto()
        {
            return duracion * costo;
        }

        protected override string Mostrar() 
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"{base.Mostrar()} - Costo: ${CostoLlamada:N2}");

            return retorno.ToString();
        }

        /// <summary>
        /// Sobreescribe el metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar();
        }


        /// <summary>
        /// Sobreescribe el metodo Equals()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Local llamada = obj as Local;
            return llamada != null;
        }

    }
}
