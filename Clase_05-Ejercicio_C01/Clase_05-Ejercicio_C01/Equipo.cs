using Clase_05_Ejercicio_C01;
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
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre)
            :this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
