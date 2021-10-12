using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            return $"{nombre} fundado el {fechaCreacion.ToString("dd/MM/yyyy")}";
        }
    }
}
