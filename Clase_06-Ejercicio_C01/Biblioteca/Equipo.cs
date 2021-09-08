using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private string nombre;
        private List<Jugador> jugadores;


        private Equipo()
        {
        }

        public Equipo(string nombre, short cantidadDeJugadores)
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                if (!(e.jugadores).Contains(j))
                {
                    (e.jugadores).Add(j);
                    return true;
                }
            }
            return false;
        }
    }
}
