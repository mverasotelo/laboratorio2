using System;
using System.Text;

namespace Centralita
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get => duracion; }

        public string NroDestino { get => nroDestino; }

        public string NroOrigen { get => nroOrigen; }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Numero Origen: {nroOrigen} - Numero Destino: { nroDestino} - Duracion: {Duracion}");

            return retorno.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            return 0;
        }
    }
}
