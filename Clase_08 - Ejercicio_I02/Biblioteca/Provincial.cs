using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99, Franja_2 = 125, Franja_3 = 66
        }

        protected Franja franjaHoraria;

        public float CostoLlamada { get => CalcularCosto(); }


        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        public new string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append($"{base.Mostrar()} - Costo: ${CostoLlamada} - Franja Horaria: {franjaHoraria}");

            return retorno.ToString();
        }

        private float CalcularCosto()
        {
            float costofranja = (float)((int)franjaHoraria) / 100;
            return duracion * costofranja;
        }
    }
}
