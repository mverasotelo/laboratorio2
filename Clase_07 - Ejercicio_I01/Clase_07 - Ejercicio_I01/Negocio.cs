using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        //atributos
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        //constructores
        private Negocio()
        {
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if (this != value)
                {
                    _= this + value; //operador de descarte. En lugar de guardar el booleano
                }
            }
        }


        public int ClientesPendientes
        {
            get
            {
                return clientes.Count();
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            if (n.clientes is not null)
            {
                foreach (Cliente cliente in n.clientes)
                {
                    if (cliente == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                (n.clientes).Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                n.caja.Atender(n.Cliente);
                return true;
            }
            return false;
        }
    }
}
