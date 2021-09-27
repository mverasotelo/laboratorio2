using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        public enum Franjas
        {
            Franja_1, Franja_2, Franja_3
        }

        protected Franjas franjaHoraria;

        public override float CostoLlamada { get => CalcularCosto(); }


        public Provincial(string origen, Franjas miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"{base.Mostrar()} - Costo: ${CostoLlamada:N2} - Franjas Horaria: {franjaHoraria}");

            return retorno.ToString();
        }

        private float CalcularCosto()
        {
            int franja = (int)franjaHoraria;

            switch(franja)
            {
                case 0:
                    return duracion * 0.99F;
                case 1:
                    return duracion * 1.25F;
                case 2:
                    return duracion * 0.66F;
                default:
                    return 0;
            }
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
            Provincial llamada = obj as Provincial;
            return llamada != null;
        }

    }
}
