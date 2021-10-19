using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;


        private Competencia()
        {
            competidores =  new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas)
            :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad competidores {cantidadCompetidores}");
            sb.AppendLine($"Cantidad vueltas: {cantidadVueltas}");
            sb.AppendLine($"Competidores:");
            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores)
            {
                if (c == a)
                {
                    return false;
                }
            }

            Random r = new Random();
            a.EnCompetencia = true;
            a.VueltasRestantes = c.cantidadVueltas;
            a.CantidadCombustible = (short) r.Next(15, 100);
            c.competidores.Add(a);
            return true;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

    }
}
