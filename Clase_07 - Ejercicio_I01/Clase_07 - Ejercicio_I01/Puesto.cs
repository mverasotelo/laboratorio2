using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        //atributos
        private static int numeroActual;
        private Puesto puesto;

        //constructores
        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        //propiedades
        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }


        /// <summary>
        /// Simula un tiempo de atención a un cliente
        /// </summary>
        /// <param name="cli">Cliente</param>
        /// <returns>Retorna true para indicar el final de la atención</returns>
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(1000);
                return true;
            }
            return false;
        }

    }
}