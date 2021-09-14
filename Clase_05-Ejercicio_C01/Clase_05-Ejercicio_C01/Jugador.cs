using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            promedioGoles = 0;
            partidosJugados = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) 
            :this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            return (float)(totalGoles / partidosJugados);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Nombre: {nombre}");
            retorno.AppendLine($"DNI: {dni}");
            retorno.AppendLine($"Partidos jugados: {partidosJugados}");
            retorno.AppendLine($"Total goles: {totalGoles}");
            retorno.AppendLine($"Promedio: {this.GetPromedioGoles():N2}");

            return retorno.ToString();
        }
    }
}