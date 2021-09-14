using System;

namespace AtencionAlCliente
{
    public class Cliente
    {
        //atributos
        private string nombre;
        private int numero;

        //propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero
        {
            get {return numero;}
        }

        //constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero)
            :this(numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
                return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1==c2);
        }
    }
}
