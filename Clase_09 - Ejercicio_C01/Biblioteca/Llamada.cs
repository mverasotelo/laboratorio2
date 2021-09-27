using System;
using System.Text;

namespace Centralita
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        /// <summary>
        /// Solo lectura
        /// </summary>
        public abstract float CostoLlamada { get; }

        public float Duracion { get => duracion; }

        public string NroDestino { get => nroDestino; }

        public string NroOrigen { get => nroOrigen; }

        //Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        //Metodos
        protected virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append($"Numero Origen: {nroOrigen} - Numero Destino: { nroDestino} - Duracion: {Duracion} min.");

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

        //Sobrecargas

        /// <summary>
        /// Sobrecarga el operador ==
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>True si las llamadas son del mismo tipo (utiliza el método Equals, sobrescrito en las clases derivadas) y los números de destino y origen son iguales en ambas llamadas.</returns>
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1 is not null && l2 is not null)
            {
                if (l1.Equals(l2) && l1.nroOrigen == l2.nroOrigen && l1.nroDestino == l2.nroDestino)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga el operador !=
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>False si las llamadas son del mismo tipo (utiliza el método Equals, sobrescrito en las clases derivadas) y los números de destino y origen son iguales en ambas llamadas.</returns>
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1==l2);
        }
    }
}
