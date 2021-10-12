using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
   
        public Torneo(string nombre)
        {
            equipos = new List<T>();
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                int r1;
                int r2;
                do
                {
                    r1 = random.Next(0, equipos.Count);
                    r2 = random.Next(0, equipos.Count);
                } while (r1 == r2);
                return CalcularPartido(equipos[r1], equipos[r2]);
            }
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            if(torneo is not null)
            {
                foreach (T item in torneo.equipos)
                {
                    if (item == equipo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(T equipo, Torneo<T> torneo)
        {
            if((torneo is not null && equipo is not null) && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DEL TORNEO");
            foreach (T item in equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            if (equipos.Count > 1 && equipo1.GetType() == equipo2.GetType())
            {
                Random random = new Random();
                return $"{equipo1.Nombre} {random.Next(0, 10)} - {equipo2.Nombre} {random.Next(0, 10)}";
            }
            return "No hay suficientes equipos para jugar un partido";
        }
    }
}
