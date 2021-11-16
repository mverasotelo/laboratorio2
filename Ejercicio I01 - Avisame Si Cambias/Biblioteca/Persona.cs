using System;

namespace Biblioteca
{
    public delegate void DelegadoString(string texto);

    public class Persona
    {
        private string apellido;
        private string nombre;
        public event DelegadoString EventoString;

        public Persona()
        {

        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if (value != apellido && EventoString is not null)
                {
                    apellido = value;
                    EventoString(apellido);
                }

            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value != nombre && EventoString is not null)
                {
                    nombre = value;
                    EventoString(nombre);
                }
            }
        }

        public string Mostrar()
        {
            return $"{nombre} {apellido}";
        }
    }
}
